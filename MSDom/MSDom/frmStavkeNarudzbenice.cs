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
    public partial class frmStavkeNarudzbenice : Form
    {
        int id;
        public frmStavkeNarudzbenice(int ID)
        {
            InitializeComponent();
            MessageBox.Show("ID narudžbenice: " + ID);
            id = ID;
        }

        private void uiActionDodaj_Click(object sender, EventArgs e)
        {
            int kolicina = int.Parse(uiInputKolicina.Text);
        }
    }
}
