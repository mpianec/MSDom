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
    public partial class frmPonistiRezervaciju : Form
    {
        public frmPonistiRezervaciju()
        {
            InitializeComponent();
            DohvatiRezervirane();
        }
        public void DohvatiRezervirane()
        {
            using (var db=new MSDomEntities())
            {
                var idRezervacije = from rez in db.rezervacijaPraonices
                                    join praon in db.praonicas
                                    on rez.praonicaId equals praon.id
                                    select new { rez.id, praon.naziv, rez.datumVrijeme };
                if(idRezervacije.ToList().Count>0)
                    uiOutputRezervacije.DataSource = idRezervacije.ToList();
                else
                    uiOutputRezervacije.DataSource = null;
            }
        }

        private void uiActionPonisti_Click(object sender, EventArgs e)
        {
            rezervacijaPraonice brisanjeRezervacije = null;
            praonica praonicaBrisanje = null;
            using (var db=new MSDomEntities())
            {
                var idOdabir = from od in db.rezervacijaPraonices
                               join praon in db.praonicas
                               on od.praonicaId equals praon.id
                               select od.id;
                if (idOdabir.ToList().Count > 0)
                {
                    int id = int.Parse(uiOutputRezervacije.CurrentRow.Cells[0].Value.ToString());
                    string naziv = uiOutputRezervacije.CurrentRow.Cells[1].Value.ToString();
                    BindingList<praonica> listaPraonica = new BindingList<praonica>(db.praonicas.ToList());
                    BindingList<rezervacijaPraonice> listaOdabira = new BindingList<rezervacijaPraonice>(db.rezervacijaPraonices.ToList());
                    foreach (var item in listaOdabira)
                    {
                        if (item.id == id)
                        {
                            brisanjeRezervacije = item;
                        }
                    }
                    foreach (var item in listaPraonica)
                    {
                        if (item.naziv == naziv)
                        {
                            praonicaBrisanje = item;
                        }
                    }
                    db.praonicas.Attach(praonicaBrisanje);
                    praonicaBrisanje.zauzeto = 0;
                    db.rezervacijaPraonices.Attach(brisanjeRezervacije);
                    db.rezervacijaPraonices.Remove(brisanjeRezervacije);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Ne možete brisati.");
                }
            }
            DohvatiRezervirane();
        }
    }
}
