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
    public partial class frmAzurirajPotsjetnik : Form
    {
        podsjetnik prosljedeniPotsjetnik = null;
        public frmAzurirajPotsjetnik(podsjetnik podsjetnik )
        {
            InitializeComponent();
            prosljedeniPotsjetnik = podsjetnik;
            PrikaziPodsejtnik();
        }
        private void PrikaziPodsejtnik()
        {
            uiInptDatumVrijeme.Text = prosljedeniPotsjetnik.datumVrijeme.ToString();
            uiInputId.Text = prosljedeniPotsjetnik.id.ToString();
            uiInputRazlog.Text = prosljedeniPotsjetnik.razlog;
        }

        private void uiActionAzuriraj_Click(object sender, EventArgs e)
        {
            using (var db=new MSDomEntities())
            {
                db.podsjetniks.Attach(prosljedeniPotsjetnik);
                prosljedeniPotsjetnik.razlog = uiInputRazlog.Text;
                prosljedeniPotsjetnik.datumVrijeme = uiInptDatumVrijeme.Value;
                db.SaveChanges();
            }
            Close();
        }
    }
}
