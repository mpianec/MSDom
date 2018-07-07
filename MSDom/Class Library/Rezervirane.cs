using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class Rezervirane
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumVrijeme { get; set; }

        public Rezervirane(int id,string naziv,DateTime datum)
        {
            ID = id;
            Naziv = naziv;
            DatumVrijeme = datum;
        }
    }
}
