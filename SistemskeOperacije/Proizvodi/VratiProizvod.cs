using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Proizvodi
{
    public class VratiProizvod : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            GamingProizvod n = (GamingProizvod)Broker.Instanca.vratiObjekat(new GamingProizvod(), objekat.ToString());

            //n.proizvodjac =  Broker.Instanca.pronadjiIVratiObjekat(new Proizvodjac(), object.)
            return n;
        }

        
    }
}
