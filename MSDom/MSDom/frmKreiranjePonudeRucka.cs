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
    public partial class frmKreiranjePonudeRucka : Form
    {
        public frmKreiranjePonudeRucka()
        {
            InitializeComponent();
            DohvatiSveRucke();
            DohvatiOdabraneRuckove();
        }
        /// <summary>
        /// Metoda DohvatiSveRucke() dohvaća iz baze podataka sve jelovnike koji su vrste ručak
        /// i kojima je vrijednost atributa aktivan jednaka 0 te ih prikazuje u data grid view.
        /// </summary>
        private void DohvatiSveRucke()
        {
            using (var db = new MSDomEntities())
            {
                var listaSvihRucka = from dor in db.izbors
                                        where (dor.kategorijaId == 2 && dor.aktivanIzbor == 0)
                                        select new { dor.id, dor.predjelo, dor.prilog, dor.meso, dor.desert };

                uiOutputPopisRucka.DataSource = listaSvihRucka.ToList();

            }
        }
        /// <summary>
        /// Metoda DohvatiOdabraneRuckove() dohvaća iz baze jelovnike koji su vrste rucak te 
        /// za vrijednost atributa aktivan imaju vrijednost 1. Metoda nakon dohvata podataka
        /// prikazuje iste u data grid view.
        /// </summary>
        private void DohvatiOdabraneRuckove()
        {
            using (var db = new MSDomEntities())
            {
                var listaAktivnihRucka = from dor in db.izbors
                                            where (dor.kategorijaId == 2 && dor.aktivanIzbor == 1)
                                            select new { dor.id, dor.predjelo, dor.prilog, dor.meso, dor.desert };

                uiOutputDanasnjaPonudaRucka.DataSource = listaAktivnihRucka.ToList();
            }
        }
        private void AktivirajIzbor(int id)
        {
            BindingList<izbor> listaIzbora = null;
            using (var db = new MSDomEntities())
            {
                listaIzbora = new BindingList<izbor>(db.izbors.ToList());
                foreach (var item in listaIzbora)
                {
                    if (item.id == id)
                    {
                        db.izbors.Attach(item);
                        item.aktivanIzbor = 1;
                        db.SaveChanges();
                    }
                }
            }

        }
        private void DeaktivirajIzbor(int id)
        {
            BindingList<izbor> listaIzbora = null;
            using (var db = new MSDomEntities())
            {
                listaIzbora = new BindingList<izbor>(db.izbors.ToList());
                foreach (var item in listaIzbora)
                {
                    if (item.id == id)
                    {
                        db.izbors.Attach(item);
                        item.aktivanIzbor = 0;
                        db.SaveChanges();
                    }
                }
            }
        }
        /// <summary>
        /// Metoda uiActionDodaj_Click() klikom na gumb "Dodaj u današnju ponudu" 
        /// uzima id selektiranog jelovnika te ga prosljeđuje metodi AktivirajIzbor().
        /// </summary>

        private void uiActionDodaj_Click(object sender, EventArgs e)
        {
            using (var db = new MSDomEntities())
            {
                var listaAktivnihRucka = from dor in db.izbors
                                            where (dor.kategorijaId == 2 && dor.aktivanIzbor == 1)
                                            select new { dor.id, dor.predjelo, dor.prilog, dor.meso, dor.desert };

                if (listaAktivnihRucka.ToList().Count >= 3)
                {
                    MessageBox.Show("Odabrali ste već 3 jelovnika.");
                }
                else
                {
                    AktivirajIzbor(int.Parse(uiOutputPopisRucka.CurrentRow.Cells[0].Value.ToString()));
                    DohvatiOdabraneRuckove();
                    DohvatiSveRucke();
                }

            }
        }
        /// <summary>
        /// Metoda uiActionMakni_Click() klikom na gumb "Maksni s danasnje ponude"
        /// uzima id selektiranog jelovnika te ga prosljeđuje metodi DeaktivirajIzbor().
        /// </summary>
        private void uiActionMakni_Click(object sender, EventArgs e)
        {
            if (uiOutputDanasnjaPonudaRucka.CurrentRow != null)
            {
                DeaktivirajIzbor(int.Parse(uiOutputDanasnjaPonudaRucka.CurrentRow.Cells[0].Value.ToString()));
                DohvatiSveRucke();
                DohvatiOdabraneRuckove();
            }
        }
    }
}
