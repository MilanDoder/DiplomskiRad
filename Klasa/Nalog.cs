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
    public class Nalog : IDomenskiObjekat
    {
        [DisplayName("Članski broj")]
        public int ClanskiBroj { get; set; }
        [DisplayName("Ime Prezime")]
        public string ImePrezime { get; set; }
        [Browsable(false)]
        public string  KontaktTelefon { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [Browsable(false)]
        public string Adresa { get; set; }

        public override string ToString()
        {
            return ImePrezime + "";
        }

        public string vratiNazivTabele()
        {
            return "Clan";
        }

        public string vratiVrednostZaInsert()
        {
            return $"'{this.ClanskiBroj}', '{this.ImePrezime}', '{this.KontaktTelefon}', '{this.Email}', '{this.Adresa}'";
        }
        public string vratiVrednostZaUpdate()
        {
            return $"ImePrezime = '{this.ImePrezime}', KontaktTelefon = '{this.KontaktTelefon}', Email = '{this.Email}', Adresa = '{this.Adresa}' ";

        }

        public string vratiUslov()
        {
            return $"ClanskiBroj = '{this.ClanskiBroj}'";
        }

        public string vratiUslovPoNazivu()
        {
            return $"ImePrezime  ='{this.ImePrezime}'";
        }

        public string vratiUslovZaPronalazenjeObjekata(string trazeni)
        {
            return $"ClanskiBroj LIKE '%{trazeni}%'  OR ImePrezime LIKE '%{trazeni}%' OR Email LIKE '%{trazeni}%'";
        }

        public string vratiUslovZaPretragu(string kriterijum)
        {
            return $"ClanskiBroj LIKE '%{kriterijum}%'  OR ImePrezime LIKE '%{kriterijum}%' OR Email LIKE '%{kriterijum}%'";
        }

        public string vratiAtributID()
        {
            return "ClanskiBroj";
        }

        public List<IDomenskiObjekat> vratiListu(SqlDataReader citac)
        {
            List<IDomenskiObjekat> lista = new List<IDomenskiObjekat>();
            while (citac.Read()) {
                Nalog n = new Nalog
                {
                    ClanskiBroj = (int) citac["ClanskiBroj"],
                    ImePrezime = citac["ImePrezime"].ToString(),
                    KontaktTelefon = citac["KontaktTelefon"].ToString(),
                    Email = citac["Email"].ToString(),
                    Adresa = citac["Adresa"].ToString()

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
            Nalog n = new Nalog();
            while (citac.Read())
            {

                n.ClanskiBroj = (int)citac["ClanskiBroj"];
                n.ImePrezime = citac["ImePrezime"].ToString();
                n.KontaktTelefon = citac["KontaktTelefon"].ToString();
                n.Email = citac["Email"].ToString();
                n.Adresa = citac["Adresa"].ToString();


            };
            return n;
        }
        
    }
}
