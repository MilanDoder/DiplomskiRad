using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrokerBazePodataka;
using Klasa;

namespace SistemskeOperacije.Zaposleni
{
    public class PrijavaZaposlenogSO : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            //Klasa.Zaposleni n = (Klasa.Zaposleni)Broker.Instanca.vratiObjekatSaLoginForme(new Klasa.Zaposleni());
            Klasa.Zaposleni prijava = (Klasa.Zaposleni)objekat;


            
            List<IDomenskiObjekat> listaDomenskihObjekata =  Broker.Instanca.vratiSve(new Klasa.Zaposleni());
            List<Klasa.Zaposleni> zaposleni = listaDomenskihObjekata.Cast<Klasa.Zaposleni>().ToList();

            foreach (Klasa.Zaposleni zaposlen in zaposleni)
            {
                zaposlen.osoba = (Klasa.Osoba)Broker.Instanca.vratiJedan(zaposlen.osoba);
            }


            foreach (Klasa.Zaposleni z in listaDomenskihObjekata)
            {
                if (z.KorisnickoIme == prijava.KorisnickoIme.Trim() && z.Sifra == prijava.Sifra.Trim())
                {
                    return z;
                }
            }
            return null;
        }

        
    }
}
