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
            label1.Text = "U tablici su vam prikazani svi dodijeljeni lijekovi po jednom nalazu.\n" +
                "Ukoliko želite promjeniti nalaz, iz padajućeg izbronika smao odaberete neki drugi nalaz.\n" +
                "Ukoliko određenom nalazu želite dodati lijek iz padajućeg izbornika izaberete lijek\n" +
                "i kliknete na gumb 'Dodaj'";
        }
        
    }
}
