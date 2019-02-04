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
    public partial class frmKreiranjeNarudzbenice : Form
    {
        int idNarudzbenice;
        public frmKreiranjeNarudzbenice()
        {
            InitializeComponent();
            DohvatiNarudzbenice();
        }

        public void DohvatiNarudzbenice()
        {
            BindingList<narudzbenica> listaNarudzbenica = null;

            using (var db = new MSDomEntities())
            {

                listaNarudzbenica = new BindingList<narudzbenica>(db.narudzbenicas.ToList());

                var listica = listaNarudzbenica.OrderBy(x => x.id).ToList();
                narudzbenicaBindingSource.DataSource = listica;

            }
        }

        private void uiActionKreirajNarudzbenicu_Click(object sender, EventArgs e)
        {

        }

        private void uiActionDodajStavke_Click(object sender, EventArgs e)
        {

            narudzbenica n = narudzbenicaBindingSource.Current as narudzbenica;
            if (n!=null)
            {
                idNarudzbenice = n.id;
                frmStavkeNarudzbenice forma = new frmStavkeNarudzbenice(idNarudzbenice);
                forma.Show();
            }
            else
            {
                MessageBox.Show("Niste odabrali narudzbenicu!");
            }
        }
    }
}
