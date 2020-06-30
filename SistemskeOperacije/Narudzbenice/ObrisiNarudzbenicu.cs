using BrokerBazePodataka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klasa;

namespace SistemskeOperacije.Narudzbenice
{
    public class ObrisiNarudzbenicu : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            int uspesno = 0;
            Narudzbenica narudzbenica = (Narudzbenica)objekat;
            foreach (var stavka in narudzbenica.stavke)
            {
                GamingProizvod proizvod = (GamingProizvod)Broker.Instanca.vratiJedan(stavka.proizvod);
                proizvod.raspolozivoStanje += stavka.Kolicina;


                uspesno =  Broker.Instanca.Promeni(proizvod);

                 Broker.Instanca.Obrisi(stavka);

            }
            int rest = Broker.Instanca.Obrisi(narudzbenica);
            if (rest == 1)
            {
                return true;
            }
            return false;
        }

    }
}
