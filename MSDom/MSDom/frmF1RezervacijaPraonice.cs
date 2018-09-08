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
    public partial class frmF1RezervacijaPraonice : Form
    {
        public frmF1RezervacijaPraonice()
        {
            InitializeComponent();
            label1.Text = "Da bi ste rezervirali praonicu odaberite praonicu iz tablice.\n";
            label1.Text += "Odaberite vrijeme koje želite tako da upišete vrijeme, te klikom na polje\n";
            label1.Text += "Vam se otvara mogućnost odabira dana kada želite rezervirati praonicu.\n";
            label1.Text += "Nakon odabira kliknite gumb 'Rezerviraj'\n\n";
            label1.Text += "Za poništavanje rezervacije odaberite rezerviranu praonicu iz druge tablice\n";
            label1.Text += "te pritisnite gumb 'Poništi'";
            label1.Text += "Također, ako želite primiti obavijest \nda je praonica u određenom terminu oslobođena,\n";
            label1.Text += "odaberite u odjeljku 'Predbilježba' taj termin i kliknite potvrdi.\n";
            label1.Text += "Na kalendaru su crvenom bojom označene Vaše buduće rezervacije, \n";
            label1.Text += "smeđom Vaše prošle, plavom tuđe buduće i tamno plavom tuđe prošle.";
        }
    }
}
