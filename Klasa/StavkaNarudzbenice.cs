using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa
{
    [Serializable]
    public class StavkaNarudzbenice : IDomenskiObjekat
    {
        [Browsable(false)]
        public Narudzbenica narudzbenica { get; set; }
        [Browsable(false)]
        public int RedniBroj { get; set; }
        [DisplayName("Proizvod")]
        public GamingProizvod proizvod { get; set; }
        [DisplayName("Kolicina")]
        public int Kolicina { get; set; }
        

        public string vratiNazivTabele()
        {
            return "StavkaNarudzbenice";
        }

        public string vratiVrednostZaInsert()
        {
            return $"'{this.narudzbenica.SifraNarudzbenice}','{this.RedniBroj}' ,'{this.Kolicina}', '{this.proizvod.proizvodID}'";
        }

        public string vratiVrednostZaUpdate()
        {
            return $"Kolicina = '{this.Kolicina}', Proizvod = '{this.proizvod.proizvodID}' ";
        }

        public string vratiUslov()
        {
            return $"ID = '{this.narudzbenica.SifraNarudzbenice}' AND RedniBroj = '{this.RedniBroj}'";
        }

        public string vratiUslovZaPretragu(string kriterijum)
        {
            throw new NotImplementedException();
        }

        public string vratiAtributID()
        {
            return "ID";
        }

        public void postaviPocetnuVrednost()
        {
            throw new NotImplementedException();
        }

        public string vratiUslovZaPronalazenjeObjekata(string trazeni)
        {
            return $"ID = '{trazeni}'";
        }

        public void povecajVrednost(object vrednost)
        {
            throw new NotImplementedException();
        }

        public IDomenskiObjekat kreirajObjekat(SqlDataReader citac)
        {
            throw new NotImplementedException();
        }

        public List<IDomenskiObjekat> vratiListu(SqlDataReader komanda)
        {
            List<IDomenskiObjekat> _lista = new List<IDomenskiObjekat>();

            while (komanda.Read()) {
                StavkaNarudzbenice sn = new StavkaNarudzbenice
                {
                    narudzbenica = new Narudzbenica {
                        SifraNarudzbenice = (int) komanda["ID"]

                    },
                    RedniBroj = (int) komanda["RedniBroj"],
                    Kolicina = (int) komanda["Kolicina"],
                    proizvod = new GamingProizvod {
                        proizvodID= (int) komanda["Proizvod"]
                    }

                };
                _lista.Add(sn);
            }


            return _lista;
        }

        public string vratiUslovPoNazivu()
        {
            throw new NotImplementedException();
        }
    }
}
