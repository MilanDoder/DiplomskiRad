using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Proizvodi
{
    public class PretragaProizvoda : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            List<IDomenskiObjekat> proizvodi = Broker.Instanca.pretrazi(new GamingProizvod(), objekat.ToString());
            List<GamingProizvod> listaProizvoda = proizvodi.Cast<GamingProizvod>().ToList();

            foreach (GamingProizvod proizvod in listaProizvoda)
            {
                proizvod.proizvodjac = (Proizvodjac)Broker.Instanca.vratiJedan(proizvod.proizvodjac);
            }

            return listaProizvoda;
        }
    }
}
