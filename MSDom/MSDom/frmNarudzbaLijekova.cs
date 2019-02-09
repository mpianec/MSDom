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
    public partial class frmNarudzbaLijekova : Form
    {
        public frmNarudzbaLijekova()
        {
            InitializeComponent();
            DohvatiLijekove();
        }
        BindingList<lijek> listaLijekica = null;

        public void DohvatiLijekove()
        {

            using (var db = new MSDomEntities())
            {

                listaLijekica = new BindingList<lijek>(db.lijeks.ToList());

                var listica = listaLijekica.OrderBy(x => x.naziv).ToList();
                lijekBindingSource.DataSource = listica;

            }
        }

        private void uiActionUnosKolicine_Click(object sender, EventArgs e)
        {
            
            lijek lijekZaAzuriranje = lijekBindingSource.Current as lijek;
            if (lijekZaAzuriranje != null)
            {
                using (var db = new MSDomEntities())
                {
                    db.lijeks.Attach(lijekZaAzuriranje);
                    lijekZaAzuriranje.kolicina += int.Parse(uiInputKolicina.Text);
                    db.SaveChanges();
                }
            }

            DohvatiLijekove();
        }

        private void uiActionNoviLijek_Click(object sender, EventArgs e)
        {
            bool postoji = false;
            using (var db = new MSDomEntities())
            {
                BindingList<lijek> listaLijekova = new BindingList<lijek>(db.lijeks.ToList());
                lijek lijek = new lijek();
                lijek.naziv = uiInputNaziv.Text;
                lijek.kolicina = int.Parse(uiInputKolicinaLijeka.Text);
                foreach (var item in listaLijekova)
                {
                    if (item.naziv==lijek.naziv)
                    {
                        postoji = true;
                    }
                }
                if (!postoji)
                {
                    db.lijeks.Add(lijek);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Lijek već postoji u bazi!");
                }
            }
            DohvatiLijekove();
        }

        private void frmNarudzbaLijekova_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmNarudzbaLijekova_KeyDown);
            this.KeyDown -= new KeyEventHandler(frmNarudzbaLijekova_KeyDown);
        }

        private void frmNarudzbaLijekova_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                frmF1NarudzbaLijekova forma = new frmF1NarudzbaLijekova();
                forma.ShowDialog();
            }
        }

        private void uiOutputPretraga_TextChanged(object sender, EventArgs e)
        {
            using (var db = new MSDomEntities())
            {
                string pretraga = uiOutputPretraga.Text;

                var lista = new List<lijek>();

                if (uiOutputPretraga.Text.Length>0)
                {
                    foreach (var item in listaLijekica)
                    {
                        if (item.naziv.ToUpper().Contains(pretraga.ToUpper()))
                        {
                            lista.Add(item);
                        }
                    }

                    lijekBindingSource.DataSource = lista;
                }
                else
                {
                    DohvatiLijekove();
                }
            }
        }
    }
}
