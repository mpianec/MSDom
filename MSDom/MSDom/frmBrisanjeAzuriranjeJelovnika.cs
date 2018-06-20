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
    public partial class frmBrisanjeAzuriranjeJelovnika : Form
    {
        public frmBrisanjeAzuriranjeJelovnika()
        {
            InitializeComponent();
            DohvatiIzbor();
        }
        /// <summary>
        /// Metoda DohvatiIzbor dohvaća sve izbore iz baze i prikazuje iz u data grid view.
        /// </summary>
        private void DohvatiIzbor()
        {
            using (var db=new MSDomEntities())
            {
                var listaIzbor = from izb in db.izbors
                                 join kat in db.izborKategorijas
                                 on izb.kategorijaId equals kat.id
                                 select new {izb.id, izb.predjelo, izb.prilog,izb.meso,izb.desert,kat.imeKategorije};
                uiOutputPopisJelovnika.DataSource = listaIzbor.ToList();
            }
        }

        private void uiActionAzuriraj_Click(object sender, EventArgs e)
        {
            if (uiOutputPopisJelovnika.CurrentRow != null) {
                int selektiraniJelovnik = int.Parse(uiOutputPopisJelovnika.CurrentRow.Cells[0].Value.ToString());
                frmAzuriranjeJelovnika azurirajJelovnik = new frmAzuriranjeJelovnika(selektiraniJelovnik);
                azurirajJelovnik.ShowDialog();
                DohvatiIzbor();
            }
        }
    }
}
