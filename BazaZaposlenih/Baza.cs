using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaZaposlenih
{
    public class Baza
    {
        public static List<Zaposleni> listaZaposlenih { get; set; }

        public static List<Zaposleni> Popuni() {
            listaZaposlenih = new List<Zaposleni>() {
                new Zaposleni { KorisnickoIme = "k1", Sifra = "k1" },
                new Zaposleni { KorisnickoIme = "k2", Sifra = "k2"}
            };
            return listaZaposlenih;
        }


        public  Baza()
        {
            listaZaposlenih = new List<Zaposleni>() {
                new Zaposleni { KorisnickoIme = "k1", Sifra = "k1" },
                new Zaposleni { KorisnickoIme = "k2", Sifra = "k2"}
            };
        }

    }
}
