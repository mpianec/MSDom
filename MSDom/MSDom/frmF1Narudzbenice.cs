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
            label1.Text = "Na ovoj formi je potrebno iz padajučeg izbornika odabrati narudžbenicu koju želimo isprintati i.\n" +
                "pritisnuti tipku za ispis. Ako želimo promjeniti narudžbenicu koju ćemo vidjeti na izvještaju,\n" +
                "samo iz padajućeg izbornika odaberemo drugu koju želimo ispisati.";
        }
    }
}
