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
    public partial class frmPonudaRucka : Form
    {
        public frmPonudaRucka()
        {
            InitializeComponent();
            DohvatiOdabraneRuckove();
            DohvatiVasOdabirRucka();
        }
        
        private void DohvatiOdabraneRuckove()
        {
            using (var db = new MSDomEntities())
            {
                var listaAktivnihRucka = from dor in db.izbors
                                         where (dor.kategorijaId == 2 && dor.aktivanIzbor == 1)
                                         select new { dor.id, dor.predjelo, dor.prilog, dor.meso, dor.desert };

                uiOutputPonudaRucka.DataSource = listaAktivnihRucka.ToList();
            }
        }
        private void DohvatiVasOdabirRucka()
        {
            DateTime datum = DateTime.Today;
            using (var db = new MSDomEntities())
            {

                var idOdabranogJelovnika = from od in db.vasIzborDanas
                                           join dor in db.izbors
                                           on od.izborId equals dor.id
                                           where (od.datum == datum && od.korisnikId == PrijavljeniKorisnik.id && dor.kategorijaId==2)
                                           select new { dor.id, dor.predjelo, dor.prilog, dor.meso, dor.desert, dor.kategorijaId };
                if (idOdabranogJelovnika.ToList().Count > 0)
                {   
                            uiOutputVasOdabir.DataSource =idOdabranogJelovnika.ToList(); 
                }
                else
                {
                    uiOutputVasOdabir.DataSource = null;
                }

            }
        }

        private void uiActionSpremiOdabir_Click(object sender, EventArgs e)
        {
            if (uiOutputPonudaRucka.CurrentRow != null)
            {
                bool postojiOdabraniDorucak = false;
                int idJelovnika = int.Parse(uiOutputPonudaRucka.CurrentRow.Cells[0].Value.ToString());
                DateTime datum = DateTime.Today;
                using (var db = new MSDomEntities())
                {
                    var idOdabranogJelovnika = from od in db.vasIzborDanas
                                               join dor in db.izbors
                                               on od.izborId equals dor.id
                                               where (od.datum == datum && od.korisnikId == PrijavljeniKorisnik.id)
                                               select new { dor.id, dor.predjelo, dor.prilog, dor.meso, dor.desert, dor.kategorijaId };
                    if (idOdabranogJelovnika.ToList().Count == 0)
                    {
                        vasIzborDana noviIzborDana = new vasIzborDana();
                        noviIzborDana.datum = datum;
                        noviIzborDana.korisnikId = PrijavljeniKorisnik.id;
                        noviIzborDana.izborId = idJelovnika;
                        db.vasIzborDanas.Add(noviIzborDana);
                        db.SaveChanges();
                    }
                    else
                    {
                        foreach (var item in idOdabranogJelovnika.ToList())
                        {
                            if (item.kategorijaId == 2)
                            {
                                postojiOdabraniDorucak = true;
                            }
                        }
                        if (!postojiOdabraniDorucak)
                        {
                            vasIzborDana noviIzborDana = new vasIzborDana();
                            noviIzborDana.datum = datum;
                            noviIzborDana.korisnikId = PrijavljeniKorisnik.id;
                            noviIzborDana.izborId = idJelovnika;
                            db.vasIzborDanas.Add(noviIzborDana);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Imate odabrani ručak. Poništite trenutni izbor.");
                        }

                    }
                }
            }
            DohvatiOdabraneRuckove();
            DohvatiVasOdabirRucka();
        }

        private void uiActionPonistiOdabir_Click(object sender, EventArgs e)
        {
            vasIzborDana izborDanaZaBrisanje = null;
            DateTime datum = DateTime.Today;
            using (var db = new MSDomEntities())
            {
                var idOdabira = from v in db.vasIzborDanas
                                join dor in db.izbors
                                on v.izborId equals dor.id
                                where (v.datum == datum && v.korisnikId == PrijavljeniKorisnik.id && dor.kategorijaId==2)
                                select v.id;
                if (idOdabira.ToList().Count > 0)
                {
                    int id = Convert.ToInt32(idOdabira.FirstOrDefault());

                    BindingList<vasIzborDana> listaIzboraDana = new BindingList<vasIzborDana>(db.vasIzborDanas.ToList());
                    foreach (var item in listaIzboraDana)
                    {
                        if (item.id == id)
                        {
                            izborDanaZaBrisanje = item;
                        }
                    }
                    db.vasIzborDanas.Attach(izborDanaZaBrisanje);
                    db.vasIzborDanas.Remove(izborDanaZaBrisanje);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Nemate dodan izbor za ručak.");
                }
            }
            DohvatiOdabraneRuckove();
            DohvatiVasOdabirRucka();
        }
    }
}
