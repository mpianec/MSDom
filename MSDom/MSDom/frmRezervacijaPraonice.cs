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
                                         where (od.korisnikId == PrijavljeniKorisnik.id && od.isteklaRezervacija==0)
                                         select new { od.id, praon.naziv,od.datumVrijeme};
                BindingList<rezervacijaPraonice> lista = new BindingList<rezervacijaPraonice>(db.rezervacijaPraonices.ToList());
                if (idOdabranePraonice.ToList().Count > 0)
                {
                    uiOutputMojeRezervacije.DataSource = idOdabranePraonice.ToList();                    
                    calendar1.RemoveAll();
                    foreach (var item in lista)
                    {
                        if (item.korisnikId == PrijavljeniKorisnik.id && item.isteklaRezervacija==0)
                        {
                            var Rezervirana = new CustomEvent
                            {
                                Date = item.datumVrijeme,
                                EventText = "Vi ste rezervirali praonicu:" + item.praonicaId,
                                EventLengthInHours = 1f,
                                EventColor = Color.Red
                            };
                            calendar1.AddEvent(Rezervirana);
                        }
                        else if (item.isteklaRezervacija == 1 && item.korisnikId==PrijavljeniKorisnik.id)
                        {
                            var Rezervirana = new CustomEvent
                            {
                                Date = item.datumVrijeme,
                                EventText = "Vaša prošla rezervacija praonice:" + item.praonicaId,
                                EventLengthInHours = 1f,
                                EventColor = Color.Brown
                            };
                            calendar1.AddEvent(Rezervirana);
                        }                      
                        else if(item.isteklaRezervacija==0 && item.korisnikId != PrijavljeniKorisnik.id)
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
                        else if (item.isteklaRezervacija == 1 && item.korisnikId != PrijavljeniKorisnik.id)
                        {
                            var Rezervirana = new CustomEvent
                            {
                                Date = item.datumVrijeme,
                                EventText = "Prošla rezervacija praonice:" + item.praonicaId,
                                EventLengthInHours = 1f,
                                EventColor = Color.MidnightBlue
                            };
                            calendar1.AddEvent(Rezervirana);
                        }
                    }
                }
                else
                {
                    uiOutputMojeRezervacije.DataSource = null;
                    calendar1.RemoveAll();
                    foreach (var item in lista)
                    {
                        if (item.korisnikId == PrijavljeniKorisnik.id && item.isteklaRezervacija == 0)
                        {
                            var Rezervirana = new CustomEvent
                            {
                                Date = item.datumVrijeme,
                                EventText = "Vi ste rezervirali praonicu:" + item.praonicaId,
                                EventLengthInHours = 1f,
                                EventColor = Color.Red
                            };
                            calendar1.AddEvent(Rezervirana);
                        }
                        else if (item.isteklaRezervacija == 1 && item.korisnikId == PrijavljeniKorisnik.id)
                        {
                            var Rezervirana = new CustomEvent
                            {
                                Date = item.datumVrijeme,
                                EventText = "Vaša prošla rezervacija praonice:" + item.praonicaId,
                                EventLengthInHours = 1f,
                                EventColor = Color.Brown
                            };
                            calendar1.AddEvent(Rezervirana);
                        }
                        else if (item.isteklaRezervacija == 0 && item.korisnikId != PrijavljeniKorisnik.id)
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
                        else if (item.isteklaRezervacija == 1 && item.korisnikId != PrijavljeniKorisnik.id)
                        {
                            var Rezervirana = new CustomEvent
                            {
                                Date = item.datumVrijeme,
                                EventText = "Prošla rezervacija praonice:" + item.praonicaId,
                                EventLengthInHours = 1f,
                                EventColor = Color.MidnightBlue
                            };
                            calendar1.AddEvent(Rezervirana);
                        }
                    }

                }
            }
        }
        private void uiActionRezervirajPraonicu_Click(object sender, EventArgs e)
        {
            
        }

        private void uiActionPoništiRezervaciju_Click(object sender, EventArgs e)
        {
            
        }

        private void frmRezervacijaPraonice_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmRezervacijaPraonice_KeyDown);
            this.KeyDown -= new KeyEventHandler(frmRezervacijaPraonice_KeyDown);

           /* rezervacijaPraonice brisanjeRezervacije = null;
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
                    
                    foreach (var item in listaOdabira)
                    {
                        //int isto = DateTime.Compare(DateTime.Today, item.datumVrijeme);
                        if (DateTime.Now>item.datumVrijeme)
                        {
                            brisanjeRezervacije = item;
                            foreach(var item2 in listaPraonica)
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
                                    if (listaKorisnika[i].ulogaId == 1 && listaKorisnika[i].predbilježbaOd<=rezer && listaKorisnika[i].predbilježbaDo>=rezer && item.isteklaRezervacija==0)
                                    {
                                        MailMessage message = new MailMessage();
                                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                                        message.From = new MailAddress("pimsdom@gmail.com");
                                        message.To.Add(listaKorisnika[i].email.ToString());
                                        message.Subject = "Oslobođena praonica";
                                        message.Body = "Poštovani "+listaKorisnika[i].korisnickoIme+", oslobođena je praonica: " + item.praonicaId;
                                        SmtpServer.Port = 587;
                                        SmtpServer.Credentials = new System.Net.NetworkCredential("pimsdom@gmail.com", "staracki1");
                                        SmtpServer.EnableSsl = true;
                                        SmtpServer.Send(message);
                                    }
                            db.rezervacijaPraonices.Attach(brisanjeRezervacije);
                            brisanjeRezervacije.isteklaRezervacija = 1;
                            db.SaveChanges();
                        }                                  
                    DohvatiVaseRezervacije();                        
                    }
                }
            }*/
        }

        private void frmRezervacijaPraonice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                frmF1RezervacijaPraonice forma = new frmF1RezervacijaPraonice();
                forma.ShowDialog();
            }
        }

        private void uiActionPredbilježi_Click(object sender, EventArgs e)
        {
            korisnik korisnikZaUpdate = null;
            
            using (var db = new MSDomEntities())
            {
                var idPredbilj = from od in db.korisniks                              
                               where (od.id==PrijavljeniKorisnik.id)
                               select od.id;
                BindingList<korisnik> lista = new BindingList<korisnik>(db.korisniks.ToList());
                if (idPredbilj.ToList().Count > 0)
                {
                    foreach (var item in lista)
                    {
                        if (item.id == PrijavljeniKorisnik.id)
                        {
                            if(item.predbilježbaDo!=null && item.predbilježbaOd != null)
                            {
                                DialogResult dialog = MessageBox.Show("Ovi podaci već postoje. Želite li ih ažurirati?", "Upozorenje", MessageBoxButtons.YesNo);
                                if (dialog == DialogResult.Yes)
                                    korisnikZaUpdate = item;
                                else if (dialog == DialogResult.No)
                                    break;
                            }
                            else
                                korisnikZaUpdate = item;
                        }                                                   
                    }
                    if (korisnikZaUpdate != null)
                    {
                        db.korisniks.Attach(korisnikZaUpdate);
                        DateTime vrijOd = uiVrijemePredbilježbeOd.Value;
                        TimeSpan tsVrijOd = vrijOd.TimeOfDay;
                        DateTime vrijDo = uiVrijemePredbilježbeDo.Value;
                        TimeSpan tsVrijDo = vrijDo.TimeOfDay;
                        korisnikZaUpdate.predbilježbaOd = tsVrijOd;
                        korisnikZaUpdate.predbilježbaDo = tsVrijDo;
                        db.SaveChanges();
                        MessageBox.Show("Uspješno uneseno u bazu!","Uneseni podaci");
                    }
                }
               
            }
        }

        private void uiActionRezervirajPraonicu_Click_1(object sender, EventArgs e)
        {
            if (uiOutputSlobodnePraonice.CurrentRow != null)
            {
                bool postoji = false;
                praonica praonicaZaUpdate = null;
                int idPraonice = int.Parse(uiOutputSlobodnePraonice.CurrentRow.Cells[0].Value.ToString());
                using (var db = new MSDomEntities())
                {
                    var idOdabranePraonice = from od in db.rezervacijaPraonices
                                             join praon in db.praonicas
                                             on od.praonicaId equals praon.id
                                             where (od.korisnikId == PrijavljeniKorisnik.id)
                                             select new { od.id, praon.naziv, od.datumVrijeme };
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
                            if (proba == false)
                            {
                                foreach (var item2 in listaRezervacija)
                                {
                                    if (id == item2.praonicaId && (item2.datumVrijeme == uiInputDatumRezervacije.Value || uiInputDatumRezervacije.Value.Subtract(item2.datumVrijeme) < razlika) && item2.isteklaRezervacija == 0)
                                    {
                                        MessageBox.Show("Taj termin je zauzeo drugi korisnik. Idući slobodan termin za ovu perilicu je: " + item2.datumVrijeme.AddHours(1));
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
                            novaRezervacija.isteklaRezervacija = 0;
                            db.rezervacijaPraonices.Add(novaRezervacija);
                            db.SaveChanges();

                        }
                    }
                    // ako je rezerviral već praonicu 
                    else
                    {
                        TimeSpan interval = new TimeSpan(0, 0, 0);
                        TimeSpan interval2 = new TimeSpan(12, 0, 0);
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
                                        if (id == item2.praonicaId && item2.datumVrijeme == uiInputDatumRezervacije.Value && item2.isteklaRezervacija == 0)
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
                                novaRezervacija.isteklaRezervacija = 0;
                                db.rezervacijaPraonices.Add(novaRezervacija);
                                db.SaveChanges();
                                var Rezervirana = new CustomEvent
                                {
                                    Date = uiInputDatumRezervacije.Value,
                                    EventText = "Vi ste rezervirali praonicu:" + id,
                                    EventLengthInHours = 1f,
                                    EventColor = Color.Red
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

        private void uiActionPoništiRezervaciju_Click_1(object sender, EventArgs e)
        {
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
                    foreach (var item in listaOdabira)
                    {
                        if (item.id == id)
                        {
                            brisanjeRezervacije = item;
                        }
                    }
                    foreach (var item in listaPraonica)
                    {
                        if (item.naziv == naziv)
                        {
                            praonicaBrisanje = item;
                        }
                    }
                    db.praonicas.Attach(praonicaBrisanje);
                    // praonicaBrisanje.zauzeto = 0;
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
    }
}
