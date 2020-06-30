using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Proizvodi
{
    public class PromeniProizvod : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            int uspesno = Broker.Instanca.Promeni((GamingProizvod) objekat);
            if (uspesno == 1)
            {
                return true;
            }
            return false;
        }

    }
}
