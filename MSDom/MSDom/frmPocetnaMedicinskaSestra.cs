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
    public partial class frmPocetnaMedicinskaSestra : Form
    {
        public frmPocetnaMedicinskaSestra()
        {
            InitializeComponent();
        }

        private void uiActionPopuniZdKarton_Click(object sender, EventArgs e)
        {
            frmSastanakSDoktorom forma = new frmSastanakSDoktorom();
            forma.ShowDialog();
        }

        private void uiActionNaruči_Click(object sender, EventArgs e)
        {
            frmDodajLijekStanaru forma = new frmDodajLijekStanaru();
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNarudzbenice forma = new frmNarudzbenice();
            forma.ShowDialog();
        }
    }
}
