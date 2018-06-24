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
    public partial class frmPocetnaDoktor : Form
    {
        public frmPocetnaDoktor()
        {
            InitializeComponent();
        }

        private void uiActionPopuniZdKarton_Click(object sender, EventArgs e)
        {
            frmPopunjavanjeZdKartona forma = new frmPopunjavanjeZdKartona();
            forma.ShowDialog();
            Close();
        }

        private void uiActionPregledSastanaka_Click(object sender, EventArgs e)
        {
            frmPregledSastanaka forma = new frmPregledSastanaka();
            forma.ShowDialog();
            Close();
        }

        private void uiActionNaruči_Click(object sender, EventArgs e)
        {
            frmNarudzbaLijekova forma = new frmNarudzbaLijekova();
            Close();
            forma.ShowDialog();
        }
    }
}
