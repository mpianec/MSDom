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
    public partial class frmRezervacijaPraonice : Form
    {
        public frmRezervacijaPraonice()
        {
            InitializeComponent();
            DohvatiSlobodnePraonice();
        }
        public void DohvatiSlobodnePraonice()
        {
            using (var db = new MSDomEntities())
            {
                var listaSlobodnihPraonica = from praon in db.praonicas
                                            where (praon.zauzeto == 0)
                                            select new { praon.id, praon.naziv};

                uiOutputSlobodnePraonice.DataSource = listaSlobodnihPraonica.ToList();
            }
        }
    }
}
