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
    public partial class frmF1Narudzbenice : Form
    {
        public frmF1Narudzbenice()
        {
            InitializeComponent();
            label1.Text = "Na ovoj formi je složen pregled narudžbenica u obliku izvještaja kako bi\n" +
                "bio omogućen ispis. Ako želimo promjeniti narudžbenicu koju ćemo vidjeti na izvještaju,\n" +
                "samo iz padajućeg izbornika odaberemo drugu koju želimo ispisati.";
        }
    }
}
