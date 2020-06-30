using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klasa;

namespace Klasa
{
    [Serializable]
    public class Proizvodjac : IDomenskiObjekat
    {
        [Browsable(true)]
        public int ProizvodjacID { get; set; }
        [Browsable(true)]
        public string Naziv { get; set; }

        public string Telefon { get; set; }
        public string Adresa { get; set; }


        public override string ToString()
        {
            return Naziv;
        }
        public string vratiNazivTabele()
        {
            return "Proizvodjac";
        }
        public string vratiUslov()
        {
            return $"ID  = '{this.ProizvodjacID}'";
        }

        public string vratiUslovPoNazivu()
        {
            return $"Naziv = '{this.Naziv}'";
        }

        public string vratiVrednostZaInsert()
        {
            throw new NotImplementedException();
        }

        public List<IDomenskiObjekat> vratiListu(SqlDataReader citac)
        {
            List<IDomenskiObjekat> lista = new List<IDomenskiObjekat>();

            while (citac.Read()) {
                Proizvodjac p = new Proizvodjac
                {
                    ProizvodjacID = (int) citac["ID"],
                    Naziv = citac["Naziv"].ToString(),
                    Telefon = citac["BrojTelefona"].ToString(),
                    Adresa = citac["Adresa"].ToString()
                };

                lista.Add(p);  
            }
            return lista;
        }

       
       
        public string vratiVrednostZaUpdate()
        {
            throw new NotImplementedException();
        }

        public string vratiVrednostZaDelete()
        {
            throw new NotImplementedException();
        }

        public string vratiAtributPretrazivanja()
        {
            throw new NotImplementedException();
        }

        public void postaviPocetnuVrednost()
        {
            throw new NotImplementedException();
        }

        public void povecajVrednost(object vrednost)
        {
            throw new NotImplementedException();
        }

        public IDomenskiObjekat kreirajObjekat(SqlDataReader citac)
        {
            Proizvodjac p = new Proizvodjac();

            while (citac.Read())
            {
                p.ProizvodjacID = (int)citac["ID"];
                p.Telefon = citac["BrojTelefona"].ToString();
                p.Naziv = citac["Naziv"].ToString();
                p.Adresa = citac["Adresa"].ToString();
            };


            return p;
        }

        public string vratiUslovZaPronalazenjeObjekata(string trazeni)
        {
            return $"ID  = '{trazeni}'";
        }

        public string vratiUslovZaPretragu(string kriterijum)
        {
            return $"Naziv LIKE %'{kriterijum}'%";
        }

        public string vratiAtributID()
        {
            return "ID";
        }
    }
}
