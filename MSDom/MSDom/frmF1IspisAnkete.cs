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
    public partial class frmF1IspisAnkete : Form
    {
        public frmF1IspisAnkete()
        {
            InitializeComponent();
            label1.Text = "Za ispis ankete odaberite anketu iz padajućeg izbornika.\n";
            label1.Text += "Kada se anketa učita pritisnite sličicu 'Printera' te će se otvorit\n";
            label1.Text += "izbornik s postavkama ispisa";
        }
    }
}
