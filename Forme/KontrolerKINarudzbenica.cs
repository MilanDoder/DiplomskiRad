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
    public class KontrolerKINarudzbenica
    {
        private static object _listaNarudzbenica;
        public static Narudzbenica narudzbenica;
        public static void ucitajNarudzbenice(DataGridView dgv_podaci) {
            _listaNarudzbenica = new BindingList<Narudzbenica>(Komunikacija.Instanca.vratiSveNarudzbenice());
            dgv_podaci.DataSource = _listaNarudzbenica;
            dgv_podaci.Refresh();

        }


        public static void prikazNarudzbenice(Panel pnl_narudzbenica, TextBox txt_ImePrezimeClanaNarudzbenica,TextBox txt_emailClanaNarudzbenica,TextBox txt_telefonClanaNarudzbenica,
            Label lbl_clanskiNalog,Label lbl_sifraNarudzbenice, TextBox txt_DatumODNarudzbenica,TextBox txt_datumDONarudzbenica, TextBox txt_ukupanIznos, DataGridView dgv_stavkeNarudzbenice) {

            pnl_narudzbenica.Show();
            pnl_narudzbenica.Size = new Size(448, 291);

            txt_ImePrezimeClanaNarudzbenica.Text = narudzbenica.Korisnik.ToString();
            //TO DO EMAIL
            txt_emailClanaNarudzbenica.Text = narudzbenica.Korisnik.osoba.Adresa;
            txt_telefonClanaNarudzbenica.Text = narudzbenica.Korisnik.osoba.Telefon;
            lbl_clanskiNalog.Text = narudzbenica.Korisnik.ClanskiBroj.ToString();

            lbl_sifraNarudzbenice.Text = narudzbenica.SifraNarudzbenice.ToString();

            txt_DatumODNarudzbenica.Text = narudzbenica.DatumOd.ToShortDateString();
            txt_datumDONarudzbenica.Text = narudzbenica.DatumDo.ToShortDateString();
            txt_ukupanIznos.Text = narudzbenica.UkupanIznos.ToString();

            dgv_stavkeNarudzbenice.DataSource = narudzbenica.stavke;

        }

    }
}
