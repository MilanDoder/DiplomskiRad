using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Narudzbenice
{
    public class VratiNarudzbenicu : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            Narudzbenica nar = (Narudzbenica)Broker.Instanca.vratiObjekat(new Narudzbenica(), objekat.ToString());

            List<IDomenskiObjekat> _lista = Broker.Instanca.vratiSvePodUslovom(new StavkaNarudzbenice(), nar.SifraNarudzbenice.ToString());
            nar.stavke = _lista.Cast<StavkaNarudzbenice>().ToList();

            foreach (StavkaNarudzbenice sn in nar.stavke)
            {
                sn.proizvod = (GamingProizvod)Broker.Instanca.vratiObjekat(new GamingProizvod(), sn.proizvod.proizvodID.ToString());
            }
            return nar;
        }

        
    }
}
