using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Narudzbenice
{
    public class VratiStavke : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            try
            {
                List<IDomenskiObjekat> stavke =Broker.Instanca.vratiSvePodUslovom(new StavkaNarudzbenice(), objekat.ToString());

                List<StavkaNarudzbenice> lista = stavke.Cast<StavkaNarudzbenice>().ToList();

                foreach (StavkaNarudzbenice st in lista)
                {
                    st.proizvod = (GamingProizvod) Broker.Instanca.vratiJedan(st.proizvod);
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
