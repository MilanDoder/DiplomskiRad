using Klasa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public class KontrolerKINalog
    {
        public static Clan nalog { get; set; }
        private static BindingList<Clan> _listaNaloga;

        public static frm_glavna GlavnaForma { get; set; } 

        //public void ucitajProizvodjace(ComboBox proizvodjaci) {
        //    IList<Proizvodjac> _lista = Komunikacija.Instanca.vratiProizvodjace();
        //    proizvodjaci.DataSource = _lista;
        //}


        public static void ucitajNaloge(DataGridView dgv_podaci)
        {

            _listaNaloga = new BindingList<Clan>(Komunikacija.Instanca.vratiSveNaloge());
            dgv_podaci.DataSource = _listaNaloga;
            dgv_podaci.Refresh();
        }


        public static void prikazNaloga(Panel pnl_prikazElemenata, Label lbl_clanskiBrojIzabranogClana, Label lbl_osobaIzabranogClana,TextBox txt_imeIzabranogClana,TextBox txt_prezimeIzabranogClana,
            TextBox txt_telefonIzabranogClana,TextBox txt_emailIzbranogClana,TextBox txt_adresaIzabranogClana) {

            pnl_prikazElemenata.Show();
            pnl_prikazElemenata.Size = new Size(447, 297);
            pnl_prikazElemenata.Location = new Point(166, 61);

            lbl_osobaIzabranogClana.Text = nalog.osoba.OsobaId.ToString();
            lbl_clanskiBrojIzabranogClana.Text = nalog.ClanskiBroj.ToString();
            txt_imeIzabranogClana.Text = nalog.osoba.Ime;
            txt_prezimeIzabranogClana.Text = nalog.osoba.Prezime;
            txt_telefonIzabranogClana.Text = nalog.osoba.Telefon;
            //TO DO EMAIL
            //nalog.ImePrezime.Substring(0, nalog.ImePrezime.IndexOf(" ")); nalog.ImePrezime.Substring(nalog.ImePrezime.IndexOf(" ") + 1);
            txt_emailIzbranogClana.Text = nalog.osoba.Email;
            txt_adresaIzabranogClana.Text = nalog.osoba.Adresa;
        }

        public static Osoba vratiNalogIzForme(Label lbl_clanskiBrojIzabranogClana,Label lbl_OsobaIzabranogClana, TextBox txt_imeIzabranogClana, TextBox txt_prezimeIzabranogClana,
                                            TextBox txt_telefonIzabranogClana, TextBox txt_emailIzbranogClana, TextBox txt_adresaIzabranogClana) {
            Clan cl = new Clan
            {
                ClanskiBroj = Convert.ToInt32(lbl_clanskiBrojIzabranogClana.Text),
                osoba = new Osoba {
                    OsobaId = Convert.ToInt32(lbl_OsobaIzabranogClana.Text),
                    Ime = txt_imeIzabranogClana.Text,
                    Prezime = txt_prezimeIzabranogClana.Text,
                    Telefon= txt_telefonIzabranogClana.Text,
                    Email =  txt_emailIzbranogClana.Text,
                    Adresa = txt_adresaIzabranogClana.Text,
                },



            };
            return cl.osoba;
        }



        public enum Opcije {
            Kreiraj,
            Izmeni,

        }
 
    }
}
