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
        }

        private void frmNarudzbenice_Load(object sender, EventArgs e)
        {
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

        
        public void DohvatiNalaze()
        {
            BindingList<nalaz> listaNalaza = null;
            using (var db = new MSDomEntities())
            {

                listaNalaza = new BindingList<nalaz>(db.nalazs.ToList());
                nalazBindingSource.DataSource = listaNalaza;

            }
        }

        public void DohvatiLijekoveZaDijagnozu()
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

        private void uiOutputPrikaz_SelectedIndexChanged(object sender, EventArgs e)
        {
            DohvatiLijekoveZaDijagnozu();
        }
    }
}
