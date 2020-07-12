using Klasa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FrmKreirajNalog : Form
    {
        static Regex ValidEmailRegex = CreateValidEmailRegex();
        string _MybackgroungColor = "#222431";
        string _MyLetterColor = "#4eb8ce";

        public FrmKreirajNalog()
        {
            InitializeComponent();
            placeholderi();
        }

        private void btn_sacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                int clBroj = new Random().Next(0, 99999999);

                //Doraditi
                ValidacijaPodataka();
                /* Clan n = new Clan
                 {
                     ClanskiBroj = clBroj,
                     osoba = new Osoba { 
                        Ime =  txt_ImeClana.Text,
                        Prezime = txt_prezimeClana.Text,
                        Telefon =  txt_telefonClana.Text,
                        Adresa = txt_adresaClana.Text,
                     }

                 };*/

                Osoba o = new Osoba
                {
                    Ime = txt_ImeClana.Text,
                    Prezime = txt_prezimeClana.Text,
                    Telefon = txt_telefonClana.Text,
                    Email = txt_emailClana.Text,
                    Adresa = txt_adresaClana.Text,
                };
                //Bilo kreiraj Nalog
                if (Komunikacija.Instanca.kreirajOsobu(o))
                {
                    MessageBox.Show("Sistem je kreirao nalog");
                }
                else {
                    MessageBox.Show("1 .Greska pri unosu clana");
                }

                Close();
            }
            catch (InvalidCastException exp) {
                MessageBox.Show("Greska sa serverom!");
                Komunikacija.Instanca.PokreniLogin = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne moože da kreira nalog");
            }

        }


        private void ValidacijaPodataka()
        {
            bool uspesno = true;


            if (String.IsNullOrWhiteSpace(txt_ImeClana.Text) || txt_ImeClana.Text=="Ime")
            {
                txt_ImeClana.BackColor = Color.IndianRed;
                uspesno = false;
            }
            if (String.IsNullOrWhiteSpace(txt_prezimeClana.Text) || txt_prezimeClana.Text =="Prezime")
            {
                txt_prezimeClana.BackColor = Color.IndianRed;
                uspesno = false;
            }

            
            if ((String.IsNullOrWhiteSpace(txt_emailClana.Text) && !EmailIsValid(txt_emailClana.Text)) ||
                    txt_emailClana.Text =="E-mail")
            {
                txt_emailClana.BackColor = Color.IndianRed;
                uspesno = false;
            }
            if (txt_telefonClana.Text == "Telefon")
            {
                txt_telefonClana.Text = "";
            }
            if (txt_adresaClana.Text =="Adresa")
            {
                txt_adresaClana.Text = "";
            }


            if (!uspesno)
            {
                throw new Exception("Niste uneli ispravne podatke");
                placeholderi();
            }
        }

        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        internal static bool EmailIsValid(string emailAddress)
        {
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
        }

        public bool IsValidPhone(string Phone)
        {
            string patternPhoneNumber = @"^((\+\d{1,3}(-| )?\(?\d\)?(-| )?\d{1,5})|(\(?\d{2,6}\)?))(-| )?(\d{3,4})(-| )?(\d{4})(( x| ext)\d{1,5}){0,1}$";
            try
            {
                var r = new Regex(patternPhoneNumber);
                return r.IsMatch(Phone);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void lbl_closeNalog_Click(object sender, EventArgs e)
        {
            //frm_glavna glavna = new frm_glavna();
            this.Close();
            //glavna.Show();
            //this.Owner = glavna;
        }
        ///PLACEHOLDERI
        /// <summary>
        /// Ime clana placeholder
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_ImeClana_Enter(object sender, EventArgs e)
        {
            if (txt_ImeClana.Text == "Ime") {
                txt_ImeClana.Text = "";
            }
        }

        private void txt_ImeClana_Leave(object sender, EventArgs e)
        {
            if (txt_ImeClana.Text == "")
            {
                txt_ImeClana.Text = "Ime";
            }
        }

        private void txt_prezimeClana_Enter(object sender, EventArgs e)
        {
            if (txt_prezimeClana.Text == "Prezime")
            {
                txt_prezimeClana.Text = "";
            }
        }

        private void txt_prezimeClana_Leave(object sender, EventArgs e)
        {
            if (txt_prezimeClana.Text == "")
            {
                txt_prezimeClana.Text = "Prezime";
            }
        }

        private void txt_telefonClana_Enter(object sender, EventArgs e)
        {
            if (txt_telefonClana.Text == "Telefon")
            {
                txt_telefonClana.Text = "";
            }
        }

        private void txt_telefonClana_Leave(object sender, EventArgs e)
        {
            if (txt_telefonClana.Text == "")
            {
                txt_telefonClana.Text = "Telefon";
            }
        }

        private void txt_emailClana_Enter(object sender, EventArgs e)
        {
            if (txt_emailClana.Text == "E-mail")
            {
                txt_emailClana.Text = "";
            }
        }

        private void txt_emailClana_Leave(object sender, EventArgs e)
        {
            if (txt_emailClana.Text == "")
            {
                txt_emailClana.Text = "E-mail";
            }
        }

        private void txt_adresaClana_Enter(object sender, EventArgs e)
        {
            if (txt_adresaClana.Text == "Adresa")
            {
                txt_adresaClana.Text = "";
            }
        }

        private void txt_adresaClana_Leave(object sender, EventArgs e)
        {
            if (txt_adresaClana.Text == "")
            {
                txt_adresaClana.Text = "Adresa";
            }
        }




        /// <summary>
        /// UCITAVANJE FORME STA DA PRIKAZE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmKreirajNalog_Load(object sender, EventArgs e)
        {
            placeholderi();
        }

        private void placeholderi() {
            txt_ImeClana.Text = "Ime";
            txt_prezimeClana.Text = "Prezime";
            txt_emailClana.Text = "E-mail";
            txt_telefonClana.Text = "Telefon";
            txt_adresaClana.Text = "Adresa";
        }

        private void txt_ImeClana_TextChanged(object sender, EventArgs e)
        {
            txt_ImeClana.BackColor = ColorTranslator.FromHtml(_MybackgroungColor);
        }

        private void txt_prezimeClana_TextChanged(object sender, EventArgs e)
        {
            txt_prezimeClana.BackColor = ColorTranslator.FromHtml(_MybackgroungColor);
        }

        private void txt_emailClana_TextChanged(object sender, EventArgs e)
        {
            txt_emailClana.BackColor = ColorTranslator.FromHtml(_MybackgroungColor);
        }
    }
}
