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
    public partial class frmF1KreiranjeNarudzbenice : Form
    {
        public frmF1KreiranjeNarudzbenice()
        {
            InitializeComponent();
            label1.Text = "Za kreiranje nove narrudžbenice pritisnite gumb Kreiraj.\n";
            label1.Text += "Za dodavanje nove stavke pritisnite gumb Dodaj stavku.\n";
            label1.Text += "Za brisanje narudžbenice pritisnite gumb Obriši.\n";
            label1.Text += "Za ispis narudžbenice u pdf formatu pritisnite gumb Ispis.";
        }
    }
}
