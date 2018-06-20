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
    public partial class frmKreiranjePonudeDorucak : Form
    {
        
        public frmKreiranjePonudeDorucak()
        {
            InitializeComponent();
            DohvatiOdabraneDorucke();
            DohvatiSveDorucke();
        }

        public void DohvatiSveDorucke()
        {
            using (var db = new MSDomEntities())
            {
                var listaSvihDorucaka = from dor in db.izbors
                                        where (dor.kategorijaId == 1 && dor.aktivanIzbor==0)
                                        select new { dor.id, dor.predjelo, dor.prilog, dor.meso, dor.desert };

                uiOutputPopisDorucka.DataSource = listaSvihDorucaka.ToList();
                
            }
        }
        private void AktivirajIzbor(int id)
        {
            BindingList<izbor> listaIzbora = null;
            using (var db=new MSDomEntities())
            {
                listaIzbora = new BindingList<izbor>(db.izbors.ToList());
                foreach (var item in listaIzbora)
                {
                    if (item.id==id)
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
        public void DohvatiOdabraneDorucke()
        {
            using (var db = new MSDomEntities())
            {
                var listaAktivnihDorucaka = from dor in db.izbors
                                        where (dor.kategorijaId == 1 && dor.aktivanIzbor == 1)
                                        select new { dor.id, dor.predjelo, dor.prilog, dor.meso, dor.desert };

                uiOutputDanasnjaPonudaDorucka.DataSource = listaAktivnihDorucaka.ToList();
            }
        }

        private void uiActionDodaj_Click(object sender, EventArgs e)
        {
           
            using (var db = new MSDomEntities())
            {
                 var listaAktivnihDorucaka = from dor in db.izbors
                                            where (dor.kategorijaId == 1 && dor.aktivanIzbor == 1)
                                            select new { dor.id, dor.predjelo, dor.prilog, dor.meso, dor.desert };

                if (listaAktivnihDorucaka.ToList().Count >= 3)
                {
                    MessageBox.Show("Odabrali ste već 3 jelovnika.");
                }
                else
                {
                    AktivirajIzbor(int.Parse(uiOutputPopisDorucka.CurrentRow.Cells[0].Value.ToString()));
                    DohvatiOdabraneDorucke();
                    DohvatiSveDorucke();
                }
                
            }
        }

        private void uiActionMakni_Click(object sender, EventArgs e)
        {
            DeaktivirajIzbor(int.Parse(uiOutputDanasnjaPonudaDorucka.CurrentRow.Cells[0].Value.ToString()));
            DohvatiSveDorucke();
            DohvatiOdabraneDorucke();
        }
    }
}
