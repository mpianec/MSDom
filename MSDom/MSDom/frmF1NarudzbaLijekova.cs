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
    public partial class frmF1NarudzbaLijekova : Form
    {
        public frmF1NarudzbaLijekova()
        {
            InitializeComponent();
            label1.Text = "Vidite ispis svih lijekova koji postoje u bazi.\n";
            label1.Text += "Ako želite naručiti neki lijek koji trenutno nije u domu te nikad nije bio, u desnom gornjem dijelu unesete naziv lijeka i potrenu količinu.\n";
            label1.Text += "Ako samo želite naručiti novu količinu postojećeg lijeka, možete to napraviti tako da odaberete lijek u tablici te u gornjem lijevom kutu upišete količinu koju želite naručiti.";        }
    }
}
