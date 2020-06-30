using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Nalozi
{
    public class PretraziNaloge : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {

            List<IDomenskiObjekat> Nalozi = Broker.Instanca.vratiSvePodUslovom(new Nalog(), objekat.ToString());


            List<Nalog> listaNaloga = Nalozi.Cast<Nalog>().ToList();

            return listaNaloga;
        }

    }
}
