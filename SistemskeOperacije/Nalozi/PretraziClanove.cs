using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Nalozi
{
    public class PretraziClanove : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {

            List<IDomenskiObjekat> Nalozi = Broker.Instanca.pretragaObjekta(new Clan(), objekat.ToString());


            List<Clan> listaNaloga = Nalozi.Cast<Clan>().ToList();

            foreach (Clan cl in listaNaloga)
            {

                cl.osoba = (Klasa.Osoba)Broker.Instanca.vratiJedan(cl.osoba);
            }

            return listaNaloga;
        }

    }
}
