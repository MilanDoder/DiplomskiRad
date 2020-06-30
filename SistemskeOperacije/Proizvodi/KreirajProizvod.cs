using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Proizvodi
{
    public class KreirajProizvod : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            GamingProizvod proizvod = (GamingProizvod)objekat;
            proizvod.proizvodID = Broker.Instanca.najveciID(proizvod) +1;
            proizvod.proizvodjac = (Proizvodjac)Broker.Instanca.vratiJedan(proizvod.proizvodjac);

            int uspesno = Broker.Instanca.Sacuvaj(proizvod);
            if (uspesno == 1)
            {
                return true;
            }
            return false;
        }

       
    }
}
