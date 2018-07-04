using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class Metode
    {
        public void DohvatiRezervirane()
        {
            using (var db = new MSDomEntities())
            {
                var idRezervacije = from rez in db.rezervacijaPraonices
                                    join praon in db.praonicas
                                    on rez.praonicaId equals praon.id
                                    select new { rez.id, praon.naziv, rez.datumVrijeme };                
            }
        }
    }
}
