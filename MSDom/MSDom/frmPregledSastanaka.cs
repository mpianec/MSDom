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

        public void DohvatiSastanke()
        {
            BindingList<sastanakSDoktorom> listaSastanaka = null;
            using (var db = new MSDomEntities())
            {
                listaSastanaka = new BindingList<sastanakSDoktorom>(db.sastanakSDoktoroms.ToList());
                sastanakSDoktoromBindingSource.DataSource = listaSastanaka.ToList();
            }
        }

        private void uiActionObrisi_Click(object sender, EventArgs e)
        {
            sastanakSDoktorom sastanak = sastanakSDoktoromBindingSource.Current as sastanakSDoktorom;
            if (sastanak!=null)
            {
                using (var db = new MSDomEntities())
                {
                    db.sastanakSDoktoroms.Attach(sastanak);
                    db.sastanakSDoktoroms.Remove(sastanak);
                    db.SaveChanges();
                }
            } 
            DohvatiSastanke();
        }
    }
}
