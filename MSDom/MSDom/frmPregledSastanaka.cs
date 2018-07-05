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
    public partial class frmPregledSastanaka : Form
    {
        public frmPregledSastanaka()
        {
            InitializeComponent();
            DohvatiSastanke();
        }
        /// <summary>
        /// Metoda DohvatiSasstanke dohvaća sve sastanke iz baze podataka i sprema ih sa bindingsourceom
        /// na datagridview koji se nalazi na formi
        /// </summary>
        public void DohvatiSastanke()
        {
            using (var db = new MSDomEntities())
            {
                var listaSastanak = from sas in db.sastanakSDoktoroms
                                    join kor in db.korisniks
                                    on sas.stanarId equals kor.id
                                    where (kor.id == sas.stanarId)
                                    select new { sas.id, kor.ime , sas.datumVrijeme };
                uiOutputSastanak.DataSource = null; 
                uiOutputSastanak.DataSource = listaSastanak.ToList();
            }
        }

        private void uiActionObrisi_Click(object sender, EventArgs e)
        {
            /*sastanakSDoktorom sastanak = sastanakSDoktoromBindingSource.Current as sastanakSDoktorom;
            if (sastanak!=null)
            {
                using (var db = new MSDomEntities())
                {
                    db.sastanakSDoktoroms.Attach(sastanak);
                    db.sastanakSDoktoroms.Remove(sastanak);
                    db.SaveChanges();
                }
            } */

            sastanakSDoktorom sastanak = null;
            using (var db = new MSDomEntities())
            {
                var odabir = from sas in db.sastanakSDoktoroms
                             join kor in db.korisniks
                             on sas.stanarId equals kor.id
                             select sas.id;
                if (odabir.ToList().Count>0)
                {
                    int id =int.Parse(uiOutputSastanak.CurrentRow.Cells[0].Value.ToString());
 
                    BindingList<sastanakSDoktorom> lista = new BindingList<sastanakSDoktorom>(db.sastanakSDoktoroms.ToList());
                    foreach (var item in lista)
                    {
                        if (item.id == id)
                        {
                            sastanak = item;
                        }
                    }
                    db.sastanakSDoktoroms.Attach(sastanak);
                    db.sastanakSDoktoroms.Remove(sastanak);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Nema sastanaka za brisanje! ");
                }
            }
            DohvatiSastanke();
        }

        private void frmPregledSastanaka_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmPregledSastanaka_KeyDown);
            this.KeyDown -= new KeyEventHandler(frmPregledSastanaka_KeyDown);
        }

        private void frmPregledSastanaka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                frmF1PregledSastanaka forma = new frmF1PregledSastanaka();
                forma.ShowDialog();
            }
        }
    }
}
