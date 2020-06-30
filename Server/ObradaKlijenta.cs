using Klasa;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class ObradaKlijenta
    {
        private BindingList<ObradaKlijenta> _zaposleni;
        private BindingList<Zaposleni> _zap = new BindingList<Zaposleni>();
        public Socket socket { get; }
        private NetworkStream stream;
        private BinaryFormatter formater = new BinaryFormatter();
        private Zaposleni z = new Zaposleni();
        private SistemskeOperacijeOpsta opstaSO;
        private object rezultatSO;
        private BindingList<ObradaKlijenta> _povezaniZaposleni;

        public ObradaKlijenta(Socket socket, BindingList<Zaposleni> _listaZaposlenih)
        {
            _zap = _listaZaposlenih;
            this.socket = socket;
            this.stream = new NetworkStream(socket);
            
            Thread nit = new Thread(Obrada);
            nit.Start();
        }

        public ObradaKlijenta(Socket socket, BindingList<Zaposleni> _listaZaposlenih, BindingList<ObradaKlijenta> _povezaniZaposleni) : this(socket, _listaZaposlenih)
        {
            this._povezaniZaposleni = _povezaniZaposleni;
        }

        public void Obrada()
        {
            try
            {
                bool kraj = false;

                while (!kraj) {
                    Zahtev zahtev = (Zahtev)this.formater.Deserialize(this.stream);
                    Odgovor odgovor = new Odgovor();

                    switch (zahtev.Operacija) {

                        case Operacija.Login:
                            z = (Zaposleni)zahtev.Podaci;
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.Login);
                            rezultatSO = opstaSO.IzvrsiSO(zahtev.Podaci);
                            odgovor.Podaci = (Zaposleni)rezultatSO;
                            odgovor.Uspesnost = true;

                            _zap.Add((Zaposleni) rezultatSO);
                            GlavnaFormaServer.brojZaposlenih++;
                            
                            break;
                        case Operacija.Odjavi:

                            
                            GlavnaFormaServer.brojZaposlenih--;
                           
                            kraj = true;
                            break;

                        case Operacija.Proveri_Stanje:
                            break;

                        case Operacija.VratiProizvodjace:
                            odgovor.Podaci = Kontroler.Kontroler.Instanca.vratiProizvodjace();
                            odgovor.Uspesnost = true;
                            break;
                        #region NALOG GOTOVO
                        //NALOG
                        case Operacija.UbaciNalog:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.UbaciNalog);
                           // rezultatSO = 
                            odgovor.Podaci = opstaSO.IzvrsiSO(zahtev.Podaci);
                            odgovor.Uspesnost = true;


                            

                            break;
                        case Operacija.PromeniNalog:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.PromeniNalog);
                            rezultatSO = opstaSO.IzvrsiSO(zahtev.Podaci);
                            odgovor.Podaci = rezultatSO;
                            odgovor.Uspesnost = true;
                            break;
                        case Operacija.ObrisiNalog:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.ObrisiNalog);
                            rezultatSO = opstaSO.IzvrsiSO(zahtev.Podaci);
                            odgovor.Podaci = rezultatSO;
                            odgovor.Uspesnost = true;
                            break;
                        case Operacija.VratiSveNaloge:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.VratiSveNaloge);
                            odgovor.Podaci = opstaSO.IzvrsiSO(zahtev.Podaci);
                            odgovor.Uspesnost = true;
                            break;
                            //SA USLOVOM SO
                        case Operacija.PretraziNalog:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.PretraziNalog);
                            odgovor.Podaci = opstaSO.IzvrsiSO(zahtev.Podaci);                        
                            odgovor.Uspesnost = true;
                            break;
                        case Operacija.VratiNalog:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.VratiNalog);
                            odgovor.Podaci = opstaSO.IzvrsiSO(zahtev.Podaci.ToString());
                           // odgovor.Podaci = Kontroler.Kontroler.Instanca.vratiNalog(zahtev.Podaci.ToString());
                            odgovor.Uspesnost = true;
                            break;


                        case Operacija.VratiProizvodjaca:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.VratiProizvodjaca);
                            odgovor.Podaci = opstaSO.IzvrsiSO(zahtev.Podaci.ToString());
                            odgovor.Uspesnost = true;
                            break;
                        #endregion 
                        //PROIZVOD
                        #region Proizvod GOTOVO
                        case Operacija.KreirajProizvod:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.KreirajProizvod);
                            odgovor.Podaci = opstaSO.IzvrsiSO(zahtev.Podaci);
                            odgovor.Uspesnost = true;
                            break;
                        case Operacija.PromeniProizvod:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.PromeniProizvod);
                            odgovor.Podaci = opstaSO.IzvrsiSO(zahtev.Podaci);
                            odgovor.Uspesnost = true;
                            break;
                        case Operacija.IzbrisiProizvod:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.IzbrisiProizvod);
                            odgovor.Podaci = opstaSO.IzvrsiSO(zahtev.Podaci);
                            odgovor.Uspesnost = true;
                            break;
                        case Operacija.VratiSveProizvode:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.VratiSveProizvode);
                            odgovor.Podaci = opstaSO.IzvrsiSO(zahtev.Podaci);
                            odgovor.Uspesnost = true;
                            break;
                        case Operacija.PretraziProizvod:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.PretraziProizvod);
                            odgovor.Podaci = opstaSO.IzvrsiSO(zahtev.Podaci);
                            odgovor.Uspesnost = true;
                            break;
                        case Operacija.VratiProizvod:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.VratiProizvod);
                            odgovor.Podaci = opstaSO.IzvrsiSO(zahtev.Podaci);
                            odgovor.Uspesnost = true;
                            break;
                        #endregion

                        #region Narudzbenica
                        //NARUDZBENICA
                        case Operacija.UbaciNarudzbinu:
                            
                                opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.UbaciNarudzbinu);
                                odgovor.Podaci = opstaSO.IzvrsiSO(zahtev.Podaci);
                                // odgovor.Podaci = Kontroler.Kontroler.Instanca.SacuvajNarudzbenicu((Narudzbenica)zahtev.Podaci);
                                odgovor.Uspesnost = true;
                            
                            
                            break;
                        case Operacija.PromeniNarudzbinu:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.PromeniNarudzbinu);
                            odgovor.Podaci = opstaSO.IzvrsiSO(zahtev.Podaci);
                                odgovor.Uspesnost = true;
                            break;
                        case Operacija.IzbrisiNarudzbinu:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.IzbrisiNarudzbinu);
                            odgovor.Podaci = opstaSO.IzvrsiSO(zahtev.Podaci);
                           // odgovor.Podaci = Kontroler.Kontroler.Instanca.izbrisiNarudzbenicu((Narudzbenica) zahtev.Podaci);
                            odgovor.Uspesnost = true;
                            break;
                        case Operacija.VratiSveNarudzbine:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.VratiSveNarudzbine);
                            odgovor.Podaci = opstaSO.IzvrsiSO((Narudzbenica)zahtev.Podaci);
                            odgovor.Uspesnost = true;
                            break;
                        case Operacija.PretraziNarudzbinu:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.PretraziNarudzbinu);
                            odgovor.Podaci = opstaSO.IzvrsiSO(zahtev.Podaci.ToString());    
                            odgovor.Uspesnost = true;
                            break;
                        case Operacija.VratiNarudzbinu:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.VratiNarudzbinu);
                            odgovor.Podaci = opstaSO.IzvrsiSO(zahtev.Podaci.ToString());
                            odgovor.Uspesnost = true;
                            break;
                        case Operacija.vratiStavke:
                            opstaSO = Kontroler.Kontroler.Instanca.vratiSistemskuOperaciju(Operacija.vratiStavke);
                            odgovor.Podaci = opstaSO.IzvrsiSO(zahtev.Podaci.ToString());
                            odgovor.Uspesnost = true;
                            break;
                        #endregion

                        default:  kraj = true; break;

                    }
                    this.formater.Serialize(this.stream, odgovor);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
               

            }
            finally {
                if(socket.Connected)
                   socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                _zap.Remove(z);
                _povezaniZaposleni.Remove(this);
                // _zaposleni.Remove(this);

            }
        }

        internal void Ugasi()
        {
            Zahtev zahtev = new Zahtev
            {

                Operacija = Operacija.Kraj_Servera
            };
            this.formater.Serialize(this.stream, zahtev);
        }
    }
}
