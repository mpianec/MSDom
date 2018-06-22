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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uiClickExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        ///  Funkcionalnost za prijavu korisnika.
        ///  1. Provjerava jesu li uneseni podaci.
        ///  2. Ako jesu provjerava postoji li korisnik u bazi.
        ///  3. Ako postoji korisnik uspoređuje njegovu lozinku iz baze s unesemom lozinkom.
        ///  4. Ako su lozinke jednake podatke o korisniku spremamo u klasu Prijavljeni korisnik.
        /// </summary>
       
        private void uiActionPrijaviSe_Click(object sender, EventArgs e)
        {
            if (uiInputKorisnickoIme.Text!="" && uiInputLozinka.Text!="") { 
            string lozinkaUBazi = "";
            int ulogaKorisnika = 0;
            string korisnickoIme = uiInputKorisnickoIme.Text;
            string lozinka = uiInputLozinka.Text;
            uiInputKorisnickoIme.Text = "";
            uiInputLozinka.Text = "";
            BindingList<korisnik> listaKorisnika = null;
            using (var db = new MSDomEntities()) {
                listaKorisnika = new BindingList<korisnik>(db.korisniks.ToList());
            }
            bool postojiKorisnik = false;
            foreach (var item in listaKorisnika)
            {
                if (item.korisnickoIme == korisnickoIme)
                {
                    postojiKorisnik = true;
                    lozinkaUBazi = item.lozinka;
                    ulogaKorisnika = item.ulogaId;
                }
            }
            if (postojiKorisnik)
            {
                if (lozinka == lozinkaUBazi)
                {
                        foreach (var item in listaKorisnika)
                        {
                            if (item.korisnickoIme == korisnickoIme)
                            {
                                PrijavljeniKorisnik.id = item.id;
                                PrijavljeniKorisnik.ime = item.ime;
                                PrijavljeniKorisnik.prezime = item.prezime;
                                PrijavljeniKorisnik.idSobe = item.sobaId;
                                PrijavljeniKorisnik.korisnickoIme = item.korisnickoIme;
                                PrijavljeniKorisnik.lozinka = item.lozinka;
                                PrijavljeniKorisnik.uloga = item.ulogaId;

                            }
                        }
                    switch (ulogaKorisnika)
                    {
                        case 1:   
                                frmPocetnaStanar pocetnaFormaStanar = new frmPocetnaStanar();
                                this.Hide();
                                pocetnaFormaStanar.ShowDialog();
                                this.Close();
                                break;
                        case 2:
                                frmPocetnaTajnik pocetnaFormaTajnik = new frmPocetnaTajnik();
                                this.Hide();
                                pocetnaFormaTajnik.ShowDialog();
                                this.Close();
                                break;
                        case 3: break;
                        case 4: break;
                        case 5:
                                frmPocetnaKuhar pocetnaFormaKuhar = new frmPocetnaKuhar();
                                this.Hide();
                                pocetnaFormaKuhar.ShowDialog();
                                this.Close();
                                break;
                        case 6: break;
                        case 7:
                                frmPocetnaDirektor pocetnaFormaDirektor = new frmPocetnaDirektor();
                                this.Hide();
                                pocetnaFormaDirektor.ShowDialog();
                                this.Close();
                                break;

                    }
                }
                else
                {
                    MessageBox.Show("Unjeli ste pogrešnu lozinku.");
                }
            }
            else
            {
                MessageBox.Show("Unjeli ste neispravno korisničko ime.");
            } }
        }
    }
}
