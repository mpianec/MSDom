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
    public partial class frmAnketa : Form
    {
        public frmAnketa()
        {
            InitializeComponent();
            DohvatiAnketu();
            DohvatiDatum();
        }

        private void frmAnketa_Load(object sender, EventArgs e)
        {
            int idAnk = int.Parse(uiOutputAnkete.SelectedValue.ToString());
            using (var db=new MSDomEntities())
            {
                var lista = from pit in db.pitanjes
                            join od in db.pitanjeSAnketes
                            on pit.id equals od.pitanjeId
                            where (od.anketaId==idAnk)
                            select new { pit.pitanje1 };
                pitanjeBindingSource.DataSource = lista.ToList();
            }
            this.reportViewer1.RefreshReport();
        }
        public void DohvatiAnketu()
        {
            using (var db = new MSDomEntities())
            {
                var listaAnketa = from ank in db.anketas
                                  select new { ank.id, ank.naziv, ank.datum };

                uiOutputAnkete.DataSource = listaAnketa.ToList();
            }
        }
        public void DohvatiDatum()
        {
            int idAnk = int.Parse(uiOutputAnkete.SelectedValue.ToString());
            using (var db=new MSDomEntities())
            {
                var datum = from ank in db.anketas
                            where (ank.id == idAnk)
                            select new { ank.datum };
                anketaBindingSource.DataSource = datum.ToList();
            }
        }


        private void uiOutputAnkete_SelectedIndexChanged(object sender, EventArgs e)
        {
            DohvatiDatum();
            int idAnk = int.Parse(uiOutputAnkete.SelectedValue.ToString());
            using (var db = new MSDomEntities())
            {
                var lista = from pit in db.pitanjes
                            join od in db.pitanjeSAnketes
                            on pit.id equals od.pitanjeId
                            where (od.anketaId == idAnk)
                            select new { pit.pitanje1 };
                pitanjeBindingSource.DataSource = lista.ToList();
            }
            this.reportViewer1.RefreshReport();
            
        }
    }
}
