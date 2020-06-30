using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Nalozi
{
    public class PromeniNalog : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            int uspesno = Broker.Instanca.Promeni((Nalog) objekat);
            if (uspesno == 1)
            {
                return true;
            }
            return false;
        }

       
    }
}
