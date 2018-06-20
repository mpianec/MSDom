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
    public partial class frmJelovnikUnos : Form
    {
        public frmJelovnikUnos()
        {
            InitializeComponent();
            DohvatiKategorije();
        }
        /// <summary>
        /// Metoda Dohvati kateorije puni commbobox za odabir kategorije s popisom kategorija.
        /// Odnosno nudi izbor doručak, ručak i večera.
        /// </summary>
        private void DohvatiKategorije()
        {
            BindingList<izborKategorija> listaKategorija = null;
            using (var db=new MSDomEntities())
            {
                listaKategorija = new BindingList<izborKategorija>(db.izborKategorijas.ToList());
            }
            uiInputKategorija.DataSource = listaKategorija;
        }
        /// <summary>
        /// Metoda koja se aktivira na klik gumba Unos.
        /// Kreira novi izbor i sprema ga u bazu.
        /// </summary>

        private void uiActionUnos_Click(object sender, EventArgs e)
        {
            if (uiInputPredjelo.Text != "" && uiInputPrilog.Text != "" && uiInputMeso.Text != "" && uiInputDesert.Text != "" && uiInputKategorija.SelectedValue != null) { 
            using (var db = new MSDomEntities())
            {
                izbor noviIzbor = new izbor();
                noviIzbor.predjelo = uiInputPredjelo.Text;
                noviIzbor.prilog = uiInputPrilog.Text;
                noviIzbor.meso = uiInputMeso.Text;
                noviIzbor.desert = uiInputDesert.Text;
                noviIzbor.kategorijaId = int.Parse(uiInputKategorija.SelectedValue.ToString());
                db.izbors.Add(noviIzbor);
                db.SaveChanges();
            }
                Close();
            }
            else
            {
                MessageBox.Show("Niste popunili cijelu formu.");
            }
        }
    }
}
