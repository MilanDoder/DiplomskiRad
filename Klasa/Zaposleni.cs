using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa
{
    [Serializable]
    public class Zaposleni
    {
        
            [Browsable(false)]
            public string KorisnickoIme { get; set; }
            [Browsable(false)]
            public string KorisnickaSifra { get; set; }
            [DisplayName("Ime zaposlenog")]
            public string Ime { get; set; }
            [DisplayName("Prezime zaposlenog")]
            public string Prezime { get; set; }
            [Browsable(false)]
             public string Image { get; set; }
       
    }
}
