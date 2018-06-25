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
    public partial class frmDodajLijekStanaru : Form
    {
        public frmDodajLijekStanaru()
        {
            InitializeComponent();
            DohvatiLijekove();
            DohvatiNalaze();
            DohvatiLijekoveZaDijagnozu();
        }

        private void uiActionDodaj_Click(object sender, EventArgs e)
        {
            using (var db = new MSDomEntities())
            {
                lijekoviZaDijagnozu lijek = new lijekoviZaDijagnozu();
                lijek.lijekId = int.Parse(uiInputLijek.SelectedValue.ToString());
                lijek.nalazId = int.Parse(uiInputNalaz.SelectedValue.ToString());
                db.lijekoviZaDijagnozus.Add(lijek);
                db.SaveChanges();
            }
            DohvatiLijekoveZaDijagnozu();
        }
        /// <summary>
        /// Metoda DohvatiLijekove() vraća sve nalaze iz baze podataka i sprema ih sa bindingsourceom
        /// u combobox sa lijekovima
        /// </summary>
        public void DohvatiLijekove()
        {

            BindingList<lijek> listaLijekica = null;
            using (var db = new MSDomEntities())
            {

                listaLijekica = new BindingList<lijek>(db.lijeks.ToList());
                lijekBindingSource.DataSource = listaLijekica;

            }
        }
        /// <summary>
        /// Metoda DohvatiNalaze() vraća sve nalaze iz baze podataka i sprema ih sa bindingsourceom
        /// u combobox
        /// </summary>
        public void DohvatiNalaze()
        {
            BindingList<nalaz> listaNalaza = null;
            using (var db = new MSDomEntities())
            {

                listaNalaza = new BindingList<nalaz>(db.nalazs.ToList());
                nalazBindingSource.DataSource = listaNalaza;

            }
        }
        /// <summary>
        /// Metoda DohvatiLijekoveZaDijagnozu() vraća sve nalaze iz baze podataka i sprema ih sa bindingsourceom
        /// </summary>
        public void DohvatiLijekoveZaDijagnozu()
        {
            int idNalaz = int.Parse(uiInputNalaz.SelectedValue.ToString());
            /* using (var db = new MSDomEntities())
             {
                 var listaLijekova = from nalaz in db.lijekoviZaDijagnozus
                                    where (nalaz.nalazId == idNalaz)
                                    select new { nalaz.id, nalaz.lijekId, nalaz.nalazId };

                 uiOutputPrikazLijekovaINalaza.DataSource = listaLijekova.ToList();*/
            using (var db = new MSDomEntities())
            {
                var listaLijeka = from lij in db.lijeks
                                  join od in db.lijekoviZaDijagnozus
                                  on lij.id equals od.lijekId
                                  join nal in db.nalazs
                                  on od.nalazId equals nal.id
                                  where(od.nalazId==idNalaz)
                                  select new {od.id, lij.naziv,nal.dijagnoza };
                uiOutputPrikazLijekovaINalaza.DataSource = listaLijeka.ToList();
            }


        }
        
        
        private void uiInputNalaz_SelectedIndexChanged(object sender, EventArgs e)
        {
            DohvatiLijekoveZaDijagnozu();
        }
    }
}
