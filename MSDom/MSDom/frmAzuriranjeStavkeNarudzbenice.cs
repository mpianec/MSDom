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
    public partial class frmAzuriranjeStavkeNarudzbenice : Form
    {
        int id;
        int kolicina;
        string naziv;
        public frmAzuriranjeStavkeNarudzbenice(int ID, int Kolicina, string Naziv)
        {
            InitializeComponent();
            id = ID;
            kolicina = Kolicina;
            naziv = Naziv;
            PrikaziDohvacenuStavku();
        }

        public void PrikaziDohvacenuStavku()
        {
            uiOutputIdStavke.Text = id.ToString();
            uiOutputNaziv.Text = naziv;
            uiInputKolicina.Text = kolicina.ToString();
        }

        private void uiActionAzuriraj_Click(object sender, EventArgs e)
        {
            using (var db = new MSDomEntities())
            {
                var ids = id;
                var kol = kolicina;
                var sql = "Update [StavkeNarudzbenice] SET kolicina = {0} WHERE id = {1}";
                db.Database.ExecuteSqlCommand(sql, uiInputKolicina.Text, id);
                
            }
            Close();
        }
    }
}
