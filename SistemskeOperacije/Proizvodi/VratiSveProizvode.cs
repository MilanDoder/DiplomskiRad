using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Proizvodi
{
    public class VratiSveProizvode : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            List<IDomenskiObjekat> listaDomenskihObjekata = Broker.Instanca.vratiSve(new GamingProizvod());

            List<GamingProizvod> proizvodi = listaDomenskihObjekata.Cast<GamingProizvod>().ToList();

            foreach (GamingProizvod proizvod in proizvodi)
            {

                proizvod.proizvodjac = (Proizvodjac)Broker.Instanca.vratiJedan(proizvod.proizvodjac);
            }


            return proizvodi;
        }

        
    }
}
