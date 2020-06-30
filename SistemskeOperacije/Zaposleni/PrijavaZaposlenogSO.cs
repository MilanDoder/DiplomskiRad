using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Zaposleni
{
    public class PrijavaZaposlenogSO : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            Klasa.Zaposleni prijava = (Klasa.Zaposleni)objekat;
            List<Klasa.Zaposleni> lista = new List<Klasa.Zaposleni>();
            lista = (List<Klasa.Zaposleni>)BazaZaposlenih.Baza.Popuni();

            foreach (Klasa.Zaposleni z in lista)
            {
                if (z.KorisnickoIme == prijava.KorisnickoIme.Trim() && z.KorisnickaSifra == prijava.KorisnickaSifra.Trim())
                {
                    return z;
                }
            }
            return null;
        }

        
    }
}
