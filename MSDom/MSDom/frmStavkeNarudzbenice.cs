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
    public partial class frmStavkeNarudzbenice : Form
    {
        int brojStavkiNarudzbenice;
        int id;
        public frmStavkeNarudzbenice(int ID)
        {
            InitializeComponent();
            id = ID;
            DohvatiLijekove();
            DohvatiStavkeNarudzbenice();
        }

        private void uiActionDodaj_Click(object sender, EventArgs e)
        {
            int? idLijeka = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (idLijeka!=null && uiInputKolicina.Text!="")
            {
                using (var db = new MSDomEntities())
                {
                    stavkeNarudzbenice novaStavka = new stavkeNarudzbenice
                    {
                        kolicina = int.Parse(uiInputKolicina.Text),
                        lijekId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
                        narudzbenicaId = id,
                        id = brojStavkiNarudzbenice
                    };

                    db.stavkeNarudzbenices.Add(novaStavka);
                    db.SaveChanges();
                    DohvatiStavkeNarudzbenice();
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali lijek ili niste unijeli količinu!!");
            }
            
            
            
        }

        public void DohvatiLijekove()
        {
            BindingList<lijek> listaLijekica = null;

            using (var db = new MSDomEntities())
            {

                listaLijekica = new BindingList<lijek>(db.lijeks.ToList());

                var listica = listaLijekica.OrderBy(x => x.id).ToList();
                lijekBindingSource.DataSource = listica;

            }
        }

        public void DohvatiStavkeNarudzbenice()
        {
            

            using (var db = new MSDomEntities())
            {

                var listaStavkiNarudzbenica = from nar in db.narudzbenicas
                                        join stav in db.stavkeNarudzbenices
                                        on nar.id equals stav.narudzbenicaId
                                        join lij in db.lijeks
                                        on stav.lijekId equals lij.id
                                        where nar.id == id
                                        select new { stav.id, lij.naziv, stav.kolicina};

                var listica = listaStavkiNarudzbenica.OrderBy(x => x.id).ToList();
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = listica;
                var listaSvihStavki = from nar in db.narudzbenicas
                                      join stav in db.stavkeNarudzbenices
                                      on nar.id equals stav.narudzbenicaId
                                      join lij in db.lijeks
                                      on stav.lijekId equals lij.id
                                      select new { stav.id, lij.naziv, stav.kolicina };
                var listicaSvih = listaSvihStavki.OrderBy(x => x.id).ToList();
                if (listicaSvih.ToArray().Length==0)
                {
                    brojStavkiNarudzbenice = 0;
                }
                else
                {
                    brojStavkiNarudzbenice = listicaSvih[listicaSvih.ToArray().Length - 1].id + 1;
                }
                
            
            }
        }

        private void uiActionAzuriraj_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow!=null)
            {
                int idStavke = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                int kolicina = int.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString());
                string naziv = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                frmAzuriranjeStavkeNarudzbenice forma = new frmAzuriranjeStavkeNarudzbenice(idStavke, kolicina, naziv);
                forma.ShowDialog();
                DohvatiStavkeNarudzbenice();
            }
            
        }

        private void uiActionObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow!=null)
            {
                int oznaceni = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                using (var db = new MSDomEntities())
                {
                    var ids = oznaceni;
                    var sql = "Delete from [StavkeNarudzbenice] WHERE id = {0}";
                    db.Database.ExecuteSqlCommand(sql, ids);

                }
                DohvatiStavkeNarudzbenice();
            }
            
        }
    }
}
