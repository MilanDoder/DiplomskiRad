using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrokerBazePodataka;

namespace SistemskeOperacije
{
    public abstract class SistemskeOperacijeOpsta
    {
        private object _rezultatOperacije;
        private string _kriterijum;

        public object IzvrsiSO(object objekat) {
            try
            {
                Broker.Instanca.otvoriKonekciju();
                Broker.Instanca.pokreniTransakciju();
                _rezultatOperacije = IzvrsiKonkrentuSO(objekat);
                Broker.Instanca.potvrdiTransakciju();
                return _rezultatOperacije;
            }
            catch (Exception ex)
            {
                Broker.Instanca.ponistiTransakciju();
            }
            finally {
                Broker.Instanca.zatvoriKonekciju();
            }
            return null;

        }


        

        protected abstract object IzvrsiKonkrentuSO(object objekat);
       // protected abstract object IzvrsiKonkretnuSOPretrage(object objekat, string kriterijum);
        
        
    }
}
