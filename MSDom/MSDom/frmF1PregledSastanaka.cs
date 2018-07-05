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
    public partial class frmF1PregledSastanaka : Form
    {
        public frmF1PregledSastanaka()
        {
            InitializeComponent();

            label1.Text = "Omogućen vam je pregled svih sastanaka koje imate sa stanarima.\n" +
                "Ako želite obrisati neki sastanak, možete to napraviti tako da\n" +
                "odaberete u tablici sastanak i kliknete na njega te zatim kliknete na\n" +
                "gumb 'Obriši sastanak'";
        }
    }
}
