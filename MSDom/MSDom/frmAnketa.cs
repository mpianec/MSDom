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
    public partial class frmAnketa : Form
    {
        public frmAnketa()
        {
            InitializeComponent();
            DohvatiAnketu();
            DohvatiDatum();
        }

        private void frmAnketa_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmAnketa_KeyDown);
            this.KeyDown -= new KeyEventHandler(frmAnketa_KeyDown); 

            int idAnk = int.Parse(uiOutputAnkete.SelectedValue.ToString());
            using (var db=new MSDomEntities())
            {
                var lista = from pit in db.pitanjes
                            join od in db.pitanjeSAnketes
                            on pit.id equals od.pitanjeId
                            where (od.anketaId==idAnk)
                            select new { pit.pitanje1 };
                pitanjeBindingSource.DataSource = lista.ToList();
            }
            this.reportViewer1.RefreshReport();
        }
        //<sumarry>
        //Metoda DohvatiAnketu() vraća sve ankete, 
        //točnije id, naziv i datum 
        //</sumarry> 
        public void DohvatiAnketu()
        {
            using (var db = new MSDomEntities())
            {
                var listaAnketa = from ank in db.anketas
                                  select new { ank.id, ank.naziv, ank.datum };

                uiOutputAnkete.DataSource = listaAnketa.ToList();
            }
        }
        //<sumarry>
        //Metoda DohvatiDatum() vraća točno određeni datum, 
        //datum one ankete koja je odabrana u comboboxu
        //</sumarry> 
        public void DohvatiDatum()
        {
            int idAnk = int.Parse(uiOutputAnkete.SelectedValue.ToString());
            using (var db=new MSDomEntities())
            {
                var datum = from ank in db.anketas
                            where (ank.id == idAnk)
                            select new { ank.datum };
                anketaBindingSource.DataSource = datum.ToList();
            }
        }


        private void uiOutputAnkete_SelectedIndexChanged(object sender, EventArgs e)
        {
            DohvatiDatum();
            int idAnk = int.Parse(uiOutputAnkete.SelectedValue.ToString());
            using (var db = new MSDomEntities())
            {
                var lista = from pit in db.pitanjes
                            join od in db.pitanjeSAnketes
                            on pit.id equals od.pitanjeId
                            where (od.anketaId == idAnk)
                            select new { pit.pitanje1 };
                pitanjeBindingSource.DataSource = lista.ToList();
            }
            this.reportViewer1.RefreshReport();
            
        }

        private void frmAnketa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                frmF1IspisAnkete forma = new frmF1IspisAnkete();
                forma.ShowDialog();
            }
        }
    }
}
