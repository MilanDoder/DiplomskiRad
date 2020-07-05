using Klasa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Forme
{
    public class Komunikacija
    {
        private static Komunikacija _instanca;
        private TcpClient klijent;
        private NetworkStream stream;
        private BinaryFormatter formater = new BinaryFormatter();

        public frm_glavna glavna { get; set; }

        public bool PokreniLogin { get; set; }


        public static Komunikacija Instanca{
            get{
                if (_instanca == null) {
                    _instanca = new Komunikacija();
                }
                return _instanca;
            }
        }


        private Komunikacija()
        {
            
        }


        public void poveziSeSaServerom() {

            try
            {
                klijent = new TcpClient("localhost", 10000);
                stream = this.klijent.GetStream();
            }
            catch (Exception ex)
            {

                throw new Exception( ex.Message);
            }

        }

        internal IList<Proizvodjac> vratiProizvodjace()
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiProizvodjace
            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return (List<Proizvodjac>)odgovor.Podaci;
            }
            else {
                throw new Exception(odgovor.Podaci.ToString());
            }

        }

        public IList<GamingProizvod> ucitajGamingProizvode() {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiSveProizvode,
            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return (IList<GamingProizvod>)odgovor.Podaci;
            }
            else {
                throw new Exception(odgovor.Podaci.ToString());
            }

        }

        //internal void Osluskuj(frm_glavna frm_glavna)
        //{
        //    glavna = frm_glavna;
        //    Thread nit = new Thread(Osluskivanje);
        //    nit.Start();
        //    nit.IsBackground = true;
        //}

        //private void Osluskivanje()
        //{
        //    try
        //    {
        //        bool kraj = false;

        //        while (!kraj)
        //        {
        //            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);

        //            switch (odgovor.Operacija)
        //            {

        //                case Operacija.Kraj_Servera:
        //                    glavna.Invoke(new Action(glavna.Close));
        //                    kraj = true;

        //                    break;


        //            }


        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        Debug.WriteLine("Greska pri osluskivanju poruka!");
        //    }
        //}

        internal bool kreirajOsobu(Osoba o)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.KreirajOsobu,
                Podaci = o
            };
            this.formater.Serialize(this.stream, zahtev);


            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return true;
            }
            else
            {
                throw new Exception(odgovor.Podaci.ToString());
            }
        }

        internal bool kreirajNalog(Clan n)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.UbaciNalog,
                Podaci = n
            };
            this.formater.Serialize(this.stream, zahtev);


            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);
            
            if (odgovor.Uspesnost)
            {
                return true;
            }
            else {
                throw new Exception(odgovor.Podaci.ToString());
            }
        }

        public bool kreirajProizvod(GamingProizvod g)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.KreirajProizvod,
                Podaci = g
            };
            
            this.formater.Serialize(this.stream, zahtev);
            
            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return (bool)odgovor.Podaci;
            }
            else {
                throw new Exception(odgovor.Podaci.ToString());
            }
        }

        public IList<Clan> vratiSveNaloge() {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiSveNaloge
            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return (IList<Clan>) odgovor.Podaci;
            }
            else {
                throw new Exception(odgovor.Podaci.ToString());
            }

        }

        public IList<GamingProizvod> vratiSveGamingProizvode()
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiSveProizvode
            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odg = (Odgovor)this.formater.Deserialize(this.stream);

            if (odg.Uspesnost)
            {
                return (IList<GamingProizvod>)odg.Podaci;
            }
            else {
                throw new Exception(odg.Podaci.ToString());
            }
        }

        internal bool ProveriStanje(Narudzbenica nar)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.Proveri_Stanje,
                Podaci = (Narudzbenica) nar
            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odgovor = this.formater.Deserialize(this.stream) as Odgovor;

            if (odgovor.Uspesnost)
            {
                return true;
            }
            else {
                throw new Exception("Ne dovoljno na stanju!");
            }
        }

        public Zaposleni PrijaviSe(string username, string password) {

            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.Login,
                Podaci = new Zaposleni
                {
                    KorisnickoIme = username,
                    Sifra = password
                }

            };
            this.formater.Serialize(this.stream, zahtev);

            
            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return (Zaposleni)odgovor.Podaci;
            }
            else {
                throw new Exception(odgovor.Podaci.ToString());
            }
            

        }

        internal IList<Narudzbenica> vratiSveNarudzbenice()
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiSveNarudzbine,

            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return (List<Narudzbenica>)odgovor.Podaci;
            }
            else {
                throw new Exception(odgovor.Podaci.ToString());
            }
        }

        internal bool SacuvajNarudzbenicu(Narudzbenica nar)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.UbaciNarudzbinu,
                Podaci = new Narudzbenica {
                    DatumDo = nar.DatumDo,
                    DatumOd = nar.DatumOd,
                    Korisnik = nar.Korisnik,
                    stavke = nar.stavke,
                    UkupanIznos = nar.UkupanIznos
                }

            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return (bool)odgovor.Podaci;
            }
            else {
                throw new Exception("Sistem ne može da kreira narudzbinu");
            }

        }

        internal void odjaviSe()
        {
            Zahtev zahtev = new Zahtev {
                Operacija = Operacija.Odjavi
            };
            formater.Serialize(this.stream, zahtev);

            _instanca = null;
        }

        public IList<Clan> pretragaNaloga(string kriterijum) {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.PretraziNalog,
                Podaci = kriterijum
                
            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return (IList<Clan>)odgovor.Podaci;
            }
            else {
                throw new Exception(odgovor.Podaci.ToString());
            }
        }

        internal bool ObrisOsobu(Osoba os)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.ObrisiOsobu,
                Podaci = os,

            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return (bool)odgovor.Podaci;
            }
            else
            {
                throw new Exception(odgovor.Podaci.ToString());
            }
        }

        internal IList<GamingProizvod> pretragaProizvoda(string kriterijum)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.PretraziProizvod,
                Podaci = kriterijum
            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odgovor = (Odgovor) this.formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return (IList<GamingProizvod>)odgovor.Podaci;
            }
            else {
                throw new Exception(odgovor.Podaci.ToString());
            }
        }

        public bool produziNalog(Clan n) {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.PromeniNalog,
                Podaci = n

            };
            this.formater.Serialize(this.stream,zahtev);

            Odgovor odgovor =  (Odgovor)formater.Deserialize(this.stream);

            if (odgovor.Uspesnost) {
                return (bool)odgovor.Podaci;
            }
            else{
                throw new Exception(odgovor.Podaci.ToString());
            }


        }

        public bool promeniOsobu(Osoba os)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.PromeniOsobu,
                Podaci = os

            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odgovor = (Odgovor)formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return (bool)odgovor.Podaci;
            }
            else
            {
                throw new Exception(odgovor.Podaci.ToString());
            }


        }

        internal IList<Narudzbenica> pretragaNarudzbenica(string text)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.PretraziNarudzbinu,
                Podaci = text
            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return (IList<Narudzbenica>)odgovor.Podaci;
            }
            else {
                throw new Exception(odgovor.Podaci.ToString());
            }
        }

        internal bool ObrisiNalog(Clan n)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.ObrisiNalog,
                Podaci = n
            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return (bool)odgovor.Podaci;
            }
            else {
                throw new Exception(odgovor.Podaci.ToString());
            }
        }

        internal bool promeniGamingProizvod(GamingProizvod g)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.PromeniProizvod,
                Podaci = g
            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odg = (Odgovor)this.formater.Deserialize(this.stream);

            if (odg.Uspesnost)
            {
                return (bool)odg.Podaci;
            }
            else {
                throw new Exception(odg.Podaci.ToString());
            }
        }

        internal bool obrisiGamingProizvod(GamingProizvod gp)
        {
            Zahtev zahtev = new Zahtev {
                Operacija = Operacija.IzbrisiProizvod,
                Podaci = gp
            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odg = (Odgovor)this.formater.Deserialize(this.stream);

            if (odg.Uspesnost)
            {
                return (bool)odg.Podaci;
            }
            else {
                throw new Exception(odg.Podaci.ToString());
            }

        }

        internal Clan vratiNalogPoUslovu(string v)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiNalog,
                Podaci = v
            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return (Clan)odgovor.Podaci;
            }
            else {
                throw new Exception(odgovor.Podaci.ToString());
            }
        }

        internal bool obrisiNarudzbenicu(Narudzbenica nar)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.IzbrisiNarudzbinu,
                Podaci = new Narudzbenica
                {
                    Korisnik = nar.Korisnik,
                    DatumDo = nar.DatumDo,
                    DatumOd = nar.DatumOd,
                    UkupanIznos = nar.UkupanIznos,
                    SifraNarudzbenice = nar.SifraNarudzbenice,
                    stavke = nar.stavke
                }
            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return true;
            }
            else {
                return false;
            }
        }

        internal GamingProizvod vratiProizvod(string ID)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiProizvod,
                Podaci = ID
            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return (GamingProizvod)odgovor.Podaci;
            }
            else {
                throw new Exception(odgovor.Podaci.ToString());
            }


        }

        internal Narudzbenica vratiNarudzbenicu(string v)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiNarudzbinu,
                Podaci = v
            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odgovor = (Odgovor)this.formater.Deserialize(this.stream);

            if (odgovor.Uspesnost)
            {
                return (Narudzbenica)odgovor.Podaci;
            }
            else {
                throw new Exception(odgovor.Podaci.ToString());
            }
        }

        internal bool azurirajNarudzbenicu(Narudzbenica n)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.PromeniNarudzbinu,
                Podaci = n
            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odg = (Odgovor)this.formater.Deserialize(this.stream);

            if (odg.Uspesnost) {
                return odg.Uspesnost;
;            } else {
                throw new Exception(odg.Podaci.ToString());
            }
        }

        internal void Kraj()
        {
            Zahtev zatev = new Zahtev()
            {
                Operacija = Operacija.Odjavi,

            };
            try
            {
                this.formater.Serialize(this.stream, zatev);
            }
            catch (Exception ex) { 
                
            }

        }

        internal List<StavkaNarudzbenice> vratiStavkeNarudzbenice(int sifraNarudzbenice)
        {
            Zahtev zahtev = new Zahtev
            {
                Podaci = sifraNarudzbenice,
                Operacija = Operacija.vratiStavke,
            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odg = this.formater.Deserialize(this.stream) as Odgovor;

            if (odg.Uspesnost) {
                return (List<StavkaNarudzbenice>)odg.Podaci;
            }
            else{
                throw new Exception(odg.Podaci.ToString());

            }

        }

        internal Proizvodjac vratiProizvodjaca(string v)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiProizvodjaca,
                Podaci =  v,

            };
            this.formater.Serialize(this.stream, zahtev);

            Odgovor odgovor = this.formater.Deserialize(this.stream) as Odgovor;

            if (odgovor.Uspesnost)
            {
                return (Proizvodjac)odgovor.Podaci;
            }
            else {
                throw new Exception(odgovor.Podaci.ToString());
            }

        }
    }
}
