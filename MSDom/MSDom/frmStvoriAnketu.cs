﻿using System;
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
    public partial class frmStvoriAnketu : Form
    {
        public frmStvoriAnketu()
        {
            InitializeComponent();
            DohvatiPitanja();
            DohvatiAnketu();
            DohvatiAnketuSPitanjima();
        }
        //<sumarry>
        //Metoda DohvatiPitanje() vraća sva pitanja iz baze,
        //točnije njihov id te sami tekst pitanja
        //</sumarry> 
        public void DohvatiPitanja()
        {
            using (var db=new MSDomEntities())
            {
                var listaPitanja = from pit in db.pitanjes                                       
                                        select new {pit.id,pit.pitanje1};                
                uiOutputComboPitanja.DataSource = listaPitanja.ToList();

            }
        }
        //<sumarry>
        //Metoda DohvatiAnketu() vraća sve ankete iz baze,
        //točnije vraća id, naziv i datum provođenja ankete
        //</sumarry> 
        public void DohvatiAnketu()
        {
            using (var db = new MSDomEntities())
            {
                var listaAnketa = from ank in db.anketas
                                  select new { ank.id, ank.naziv, ank.datum };
                
                uiOutputComboAnkete.DataSource = listaAnketa.ToList();
            }
        }

        private void uiInputDodajPitanje_Click(object sender, EventArgs e)
        {
            using(var db=new MSDomEntities())
            {
                pitanje novo = new pitanje();
                novo.pitanje1 = uiInputUnosPitanja.Text;
                db.pitanjes.Add(novo);
                db.SaveChanges();
            }
            DohvatiPitanja();
        }

        private void uiActionStvoriAnketu_Click(object sender, EventArgs e)
        {
            using(var db=new MSDomEntities())
            {
                anketa nova = new anketa();
                nova.naziv = uiInputNazivAnkete.Text;
                nova.datum = uiInputDatumAnkete.Value.Date;
                db.anketas.Add(nova);
                db.SaveChanges();
            }
            DohvatiAnketu();
            DohvatiAnketuSPitanjima();
        }
        //<sumarry>
        //Metoda DohvatiAnketuSPitanjima() služi za dohvaćanje svih pitanja
        //koja se nalaze na nekoj određenoj anketi (koja je odabrana u comboboxu),
        //ispisuje se naziv ankete i pitanja koje je na njoj
        //</sumarry> 
        private void DohvatiAnketuSPitanjima()
        {
            int idAnk = int.Parse(uiOutputComboAnkete.SelectedValue.ToString());
            using (var db=new MSDomEntities())
            {
                var lista = from od in db.pitanjeSAnketes
                            join ank in db.anketas
                            on od.anketaId equals ank.id
                            join pit in db.pitanjes
                            on od.pitanjeId equals pit.id
                            where(ank.id==idAnk)
                            select new { ank.naziv, pit.pitanje1 };
                uiOutputPitanjaNaAnketi.DataSource = lista.ToList();
            }
        }
        private void uiActionDodajPitanje_Click(object sender, EventArgs e)
        {
            int idAnkete = int.Parse(uiOutputComboAnkete.SelectedValue.ToString());
            int idPitanje = int.Parse(uiOutputComboPitanja.SelectedValue.ToString());
            bool postoji = false;
            using (var db = new MSDomEntities())
            {
                BindingList<pitanjeSAnkete> listaPitanja = new BindingList<pitanjeSAnkete>(db.pitanjeSAnketes.ToList());
                pitanjeSAnkete novo = new pitanjeSAnkete();
                /*var lista = from od in db.pitanjeSAnketes
                            join ank in db.anketas
                            on od.anketaId equals ank.id
                            join pit in db.pitanjes
                            on od.pitanjeId equals pit.id
                            where (ank.id == idAnkete)
                            select new { od.id, pit.pitanje1 };*/

                foreach (var item in listaPitanja)
                {
                    if (item.pitanjeId == idPitanje && item.anketaId==idAnkete)
                        postoji = true;
                }
                if (!postoji) {
                    novo.anketaId = idAnkete;
                    novo.pitanjeId = idPitanje;
                    db.pitanjeSAnketes.Add(novo);
                    db.SaveChanges(); }

                else
                {
                    MessageBox.Show("Pitanje već postoji.");
                }
            }
            DohvatiAnketuSPitanjima();
        }

        private void uiOutputComboAnkete_SelectedIndexChanged(object sender, EventArgs e)
        {
            DohvatiAnketuSPitanjima();
        }

        private void frmStvoriAnketu_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmStvoriAnketu_KeyDown);
            this.KeyDown -= new KeyEventHandler(frmStvoriAnketu_KeyDown); ;
        }

        private void frmStvoriAnketu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                frmF1StvoriAnketu forma = new frmF1StvoriAnketu();
                forma.ShowDialog();
            }
        }
    }
}
