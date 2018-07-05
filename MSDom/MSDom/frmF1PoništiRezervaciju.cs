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
    public partial class frmF1PoništiRezervaciju : Form
    {
        public frmF1PoništiRezervaciju()
        {
            InitializeComponent();
            label1.Text = "Odaberite željenu praonicu klikom na nju. \nDa bi ste poništili rezervaciju pristisnite gumb 'Poništi rezervaciju'.";
        }
    }
}
