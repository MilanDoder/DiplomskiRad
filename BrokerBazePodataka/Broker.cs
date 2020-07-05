using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klasa;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Configuration;

namespace BrokerBazePodataka
{
    /// <summary>
    ///     Vrsi komunikaciju bazom podataka
    ///     i vraca sve potrebne podatke iz baze podataka
    /// </summary>
    /// 

    public class Broker
    {

        private static Broker _instanca;
        private SqlConnection konekcija;
        private SqlTransaction transakcija;


        //konstruktorom odma imamo vezu sa bazom
        private Broker()
        {

            //string prom = ConfigurationManager.AppSettings["kljuc"];
            konekcija = new SqlConnection(ConfigurationManager.ConnectionStrings["konekcija"].ConnectionString);


        }

        public static Broker Instanca
        {

            get
            {
                if (_instanca == null)
                {
                    _instanca = new Broker();
                }
                return _instanca;

            }
        }



        //Genericke metode

        public List<IDomenskiObjekat> vratiSve(IDomenskiObjekat objekat)
        {

            SqlDataReader reader = null;
            try
            {
                SqlCommand komanda = new SqlCommand("", konekcija, transakcija);
                string upit = $"Select  * from {objekat.vratiNazivTabele()}";
                komanda.CommandText = upit;
                reader = komanda.ExecuteReader();
                return objekat.vratiListu(reader);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public List<IDomenskiObjekat> vratiSvePodUslovom(IDomenskiObjekat objekat, string trazeni)
        {

            SqlDataReader citac = null;
            try
            {
                SqlCommand komanda = new SqlCommand("", konekcija, transakcija);
                string query = $"SELECT * FROM {objekat.vratiNazivTabele()} WHERE {objekat.vratiUslovZaPronalazenjeObjekata(trazeni)}";

                komanda.CommandText = query;
                citac = komanda.ExecuteReader();

                return objekat.vratiListu(citac).ToList();
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }

        }

        public IDomenskiObjekat vratiObjekat(IDomenskiObjekat objekat, string ID)
        {


            try
            {
                SqlCommand komanda = new SqlCommand("", konekcija, transakcija);
                string query = $"SELECT * FROM {objekat.vratiNazivTabele()} WHERE {objekat.vratiUslovZaPronalazenjeObjekata(ID)}";

                komanda.CommandText = query;

                SqlDataReader citac = komanda.ExecuteReader();

                return objekat.kreirajObjekat(citac);

            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<IDomenskiObjekat> pretragaObjekta(IDomenskiObjekat objekat, string kriterijum)
        {


            try
            {
                SqlCommand komanda = new SqlCommand("", konekcija, transakcija);
                string query = $"SELECT * FROM {objekat.vratiNazivTabele(kriterijum)} WHERE {objekat.vratiUslovZaPretragu(kriterijum)}";

                komanda.CommandText = query;

                SqlDataReader citac = komanda.ExecuteReader();

                return objekat.vratiListu(citac).ToList();
            }
            catch (Exception)
            {

                throw;
            }

        }




        public IDomenskiObjekat vratiJedan(IDomenskiObjekat domenskiObjekat)
        {
            SqlDataReader citac = null;
            //Pomoc za transakcije !!!
            SqlCommand komanda = new SqlCommand("", konekcija, transakcija);

            string upit = $"Select  * From {domenskiObjekat.vratiNazivTabele()} Where {domenskiObjekat.vratiUslov()} OR {domenskiObjekat.vratiUslovPoNazivu()}";
            komanda.CommandText = upit;

            //ovo je umesto try finnalu bloka!!!
            using (citac = komanda.ExecuteReader())
            {
                return domenskiObjekat.vratiListu(citac).First();
            }
        }

        public int Sacuvaj(IDomenskiObjekat objekat)
    {
        
        SqlCommand komanda = new SqlCommand("", konekcija, transakcija);
        string query = $"INSERT INTO {objekat.vratiNazivTabele()} VALUES ({objekat.vratiVrednostZaInsert()})";

        komanda.CommandText = query;


        return komanda.ExecuteNonQuery();
    }

        public int Promeni(IDomenskiObjekat objekat)
    {
        SqlCommand komanda = new SqlCommand("", konekcija, transakcija);
            string query = $"UPDATE {objekat.vratiNazivTabele()} SET {objekat.vratiVrednostZaUpdate()} WHERE {objekat.vratiUslov()}";

        komanda.CommandText = query;

        return komanda.ExecuteNonQuery();
    }

        public int Obrisi(IDomenskiObjekat objekat)
        {
            SqlCommand komanda = new SqlCommand("", konekcija, transakcija);
            string query = $"DELETE  FROM {objekat.vratiNazivTabele()} WHERE {objekat.vratiUslov()}";
            komanda.CommandText = query;
            return komanda.ExecuteNonQuery();
        }



        public int najveciID(IDomenskiObjekat objekat)
        {
            try
            {
                SqlCommand komanda = new SqlCommand("", konekcija, transakcija);

                string query = $"SELECT MAX({objekat.vratiAtributID()}) FROM {objekat.vratiNazivTabele()}";

                komanda.CommandText = query;
                var rezultat = komanda.ExecuteScalar();

                return (int)rezultat;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }



        /// <summary>
        /// TRANSAKCIJE I BAZA
        /// 
        /// </summary>

        public void otvoriKonekciju()
    {
        konekcija.Open();
    }

        public void zatvoriKonekciju()
    {
        konekcija.Close();
    }

        public void pokreniTransakciju()
    {
        transakcija = konekcija.BeginTransaction();
    }

        public void potvrdiTransakciju()
    {
        transakcija.Commit();
    }

        public void ponistiTransakciju()
    {
        transakcija.Rollback();
    }




        public List<IDomenskiObjekat> pretrazi(IDomenskiObjekat objekat, string trazeni)
        {

            SqlDataReader citac = null;
            try
            {
                SqlCommand komanda = new SqlCommand("", konekcija, transakcija);

                string query = $"SELECT * FROM {objekat.vratiNazivTabele()} WHERE {objekat.vratiUslovZaPretragu(trazeni)}";

                komanda.CommandText = query;
                citac = komanda.ExecuteReader();
                return objekat.vratiListu(citac).ToList();
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }



            throw new Exception();
        }

    }
}
