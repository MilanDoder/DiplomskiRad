using Klasa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FrmPrijavljivanje : Form
    {
        KontrolerKI kki = new KontrolerKI();

        public FrmPrijavljivanje()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmPrijavljivanje_Load(object sender, EventArgs e)
        {
            GraphicsPath eclipseRadius = new GraphicsPath();

            eclipseRadius.StartFigure();
            eclipseRadius.AddArc(new Rectangle(0, 0, 20, 20), 180, 90);
            eclipseRadius.AddLine(20, 0, btn_potvrdi.Width - 20, 0);
            eclipseRadius.AddArc(new Rectangle(btn_potvrdi.Width-20, 0, 20, 20), -90,90);
            eclipseRadius.AddLine(btn_potvrdi.Width, 20, btn_potvrdi.Width, btn_potvrdi.Height-20);
            eclipseRadius.AddArc(new Rectangle(btn_potvrdi.Width-20,btn_potvrdi.Height-20,20,20), 0,90);
            eclipseRadius.AddLine(btn_potvrdi.Width-20, btn_potvrdi.Height,20,btn_potvrdi.Height);
            eclipseRadius.AddArc(new Rectangle(0, btn_potvrdi.Height-20, 20, 20), 90, 90);
            
            eclipseRadius.CloseFigure();

            btn_potvrdi.Region = new Region(eclipseRadius);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_potvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                Komunikacija.Instanca.poveziSeSaServerom();
                Zaposleni z = (Zaposleni)kki.PrijavljivanjeZaposlenog(txt_Username, txt_password);
               
                this.Hide();
                frm_glavna gf = new frm_glavna(z);

                this.Owner = gf;
                gf.ShowDialog();
            }
            catch (Exception ex)
            {
                Komunikacija.Instanca.PokreniLogin = true;
                MessageBox.Show("Greska pri prijavljivanju!");
                //MessageBox.Show(ex.Message);
            }
            
            
        }

        /// <summary>
        /// Enxryption RSA
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="RSAKey"></param>
        /// <param name="DoOAEPPadding"></param>
        /// <returns></returns>
        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey); encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        /// <summary>
        /// Decryption
        ///
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="RSAKey"></param>
        /// <param name="DoOAEPPadding"></param>
        /// <returns></returns>
        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

       
    }
}
