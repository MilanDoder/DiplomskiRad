using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Nalozi
{
    public class VratiSveNaloge : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            List<IDomenskiObjekat> Nalozi = Broker.Instanca.vratiSve(new Nalog());


            List<Nalog> listaNaloga = Nalozi.Cast<Nalog>().ToList();

            return listaNaloga;
        }

        
    }
}
