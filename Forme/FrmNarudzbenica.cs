using Klasa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FrmNarudzbenica : Form
    {
        private Nalog korisnik;
        private GamingProizvod GamProizvod;
        private float ukupanIznos = 0;

        BindingList<StavkaNarudzbenice> _listaStavki = new BindingList<StavkaNarudzbenice>();

        public FrmNarudzbenica()
        {
            InitializeComponent();
        }

        private void FrmNarudzbenica_Load(object sender, EventArgs e)
        {
            try
            {
                cbx_korisnikClan.DataSource = Komunikacija.Instanca.vratiSveNaloge();
                cbx_proizvodi.DataSource = Komunikacija.Instanca.vratiSveGamingProizvode();
                txt_datumDo.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greska. Zatvorite formu!");
            }
            
        }

        private void btn_sacuvajProizvod_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txt_kolicinaProizvoda.Text) || String.IsNullOrEmpty(txt_datumOd.Text)
                    || String.IsNullOrEmpty(txt_datumDo.Text))
                {
                    throw new Exception("Sva polja su obavezna!");
                }
                /*Narudzbenica nar = kreirajNarudzbenicu();


                if (!Komunikacija.Instanca.ProveriStanje(nar))
                {
                    throw new Exception("Ne dovoljan broj proizvoda na stanju!");
                }*/
                DateTime datumOd = Convert.ToDateTime(txt_datumOd.Text);
                DateTime datumDo = Convert.ToDateTime(txt_datumDo.Text);

                int kolicina = Convert.ToInt32(txt_kolicinaProizvoda.Text);


                StavkaNarudzbenice sn = kreirajStavkuNarudzbenice();
                _listaStavki.Add(sn);
                dgv_StavkeNarudzbenice.DataSource = _listaStavki;
                ukupanIznos += (sn.proizvod.cena * kolicina);
                txt_ukupanIznos.Text = (ukupanIznos).ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private StavkaNarudzbenice kreirajStavkuNarudzbenice()
        {
            return new StavkaNarudzbenice
            {
                proizvod = GamProizvod,
                Kolicina = Convert.ToInt32(txt_kolicinaProizvoda.Text),
                
            };
        }

        private void lbl_closeNarudzbenica_Click(object sender, EventArgs e)
        {
            frm_glavna glavna = new frm_glavna();
            this.Hide();
            glavna.Show();
            this.Owner = glavna;
        }

        


        /// <summary>
        /// Kalendar
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txt_datumOd_MouseEnter(object sender, EventArgs e)
        {
            mcal_datumOd.Visible = true;
        }

        private void txt_datumDo_MouseEnter(object sender, EventArgs e)
        {
            mcal_DatumDo.Visible = true;
        }

      
        private void mcal_DatumDo_MouseLeave(object sender, EventArgs e)
        {
            mcal_DatumDo.Visible = false;
        }

        private void mcal_datumOd_MouseLeave(object sender, EventArgs e)
        {
            mcal_datumOd.Visible = false;
        }

        private void mcal_DatumDo_MouseCaptureChanged(object sender, EventArgs e)
        {
            if(txt_datumDo.Text=="")
            mcal_DatumDo.Visible = false;
            
        }

        private void mcal_datumOd_MouseCaptureChanged(object sender, EventArgs e)
        {
            mcal_datumOd.Visible = false;
            
        }

        private void mcal_DatumDo_DateSelected(object sender, DateRangeEventArgs e)
        {
            string datum = e.Start.ToShortDateString();
            DateTime datumOd = Convert.ToDateTime(txt_datumOd.Text);
            DateTime datumDo = Convert.ToDateTime(datum);
            try
            {
                if (datumOd <= datumDo)
                {
                    txt_datumDo.Text = datum;
                }
                else {
                    throw new Exception("Ne ispravan datum");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            


        }

        private void mcal_datumOd_DateSelected(object sender, DateRangeEventArgs e)
        {
            
            txt_datumOd.Text = (e.Start.ToShortDateString());
            txt_datumDo.Enabled = true;
        }

        private void cbx_korisnikClan_SelectedIndexChanged(object sender, EventArgs e)
        {
            korisnik = cbx_korisnikClan.SelectedItem as Nalog;
            
        }

        private void cbx_proizvodi_SelectedIndexChanged(object sender, EventArgs e)
        {
            GamProizvod = cbx_proizvodi.SelectedItem as GamingProizvod;

            txt_cenaProizvoda.Text = GamProizvod.cena.ToString();
            txt_modelProizvoda.Text = GamProizvod.model.ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                
                Narudzbenica nar = kreirajNarudzbenicu();

                

                Komunikacija.Instanca.SacuvajNarudzbenicu(nar);
                _listaStavki = new BindingList<StavkaNarudzbenice>();
                dgv_StavkeNarudzbenice.DataSource = _listaStavki;
                txt_datumOd.Text = "";
                txt_datumDo.Text = "";
                txt_ukupanIznos.Text = "";
                MessageBox.Show("Narudzbenica je kreirana");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private Narudzbenica kreirajNarudzbenicu()
        {

            MessageBox.Show(txt_datumDo.Text);
            DateTime datumOd = DateTime.ParseExact(txt_datumOd.Text, "M/d/yyyy", CultureInfo.InvariantCulture);
            DateTime datumDo = DateTime.ParseExact(txt_datumDo.Text, "M/d/yyyy", CultureInfo.InvariantCulture);

            return new Narudzbenica {
                Korisnik = korisnik,
                DatumOd = datumOd,
                DatumDo = datumDo,
                UkupanIznos = Convert.ToInt64(txt_ukupanIznos.Text),
                stavke = _listaStavki.ToList(),

            };
        }
    }
}
