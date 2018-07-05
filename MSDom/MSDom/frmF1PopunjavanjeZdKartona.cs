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
    public partial class frmF1PopunjavanjeZdKartona : Form
    {
        public frmF1PopunjavanjeZdKartona()
        {
            InitializeComponent();
            label1.Text = "U tablici su vidljivi svi zdravstveni kartoni određenog stanara.\n" +
                "Ukoliko želite promjeniti stanara za kojeg gledate\n" +
                "zdarvsteni karton, u padajućem izborniku na sredini forme izaberete\n" +
                "kojeg stanara želite.\n" +
                "Kada ste odabrali stanara imate pregled njegovih nalaza\n" +
                "i možete mu dodati novi tako da u gornjem dijelu upišete potrebne\n" +
                "podatke i kliknete na gumb 'Dodaj novi nalaz'.";
        }
    }
}
