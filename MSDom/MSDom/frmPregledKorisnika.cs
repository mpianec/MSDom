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
    public partial class frmPregledKorisnika : Form
    {
        public frmPregledKorisnika()
        {
            InitializeComponent();
            DohvatiKorisnike();
        }

        public void DohvatiKorisnike()
        {
            
            using (var db=new MSDomEntities())
            {
                var listaKorisnika = from kor in db.korisniks
                                     join ulo in db.ulogas
                                     on kor.ulogaId equals ulo.id
                                     join sob in db.sobas
                                     on kor.sobaId equals sob.id
                                     select new {kor.id,kor.ime,kor.prezime,kor.korisnickoIme,kor.lozinka,ulo.naziv, sob.brojSobe};
                uiOutputKorisnici.DataSource = listaKorisnika.ToList();
            }
            
        }

        private void uiActionAzurirajKorisnika_Click(object sender, EventArgs e)
        {
            if (uiOutputKorisnici.CurrentRow != null)
            {
                int id = int.Parse(uiOutputKorisnici.CurrentRow.Cells[0].Value.ToString());
                frmAzuriranjeKorisnika azuriranjeKorisnika = new frmAzuriranjeKorisnika(id);
                azuriranjeKorisnika.ShowDialog();
                DohvatiKorisnike();
            }
        }
    }
}
