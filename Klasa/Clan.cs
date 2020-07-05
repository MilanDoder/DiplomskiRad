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
    public class Clan : IDomenskiObjekat
    {
        [DisplayName("Članski broj")]
        public int ClanskiBroj { get; set; }
        [DisplayName("Ime Prezime")]
        public string ImePrezime { get { return osoba.Ime +" " + osoba.Prezime; } set { ; } }
        [DisplayName("Adresa")]
        public string Adresa { get { return osoba.Adresa; } set {; } }
        [DisplayName("Telefon")]
        public string Telefon { get { return osoba.Telefon; } set {; } }
        [Browsable(false)]
        public Osoba osoba { get; set; }


        public override string ToString()
        {
            //return osoba.Ime + " " + osoba.Prezime;
            return this.ImePrezime;
        }

        public string vratiNazivTabele() 
        {            
            
                return "Clan";
        }

        public string vratiVrednostZaInsert()
        {
            return $"'{this.ClanskiBroj}', '{this.osoba.OsobaId}'";
        }
        public string vratiVrednostZaUpdate()
        {
            //TO DO
            //return $"ImePrezime = '{this.ImePrezime}', KontaktTelefon = '{this.KontaktTelefon}', Email = '{this.Email}', Adresa = '{this.Adresa}' ";
            return "";
        }

        public string vratiUslov()
        {
            return $"ClanskiBroj = '{this.ClanskiBroj}'";
        }

        public string vratiUslovPoNazivu()
        {
            //TO DO
            //return $"ImePrezime  ='{this.ImePrezime}'";
            return $"ClanskiBroj = '{this.ClanskiBroj}'";
        }

        public string vratiUslovZaPronalazenjeObjekata(string kriterijum)
        {
            return $"ClanskiBroj = '{kriterijum}'";
            //return $"ClanskiBroj LIKE '%{kriterijum}%' OR Osoba.Adresa LIKE '%{kriterijum}%' OR Osoba.KontaktTelefon LIKE '%{kriterijum}%'" +
            //    $" Osoba.Ime LIKE '%{kriterijum}%' OR Osoba.Prezime LIKE '%{kriterijum}%'";
        }

        public string vratiUslovZaPretragu(string kriterijum)
        {
            return $"ClanskiBroj LIKE '%{kriterijum}%' OR Osoba.Adresa LIKE '%{kriterijum}%' OR Osoba.KontaktTelefon LIKE '%{kriterijum}%'" +
                $" OR Osoba.Ime LIKE '%{kriterijum}%' OR Osoba.Prezime LIKE '%{kriterijum}%'";
        }

        public string vratiAtributID()
        {
            return "ClanskiBroj";
        }

        public List<IDomenskiObjekat> vratiListu(SqlDataReader citac)
        {
            List<IDomenskiObjekat> lista = new List<IDomenskiObjekat>();
            while (citac.Read()) {
                Clan n = new Clan
                {
                    ClanskiBroj = (int)citac["ClanskiBroj"],
                    osoba =  new Osoba { 
                        OsobaId = (int)citac["OsobaId"],
                    
                    },
                    /*osoba = new Osoba
                    {
                        Ime = citac["Ime"].ToString(),
                        Prezime = citac["Prezime"].ToString(),
                        Adresa = citac["Adresa"].ToString(),
                        Telefon = citac["KontaktTelefon"].ToString()
                    },*/

                    //Email = citac["Email"].ToString(),
                };
                lista.Add(n);
            }

            return lista;
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
            Clan n = new Clan();
            while (citac.Read())
            {

                n.ClanskiBroj = (int)citac["ClanskiBroj"];
                //TO DO KReiranje Osobe
                n.osoba = new Osoba
                {
                    OsobaId = (int)citac["OsobaId"],

                };
              
               // n.Email = citac["Email"].ToString();


            };
            return n;
        }

        public string vratiUslovZaUspesanLogin(string korisnik, string sifra)
        {
            throw new NotImplementedException();
        }

        public string vratiNazivTabele(string kriterijum)
        {
            if (kriterijum == null)
            {
                return "Clan";
            }
            else {
                return "Clan JOIN Osoba on Clan.OsobaId = Osoba.OsobaId";
            }
        }
    }
}
