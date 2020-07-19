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
    public class Zaposleni : IDomenskiObjekat
    {
        public int ID { get; set; }
        [Browsable(false)]
         public string KorisnickoIme { get; set; }
         [Browsable(false)]
         public string Sifra { get; set; }            

         public Osoba osoba { get; set; }


        public IDomenskiObjekat kreirajObjekat(SqlDataReader citac)
        {
            Zaposleni z = new Zaposleni();
            while (citac.Read())
            {
                z.ID = (int)citac["ID"];
                z.KorisnickoIme = citac["KorisnickoIme"].ToString();
                z.Sifra = citac["Sifra"].ToString();
                z.osoba = new Osoba
                {
                    OsobaId = (int)citac["ID"],
                };
            }
            return z;
        }

        public string vratiAtributID()
        {
            return "ID";
        }

        public List<IDomenskiObjekat> vratiListu(SqlDataReader citac)
        {
            List<IDomenskiObjekat> lista = new List<IDomenskiObjekat>();

            while (citac.Read())
            {
                Zaposleni p = new Zaposleni
                {
                    ID = (int)citac["ID"],
                    KorisnickoIme = citac["KorisnickoIme"].ToString(),
                    Sifra = citac["Sifra"].ToString(),
                    osoba =  new Osoba { 
                        OsobaId = (int)citac["ID"]
                    }
                };

                lista.Add(p);
            }
            return lista;
        }

        public string vratiNazivTabele()
        {
            return "Zaposleni";
        }

        public string vratiNazivTabele(string kriterijum)
        {
            return "Zaposleni";
        }

        public string vratiUslov()
        {
            return $"ID = {this.ID}";
        }

        public string vratiUslovPoNazivu()
        {
            return "";
        }

        public string vratiUslovZaPretragu(string kriterijum)
        {
            throw new NotImplementedException();
        }

        public string vratiUslovZaPronalazenjeObjekata(string trazeni)
        {
            return "";
        }

        public string vratiUslovZaUspesanLogin(string korisnickoIme, string sifra) {
            return $"KorisnickoIme = '{korisnickoIme}' AND Sifra = '%{sifra}%'";
        }

        public string vratiVrednostZaInsert()
        {
            throw new NotImplementedException();
        }

        public string vratiVrednostZaUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
