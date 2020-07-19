using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Nalozi
{
    public class VratiClana : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            Clan n = (Clan)Broker.Instanca.vratiObjekat(new Clan(), objekat.ToString());

            n.osoba = (Klasa.Osoba)Broker.Instanca.vratiObjekat(new Klasa.Osoba(), n.osoba.OsobaId.ToString());
            return n;

        }

       
    }
}
