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
            using (var db = new MSDomEntities())
            {
                sastanakSDoktorom sastanak = new sastanakSDoktorom();
                sastanak.stanarId = int.Parse(uiInputStanar.SelectedValue.ToString());
                sastanak.doktorId = int.Parse(uiInputDoktor.SelectedValue.ToString());
                sastanak.datumVrijeme = dateTimePicker1.Value;
                db.sastanakSDoktoroms.Add(sastanak);
                db.SaveChanges();
            }
            MessageBox.Show("Ugovorili ste sastanak!");
            DohvatiDoktoreCmb();
            DohvatiStanareCmb();
        }

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
    }
}
