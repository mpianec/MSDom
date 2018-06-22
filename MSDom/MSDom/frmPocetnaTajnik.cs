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
    public partial class frmPocetnaTajnik : Form
    {
        public frmPocetnaTajnik()
        {
            InitializeComponent();
        }

        private void uiActionStvoriAnketu_Click(object sender, EventArgs e)
        {
            frmAnketa novaAnketa = new frmAnketa();
            novaAnketa.ShowDialog();
        }
    }
}
