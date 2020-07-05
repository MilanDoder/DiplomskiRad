using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Osoba
{
    public class KreirajOsobu : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            try
            {
                int i = 1;
                Klasa.Osoba os = (Klasa.Osoba)objekat;
                os.OsobaId = Broker.Instanca.najveciID(os) + 1;

                int uspesno = Broker.Instanca.Sacuvaj(os);

                Clan c = new Clan
                {
                    ClanskiBroj = new Random().Next(0, 99999999),
                    osoba = os,
                };

                uspesno = Broker.Instanca.Sacuvaj((Clan)c);



                if (uspesno == 1)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
