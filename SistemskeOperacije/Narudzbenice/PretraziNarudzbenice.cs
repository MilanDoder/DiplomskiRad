using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Narudzbenice
{
    public class PretraziNarudzbenice : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {

            List<IDomenskiObjekat> narudzbenice = Broker.Instanca.vratiSvePodUslovom(new Narudzbenica(), objekat.ToString());
            List<Narudzbenica> _listanarudzbenica = narudzbenice.Cast<Narudzbenica>().ToList();

            foreach (Narudzbenica narudz in _listanarudzbenica)
            {
                narudz.Korisnik = (Clan)Broker.Instanca.vratiJedan(narudz.Korisnik);
            }


            return _listanarudzbenica;
        }
    }
}
