using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void DohvatiSlobodnePraonice()
        {
            using (var db = new MSDomEntities())
            {
                var listaSlobodnihPraonica = from praon in db.praonicas
                                            where (praon.zauzeto == 0)
                                            select new { praon.id, praon.naziv};

                uiOutputSlobodnePraonice.DataSource = listaSlobodnihPraonica.ToList();
            }
        }
        public void DohvatiVaseRezervacije()
        {
            using (var db=new MSDomEntities())
            {
                var idOdabranePraonice = from od in db.rezervacijaPraonices
                                         join praon in db.praonicas
                                         on od.praonicaId equals praon.id
                                         where (od.korisnikId == PrijavljeniKorisnik.id)
                                         select new { od.id, praon.naziv,od.datumVrijeme};
                if (idOdabranePraonice.ToList().Count > 0)
                    uiOutputMojeRezervacije.DataSource = idOdabranePraonice.ToList();
                else
                    uiOutputMojeRezervacije.DataSource = null;
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
                    if (idOdabranePraonice.ToList().Count == 0)
                    {
                        BindingList<praonica> listaPraonica = new BindingList<praonica>(db.praonicas.ToList());                   
                        int id = int.Parse(uiOutputSlobodnePraonice.CurrentRow.Cells[0].Value.ToString());
                        foreach(var item in listaPraonica)
                        {
                            if (item.id == id)
                            {
                                praonicaZaUpdate = item;
                            }
                        }
                        db.praonicas.Attach(praonicaZaUpdate);
                        praonicaZaUpdate.zauzeto = 1;
                        rezervacijaPraonice novaRezervacija = new rezervacijaPraonice();
                        novaRezervacija.datumVrijeme = uiInputDatumRezervacije.Value;
                        novaRezervacija.korisnikId = PrijavljeniKorisnik.id;
                        novaRezervacija.praonicaId = idPraonice;                        
                        db.rezervacijaPraonices.Add(novaRezervacija);
                        db.SaveChanges();
                    }
                    else
                    {
                        TimeSpan interval = new TimeSpan(0, 0, 0);
                        TimeSpan interval2 = new TimeSpan(1, 0, 0, 0);
                        foreach(var item in idOdabranePraonice.ToList())
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
                            BindingList<praonica> listaPraonica = new BindingList<praonica>(db.praonicas.ToList());
                            int id = int.Parse(uiOutputSlobodnePraonice.CurrentRow.Cells[0].Value.ToString());
                            foreach (var item in listaPraonica)
                            {
                                if (item.id == id)
                                {
                                    praonicaZaUpdate = item;
                                }
                            }
                            db.praonicas.Attach(praonicaZaUpdate);
                            praonicaZaUpdate.zauzeto = 1;
                            rezervacijaPraonice novaRezervacija = new rezervacijaPraonice();
                            novaRezervacija.datumVrijeme = uiInputDatumRezervacije.Value;
                            novaRezervacija.korisnikId = PrijavljeniKorisnik.id;
                            novaRezervacija.praonicaId = idPraonice;
                            db.rezervacijaPraonices.Add(novaRezervacija);
                            db.SaveChanges();
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
    }
}
