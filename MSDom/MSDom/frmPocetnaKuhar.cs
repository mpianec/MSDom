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
    public partial class frmPocetnaKuhar : Form
    {
        public frmPocetnaKuhar()
        {
            InitializeComponent();
        }

        private void uiActionBrisanjeJelovnika_Click(object sender, EventArgs e)
        {
            frmBrisanjeAzuriranjeJelovnika brisanjeAzuriranje = new frmBrisanjeAzuriranjeJelovnika();
            brisanjeAzuriranje.ShowDialog();
        }

        private void uiActionKreiranjeJelovnika_Click(object sender, EventArgs e)
        {
            frmJelovnikUnos unosJelovnika = new frmJelovnikUnos();
            unosJelovnika.ShowDialog();
        }

        private void uiActionKreiranjeDorucka_Click(object sender, EventArgs e)
        {
            frmKreiranjePonudeDorucak dorucak = new frmKreiranjePonudeDorucak();
            dorucak.ShowDialog();

        }

        private void uiActionKreiranjeRucka_Click(object sender, EventArgs e)
        {
            frmKreiranjePonudeRucka rucak = new frmKreiranjePonudeRucka();
            rucak.ShowDialog();
        }

        private void uiActionKreiranjeVecere_Click(object sender, EventArgs e)
        {
            frmKreiranjePonudeVecera vecera = new frmKreiranjePonudeVecera();
            vecera.ShowDialog();
        }

        private void uiActionPregledNarudzbi_Click(object sender, EventArgs e)
        {
            frmPrikazNarudzbi prikazNarudzbi = new frmPrikazNarudzbi();
            prikazNarudzbi.ShowDialog();
        }
    }
}
