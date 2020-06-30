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
                new Zaposleni { KorisnickoIme = "k1", KorisnickaSifra = "k1", Ime = "Pera", Prezime = "Peric" ,Image = "controlers1.jpg" },
                new Zaposleni { KorisnickoIme = "k2", KorisnickaSifra = "k2", Ime = "Mika", Prezime = "Mikic" ,Image = "controlers1.jpg"}
            };
            return listaZaposlenih;
        }


        public  Baza()
        {
            listaZaposlenih = new List<Zaposleni>() {
                new Zaposleni { KorisnickoIme = "k1", KorisnickaSifra = "k1", Ime = "Pera", Prezime = "Peric" ,Image = "controlers1.jpg" },
                new Zaposleni { KorisnickoIme = "k2", KorisnickaSifra = "k2", Ime = "Mika", Prezime = "Mikic" ,Image = "controlers1.jpg"}
            };
        }

    }
}
