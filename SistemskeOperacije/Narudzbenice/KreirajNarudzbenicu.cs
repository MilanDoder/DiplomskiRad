using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Narudzbenice
{
    public class KreirajNarudzbenicu : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            try
            {
                int i = 1;
                int uspesno = Broker.Instanca.Sacuvaj((Narudzbenica)objekat);
                Narudzbenica nar = (Narudzbenica)objekat;

                foreach (var stavka in nar.stavke)
                {
                    stavka.narudzbenica = (Narudzbenica)Broker.Instanca.vratiObjekat(new Narudzbenica(), nar.SifraNarudzbenice.ToString());
                    stavka.RedniBroj = i;

                    GamingProizvod proizvod = (GamingProizvod)Broker.Instanca.vratiJedan(stavka.proizvod);

                    if (proizvod.raspolozivoStanje - stavka.Kolicina < 0)
                        throw new Exception("Nedovoljno na stanju!");

                    proizvod.raspolozivoStanje -= stavka.Kolicina;

                    Debug.WriteLine(proizvod.raspolozivoStanje + "\t " + proizvod.Naziv);
                    uspesno = Broker.Instanca.Promeni(proizvod);

                    uspesno = Broker.Instanca.Sacuvaj(stavka);
                    i++;
                }


                if (uspesno == 1)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex )
            {

                throw;
            }
        }

        
    }
}
