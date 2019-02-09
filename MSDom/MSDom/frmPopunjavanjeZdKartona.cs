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
    public partial class frmPopunjavanjeZdKartona : Form
    {
        public frmPopunjavanjeZdKartona()
        {
            InitializeComponent();
            DohvatiStanareCmb();
            DohvatiNalaze();
            DohvatiStanaraZaNoviNalaz();
        }

        int? idNalaza;
        /// <summary>
        /// Metoda DohvatiNalaze() vraća sve nalaze iz baze podataka i sprema ih
        /// u datagridview ako odgovara zadanom upitu
        /// </summary>
        public void DohvatiNalaze()
        {
            int idKor = int.Parse(uiOutputKorisnik.SelectedValue.ToString());
            using (var db = new MSDomEntities())
            {
                var listaStanara = from nalaz in db.nalazs
                                             where (nalaz.stanarId == idKor)
                                             select new {nalaz.id, nalaz.dijagnoza, nalaz.nazivBolesti, nalaz.datum };
                
                    uiOutputStanari.DataSource = listaStanara.ToList();
                
                
            }
        }
        /// <summary>
        /// Metoda DohvatiStanareCmb() vraća sve korisnike iz baze podataka koji imaju ulogu 1
        /// odnosno koji su stanari i sprema ih zatim u combobox u kojem ih možemo odabrati
        /// da nam se prikažu
        /// </summary>
        public void DohvatiStanareCmb()
        {
            using (var db = new MSDomEntities())
            {
                var listaKorisnika = from kor in db.korisniks
                                   where (kor.ulogaId == 1)
                                   select new { kor.id, kor.ime };
                
                    uiOutputKorisnik.DataSource = listaKorisnika.ToList();
                
                
            }
        }

        private void uiOutputKorisnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            DohvatiNalaze();
        }

        private void uiActionNoviNalaz_Click(object sender, EventArgs e)
        {
            using (var db = new MSDomEntities())
            {
                nalaz nalaz = new nalaz();
                nalaz.nazivBolesti = uiInputNazivBolesti.Text;
                nalaz.dijagnoza = uiInputDijagnoza.Text;
                nalaz.stanarId = int.Parse(uiInputStanar.SelectedValue.ToString());
                nalaz.datum = dateTimePicker1.Value;
                db.nalazs.Add(nalaz);
                db.SaveChanges();
            }
            DohvatiStanareCmb();
            DohvatiNalaze();

        }
        /// <summary>
        /// Metoda DohvatiStanareZaNoviNalaz() dohvaća iz baze sve korisnike koji su stanari
        /// te ih sprema u datagridview s kojim upisujemo novi nalaz
        /// </summary>
        public void DohvatiStanaraZaNoviNalaz()
        {
            using (var db = new MSDomEntities())
            {
                var listaKorisnika = from kor in db.korisniks
                                     where (kor.ulogaId == 1)
                                     select new { kor.id, kor.ime };

                uiInputStanar.DataSource = listaKorisnika.ToList();
            }
        }

        private void frmPopunjavanjeZdKartona_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmPopunjavanjeZdKartona_KeyDown);
            this.KeyDown -= new KeyEventHandler(frmPopunjavanjeZdKartona_KeyDown);
        }

        private void frmPopunjavanjeZdKartona_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                frmF1PopunjavanjeZdKartona forma = new frmF1PopunjavanjeZdKartona();
                forma.ShowDialog();
            }
        }

        private void uiActionObrisi_Click(object sender, EventArgs e)
        {
            nalaz nalaz = null;


            int id = int.Parse(uiOutputStanari.CurrentRow.Cells[0].Value.ToString());
            using (var db = new MSDomEntities())
            {
                var odabir = from nlz in db.nalazs
                             select nlz.id;
                if (odabir.ToList().Count > 0)
                {

                    BindingList<nalaz> lista = new BindingList<nalaz>(db.nalazs.ToList());
                    foreach (var item in lista)
                    {
                        if (item.id == id)
                        {
                            nalaz = item;
                        }
                    }
                    db.nalazs.Attach(nalaz);
                    db.nalazs.Remove(nalaz);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Nema nalaza za brisanje! ");
                }
            }

            

            DohvatiNalaze();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idNalaza = int.Parse(uiOutputStanari.CurrentRow.Cells[0].Value.ToString());

            if (idNalaza!=null)
            {
                frmDodajLijekStanaru forma = new frmDodajLijekStanaru(int.Parse(uiOutputStanari.CurrentRow.Cells[0].Value.ToString()));
                forma.Show();
            }
            else
            {
                MessageBox.Show("Niste odabrali nalaz");
            }
        }
    }
}
