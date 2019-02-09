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
    public partial class frmF1DodajLijekStanaru : Form
    {
        public frmF1DodajLijekStanaru()
        {
            InitializeComponent();
            label1.Text = "U tablici su vam prikazani svi lijekovi.\n" +
                "Za prethodno odabrani nalaz možete dodati novi lijek, odabirom lijeka iz prikaza te klikom na gumb Odaberi.\n" +
                "Imate prikaz dodijeljenih lijekova nekom nalazu te ih pritiskom na gumb Obrisi možete obrisati\n";
        }
        
    }
}
