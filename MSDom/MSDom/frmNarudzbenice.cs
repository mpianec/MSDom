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
    public partial class frmNarudzbenice : Form
    {
        public frmNarudzbenice()
        {
            InitializeComponent();
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

            this.reportViewer1.RefreshReport();
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
            this.reportViewer1.Refresh();
        }
        /// <summary>
        /// Metoda DohvatiLijekove() vraća sve lijekove iz baze podataka i sprema ih sa bindingsourceom
        /// </summary>
        public void DohvatiLijekove()
        {
            int idNalaz = int.Parse(uiOutputPrikaz.SelectedValue.ToString());
            using (var db = new MSDomEntities())
            {
                var listalijekova = from lij in db.lijeks
                                    join od in db.lijekoviZaDijagnozus
                                    on lij.id equals od.lijekId
                                    where(od.id==idNalaz)
                                  select new { lij.id, lij.naziv };
                lijekBindingSource.DataSource = listalijekova.ToList();             
            }
            this.reportViewer1.Refresh();
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

            int idNalaz = int.Parse(uiOutputPrikaz.SelectedValue.ToString());
            using (var db = new MSDomEntities())
            {
                var listaLijekova = from nalaz in db.lijekoviZaDijagnozus
                                    where (nalaz.nalazId == idNalaz)
                                    select new { nalaz.id, nalaz.lijekId, nalaz.nalazId };

                lijekoviZaDijagnozuBindingSource.DataSource = listaLijekova.ToList();
            }
            this.reportViewer1.Refresh();
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
    }
}
