using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisakZaposlenih.cs
{
    public class Radnici
    {
        public IList<> listaZaposlenih { get; }

        public StorageKorisnik()
        {
            Korisnici = new List<Korisnik>() {
                new Korisnik { KorisnickoIme = "k1", KorisnickaSifra = "k1", Ime = "Pera", Prezime = "Peric" },
                new Korisnik { KorisnickoIme = "k2", KorisnickaSifra = "k2", Ime = "Mika", Prezime = "Mikic" }
            };
        }
    }
}
