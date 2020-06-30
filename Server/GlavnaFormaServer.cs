using Klasa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class GlavnaFormaServer : Form
    {
        private Server s;
        //private static BindingList<Zaposleni> _listaZaposlenih = new BindingList<Zaposleni>();
        public static int brojZaposlenih = 0;
       
        public GlavnaFormaServer()
        {
            InitializeComponent();
            s = new Server();
        }

        private void btn_pokreniServer_Click(object sender, EventArgs e)
        {
            s = new Server();
            Thread serverskaNit = new Thread(s.PokreniServer);
            serverskaNit.Start();
            serverskaNit.IsBackground = true;
            MessageBox.Show("Server pokrenut!");

        }

        private void GlavnaFormaServer_Load(object sender, EventArgs e)
        {

            Thread nitVreme = new Thread(PrikaziVremeNaServeru);
            nitVreme.Start();
            Thread nitZaposlenihServer = new Thread(PromeniBrojZaposlenih);
            nitZaposlenihServer.Start();
            nitZaposlenihServer.IsBackground = true;
            /*
            s._povezaniZaposleni.ListChanged += (o, args) =>
            {
                
                dgv_PrijavljeniKorisnici.Invoke(new Action(() =>
                {
                    dgv_PrijavljeniKorisnici.DataSource = new BindingList<Zaposleni>(s._listaPrijavljenihZaposlenih);
                }));

                lbl_brojKorinika.Invoke(new Action(() => {
                    lbl_brojKorinika.Text = $"Korisnici na serveru ({s._listaPrijavljenihZaposlenih.Count})";

                }));
            };
            */
        }
        
        private void PromeniBrojZaposlenih()
        {
            try
            {
                while (true)
                {
                    this.Invoke(new Action(() => {

                        lbl_brojKorinika.Text = $"Korisnici na serveru ({brojZaposlenih})";
                        dgv_PrijavljeniKorisnici.DataSource = s._listaPrijavljenihZaposlenih;


                    }
                    ));
                    Thread.Sleep(10000);
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }
        }
        
        private void PrikaziVremeNaServeru()
        {
            try
            {
                while (true)
                {
                    this.Invoke(new Action(() =>
                    {
                        lbl_vremeNaServeru.Text = DateTime.Now.ToLongTimeString();
                    }));
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }
            
        }

        

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void lbl_spisakZaposlenih_Click(object sender, EventArgs e)
        {
            if (lbl_spisakZaposlenih.Text == "+")
            {
                lbl_spisakZaposlenih.Text = "-";
                this.Size = new Size(284, 255);
                dgv_PrijavljeniKorisnici.Visible = true;
                dgv_PrijavljeniKorisnici.DataSource = s._listaPrijavljenihZaposlenih;
            }
            else {
                lbl_spisakZaposlenih.Text = "+";
                this.Size = new Size(284,138);
                dgv_PrijavljeniKorisnici.Visible = false;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnb_turnOn_Click(object sender, EventArgs e)
        {
            try
            {
               
                Thread serverskaNit = new Thread(s.PokreniServer);
                serverskaNit.Start();
                btn_turnOff.Location = new Point(109, 12);
                MessageBox.Show("Server pokrenut!");
                btn_turnOff.Visible = true;
                btnb_turnOn.Visible = false;

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
            
        }

        private void btn_turnOff_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Zaustavljen server!");
                s.ZaustaviServer();
                btn_turnOff.Visible = false;
                btnb_turnOn.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
