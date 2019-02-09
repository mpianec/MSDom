using IspisPdf;
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
    public partial class frmKreiranjeNarudzbenice : Form
    {
        int posljednjiId;
        int? idNarudzbenice ;
        public frmKreiranjeNarudzbenice()
        {
            InitializeComponent();
            DohvatiNarudzbenice();
        }

        public void DohvatiNarudzbenice()
        {
           
            using (var db = new MSDomEntities())
            {

                var listaNarudzbenica = from nar in db.narudzbenicas
                                    join kor in db.korisniks
                                    on nar.korisnikId equals kor.id
                                    select new { nar.id, kor.ime, kor.prezime, nar.datum };

                var listica = listaNarudzbenica.OrderBy(x => x.id).ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listica;
                posljednjiId = listica[listica.ToArray().Length-1].id+1;

            }
        }

        private void uiActionKreirajNarudzbenicu_Click(object sender, EventArgs e)
        {
            using (var db= new MSDomEntities())
            {
                narudzbenica n = new narudzbenica
                {
                    id = posljednjiId,
                    korisnikId = PrijavljeniKorisnik.id,
                    datum = DateTime.Now
                };
                db.narudzbenicas.Add(n);
                db.SaveChanges();
            }
            DohvatiNarudzbenice();
        }

        private void uiActionDodajStavke_Click(object sender, EventArgs e)
        {
            idNarudzbenice = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (idNarudzbenice!=null)
            {
                frmStavkeNarudzbenice forma = new frmStavkeNarudzbenice(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                forma.Show();
            }
            else
            {
                MessageBox.Show("Niste odabrali narudzbenicu!");
            }
        }

        private void uiActionObrisi_Click(object sender, EventArgs e)
        {
            
            bool zastavica = false;
            if (dataGridView1.CurrentRow != null)
            {
                int varijabla = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                using (var db = new MSDomEntities())
                {
                    var listaStavkiNarudzbenice = from nar in db.narudzbenicas
                                                  join stav in db.stavkeNarudzbenices
                                                  on nar.id equals stav.narudzbenicaId
                                                  where nar.id == varijabla
                                            select new { stav.id };

                    if (listaStavkiNarudzbenice.ToArray().Length>0)
                    {
                        zastavica = true;
                    }
                    
                }
                if (!zastavica)
                {
                    int oznaceni = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    using (var db = new MSDomEntities())
                    {
                        var ids = oznaceni;
                        var sql = "Delete from [narudzbenica] WHERE id = {0}";
                        db.Database.ExecuteSqlCommand(sql, ids);

                    }
                    DohvatiNarudzbenice();
                }
                else
                {
                    MessageBox.Show("Morate prvo obrisati stavke narudžbenice!");
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNarudzbenice forma = new frmNarudzbenice();
            forma.Show();
        }

        private void uiActionIspis_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {

                List<IspisPdf.StavkeNarudzbenice> listalijekova;
                int varijabla = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                using (var db = new MSDomEntities())
                {
                    var listaStavkiNarudzbenice = from nar in db.narudzbenicas
                                                  join stav in db.stavkeNarudzbenices
                                                  on nar.id equals stav.narudzbenicaId
                                                  join lij in db.lijeks
                                                  on stav.lijekId equals lij.id
                                                  where nar.id == varijabla
                                                  select new IspisPdf.StavkeNarudzbenice { Kolicina = stav.kolicina, Naziv = lij.naziv };

                    listalijekova = listaStavkiNarudzbenice.ToList();
                }

                if (Ispis.IspisNarudzbenice(varijabla, listalijekova) == true)
                {
                    Ispis.IspisNarudzbenice(varijabla, listalijekova);
                }
                else
                {
                    MessageBox.Show("PDF je već otvoren");
                }
            }
        }

        private void frmKreiranjeNarudzbenice_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmKreiranjeNarudzbenice_KeyDown);
            this.KeyDown -= new KeyEventHandler(frmKreiranjeNarudzbenice_KeyDown);
        }

        private void frmKreiranjeNarudzbenice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                frmF1KreiranjeNarudzbenice forma = new frmF1KreiranjeNarudzbenice();
                forma.ShowDialog();
            }
        }
    }
}
