using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Nalozi
{
    public class KreirajClana : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            int uspesno = Broker.Instanca.Sacuvaj((Clan)objekat);
            Clan clan = (Clan)objekat;

            //uspesno = Broker.Instanca.Sacuvaj((Klasa.Osoba)clan.osoba);
            if (uspesno == 1)
            {
                return true;
            }
            return false;
        }

 
    }
}
