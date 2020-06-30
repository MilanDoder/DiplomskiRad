using Bunifu.UI.WinForms.BunifuButton;
using Bunifu.UI.WinForms.BunifuTextbox;
using Klasa;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Forme
{
    public class KontrolerKI
    {
        private static Zaposleni z;

        string _MybackgroungColor = "#222431";
        string _MyLetterColor = "#4eb8ce";
        private BindingList<Nalog> _listaNaloga;
        private BindingList<Narudzbenica> _listaNarudzbenica;
        private BindingList<GamingProizvod> _listaGamingProizvoda;

        internal object PrijavljivanjeZaposlenog(TextBox txt_Username, TextBox txt_password)
        {
            if (String.IsNullOrWhiteSpace(txt_Username.Text)
                    || String.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Korisnicko ime i sifra su obavezna polja!");
                throw new Exception("Greska pri prijavljivanju!");
            }
            else
            {
                try
                {
                    z = Komunikacija.Instanca.PrijaviSe(txt_Username.Text.Trim(), txt_password.Text.Trim());
                    return z;       
                }
                catch (Exception)
                {
                    MessageBox.Show("Greska pri prijavljivanju!");
                    return null;
                }
            }
        }

        public  void PostaviDesniPanel(BunifuButton btn_clanovi, BunifuButton btn_narudzbenica, BunifuButton btn_proizvodi,Panel pnl_selektovanoDugme,
            Panel pnl_left, BunifuButton btn_kreiraj, BunifuButton btn_promeni, BunifuButton btn_Obrisi, BunifuTextBox btn_pretraga)
        {
            btn_clanovi.IdleBorderColor = ColorTranslator.FromHtml(_MybackgroungColor);
            btn_narudzbenica.IdleBorderColor = ColorTranslator.FromHtml(_MybackgroungColor);
            btn_proizvodi.IdleBorderColor = ColorTranslator.FromHtml(_MyLetterColor);
            pnl_selektovanoDugme.BackColor = ColorTranslator.FromHtml(_MyLetterColor);
            pnl_left.Show();

            btn_kreiraj.Enabled = true;

            btn_promeni.Enabled = false;
            btn_Obrisi.Enabled = false;
            pnl_left.Show();
            btn_pretraga.Enabled = true;
        }


       
    }
}
