using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Narudzbenice
{
    public class PromeniNarudzbenicu : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            int uspesno;
            Narudzbenica nar = (Narudzbenica)objekat;


            uspesno = Broker.Instanca.Promeni(nar);

            foreach (StavkaNarudzbenice sn in nar.stavke) {
                uspesno = Broker.Instanca.Promeni(sn);
            }

            if (uspesno == 1) {
                return true;
            }
            return false;
            
        }

    }
}
