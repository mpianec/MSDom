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
    public partial class frmOdabirDorucka : Form
    {
        public frmOdabirDorucka()
        {
            InitializeComponent();
            DohvatiOdabraneDorucke();
            DohvatiVasOdabirZaSutra();
        }
        /// <summary>
        /// Metoda DohvatiOdabreneDorucke() dohvaća sve jelovnike koji su vrste doručak
        /// te pod vrijednosti atributa aktivan imaju vrijednost 1.
        /// </summary>
        public void DohvatiOdabraneDorucke()
        {
            using (var db = new MSDomEntities())
            {
                var listaAktivnihDorucaka = from dor in db.izbors
                                            where (dor.kategorijaId == 1 && dor.aktivanIzbor == 1)
                                            select new { dor.id, dor.predjelo, dor.prilog, dor.meso, dor.desert };

                uiOutputPonudaDorucka.DataSource = listaAktivnihDorucaka.ToList();
            }
        }
        public void DohvatiVasOdabirZaSutra()
        {
            DateTime datum = DateTime.Today;
            using (var db=new MSDomEntities())
            {
                
                var idOdabranogJelovnika = from od in db.vasIzborDanas
                                           join dor in db.izbors
                                           on od.izborId equals dor.id
                                           where (od.datum == datum && od.korisnikId == PrijavljeniKorisnik.id)
                                           select new { dor.id, dor.predjelo, dor.prilog, dor.meso, dor.desert };
                if (idOdabranogJelovnika.ToList().Count == 1)
                {
                    uiOutputVasOdabir.DataSource = idOdabranogJelovnika.ToList();
                }
                else
                {
                    uiOutputVasOdabir.DataSource = null;
                }
                
            }
        }

        private void uiActionSpremiOdabir_Click(object sender, EventArgs e)
        {
            if (uiOutputPonudaDorucka.CurrentRow != null)
            {

                int idJelovnika = int.Parse(uiOutputPonudaDorucka.CurrentRow.Cells[0].Value.ToString());
                DateTime datum = DateTime.Today;
                using (var db = new MSDomEntities())
                {
                    var idOdabranogJelovnika = from od in db.vasIzborDanas
                                               join dor in db.izbors
                                               on od.izborId equals dor.id
                                               where (od.datum == datum && od.korisnikId == PrijavljeniKorisnik.id)
                                               select new { dor.id, dor.predjelo, dor.prilog, dor.meso, dor.desert };
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
                        MessageBox.Show("Imate odabrani doručak. Poništite trenutni izbor.");
                    }
                }
            }
            DohvatiOdabraneDorucke();
            DohvatiVasOdabirZaSutra();
        }

        private void uiActionPonistiOdabir_Click(object sender, EventArgs e)
        {

            vasIzborDana izborDanaZaBrisanje = null;
            DateTime datum = DateTime.Today;
            using (var db = new MSDomEntities())
            {
                var idOdabira = from v in db.vasIzborDanas
                                where (v.datum == datum && v.korisnikId == PrijavljeniKorisnik.id)
                                select v.id;
                if (idOdabira.ToList().Count > 0) { 
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
                    MessageBox.Show("Nemate dodan izbor za doručak.");
                }
        }
            DohvatiOdabraneDorucke();
            DohvatiVasOdabirZaSutra();
        }
    }
}
