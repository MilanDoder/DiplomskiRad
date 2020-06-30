using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Nalozi
{
    public class VratiNalog : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            Nalog n = (Nalog)Broker.Instanca.vratiObjekat(new Nalog(), objekat.ToString());
            return n;

        }

       
    }
}
