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
    public partial class frmPotsjetnici : Form
    {
        public frmPotsjetnici()
        {
            InitializeComponent();
            PrikaziPotsjetnike();
        }
        private void PrikaziPotsjetnike()
        {
            BindingList<podsjetnik> listaPotsjetnika = null;
            using (var db=new MSDomEntities())
            {
                listaPotsjetnika = new BindingList<podsjetnik>(db.podsjetniks.ToList());
            }
            BindingList<podsjetnik> listaPodsjetnikaKorisnik = new BindingList<podsjetnik>();
            foreach (var item in listaPotsjetnika)
            {
                if (item.korisnikId==PrijavljeniKorisnik.id)
                {
                    listaPodsjetnikaKorisnik.Add(item);
                }
            }
            if (listaPodsjetnikaKorisnik.Count == 0)
            {
                podsjetnikBindingSource.DataSource = null;
            }
            else
            {
                podsjetnikBindingSource.DataSource = listaPodsjetnikaKorisnik;
            }
            
        }

        private void uiActionDodaj_Click(object sender, EventArgs e)
        {
            frmNoviPotsjetnik noviPotsjetnik = new frmNoviPotsjetnik();
            noviPotsjetnik.ShowDialog();
            PrikaziPotsjetnike();
        }

        private void uiActionAzuriraj_Click(object sender, EventArgs e)
        {
            if (podsjetnikBindingSource.Current as podsjetnik != null)
            {   
                frmAzurirajPotsjetnik azuriranjePotsjetnika = new frmAzurirajPotsjetnik(podsjetnikBindingSource.Current as podsjetnik);
                azuriranjePotsjetnika.ShowDialog();
                PrikaziPotsjetnike();
            }
            

        }

        private void uiActionObrisi_Click(object sender, EventArgs e)
        {
            if (podsjetnikBindingSource.Current as podsjetnik != null)
            {
                podsjetnik podsjetnikZaBrisanje = podsjetnikBindingSource.Current as podsjetnik;
                using (var db=new MSDomEntities())
                {
                    db.podsjetniks.Attach(podsjetnikZaBrisanje);
                    db.podsjetniks.Remove(podsjetnikZaBrisanje);
                    db.SaveChanges();
                }
            }
            PrikaziPotsjetnike();
        }
    }
}
