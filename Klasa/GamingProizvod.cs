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
    public class GamingProizvod : IDomenskiObjekat
    {
        [DisplayName("Sifra Proizvoda")]
        public int proizvodID { get; set; }
        [DisplayName("Naziv")]
        public string Naziv { get ; set; }
        [Browsable(false)]
        public string karakteristike { get; set; }
        [DisplayName("Model")]
        public string model { get; set; }
        [DisplayName("Cena")]
        public float cena { get; set; }
        [DisplayName("Količina")]
        public int raspolozivoStanje { get; set; }
        [Browsable(false)]
        public Proizvodjac proizvodjac { get; set; }
        /// <summary>
        /// Da bi prikazao samog proizvodjaca kod proizvoda 
        /// moramo kreirati sami properti koji ce se izvrsiti, a 
        /// ne standardizovani properti to string
        /// 
        /// </summary>
        [DisplayName("Proizvodjac")]
        public string Proizvodjac_Ime
        {
            get { return (proizvodjac != null) ? proizvodjac.Naziv : ""; }
        }

        public override string ToString()
        {
            return $"{Naziv}";
        }

        public string vratiNazivTabele()
        {
            return "Proizvod";
        }

        public string vratiVrednostZaInsert()
        {
            return $"'{this.proizvodID}' , '{this.Naziv}' , '{this.karakteristike}' ,'{this.model}', '{this.cena}', '{this.raspolozivoStanje}', '{this.proizvodjac.ProizvodjacID}'";
        }

        public string vratiUslov()
        {
            return $"ProizvodID = {this.proizvodID}";
        }

        public string vratiVrednostZaUpdate()
        {
            return $"Naziv = '{this.Naziv}', Karakteristike = '{this.karakteristike}', Model = '{this.model}', Cena = '{this.cena}', RaspolozivaKolicina = '{this.raspolozivoStanje}', ProizvodjacID = '{this.proizvodjac.ProizvodjacID}'";
        }

        public string vratiUslovZaPretragu(string kriterijum)
        {
            return $"ProizvodID LIKE '%{kriterijum}%' OR Naziv LIKE '%{kriterijum}%'  OR Model LIKE '%{kriterijum}%'";
        }

        public string vratiAtributID()
        {
            return "ProizvodID";
        }



        public void postaviPocetnuVrednost()
        {
            this.proizvodID = 1;
        }

        public void povecajVrednost(object vrednost)
        {
            this.proizvodID = (int)vrednost;
            this.proizvodID++;
        }

        

        public IDomenskiObjekat kreirajObjekat(SqlDataReader citac)
        {
            GamingProizvod gp = new GamingProizvod();
            while(citac.Read())
            {

                gp.proizvodID = (int)citac["ProizvodID"];
                gp.Naziv = citac["Naziv"].ToString();
                gp.karakteristike = citac["Karakteristike"].ToString();
                gp.model = citac["Model"].ToString();
                gp.cena = Convert.ToInt64(citac["Cena"]);
                gp.raspolozivoStanje = (int)citac["RaspolozivaKolicina"];
                    gp.proizvodjac = new Proizvodjac
                    {
                        ProizvodjacID = (int)citac["ProizvodjacID"]
                    };

                
               
            }
            return gp;
        }

        public string vratiUslovPoNazivu()
        {
            return $"Naziv = '{this.Naziv}'";
        }

        

        public string vratiUslovZaPronalazenjeObjekata(string trazeni)
        {
            //OR Naziv LIKE '%{trazeni}%'  OR Model LIKE '%{trazeni}%'
            return $" ProizvodID = '{trazeni}'";
        }

        

        

        public List<IDomenskiObjekat> vratiListu(SqlDataReader komanda)
        {
            List<IDomenskiObjekat> lista = new List<IDomenskiObjekat>();

            while (komanda.Read())
            {
                GamingProizvod gp = new GamingProizvod
                {
                    proizvodID = (int)komanda["ProizvodID"],
                    Naziv = komanda["Naziv"].ToString(),
                    karakteristike = komanda["Karakteristike"].ToString(),
                    model = komanda["Model"].ToString(),
                    cena = Convert.ToInt64(komanda["Cena"]),
                    raspolozivoStanje = (int)komanda["RaspolozivaKolicina"],
                    proizvodjac = new Proizvodjac
                    {
                        ProizvodjacID = (int)komanda["ProizvodjacID"]
                    }

                };
                lista.Add(gp);
            }
            return lista;

        }

        public string vratiUslovZaUspesanLogin(string korisnik, string sifra)
        {
            throw new NotImplementedException();
        }

        public string vratiNazivTabele(string kriterijum)
        {
            return "Proizvod";
        }
    }
}
