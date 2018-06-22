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
    public partial class frmPocetnaStanar : Form
    {
        public frmPocetnaStanar()
        {
            InitializeComponent();
        }

        private void uiActionOdabirDorucka_Click(object sender, EventArgs e)
        {
            frmOdabirDorucka dorucak = new frmOdabirDorucka();
            dorucak.ShowDialog();
            
        }

        private void uiActionOdabirRucka_Click(object sender, EventArgs e)
        {
            frmPonudaRucka rucak = new frmPonudaRucka();
            rucak.ShowDialog();
        }

        private void uiActionOdabirVecere_Click(object sender, EventArgs e)
        {
            frmPonudaVecere vecera = new frmPonudaVecere();
            vecera.ShowDialog();
        }

        private void uiActionRezervacijaPraonice_Click(object sender, EventArgs e)
        {
            frmRezervacijaPraonice rezervacija = new frmRezervacijaPraonice();
            rezervacija.ShowDialog();
        }
    }
}
