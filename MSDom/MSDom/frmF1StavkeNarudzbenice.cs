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
    public partial class frmF1StavkeNarudzbenice : Form
    {
        public frmF1StavkeNarudzbenice()
        {
            InitializeComponent();
            label1.Text = "Za prethodno odabrani lijek možete dodati novu stavku upisom količine i " +
                "odabirom lijeka te pritiskom na gumb Dodaj." +
                "Također, omogućeno je ažuriranje stavke, odabirom jedne od stavki iz prikaza te pritiskom" +
                "na gumb Ažuriraj." +
                "Omogućeno je i brisanje stavke, odabirom jedne iz prikaza i pritiskom na gumb Obrisi." +
                "Još je mogući i pretraživanje lijekova upisivanjem imena lijeka u tekstualno polje.";
        }
    }
}
