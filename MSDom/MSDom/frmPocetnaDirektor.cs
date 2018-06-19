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
    public partial class frmPocetnaDirektor : Form
    {
        public frmPocetnaDirektor()
        {
            InitializeComponent();
        }

        private void uiActionRegistrirajNovogKorisnika_Click(object sender, EventArgs e)
        {
            frmRegistracija registracija = new frmRegistracija();
            registracija.ShowDialog();
        }

        private void uiActionPregledKorisnika_Click(object sender, EventArgs e)
        {
            frmPregledKorisnika pregledKorisnika = new frmPregledKorisnika();
            pregledKorisnika.ShowDialog();
        }
    }
}
