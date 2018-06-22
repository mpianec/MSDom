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
    public partial class frmPrikazNarudzbi : Form
    {
        public frmPrikazNarudzbi()
        {
            InitializeComponent();
            DohvatiDorucke();
            DohvatiRucak();
            DohvatiVecere();
        }
        private int PrebrojIzbore(int id)
        {
            DateTime datum = DateTime.Today;
            int brojac = 0;
            using (var db=new MSDomEntities())
            {
                BindingList<vasIzborDana> lista = new BindingList<vasIzborDana>(db.vasIzborDanas.ToList());
                foreach (var item in lista)
                {
                    if (item.izborId == id && item.datum==datum)
                    {
                        brojac++;
                    }
                }
            }
            return brojac;
        }
        private void Ispislabel(List<int?> listaId, int vrsta)
        {
            string prvi = "";
            string drugi = "";
            string treci = "";
            BindingList<izbor> sviIJelovnici = null;
            using (var db=new MSDomEntities())
            {
                 sviIJelovnici = new BindingList<izbor>(db.izbors.ToList());
            }
            
            foreach (var item in sviIJelovnici)
            {
                if (item.id == listaId[0])
                {
                    prvi = "ID: " + item.id + ", Predjelo: " + item.predjelo + ", Prilog: " + item.prilog + ", Meso: " + item.meso + ", Desert: " + item.desert + ", Broj porcija:" + PrebrojIzbore(item.id).ToString();
                }
                if (item.id == listaId[1])
                {
                    drugi = "ID: " + item.id + ", Predjelo: " + item.predjelo + ", Prilog: " + item.prilog + ", Meso: " + item.meso + ", Desert: " + item.desert + ", Broj porcija:" + PrebrojIzbore(item.id).ToString();
                }
                if (item.id == listaId[2])
                {
                    treci = "ID: " + item.id + ", Predjelo: " + item.predjelo + ", Prilog: " + item.prilog + ", Meso: " + item.meso + ", Desert: " + item.desert + ", Broj porcija:" + PrebrojIzbore(item.id).ToString();
                }
            }
            switch (vrsta)
            {
                case 1:
                    label1.Text = prvi;
                    label2.Text = drugi;
                    label3.Text = treci;
                    break;
                case 2:
                    label4.Text = prvi;
                    label5.Text = drugi;
                    label6.Text = treci;
                    break;
                case 3:
                    label7.Text = prvi;
                    label8.Text = drugi;
                    label9.Text = treci;
                    break;
            }
        }
        private void DohvatiDorucke()
        {
            
            using (var db= new MSDomEntities())
            {
                var idDoruckova = from dor in db.izbors
                                where (dor.kategorijaId == 1 && dor.aktivanIzbor == 1)
                                select dor.id;
                List<int?> listaId = new List<int?>();
               
                foreach (var item in idDoruckova.ToList())
                {
                    listaId.Add(item);
                    
                }
                Ispislabel(listaId, 1);

            }
            
        }
        private void DohvatiRucak()
        {
            using (var db = new MSDomEntities())
            {
                var idDoruckova = from dor in db.izbors
                                  where (dor.kategorijaId == 2 && dor.aktivanIzbor == 1)
                                  select dor.id;
                List<int?> listaId = new List<int?>();

                foreach (var item in idDoruckova.ToList())
                {
                    listaId.Add(item);

                }
                Ispislabel(listaId, 2);

            }
        }
        private void DohvatiVecere()
        {
            using (var db = new MSDomEntities())
            {
                var idDoruckova = from dor in db.izbors
                                  where (dor.kategorijaId == 3 && dor.aktivanIzbor == 1)
                                  select dor.id;
                List<int?> listaId = new List<int?>();

                foreach (var item in idDoruckova.ToList())
                {
                    listaId.Add(item);

                }
                Ispislabel(listaId, 3);

            }
        }
    }
}
