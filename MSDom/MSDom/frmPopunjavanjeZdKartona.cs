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
                                             select new { nalaz.dijagnoza, nalaz.nazivBolesti, nalaz.datum };
                
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
    }
}
