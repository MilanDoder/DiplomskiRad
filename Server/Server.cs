using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Klasa;

namespace Server
{
    public class Server
    {
        public BindingList<Zaposleni> _listaPrijavljenihZaposlenih { get; }
        private Socket serverSoket;

        public BindingList<ObradaKlijenta> _povezaniZaposleni { get; set; }

        bool kraj = false;

        public Server() {
            _listaPrijavljenihZaposlenih = new BindingList<Zaposleni>();
            _povezaniZaposleni = new BindingList<ObradaKlijenta>();
        }


        public void PokreniServer() {
            try
            {
                kraj = false;
                this.serverSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                this.serverSoket.Bind(new IPEndPoint(IPAddress.Any,10000));
                this.serverSoket.Listen(5);
                Console.WriteLine("Server pokrenut!");

                while (!kraj) {
                    Console.WriteLine("Cekamo klijenta!");
                    Socket klijentSoket = this.serverSoket.Accept();
                    Console.WriteLine("Klijent se prijavio!");
                    

                    ObradaKlijenta obrada =  new ObradaKlijenta(klijentSoket,_listaPrijavljenihZaposlenih,_povezaniZaposleni);
                    _povezaniZaposleni.Add(obrada);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Server je vec pokrenut!");
                //throw new Exception("Server je vec pokrenut!");
            }
        }

        internal void ZaustaviServer()
        {
            kraj = true;
            
            foreach (ObradaKlijenta ok in _povezaniZaposleni) {
                ok.Ugasi();
            }

            serverSoket?.Close();
        }
    }
}
