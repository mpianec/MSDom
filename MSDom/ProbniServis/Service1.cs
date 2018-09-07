using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace ProbniServis
{
    public partial class Service1 : ServiceBase
    {
        System.Timers.Timer tajmer;
        System.Timers.Timer tajmer2;
        public Service1()
        {
            InitializeComponent();
            using (var db = new Entities())
            {
                var id = from od in db.rezervacijaPraonices
                         select od.datumVrijeme;
                if (id.ToList().Count > 0)
                {
                    BindingList<korisnik> listaKorisnika = new BindingList<korisnik>(db.korisniks.ToList());
                    BindingList<rezervacijaPraonice> listaRezervacija = new BindingList<rezervacijaPraonice>(db.rezervacijaPraonices.ToList());
                    TimeSpan razlika = new TimeSpan(1, 0, 0);
                    foreach (var item in listaRezervacija)
                    {
                        if (DateTime.Now.Subtract(item.datumVrijeme) <= razlika)
                            for (int i = 0; i < listaKorisnika.Count(); i++)
                                if (item.korisnikId == listaKorisnika[i].id && item.isteklaRezervacija == 0)
                                {
                                    MailMessage message = new MailMessage();
                                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                                    message.From = new MailAddress("mattaker.knot@gmail.com");
                                    message.To.Add(listaKorisnika[i].email.ToString());
                                    message.Subject = "Podsjetnik";
                                    message.Body = "Poštovani " + listaKorisnika[i].korisnickoIme + ", podsjećamo Vas da imate rezerviranu praonicu za: " + item.datumVrijeme;
                                    SmtpServer.Port = 587;
                                    SmtpServer.Credentials = new System.Net.NetworkCredential("mattaker.knot@gmail.com", "grejtsejtan666");
                                    SmtpServer.EnableSsl = true;
                                    SmtpServer.Send(message);
                                }
                    }
                }
            }
        }
        public void OnDebug()
        {
            OnStart(null);
        }
        protected override void OnStart(string[] args)
        {
            tajmer = new System.Timers.Timer();
            tajmer.Elapsed += new System.Timers.ElapsedEventHandler(this.Podsjetnik);
            tajmer.Interval = 1800000;
            tajmer.Enabled = true;
            tajmer.AutoReset = true;
            tajmer.Start();

            tajmer2 = new System.Timers.Timer();
            tajmer2.Elapsed += new System.Timers.ElapsedEventHandler(this.Oslobođenje);
            tajmer2.Interval = 5000;
            tajmer2.Enabled = true;
            tajmer2.AutoReset = true;
            tajmer2.Start();
        }
        
        protected override void OnStop()
        {
            tajmer.Enabled = false;
            tajmer2.Enabled = false;
        }
        public void Oslobođenje(object sender, System.Timers.ElapsedEventArgs args)
        {
            rezervacijaPraonice brisanjeRezervacije = null;
            praonica praonicaBrisanje = null;
            using (var db = new Entities())
            {
                var idOdabir = from od in db.rezervacijaPraonices                              
                               select od.id;
                if (idOdabir.ToList().Count > 0)
                {
                    BindingList<praonica> listaPraonica = new BindingList<praonica>(db.praonicas.ToList());
                    BindingList<rezervacijaPraonice> listaOdabira = new BindingList<rezervacijaPraonice>(db.rezervacijaPraonices.ToList());
                    BindingList<korisnik> listaKorisnika = new BindingList<korisnik>(db.korisniks.ToList());

                    foreach (var item in listaOdabira)
                    {
                        //int isto = DateTime.Compare(DateTime.Today, item.datumVrijeme);
                        if (DateTime.Now > item.datumVrijeme)
                        {
                            brisanjeRezervacije = item;
                            foreach (var item2 in listaPraonica)
                            {
                                if (item.praonicaId == item2.id)
                                    praonicaBrisanje = item2;
                            }
                        }
                        if (brisanjeRezervacije != null && praonicaBrisanje != null)
                        {
                            TimeSpan rezer = item.datumVrijeme.TimeOfDay;
                            db.praonicas.Attach(praonicaBrisanje);
                            // praonicaBrisanje.zauzeto = 0;                                                   


                            for (int i = 0; i < listaKorisnika.Count(); i++)
                                if (listaKorisnika[i].ulogaId == 1 && listaKorisnika[i].predbilježbaOd <= rezer && listaKorisnika[i].predbilježbaDo >= rezer && item.isteklaRezervacija == 0)
                                {
                                    MailMessage message = new MailMessage();
                                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                                    message.From = new MailAddress("pimsdom@gmail.com");
                                    message.To.Add(listaKorisnika[i].email.ToString());
                                    message.Subject = "Oslobođena praonica";
                                    message.Body = "Poštovani " + listaKorisnika[i].korisnickoIme + ", oslobođena je praonica: " + item.praonicaId;
                                    SmtpServer.Port = 587;
                                    SmtpServer.Credentials = new System.Net.NetworkCredential("pimsdom@gmail.com", "staracki1");
                                    SmtpServer.EnableSsl = true;
                                    SmtpServer.Send(message);
                                }
                            db.rezervacijaPraonices.Attach(brisanjeRezervacije);
                            brisanjeRezervacije.isteklaRezervacija = 1;
                            db.SaveChanges();
                        }
                    }
                }
            }
        } 
        public void Podsjetnik(object sender, System.Timers.ElapsedEventArgs args)
        {
           using (var db=new Entities()) {
                var id = from od in db.rezervacijaPraonices
                         select od.datumVrijeme;
                if (id.ToList().Count > 0)
                {
                    BindingList<korisnik> listaKorisnika = new BindingList<korisnik>(db.korisniks.ToList());
                    BindingList<rezervacijaPraonice> listaRezervacija = new BindingList<rezervacijaPraonice>(db.rezervacijaPraonices.ToList());
                    TimeSpan razlika = new TimeSpan(1, 0, 0);
                    foreach(var item in listaRezervacija)
                    {
                        if (DateTime.Now.Subtract(item.datumVrijeme) <= razlika)                       
                            for(int i = 0; i < listaKorisnika.Count(); i++)                           
                                if (item.korisnikId == listaKorisnika[i].id && item.isteklaRezervacija==0)
                                {
                                    MailMessage message = new MailMessage();
                                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                                    message.From = new MailAddress("pimsdom@gmail.com");
                                    message.To.Add(listaKorisnika[i].email.ToString());
                                    message.Subject = "Podsjetnik";
                                    message.Body = "Poštovani " + listaKorisnika[i].korisnickoIme + ", podsjećamo Vas da imate rezerviranu praonicu za: " + item.datumVrijeme;
                                    SmtpServer.Port = 587;
                                    SmtpServer.Credentials = new System.Net.NetworkCredential("pimsdom@gmail.com", "staracki1");
                                    SmtpServer.EnableSsl = true;
                                    SmtpServer.Send(message);
                                }   
                    }
                }
            }

        }
    }
}
