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
    public partial class frmAzuriranjeJelovnika : Form
    {
        public int idProsljedenogJelovnika = 0;
        public izbor jelovnikOdProsljedenogId = null;
        public frmAzuriranjeJelovnika(int id)
        {
            InitializeComponent();
            idProsljedenogJelovnika = id;
            DohvatiKategorije();
            DohvatiJelovnik();
        }
        private void DohvatiKategorije()
        {
            BindingList<izborKategorija> listaKategorija = null;
            using (var db=new MSDomEntities())
            {
                listaKategorija = new BindingList<izborKategorija>(db.izborKategorijas.ToList());
            }
            uiInputKategorija.DataSource = listaKategorija;
        }
        private void DohvatiJelovnik()
        {
            BindingList<izbor> listaIzbora = null;
            BindingList<izborKategorija> listaKategorija = null;
            using (var db=new MSDomEntities())
            {
                listaIzbora = new BindingList<izbor>(db.izbors.ToList());
                listaKategorija = new BindingList<izborKategorija>(db.izborKategorijas.ToList());         
            }
            foreach (var item in listaIzbora)
            {
                if (item.id == idProsljedenogJelovnika)
                {
                    jelovnikOdProsljedenogId = item;
                }
            }
            uiInputID.Text = jelovnikOdProsljedenogId.id.ToString();
            uiInputPredjelo.Text = jelovnikOdProsljedenogId.predjelo;
            uiInputPrilog.Text = jelovnikOdProsljedenogId.prilog;
            uiInputMeso.Text = jelovnikOdProsljedenogId.meso;
            uiInputDesert.Text = jelovnikOdProsljedenogId.desert;
            for(int i=0; i<listaKategorija.Count;i++)
            {
                if (listaKategorija[i].id == jelovnikOdProsljedenogId.kategorijaId)
                {
                    uiInputKategorija.SelectedIndex = i;
                }
            }
            
        }

        private void uiActionAzuriraj_Click(object sender, EventArgs e)
        {
            using (var db=new MSDomEntities())
            {
                db.izbors.Attach(jelovnikOdProsljedenogId);
                jelovnikOdProsljedenogId.id = int.Parse(uiInputID.Text);
                jelovnikOdProsljedenogId.predjelo = uiInputPredjelo.Text;
                jelovnikOdProsljedenogId.prilog = uiInputPrilog.Text;
                jelovnikOdProsljedenogId.meso = uiInputMeso.Text;
                jelovnikOdProsljedenogId.desert = uiInputDesert.Text;
                jelovnikOdProsljedenogId.kategorijaId = int.Parse(uiInputKategorija.SelectedValue.ToString());
                db.SaveChanges();
            }
            Close();
        }
    }
}
