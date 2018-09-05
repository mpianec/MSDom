using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calendar.NET;
using System.Net.Mail;

namespace MSDom
{
    public partial class frmRezervacijaPraonice : Form
    {
        
        public frmRezervacijaPraonice()
        {
            InitializeComponent();
            DohvatiSlobodnePraonice();
            DohvatiVaseRezervacije();
        }
        //<sumarry>
        //Metoda DohvatiSlobodnePraonice() vraća sve slobodne praonice, 
        //točnije id i naziv praonice  
        //</sumarry> 
        public void DohvatiSlobodnePraonice()
        {
            using (var db = new MSDomEntities())
            {
                var listaSlobodnihPraonica = from praon in db.praonicas
                                            //where (praon.zauzeto == 0)
                                            select new { praon.id, praon.naziv};

                uiOutputSlobodnePraonice.DataSource = listaSlobodnihPraonica.ToList();
            }
        }
        //<sumarry>
        //Metoda DohvatiVaseRezervacije() vraća sve rezervirane praonice, 
        //koje je rezervirao trenutno prijavljeni korisnik
        //ispisuje id rezervacije, naziv praonice i datum rezervacije
        //</sumarry> 
        public void DohvatiVaseRezervacije()
        {
            using (var db=new MSDomEntities())
            {
                var idOdabranePraonice = from od in db.rezervacijaPraonices
                                         join praon in db.praonicas
                                         on od.praonicaId equals praon.id
                                         where (od.korisnikId == PrijavljeniKorisnik.id)
                                         select new { od.id, praon.naziv,od.datumVrijeme};
                BindingList<rezervacijaPraonice> lista = new BindingList<rezervacijaPraonice>(db.rezervacijaPraonices.ToList());
                if (idOdabranePraonice.ToList().Count > 0)
                {
                    uiOutputMojeRezervacije.DataSource = idOdabranePraonice.ToList();
                    
                    calendar1.RemoveAll();
                    foreach (var item in lista)
                    {
                        var Rezervirana = new CustomEvent
                        {
                            Date = item.datumVrijeme,
                            EventText = "Rezervirana praonica broj:" + item.praonicaId,
                            EventLengthInHours = 1f,
                            EventColor = Color.Blue
                        };
                        calendar1.AddEvent(Rezervirana);
                    }
                }
                else
                {
                    uiOutputMojeRezervacije.DataSource = null;
                    calendar1.RemoveAll();
                    foreach (var item in lista)
                    {
                        var Rezervirana = new CustomEvent
                        {
                            Date = item.datumVrijeme,
                            EventText = "Rezervirana praonica broj:" + item.praonicaId,
                            EventLengthInHours = 1f,
                            EventColor = Color.Blue
                        };
                        calendar1.AddEvent(Rezervirana);
                    }
                }
            }
        }
        private void uiActionRezervirajPraonicu_Click(object sender, EventArgs e)
        {
            if (uiOutputSlobodnePraonice.CurrentRow != null)
            {
                bool postoji = false;
                praonica praonicaZaUpdate = null;
                int idPraonice = int.Parse(uiOutputSlobodnePraonice.CurrentRow.Cells[0].Value.ToString());
                using (var db=new MSDomEntities())
                {                   
                    var idOdabranePraonice = from od in db.rezervacijaPraonices
                                             join praon in db.praonicas
                                             on od.praonicaId equals praon.id
                                             where (od.korisnikId == PrijavljeniKorisnik.id)
                                             select new { od.id, praon.naziv,od.datumVrijeme};
                    //ako nema već rezerviranu praonicu
                    var idZauzetaPraonica = from od in db.rezervacijaPraonices select new { od.id, od.datumVrijeme };
                    if (idOdabranePraonice.ToList().Count == 0)
                    {
                        bool proba = false;
                        BindingList<praonica> listaPraonica = new BindingList<praonica>(db.praonicas.ToList());
                        BindingList<rezervacijaPraonice> listaRezervacija = new BindingList<rezervacijaPraonice>(db.rezervacijaPraonices.ToList());
                        int id = int.Parse(uiOutputSlobodnePraonice.CurrentRow.Cells[0].Value.ToString());
                        TimeSpan razlika = new TimeSpan(1, 0, 0);
                        foreach (var item in listaPraonica)
                        {
                            if (proba == false) {
                                foreach (var item2 in listaRezervacija)
                                {
                                    if (id == item2.praonicaId && (item2.datumVrijeme == uiInputDatumRezervacije.Value || uiInputDatumRezervacije.Value.Subtract(item2.datumVrijeme)<razlika))
                                    {                                                                        
                                        MessageBox.Show("Taj termin je zauzeo drugi korisnik. Idući slobodan termin za ovu perilicu je: "+ item2.datumVrijeme.AddHours(1));
                                        proba = true;
                                    }
                                }
                            }
                            if (proba == false && item.id == id)
                            {
                                praonicaZaUpdate = item;
                                proba = false;
                            }
                        }
                        if (proba == false)
                        {
                            db.praonicas.Attach(praonicaZaUpdate);
                            //  praonicaZaUpdate.zauzeto = 1;
                            rezervacijaPraonice novaRezervacija = new rezervacijaPraonice();
                            novaRezervacija.datumVrijeme = uiInputDatumRezervacije.Value;
                            novaRezervacija.korisnikId = PrijavljeniKorisnik.id;
                            novaRezervacija.praonicaId = idPraonice;
                            db.rezervacijaPraonices.Add(novaRezervacija);
                            db.SaveChanges();
                            var Rezervirana = new CustomEvent
                            {
                                Date = uiInputDatumRezervacije.Value,
                                EventText = "Rezervirana praonica broj:" + id,
                                EventLengthInHours = 1f,
                                EventColor = Color.Blue
                            };
                            calendar1.AddEvent(Rezervirana);
                        }
                    }
                    // ako je rezerviral već praonicu 
                    else
                    {
                        TimeSpan interval = new TimeSpan(0, 0, 0);
                        TimeSpan interval2 = new TimeSpan(1, 0, 0, 0);
                        foreach (var item in idOdabranePraonice.ToList())
                        {
                            /* if ( item.datumVrijeme.Subtract(uiInputDatumRezervacije.Value)<=interval2)
                             {
                                 postoji = true;
                             }*/
                            if (uiInputDatumRezervacije.Value.Subtract(item.datumVrijeme) < interval2)
                            {
                                postoji = true;
                            }
                        }
                        if (!postoji)
                        {
                            bool proba = false;
                            BindingList<praonica> listaPraonica = new BindingList<praonica>(db.praonicas.ToList());
                            BindingList<rezervacijaPraonice> listaRezervacija = new BindingList<rezervacijaPraonice>(db.rezervacijaPraonices.ToList());
                            int id = int.Parse(uiOutputSlobodnePraonice.CurrentRow.Cells[0].Value.ToString());
                            foreach (var item in listaPraonica)
                            {
                                if (proba == false)
                                {
                                    foreach (var item2 in listaRezervacija)
                                    {
                                        if (id == item2.praonicaId && item2.datumVrijeme == uiInputDatumRezervacije.Value)
                                        {
                                            uiInputDatumRezervacije.Value = uiInputDatumRezervacije.Value.AddHours(1);
                                            MessageBox.Show("Taj termin je zauzeo drugi korisnik. Idući slobodan termin za ovu perilicu je: " + uiInputDatumRezervacije.Value);
                                            proba = true;
                                        }
                                    }
                                }
                                if (proba == false && item.id == id)
                                {
                                    praonicaZaUpdate = item;
                                    proba = false;
                                }
                            }
                            if (proba == false)
                            {
                                db.praonicas.Attach(praonicaZaUpdate);
                                //  praonicaZaUpdate.zauzeto = 1;
                                rezervacijaPraonice novaRezervacija = new rezervacijaPraonice();
                                novaRezervacija.datumVrijeme = uiInputDatumRezervacije.Value;
                                novaRezervacija.korisnikId = PrijavljeniKorisnik.id;
                                novaRezervacija.praonicaId = idPraonice;
                                db.rezervacijaPraonices.Add(novaRezervacija);
                                db.SaveChanges();
                                var Rezervirana = new CustomEvent
                                {
                                    Date = uiInputDatumRezervacije.Value,
                                    EventText = "Rezervirana praonica broj:" + id,
                                    EventLengthInHours = 1f,
                                    EventColor = Color.Blue
                                };
                                calendar1.AddEvent(Rezervirana);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ne može se odabrati taj termin");
                        }
                    }
                }
            }
            DohvatiSlobodnePraonice();
            DohvatiVaseRezervacije();
        }

        private void uiActionPoništiRezervaciju_Click(object sender, EventArgs e)
        {
            rezervacijaPraonice brisanjeRezervacije = null;
            praonica praonicaBrisanje = null;
            using (var db=new MSDomEntities())
            {
                var idOdabir = from od in db.rezervacijaPraonices
                               join praon in db.praonicas
                               on od.praonicaId equals praon.id
                               where (od.korisnikId == PrijavljeniKorisnik.id)
                               select od.id;
                if (idOdabir.ToList().Count > 0)
                {
                    int id =  int.Parse(uiOutputMojeRezervacije.CurrentRow.Cells[0].Value.ToString());
                    string naziv = uiOutputMojeRezervacije.CurrentRow.Cells[1].Value.ToString();
                    BindingList<praonica> listaPraonica = new BindingList<praonica>(db.praonicas.ToList());
                    BindingList<rezervacijaPraonice> listaOdabira = new BindingList<rezervacijaPraonice>(db.rezervacijaPraonices.ToList());
                    foreach(var item in listaOdabira)
                    {
                        if (item.id == id)
                        {
                            brisanjeRezervacije = item;
                        }
                    }
                    foreach(var item in listaPraonica)
                    {
                        if (item.naziv == naziv)
                        {
                            praonicaBrisanje = item;
                        }
                    }
                    db.praonicas.Attach(praonicaBrisanje);
                    praonicaBrisanje.zauzeto = 0;
                    db.rezervacijaPraonices.Attach(brisanjeRezervacije);
                    db.rezervacijaPraonices.Remove(brisanjeRezervacije);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Nemate rezervacije.");
                }
            }
            DohvatiSlobodnePraonice();
            DohvatiVaseRezervacije();
        }

        private void frmRezervacijaPraonice_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmRezervacijaPraonice_KeyDown);
            this.KeyDown -= new KeyEventHandler(frmRezervacijaPraonice_KeyDown);

