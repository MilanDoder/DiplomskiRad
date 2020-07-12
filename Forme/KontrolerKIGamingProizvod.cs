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
    public class KontrolerKIGamingProizvod
    {
        private static object _listaGamingProizvoda;
        public static GamingProizvod proizvod { get; set; }

        public static void ucitajGamingProizvode(DataGridView dgv_podaci) {
            _listaGamingProizvoda = new BindingList<GamingProizvod>(Komunikacija.Instanca.ucitajGamingProizvode());
            dgv_podaci.DataSource = _listaGamingProizvoda;
            dgv_podaci.Refresh();

        }

        public static void ucitajProizvodjace(ComboBox cbx_proizvodjaci) {
            try
            {
                IList<Proizvodjac> listaProizvodjaca = new List<Proizvodjac>();
                listaProizvodjaca = Komunikacija.Instanca.vratiProizvodjace();
                cbx_proizvodjaci.DataSource = listaProizvodjaca;
                cbx_proizvodjaci.DisplayMember = "Naziv";
                cbx_proizvodjaci.ValueMember = "ProizvodjacID";
            }
            catch (Exception ex) {
                MessageBox.Show("Greska. Zatvorite formu!");
            }

        }

        public static void prikazGamingProizvoda(Panel pnl_izabraniGamingProizvod, Label lbl_nazivGProizvoda,Label lbl_modelGProizvoda,TextBox txt_cenaIzabranogGamingProizvoda, TextBox txt_karakteristikeIzabranogGamingProizvoda,
            TextBox txt_kolicinaIzabranogGamingProizvoda, Label lbl_nazivProizvodjacaIzbProizvoda,TextBox txt_telefonIzabranogProizvodjac, TextBox txt_adresaIzabranogProizvodjaca,
            Label lbl_ProizvodID, Label lbl_proizvodjacID) {


            pnl_izabraniGamingProizvod.Show();
            pnl_izabraniGamingProizvod.Size = new Size(447, 255);

            lbl_nazivGProizvoda.Text = proizvod.Naziv;
            lbl_modelGProizvoda.Text = proizvod.model;
            txt_cenaIzabranogGamingProizvoda.Text = proizvod.cena.ToString();
            txt_karakteristikeIzabranogGamingProizvoda.Text = proizvod.karakteristike.ToString();
            txt_kolicinaIzabranogGamingProizvoda.Text = proizvod.raspolozivoStanje.ToString();
            lbl_nazivProizvodjacaIzbProizvoda.Text = proizvod.proizvodjac.Naziv;
            txt_telefonIzabranogProizvodjac.Text = proizvod.proizvodjac.Telefon;
            txt_adresaIzabranogProizvodjaca.Text = proizvod.proizvodjac.Adresa;
            lbl_ProizvodID.Text = proizvod.proizvodID.ToString();
            lbl_proizvodjacID.Text = proizvod.proizvodjac.ProizvodjacID.ToString();
        }



        public static void  PrikaziPodatkeOProizvodu(Label lbl_plusMinusKar,TextBox txt_karakteristikeIzabranogGamingProizvoda, Panel pnl_plusUMinusProizvodjac,Panel pnl_plusUMinusKarakteristike,
                            Label lbl_proizvodjacIzbProizvda,  Label lbl_nazivProizvodjacaIzbProizvoda, Panel pnl_podaciIzabranogProizvodjaca) {
            lbl_plusMinusKar.Text = "-";
            txt_karakteristikeIzabranogGamingProizvoda.Visible = true;
            pnl_plusUMinusProizvodjac.Location = new Point(pnl_plusUMinusKarakteristike.Location.X, pnl_plusUMinusKarakteristike.Location.Y + 95);
            lbl_proizvodjacIzbProizvda.Location = new Point(pnl_plusUMinusKarakteristike.Location.X + 26, pnl_plusUMinusKarakteristike.Location.Y + 95);
            lbl_nazivProizvodjacaIzbProizvoda.Location = new Point(lbl_proizvodjacIzbProizvda.Location.X + 84, lbl_proizvodjacIzbProizvda.Location.Y + 10);
            pnl_podaciIzabranogProizvodjaca.Location = new Point(lbl_proizvodjacIzbProizvda.Location.X + 5, lbl_proizvodjacIzbProizvda.Location.Y + 28);

        }

        public static void SakrijPodatkeOProizvodu(Label lbl_plusMinusKar, TextBox txt_karakteristikeIzabranogGamingProizvoda, Panel pnl_plusUMinusProizvodjac, Panel pnl_plusUMinusKarakteristike,
                            Label lbl_proizvodjacIzbProizvda, Label lbl_nazivProizvodjacaIzbProizvoda, Panel pnl_podaciIzabranogProizvodjaca) {


            lbl_plusMinusKar.Text = "+";
            pnl_plusUMinusProizvodjac.Location = new Point(pnl_plusUMinusKarakteristike.Location.X, pnl_plusUMinusKarakteristike.Location.Y + 42);
            txt_karakteristikeIzabranogGamingProizvoda.Visible = false;
            lbl_proizvodjacIzbProizvda.Location = new Point(pnl_plusUMinusKarakteristike.Location.X + 26, pnl_plusUMinusKarakteristike.Location.Y + 42);
            lbl_nazivProizvodjacaIzbProizvoda.Location = new Point(lbl_proizvodjacIzbProizvda.Location.X + 84, lbl_proizvodjacIzbProizvda.Location.Y + 10);
            pnl_podaciIzabranogProizvodjaca.Location = new Point(lbl_proizvodjacIzbProizvda.Location.X + 5, lbl_proizvodjacIzbProizvda.Location.Y + 28);
        }

    }
}
