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
    public partial class frmF1SastanakSDoktorom : Form
    {
        public frmF1SastanakSDoktorom()
        {
            InitializeComponent();
            label1.Text = "U ovoj formi možete naručiti stanara na pregled kod doktora.\n" +
                "Da biste to napravili morate iz padajučih izbornika odabrati stanara kojeg želite naručiti\n" +
                "te doktora kojem ide na pregled. Zatim odaberete datum i pritisnete gumb\n" +
                "'Ugovori novi sastanak s doktorom.";
        }
    }
}
