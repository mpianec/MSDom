using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class Prijava
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public Prijava()
        {

        }

        public bool UneseneVrijednosti(string korIme, string lozinka)
        {
            if (korIme == "")
            {
                return false;
                
            }
            else if (lozinka == "")
            {
                return false;
            }
            return true;
        }


    }
}
