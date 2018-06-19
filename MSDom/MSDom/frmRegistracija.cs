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
    public partial class frmRegistracija : Form
    {
        public frmRegistracija()
        {
            InitializeComponent();
            DohvatiUloge();
            DohvatiSobe();
        }
        private void DohvatiUloge()
        {
            BindingList<uloga> listaUloga = null;
            using(var db=new MSDomEntities())
            {
                listaUloga = new BindingList<uloga>(db.ulogas.ToList());
            }
            uiInputUloga.DataSource = listaUloga;
        }
        private void DohvatiSobe()
        {
            BindingList<soba> listaSoba = null;
            using(var db=new MSDomEntities())
            {
                listaSoba = new BindingList<soba>(db.sobas.ToList());
            }
            uiInputBrojSobe.DataSource = listaSoba;
        }
        private void uiActionUnos_Click(object sender, EventArgs e)
        {
            if (uiInputIme.Text != "" && uiInputPrezime.Text != "" && uiInputKorisnickoIme.Text != "" && uiInputLozinka.Text != "" && uiInputUloga.SelectedValue != null && uiInputBrojSobe.SelectedValue != null) { 
            bool postojeceKorisnickoIme = false;
            korisnik noviKorisnik = new korisnik();
            noviKorisnik.ime = uiInputIme.Text;
            noviKorisnik.prezime = uiInputPrezime.Text;
            noviKorisnik.sobaId = int.Parse(uiInputBrojSobe.SelectedValue.ToString());
            noviKorisnik.ulogaId = int.Parse(uiInputUloga.SelectedValue.ToString());
            noviKorisnik.korisnickoIme = uiInputKorisnickoIme.Text;
            noviKorisnik.lozinka = uiInputLozinka.Text;
            BindingList<korisnik> listaKorisnika = null;
            using (var db = new MSDomEntities())
            {
                listaKorisnika = new BindingList<korisnik>(db.korisniks.ToList());
            }
            foreach (var item in listaKorisnika)
            {
                if (noviKorisnik.korisnickoIme == item.korisnickoIme)
                {
                    postojeceKorisnickoIme = true;
                }
            }
            if (!postojeceKorisnickoIme)
            {
                using (var db = new MSDomEntities())
                {
                    db.korisniks.Add(noviKorisnik);
                    db.SaveChanges();
                }
                    Close();
            }
            else
            {
                MessageBox.Show("Korisničko ime je zauzeto.");
            }
            }
            else
            {
                MessageBox.Show("Niste unijeli sve podatke");
            }
        }
    }
}
