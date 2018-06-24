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
    public partial class frmNoviPotsjetnik : Form
    {
        public frmNoviPotsjetnik()
        {
            InitializeComponent();
        }

        private void uiActionUnos_Click(object sender, EventArgs e)
        {
            using (var db=new MSDomEntities())
            {
                podsjetnik noviPotsjetnik = new podsjetnik();
                noviPotsjetnik.datumVrijeme = uiInptDatumVrijeme.Value;
                noviPotsjetnik.korisnikId = PrijavljeniKorisnik.id;
                noviPotsjetnik.razlog = uiInputRazlog.Text;
                db.podsjetniks.Add(noviPotsjetnik);
                db.SaveChanges();

            }
            Close();
        }
    }
}
