using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Proizvodi
{
    public class VratiProizvodjaca : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            try
            {
                Proizvodjac proizvodjac = (Proizvodjac)Broker.Instanca.vratiObjekat(new Proizvodjac(), objekat.ToString());
                return proizvodjac;                
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
