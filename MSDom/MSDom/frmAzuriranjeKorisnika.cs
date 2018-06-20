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
    public partial class frmAzuriranjeKorisnika : Form
    {
        public int prosljedeniId = 0;
        public korisnik prosljedeniKorisnik=null;
        public frmAzuriranjeKorisnika(int id)
        {
            InitializeComponent();
            prosljedeniId = id;
            DohvatiKorisnika();
        }
        /// <summary>
        /// Metoda DohvatiKorisnika() dohvaća korisnika koji ima id jednak prosljeđenom id-u te
        /// njegovim podacima popunjava polja za unos.
        /// </summary>
        private void DohvatiKorisnika()
        {
            BindingList<korisnik> listaKorisnika = null;
            BindingList<soba> listaSoba = null;
            BindingList<uloga> listaUloga = null;
            using(var db=new MSDomEntities())
            {
                listaKorisnika = new BindingList<korisnik>(db.korisniks.ToList());
                listaSoba = new BindingList<soba>(db.sobas.ToList());
                listaUloga = new BindingList<uloga>(db.ulogas.ToList());
            }
            uiInputBrojSobe.DataSource = listaSoba;
            uiInputUloga.DataSource = listaUloga;
            foreach (var item in listaKorisnika)
            {
                if (item.id == prosljedeniId)
                {
                    prosljedeniKorisnik = item;
                    uiInputID.Text = item.id.ToString();
                    uiInputIme.Text = item.ime;
                    uiInputPrezime.Text = item.prezime;
                    for (int i = 0; i < listaSoba.Count; i++)
                    {
                        if (listaSoba[i].id ==item.sobaId)
                        {
                            uiInputBrojSobe.SelectedIndex=i; 
                        }
                    }

                    for (int i = 0; i < listaUloga.Count; i++)
                    {
                        if (listaUloga[i].id == item.ulogaId)
                        {
                            uiInputUloga.SelectedIndex = i;
                        }
                    }
                  
                  
                    uiInputKorisnickoIme.Text = item.korisnickoIme;
                    uiInputLozinka.Text = item.lozinka;
                }
            }
           
          
            
        }
        /// <summary>
        /// Kreirana metoda koja dohvaća sve podatke koji su uneseni, sprema ih u korinika
        /// koji ima id jednak prosljeđenom id te sprema podatke u bazu.
        /// </summary>
       
        private void uiActionSpremi_Click(object sender, EventArgs e)
        {
            using (var db=new MSDomEntities())
            {
                db.korisniks.Attach(prosljedeniKorisnik);
                prosljedeniKorisnik.id = int.Parse(uiInputID.Text.ToString());
                prosljedeniKorisnik.ime = uiInputIme.Text;
                prosljedeniKorisnik.prezime = uiInputPrezime.Text;
                prosljedeniKorisnik.sobaId = int.Parse(uiInputBrojSobe.SelectedValue.ToString());
                prosljedeniKorisnik.ulogaId = int.Parse(uiInputUloga.SelectedValue.ToString());
                prosljedeniKorisnik.korisnickoIme = uiInputKorisnickoIme.Text;
                prosljedeniKorisnik.lozinka = uiInputLozinka.Text;
                db.SaveChanges();
            }
            Close();
        }
    }
}