            rezervacijaPraonice brisanjeRezervacije = null;
            praonica praonicaBrisanje = null;
            using (var db = new MSDomEntities())
            {
                var idOdabir = from od in db.rezervacijaPraonices
                               join praon in db.praonicas
                               on od.praonicaId equals praon.id
                               where (od.korisnikId == PrijavljeniKorisnik.id)
                               select od.id;                
                if (idOdabir.ToList().Count > 0)
                {
                    int id = int.Parse(uiOutputMojeRezervacije.CurrentRow.Cells[0].Value.ToString());
                    string naziv = uiOutputMojeRezervacije.CurrentRow.Cells[1].Value.ToString();
                    BindingList<praonica> listaPraonica = new BindingList<praonica>(db.praonicas.ToList());
                    BindingList<rezervacijaPraonice> listaOdabira = new BindingList<rezervacijaPraonice>(db.rezervacijaPraonices.ToList());
                    BindingList<korisnik> listaKorisnika = new BindingList<korisnik>(db.korisniks.ToList());
                    TimeSpan interval3 = new TimeSpan(0, 0, 0, 1);
                    
                    foreach (var item in listaOdabira)
                    {
                        //int isto = DateTime.Compare(DateTime.Today, item.datumVrijeme);
                        if (DateTime.Now>item.datumVrijeme)
                        {
                            brisanjeRezervacije = item;
                            foreach(var item2 in listaPraonica)
                            {
                                if (item.praonicaId == item2.id)
                                {
                                    praonicaBrisanje = item2;
                                    if (praonicaBrisanje != null && brisanjeRezervacije != null)                                    
                                        for (int i = 0; i < listaKorisnika.Count(); i++)                                       
                                            if (listaKorisnika[i].ulogaId == 1)
                                            {
                                                MailMessage message = new MailMessage();
                                                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                                                message.From = new MailAddress("mattaker.knot@gmail.com");
                                                message.To.Add("mpianec@foi.hr");
                                                message.Subject = "Oslobođena praonica";
                                                message.Body = "Oslobođena je praonica: " + item.praonicaId;
                                                SmtpServer.Port = 587;
                                                SmtpServer.Credentials = new System.Net.NetworkCredential("mattaker.knot@gmail.com", "grejtsejtan666");
                                                SmtpServer.EnableSsl = true;
                                                SmtpServer.Send(message);
                                            }                                                                          
                                }
                            }
                        }

                    }                 
                    if (brisanjeRezervacije != null && praonicaBrisanje!=null)
                    {
                        db.praonicas.Attach(praonicaBrisanje);
                        praonicaBrisanje.zauzeto = 0;
                        db.rezervacijaPraonices.Attach(brisanjeRezervacije);
                        db.rezervacijaPraonices.Remove(brisanjeRezervacije);
                        db.SaveChanges();
                        DohvatiVaseRezervacije();                        
                    }
                }
            }
        }

        private void frmRezervacijaPraonice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                frmF1RezervacijaPraonice forma = new frmF1RezervacijaPraonice();
                forma.ShowDialog();
            }
        }
    }
}
