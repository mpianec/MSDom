using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class Metode
    {

        public IEnumerable<object> DohvatiRezervirane1()
        {
            List<object> lista = new List<object>();
            var db = new MSDomEntities();
            
            IEnumerable<object> idRezervacije = from rez in db.rezervacijaPraonice
                                        join praon in db.praonica
                                        on rez.praonicaId equals praon.id
                                        select new { rez.id, praon.naziv, rez.datumVrijeme };
            lista = new List<object>(idRezervacije);
            
            return lista;
        }
    }
}