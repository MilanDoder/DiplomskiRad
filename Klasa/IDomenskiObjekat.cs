using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa
{
    public interface IDomenskiObjekat
    {
        string vratiNazivTabele();
        string vratiVrednostZaInsert();
        string vratiVrednostZaUpdate();
        
        string vratiUslov();
        string vratiUslovZaPretragu(string kriterijum);
        string vratiAtributID();

        string vratiUslovPoNazivu();
        string vratiUslovZaPronalazenjeObjekata(string trazeni);

       
        IDomenskiObjekat kreirajObjekat(SqlDataReader citac);
        List<IDomenskiObjekat> vratiListu(SqlDataReader komanda);
    }
}
