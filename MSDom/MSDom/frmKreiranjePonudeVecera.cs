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
    public partial class frmKreiranjePonudeVecera : Form
    {
        public frmKreiranjePonudeVecera()
        {
            InitializeComponent();
            DohvatiSveVecere();
            DohvatiAktivneVecere();
        }
        /// <summary>
        /// Metoda DohvatiSveVecere() dohvaća sve jelovnike koji su vrste večera i koji
        /// za vrijednost atributa aktivan imaju vrijednost 0 te ih prikazuje u data grid view.
        /// </summary>

        private void DohvatiSveVecere()
        {
            using (var db = new MSDomEntities())
            {
                var listaSvihVecera = from dor in db.izbors
                                        where (dor.kategorijaId == 3 && dor.aktivanIzbor == 0)
                                        select new { dor.id, dor.predjelo, dor.prilog, dor.meso, dor.desert };

                uiOutputPopisVecera.DataSource = listaSvihVecera.ToList();

            }
        }
        /// <summary>
        /// Metoda DohvatiAktivneVecere() dohvaća sve jelovnike koji su vrste večera i koji
        /// za vrijednost atributa aktivan imaju vrijednost 1 te ih prikazuje u data grid view.
        /// </summary>
        private void DohvatiAktivneVecere()
        {
            using (var db = new MSDomEntities())
            {
                var listaAktivnihVecera = from dor in db.izbors
                                            where (dor.kategorijaId == 3 && dor.aktivanIzbor == 1)
                                            select new { dor.id, dor.predjelo, dor.prilog, dor.meso, dor.desert };

                uiOutputDanasnjaPonudaVecera.DataSource = listaAktivnihVecera.ToList();
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
                var listaAktivnihVecera = from dor in db.izbors
                                            where (dor.kategorijaId == 3 && dor.aktivanIzbor == 1)
                                            select new { dor.id, dor.predjelo, dor.prilog, dor.meso, dor.desert };

                if (listaAktivnihVecera.ToList().Count >= 3)
                {
                    MessageBox.Show("Odabrali ste već 3 jelovnika.");
                }
                else
                {
                    AktivirajIzbor(int.Parse(uiOutputPopisVecera.CurrentRow.Cells[0].Value.ToString()));
                    DohvatiAktivneVecere();
                    DohvatiSveVecere();
                }

            }
        }
        /// <summary>
        /// Metoda uiActionMakni_Click() klikom na gumb "Maksni s danasnje ponude"
        /// uzima id selektiranog jelovnika te ga prosljeđuje metodi DeaktivirajIzbor().
        /// </summary>
        private void uiActionMakni_Click(object sender, EventArgs e)
        {
            if (uiOutputDanasnjaPonudaVecera.CurrentRow != null)
            {
                DeaktivirajIzbor(int.Parse(uiOutputDanasnjaPonudaVecera.CurrentRow.Cells[0].Value.ToString()));
                DohvatiSveVecere();
                DohvatiAktivneVecere();
            }
        }
    }
}
