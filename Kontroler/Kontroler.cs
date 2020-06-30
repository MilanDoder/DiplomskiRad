using BazaZaposlenih;
using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Security.Cryptography;
using SistemskeOperacije;
using SistemskeOperacije.Zaposleni;
using SistemskeOperacije.Nalozi;
using SistemskeOperacije.Proizvodi;
using SistemskeOperacije.Narudzbenice;

namespace Kontroler
{

    public class Kontroler
    {
        
        public Zaposleni Zaposleni { get; set; }
        public GamingProizvod GamingProizvod { get; set; }

        private static Kontroler _instanca;
        private Baza storageKorisnik;

        public static Kontroler Instanca {
            get {
                if (_instanca == null) {
                    _instanca = new Kontroler();

                }
                return _instanca;
            }

        }
        private Kontroler()
        {
            storageKorisnik = new Baza();
        }

        /// Sistemske operacije
        /// 

        public SistemskeOperacijeOpsta vratiSistemskuOperaciju(Operacija operacija) {
            switch (operacija) {
                case Operacija.Login:
                    return new PrijavaZaposlenogSO();

          
                    //NALOG
                case Operacija.UbaciNalog:
                    return new KreirajNalog();
                case Operacija.PromeniNalog:
                    return new PromeniNalog();
                case Operacija.ObrisiNalog:
                    return new ObrisiNalog();
                case Operacija.VratiSveNaloge:
                    return new VratiSveNaloge();
                case Operacija.VratiNalog:
                    return new VratiNalog();
                case Operacija.PretraziNalog:
                    return new PretraziNaloge();
                
                    //PROIZVOD
                case Operacija.KreirajProizvod:
                    return new KreirajProizvod();
                case Operacija.PromeniProizvod:
                    return new PromeniProizvod();
                case Operacija.IzbrisiProizvod:
                    return new ObrisiProizvod();
                case Operacija.VratiSveProizvode:
                    return new VratiSveProizvode();
                case Operacija.VratiProizvod:
                    return new VratiProizvod();
                case Operacija.PretraziProizvod:
                    return new PretragaProizvoda();
                case Operacija.VratiProizvodjaca:
                    return new VratiProizvodjaca();

                //NARUDZBENICA
                case Operacija.UbaciNarudzbinu:
                    return new KreirajNarudzbenicu();
                case Operacija.PromeniNarudzbinu:
                    return new PromeniNarudzbenicu();
                case Operacija.IzbrisiNarudzbinu:
                    return new ObrisiNarudzbenicu();
                case Operacija.VratiSveNarudzbine:
                    return new VratiSveNarudzbenice();
                case Operacija.VratiNarudzbinu:
                    return new VratiNarudzbenicu();
                case Operacija.PretraziNarudzbinu:
                    return new PretraziNarudzbenice();
                case Operacija.vratiStavke:
                    return new VratiStavke();
            }
            throw new Exception("Greska prilikom izvrsavanje sistemske operacije!");

        }



        /**Izmenjen Kontroler***/
        public object vratiProizvodjace()
        {
            try
            {
                Broker.Instanca.otvoriKonekciju();
                List<IDomenskiObjekat> proizvodjaci = Broker.Instanca.vratiSve(new Proizvodjac());
                return proizvodjaci.Cast<Proizvodjac>().ToList();
            }
            finally
            {
                Broker.Instanca.zatvoriKonekciju();
            }
        }



        ///IZBRISATI NAKON STO SREDIMO SISTEMSKE OPERACIJE

        //NALOG
        

    }
}
