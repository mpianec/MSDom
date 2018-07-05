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
    public partial class frmSastanakSDoktorom : Form
    {
        public frmSastanakSDoktorom()
        {
            InitializeComponent();
            DohvatiStanareCmb();
            DohvatiDoktoreCmb();
        }

        private void uiActionUgovori_Click(object sender, EventArgs e)
        {
            bool postoji = false;
            using (var db = new MSDomEntities())
            {
                BindingList<sastanakSDoktorom> listaSastanaka = new BindingList<sastanakSDoktorom>(db.sastanakSDoktoroms.ToList());
                sastanakSDoktorom sastanak = new sastanakSDoktorom();
                sastanak.stanarId = int.Parse(uiInputStanar.SelectedValue.ToString());
                sastanak.doktorId = int.Parse(uiInputDoktor.SelectedValue.ToString());
                sastanak.datumVrijeme = dateTimePicker1.Value;

                foreach (var item in listaSastanaka)
                {
                    if (item.datumVrijeme==sastanak.datumVrijeme)
                    {
                        postoji = true;
                    }
                }
                if (!postoji)
                {
                    db.sastanakSDoktoroms.Add(sastanak);
                    MessageBox.Show("Ugovorili ste sastanak!");
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Termin je već rezerviran!");
                }
            }
            
            DohvatiDoktoreCmb();
            DohvatiStanareCmb();
        }
        /// <summary>
        /// Metoda DohvatiStanareCmb() vraća sve korisnike iz baze podataka koji imaju ulogu 1
        /// odnosno koji su stanari i sprema ih zatim u combobox u kojem ih možemo odabrati
        /// da ugovorimo sastanak s doktorom
        /// </summary>
        public void DohvatiStanareCmb()
        {
            using (var db = new MSDomEntities())
            {
                var listaKorisnika = from kor in db.korisniks
                                     where (kor.ulogaId == 1)
                                     select new { kor.id, kor.ime };

                uiInputStanar.DataSource = listaKorisnika.ToList();


            }
        }
        /// <summary>
        /// Metoda DohvatiDoktoreeCmb() vraća sve korisnike iz baze podataka koji imaju ulogu 3
        /// odnosno koji su doktori i sprema ih zatim u combobox u kojem ih možemo odabrati
        /// da dogovorimo sastanak s doktorom
        /// </summary>
        public void DohvatiDoktoreCmb()
        {
            using (var db = new MSDomEntities())
            {
                var listaKorisnika = from kor in db.korisniks
                                     where (kor.ulogaId == 3)
                                     select new { kor.id, kor.ime };

                uiInputDoktor.DataSource = listaKorisnika.ToList();


            }
        }

        private void frmSastanakSDoktorom_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmSastanakSDoktorom_KeyDown);
            this.KeyDown -= new KeyEventHandler(frmSastanakSDoktorom_KeyDown);
        }

        private void frmSastanakSDoktorom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                frmF1SastanakSDoktorom forma = new frmF1SastanakSDoktorom();
                forma.ShowDialog();
            }
        }
    }
}
