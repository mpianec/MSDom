using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IspisPdf;

namespace MSDom
{
    public partial class frmNarudzbenice : Form
    {
        public frmNarudzbenice()
        {
            InitializeComponent();
            DohvatiStanareCmb();
            DohvatiNalaze();
            DohvatiLijekoveZaDijagnozu();
            DohvatiLijekove();
        }
        /// <summary>
        /// Metoda frmNarudzbeniceLoad na sami load forme prikazuje narudzbenice na reportu
        /// </summary>
        private void frmNarudzbenice_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmNarudzbenice_KeyDown);
            this.KeyDown -= new KeyEventHandler(frmNarudzbenice_KeyDown);


            /*int idNalaz = int.Parse(uiOutputPrikaz.SelectedValue.ToString());
            BindingList<lijekoviZaDijagnozu> listaLijekovaZaDijgnozu = null;
            using (var db = new MSDomEntities())
            {
                listaLijekovaZaDijgnozu = new BindingList<lijekoviZaDijagnozu>(db.lijekoviZaDijagnozus.ToList());
                foreach (var item in listaLijekovaZaDijgnozu)
                {
                    if (item.nalazId == idNalaz)
                    {
                        lijekoviZaDijagnozuBindingSource.DataSource = listaLijekovaZaDijgnozu;

                    }
                }
            }*/
            int idNalaz = int.Parse(uiOutputPrikaz.SelectedValue.ToString());
            using (var db = new MSDomEntities())
            {
                var listaLijekova = from nalaz in db.lijekoviZaDijagnozus
                                    where (nalaz.nalazId == idNalaz)
                                    select new { nalaz.id, nalaz.lijekId, nalaz.nalazId };

                lijekoviZaDijagnozuBindingSource.DataSource = listaLijekova.ToList();

            }
            
        }

        public void DohvatiStanareCmb()
        {
            using (var db = new MSDomEntities())
            {
                var listaKorisnika = from kor in db.korisniks
                                     where (kor.ulogaId == 1)
                                     select new { kor.id, kor.ime };

                uiOutputPrikaz.DataSource = listaKorisnika.ToList();


            }
        }


        /// <summary>
        /// Metoda DohvatiNalaze() vraća sve nalaze iz baze podataka i sprema ih sa bindingsourceom
        /// </summary>
        public void DohvatiNalaze()
        {
            using (var db = new MSDomEntities())
            {
                var listaNalaza = from nalaz in db.nalazs
                                     select new { nalaz.id, nalaz.nazivBolesti};
                nalazBindingSource.DataSource = listaNalaza.ToList();
            }
        }
        /// <summary>
        /// Metoda DohvatiLijekove() vraća sve lijekove iz baze podataka i sprema ih sa bindingsourceom
        /// </summary>
        public void DohvatiLijekove()
        {
            if (uiOutputPrikaz.SelectedItem!=null)
            {
                int idNalaz = int.Parse(uiOutputPrikaz.SelectedValue.ToString());
                using (var db = new MSDomEntities())
                {
                    var listalijekova = from lij in db.lijeks
                                        join od in db.lijekoviZaDijagnozus
                                        on lij.id equals od.lijekId
                                        where (od.nalazId == idNalaz)
                                        select new { lij.id, lij.naziv };
                    lijekBindingSource.DataSource = listalijekova.ToList();
                }
            }
            
        }
        /// <summary>
        /// Metoda DohvatiLijekoveZaDijagnozu() vraća sve narudzbenice iz baze podataka i sprema ih sa bindingsourceom
        /// </summary>
        public void DohvatiLijekoveZaDijagnozu()
        {
            /*int idNalaz = int.Parse(uiOutputPrikaz.SelectedValue.ToString());
            BindingList<lijekoviZaDijagnozu> listaLijekovaZaDijgnozu = null;
            using (var db = new MSDomEntities())
            {
                listaLijekovaZaDijgnozu = new BindingList<lijekoviZaDijagnozu>(db.lijekoviZaDijagnozus.ToList());
                foreach (var item in listaLijekovaZaDijgnozu)
                {
                    if (item.nalazId==idNalaz)
                    {
                        lijekoviZaDijagnozuBindingSource.DataSource = listaLijekovaZaDijgnozu;

                    }
                }
            }*/
            if (uiOutputPrikaz.SelectedValue!=null)
            {
                int idNalaz = int.Parse(uiOutputPrikaz.SelectedValue.ToString());
                using (var db = new MSDomEntities())
                {
                    var listaLijekova = from nalaz in db.lijekoviZaDijagnozus
                                        where (nalaz.nalazId == idNalaz)
                                        select new { nalaz.id, nalaz.lijekId, nalaz.nalazId };
                    lijekoviZaDijagnozuBindingSource.DataSource = listaLijekova.ToList();
                }
            }
            
            
        }

        private void uiOutputPrikaz_SelectedIndexChanged(object sender, EventArgs e)
        {
            DohvatiLijekove();
            DohvatiLijekoveZaDijagnozu();           
        }

        private void frmNarudzbenice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                frmF1Narudzbenice forma = new frmF1Narudzbenice();
                forma.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int idNalaz = int.Parse(uiOutputPrikaz.SelectedValue.ToString());
            List<IspisPdf.StavkeNarudzbenice> listalijekova;

            using (var db = new MSDomEntities())
            {
                var temp = from lij in db.lijeks
                           join od in db.lijekoviZaDijagnozus
                           on lij.id equals od.lijekId
                           join nal in db.nalazs
                           on od.nalazId equals nal.id
                           join kor in db.korisniks
                           on nal.stanarId equals kor.id
                           where (kor.id == idNalaz)
                           select new IspisPdf.StavkeNarudzbenice { ID = lij.id, Naziv = lij.naziv };
                listalijekova = temp.ToList();
            }


            if (Ispis.IspisNarudzbenice(idNalaz, listalijekova)==true)
            {
                Ispis.IspisNarudzbenice(idNalaz, listalijekova);
            }
            else
            {
                MessageBox.Show("PDF je već otvoren");
            }
        }
    }
}
