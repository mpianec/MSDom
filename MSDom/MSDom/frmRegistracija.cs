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
        /// <summary>
        /// Funkcija dohvaća uloge korisnika.
        /// Kako bi se mogle odabrati u combobox-u.
        /// </summary>
        private void DohvatiUloge()
        {
            BindingList<uloga> listaUloga = null;
            using(var db=new MSDomEntities())
            {
                listaUloga = new BindingList<uloga>(db.ulogas.ToList());
            }
            uiInputUloga.DataSource = listaUloga;
        }
        /// <summary>
        /// Funkcija dohvaća sve sobe koje su prazne i one koje nisu tipa soba.
        /// Kao što su na primjer Kabinet i Ured.
        /// </summary>
        private void DohvatiSobe()
        {
            
            using(var db=new MSDomEntities())
            {
               var  listaSoba = from sob in db.sobas
                            where (sob.brojPopunjenihKreveta < sob.brojKreveta || sob.tipSobeId!=1)
                            select new {sob.id, sob.brojSobe};
                uiInputBrojSobe.DataSource = listaSoba.ToList();


            }
            
        }
        /// <summary>
        /// Funkcija služi za spremanje novog korisnika u bazu.
        /// Provjerava jesu li popunjena sva polja, ako jesu provjerava je li korisničko ime
        /// različito od korisničkih imena u bazi, ako je i taj uvjet zadovoljen
        /// u bazu se sprema novi korisnik.
        /// </summary>
        
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
                    soba sobaZaPovecanjeZauzetosti = null;
                using (var db = new MSDomEntities())
                {
                        BindingList<soba> listaSoba = new BindingList<soba>(db.sobas.ToList());
                        foreach (var item in listaSoba)
                        {
                            if (item.id == noviKorisnik.sobaId)
                            {
                                sobaZaPovecanjeZauzetosti = item;
                            }

                        }
                        db.sobas.Attach(sobaZaPovecanjeZauzetosti);
                        sobaZaPovecanjeZauzetosti.brojPopunjenihKreveta++;
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
