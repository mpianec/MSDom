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
    public partial class frmPocetnaSpremacica : Form
    {
        public frmPocetnaSpremacica()
        {
            InitializeComponent();
        }

        private void uiInputPonistiRezervacije_Click(object sender, EventArgs e)
        {
            frmPonistiRezervaciju formaPonisti = new frmPonistiRezervaciju();
            formaPonisti.ShowDialog();
        }
    }
}
