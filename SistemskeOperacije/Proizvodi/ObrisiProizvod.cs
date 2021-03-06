﻿using BrokerBazePodataka;
using Klasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Proizvodi
{
    public class ObrisiProizvod : SistemskeOperacijeOpsta
    {
        protected override object IzvrsiKonkrentuSO(object objekat)
        {
            int uspesno = Broker.Instanca.Obrisi((GamingProizvod) objekat);
            if (uspesno == 1)
            {
                return true;
            }
            return false;
        }

    }
}
