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

        private void frmNarudzbenice_Load(object sender, EventArgs e)
        {
            int idNalaz = int.Parse(uiOutputPrikaz.SelectedValue.ToString());
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
            }

            this.reportViewer1.RefreshReport();
        }
            

        
        public void DohvatiNalaze()
        {
            using (var db = new MSDomEntities())
            {
                var listaNalaza = from nalaz in db.nalazs
                                     select new { nalaz.id, nalaz.nazivBolesti};
                nalazBindingSource.DataSource = listaNalaza.ToList(); 

            }
        }

        public void DohvatiLijekove()
        {
            using (var db = new MSDomEntities())
            {
                var listalijekova = from lij in db.lijeks
                                  select new { lij.id, lij.naziv };
                lijekBindingSource.DataSource = listalijekova.ToList();
                
            }
        }

        public void DohvatiLijekoveZaDijagnozu()
        {
            int idNalaz = int.Parse(uiOutputPrikaz.SelectedValue.ToString());
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
            }
        }


    }
}
