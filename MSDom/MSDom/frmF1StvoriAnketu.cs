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
    public partial class frmF1StvoriAnketu : Form
    {
        public frmF1StvoriAnketu()
        {
            InitializeComponent();
            label1.Text = "Za unos novog pitanja u naznačeno prazno polje unesite pitanje te pritisnite gumb 'Dodaj'\n";
            label1.Text += "Za unos novog pitanja u naznačeno prazno polje unesite pitanje.\n";
            label1.Text+="Odaberite datum koji želite klikom na datum te pritisnite gumb 'Dodaj'\n\n";
            label1.Text += "Za dodavanje pitanja na anketu odaberite anketu u padajućem izborniku\n";
            label1.Text += "te u drugom padajućem izborniku odaberite pitanje koje želite. Pritisnite gumb 'Dodaj'";
        }
    }
}
