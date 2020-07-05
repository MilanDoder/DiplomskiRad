using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa
{
    [Serializable]
    public class Zahtev
    {
        public Operacija Operacija { get; set; }
        public object Podaci { get; set; }
    }

    public enum Operacija {
        Login,
        PretraziNalog,
        PretraziProizvod,
        PretraziNarudzbinu,
        VratiSveNaloge,
        VratiSveProizvode,
        VratiSveNarudzbine,
        UbaciNalog,
        PromeniNalog,
        ObrisiNalog,
        VratiNalog,
        KreirajProizvod,
        PromeniProizvod,
        IzbrisiProizvod,
        VratiProizvod,
        UbaciNarudzbinu,
        PromeniNarudzbinu,
        IzbrisiNarudzbinu,
        VratiNarudzbinu,
        VratiProizvodjace,
        Odjavi,
        Proveri_Stanje,
        vratiStavke,
        VratiProizvodjaca,
        Kraj_Servera,

        KreirajOsobu,
        PromeniOsobu,
        ObrisiOsobu,

    }
}
