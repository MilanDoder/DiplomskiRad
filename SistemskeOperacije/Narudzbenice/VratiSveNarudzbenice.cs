using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Narudzbenice
{
    public class VratiSveNarudzbenice : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            List<IDomenskiObjekat> lista = Broker.Instanca.vratiSve(new Narudzbenica());

            List<Narudzbenica> listaNarudzbenica = lista.Cast<Narudzbenica>().ToList();

            foreach (Narudzbenica narz in listaNarudzbenica)
            {
                narz.Korisnik = (Clan)Broker.Instanca.vratiJedan(narz.Korisnik);
                narz.Korisnik.osoba = (Klasa.Osoba)Broker.Instanca.vratiJedan(narz.Korisnik.osoba);
            }

            return listaNarudzbenica;
        }

       
    }
}
