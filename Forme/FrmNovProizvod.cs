using Klasa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FrmNovProizvod : Form
    {
        public FrmNovProizvod()
        {
            InitializeComponent();
            KontrolerKIGamingProizvod.ucitajProizvodjace(cbx_proizvodjaci);
        }

        private void FrmNovProizvod_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
           
            frm_glavna glavna = new frm_glavna();
            this.Hide();
            glavna.Show();
            this.Owner = glavna;


        }

        private void btn_sacuvajProizvod_Click(object sender, EventArgs e)
        {

            try
            {
                GamingProizvod g = new GamingProizvod();

                
                g.Naziv = txt_nazivProizvoda.Text;
                g.karakteristike = txt_karakteristike.Text;
                g.model = txt_modelProizvoda.Text;
                g.cena = Convert.ToInt64(txt_cenaProizvoda.Text);
                g.raspolozivoStanje = Convert.ToInt32(txt_kolicina.Text);
                g.proizvodjac = new Proizvodjac()
                {
                    Naziv = cbx_proizvodjaci.SelectedItem.ToString(),
                };

                
                if (Komunikacija.Instanca.kreirajProizvod(g))
                {
                    MessageBox.Show("Sistem je uneo Gaming proizvod");
                 
                    frm_glavna glavna = new frm_glavna();
                    this.Hide();
                    glavna.Show();
                    this.Owner = glavna;
                }
                else {
                    throw new Exception();
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da unese dati proizvod");
            }
        }
    }
}
