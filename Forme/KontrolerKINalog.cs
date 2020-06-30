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
        public static Nalog nalog { get; set; }
        private static BindingList<Nalog> _listaNaloga;

        public static frm_glavna GlavnaForma { get; set; } 

        //public void ucitajProizvodjace(ComboBox proizvodjaci) {
        //    IList<Proizvodjac> _lista = Komunikacija.Instanca.vratiProizvodjace();
        //    proizvodjaci.DataSource = _lista;
        //}


        public static void ucitajNaloge(DataGridView dgv_podaci)
        {

            _listaNaloga = new BindingList<Nalog>(Komunikacija.Instanca.vratiSveNaloge());
            dgv_podaci.DataSource = _listaNaloga;
            dgv_podaci.Refresh();
        }


        public static void prikazNaloga(Panel pnl_prikazElemenata, Label lbl_clanskiBrojIzabranogClana,TextBox txt_imeIzabranogClana,TextBox txt_prezimeIzabranogClana,
            TextBox txt_telefonIzabranogClana,TextBox txt_emailIzbranogClana,TextBox txt_adresaIzabranogClana) {

            pnl_prikazElemenata.Show();
            pnl_prikazElemenata.Size = new Size(447, 297);
            pnl_prikazElemenata.Location = new Point(166, 61);

            lbl_clanskiBrojIzabranogClana.Text = nalog.ClanskiBroj.ToString();
            txt_imeIzabranogClana.Text = nalog.ImePrezime.Substring(0, nalog.ImePrezime.IndexOf(" "));
            txt_prezimeIzabranogClana.Text = nalog.ImePrezime.Substring(nalog.ImePrezime.IndexOf(" ") + 1);
            txt_telefonIzabranogClana.Text = nalog.KontaktTelefon;
            txt_emailIzbranogClana.Text = nalog.Email;
            txt_adresaIzabranogClana.Text = nalog.Adresa;
        }

        public static Nalog vratiNalogIzForme(Label lbl_clanskiBrojIzabranogClana, TextBox txt_imeIzabranogClana, TextBox txt_prezimeIzabranogClana,
                                            TextBox txt_telefonIzabranogClana, TextBox txt_emailIzbranogClana, TextBox txt_adresaIzabranogClana) {
            return new Nalog
            {
                ClanskiBroj = Convert.ToInt32(lbl_clanskiBrojIzabranogClana.Text),
                ImePrezime = txt_imeIzabranogClana.Text + " " + txt_prezimeIzabranogClana.Text,
                KontaktTelefon = txt_telefonIzabranogClana.Text,
                Email = txt_emailIzbranogClana.Text,
                Adresa = txt_adresaIzabranogClana.Text


            };

        }



        public enum Opcije {
            Kreiraj,
            Izmeni,

        }
 
    }
}
