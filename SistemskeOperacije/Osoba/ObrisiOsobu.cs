using BrokerBazePodataka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Osoba
{
    public class ObrisiOsobu : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            int uspesno = Broker.Instanca.Obrisi((Klasa.Osoba)objekat);
            if (uspesno == 1)
            {
                return true;
            }
            return false;
        }
    }
}
