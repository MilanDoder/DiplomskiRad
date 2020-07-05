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
    public class Osoba : IDomenskiObjekat
    {

        [DisplayName("ID")]
        public int OsobaId { get; set; }
        [DisplayName("Ime")]
        public string Ime { get; set; }
        [DisplayName("Prezime")]
        public string Prezime { get; set; }
        [DisplayName("Telefon")]
        public string Telefon { get; set; }
        [DisplayName("Adresa")]
        public string Adresa { get; set; }

        public IDomenskiObjekat kreirajObjekat(SqlDataReader citac)
        {
            Osoba os = new Osoba();
            while (citac.Read())
            {
                os.OsobaId = Convert.ToInt32(citac["OsobaId"].ToString());
                os.Ime = citac["Ime"].ToString();
                os.Prezime = citac["Prezime"].ToString();
                os.Telefon = citac["KontaktTelefon"].ToString();
                os.Adresa = citac["Adresa"].ToString();
                /*osoba = new Osoba
                {
                    Ime = citac["Ime"].ToString(),
                    Prezime = citac["Prezime"].ToString(),
                    Adresa = citac["Adresa"].ToString(),
                    Telefon = citac["KontaktTelefon"].ToString()
                };*/
                // n.Email = citac["Email"].ToString();


            };
            return os;
        }

        public string vratiAtributID()
        {
            return "OsobaId";
        }

        public List<IDomenskiObjekat> vratiListu(SqlDataReader komanda)
        {
            List<IDomenskiObjekat> lista = new List<IDomenskiObjekat>();

            while (komanda.Read())
            {
                Osoba osoba = new Osoba
                {
                    OsobaId = (int)komanda["OsobaId"],
                    Ime = komanda["Ime"].ToString(),
                    Prezime = komanda["Prezime"].ToString(),
                    Telefon = komanda["KontaktTelefon"].ToString(),
                    Adresa = komanda["Adresa"].ToString(),
                };
                lista.Add(osoba);
            }
            return lista;
        }

        public string vratiNazivTabele()
        {
            return "Osoba";
        }

        public string vratiNazivTabele(string kriterijum)
        {
            return "Osoba";
        }

        public string vratiUslov()
        {
            return $"OsobaId = {this.OsobaId}";
        }

        public string vratiUslovPoNazivu()
        {
            return $"Ime = '{this.Ime}'";
        }

        public string vratiUslovZaPretragu(string kriterijum)
        {
            throw new NotImplementedException();
        }

        public string vratiUslovZaPronalazenjeObjekata(string trazeni)
        {
            return $"OsobaId = {trazeni}";
        }

        public string vratiUslovZaUspesanLogin(string korisnik, string sifra)
        {
            throw new NotImplementedException();
        }

        public string vratiVrednostZaInsert()
        {
            return $"'{this.OsobaId}' , '{this.Ime}' , '{this.Prezime}' ,'{this.Telefon}', '', '{this.Adresa}'";
        }

        public string vratiVrednostZaUpdate()
        {
            return $"Ime = '{this.Ime}', Prezime = '{this.Prezime}', KontaktTelefon = '{this.Telefon}', Adresa = '{this.Adresa}'";
        }
    }
}
