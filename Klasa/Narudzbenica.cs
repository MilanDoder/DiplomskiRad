using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa
{
    [Serializable]
    public class Narudzbenica : IDomenskiObjekat
    {

        public int SifraNarudzbenice { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public double UkupanIznos { get; set; }
        public Clan Korisnik { get; set; }
        public List<StavkaNarudzbenice> stavke { get; set; }


        public IDomenskiObjekat kreirajObjekat(SqlDataReader citac)
        {
            Narudzbenica n = new Narudzbenica();
            while (citac.Read()) {
                n.DatumDo = Convert.ToDateTime(citac["DatumDo"]);
                n.DatumOd = Convert.ToDateTime(citac["DatumOd"]);
                n.SifraNarudzbenice = (int)citac["SifraNarudzbenice"];
                n.UkupanIznos = Convert.ToInt64(citac["UkupanIznos"]);
                n.Korisnik = new Clan {
                    ClanskiBroj = (int)citac["SifraClana"]
                };
                n.stavke = new List<StavkaNarudzbenice>();

            }

            return n;
        }

        public void postaviPocetnuVrednost()
        {
            this.SifraNarudzbenice = 1;
        }

        public void povecajVrednost(object vrednost)
        {
            this.SifraNarudzbenice = (int)vrednost +1 ;
        }

       
        

        public List<IDomenskiObjekat> vratiListu(SqlDataReader komanda)
        {
            List<IDomenskiObjekat> _lista = new List<IDomenskiObjekat>();
            while (komanda.Read()) {
                Narudzbenica n = new Narudzbenica
                {
                    SifraNarudzbenice = (int) komanda["SifraNarudzbenice"],
                    DatumDo =  (DateTime)komanda["DatumDo"],
                    DatumOd = (DateTime)komanda["DatumOd"],
                    UkupanIznos = Convert.ToInt64( komanda["UkupanIznos"]),
                    Korisnik = new Clan {
                        ClanskiBroj = (int) komanda["SifraClana"]
                    } ,
                };
                _lista.Add(n);
            }
            return _lista;
        }

        public override string ToString()
        {
            return SifraNarudzbenice.ToString();
        }

        public string vratiNazivTabele()
        {
            return "Narudzbenica";
        }

        public string vratiUslov()
        {
            return $"SifraNarudzbenice = '{this.SifraNarudzbenice}'";
        }

        public string vratiVrednostZaInsert()
        {
            return $"'{this.DatumOd}', '{this.DatumDo}', '{this.UkupanIznos}', '{this.Korisnik.ClanskiBroj}'";
        }

        public string vratiVrednostZaUpdate()
        {
            return $"DatumOd ='{this.DatumOd}', DatumDo = '{this.DatumDo}', UkupanIznos = '{this.UkupanIznos}' ";
        }

        public string vratiUslovZaPretragu(string kriterijum)
        {
            return $"SifraNarudzbenice LIKE '%{kriterijum}%' OR DatumOd LIKE '%{kriterijum}%' OR UkupanIznos LIKE '%{kriterijum}%'";
        }

        public string vratiAtributID()
        {
            return "SifraNarudzbenica";
        }

        public string vratiUslovPoNazivu()
        {
            //TO DO
            //SifraClana LIKE '%{this.Korisnik.ImePrezime}%' OR 
            return $"SifraClana LIKE '%{this.Korisnik.ClanskiBroj}%' ";
        }

        public string vratiUslovZaPronalazenjeObjekata(string trazeni)
        {
            return $"SifraNarudzbenice LIKE '%{trazeni}%' OR DatumOd LIKE '%{trazeni}%' OR UkupanIznos LIKE '%{trazeni}%'";
        }

        public string vratiUslovZaUspesanLogin(string korisnik, string sifra)
        {
            throw new NotImplementedException();
        }

        public string vratiNazivTabele(string kriterijum)
        {
            return "Narudzbenica";
        }
    }
}
