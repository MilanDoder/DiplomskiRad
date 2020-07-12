using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klasa;
using System.IO;
using System.Diagnostics;

namespace Forme
{
    public partial class frm_glavna : Form
    {
        string _MybackgroungColor = "#222431";
        string _MyLetterColor = "#4eb8ce";
        private Zaposleni _z;

        

        private BindingList<Clan> _listaNaloga = new BindingList<Clan>();
        private BindingList<GamingProizvod> _listaGamingProizvoda = new BindingList<GamingProizvod>();
        private BindingList<Narudzbenica> _listaNarudzbenica = new BindingList<Narudzbenica>();
        private List<StavkaNarudzbenice> _listaStavkinarudzbenica =  new List<StavkaNarudzbenice>();
        // SystFbtnem.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#FFCC66");

        KontrolerKI kki = new KontrolerKI();
        KontrolerKINalog kkin = new KontrolerKINalog();

        public frm_glavna()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            pnl_left.Hide();
            dgv_podaci.Show();
            pnl_prikazElemenata.Size = new Size(0, 0);
        }

        public frm_glavna(Zaposleni z)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            pnl_left.Hide();
            _z = z;
            lbl_zaposleniIme.Text = _z.osoba.Ime + " " + _z.osoba.Prezime;

            btn_pretraga.Enabled = false;
        }

        

        private void lbl_imePrezimeZaposlenog_Click(object sender, EventArgs e)
        {

        }

        private void FrmGlForma_Load(object sender, EventArgs e)
        {
           // Komunikacija.Instanca.Osluskuj(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void btn_clanovi_Click(object sender, EventArgs e)
        {
            lbl_selektovaniNaziv.Text = btn_clanovi.ButtonText;
            try
            {
                kki.PostaviDesniPanel(btn_clanovi, btn_narudzbenica, btn_proizvodi, pnl_selektovanoDugme,
                                       pnl_left, btn_kreiraj, btn_promeni, btn_Obrisi, btn_pretraga);
                btn_kreiraj.ButtonText = "Kreiraj";
                btn_promeni.ButtonText = "Promeni";

                pnl_selektovanoDugme.Location = new Point(0, 109);
                ///Prikaz svih naloga                
                KontrolerKINalog.ucitajNaloge(dgv_podaci);
            }
            catch (InvalidCastException ex) {
                MessageBox.Show("Greska sa serverom?");
                Komunikacija.Instanca.PokreniLogin = true;
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri promeni selekcije");
               
            }
        }

        private void btn_narudzbenica_Click(object sender, EventArgs e)
        {
            lbl_selektovaniNaziv.Text = btn_narudzbenica.ButtonText;
            try
            {
                kki.PostaviDesniPanel(btn_clanovi, btn_narudzbenica, btn_proizvodi, pnl_selektovanoDugme,
                                       pnl_left, btn_kreiraj, btn_promeni, btn_Obrisi, btn_pretraga);

                btn_kreiraj.ButtonText = "Kreiraj";
                btn_promeni.ButtonText = "Ažuriraj";
                pnl_selektovanoDugme.Location = new Point(0, 147);

                KontrolerKINarudzbenica.ucitajNarudzbenice(dgv_podaci);
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Greska sa serverom?");
                Komunikacija.Instanca.PokreniLogin = true;
                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Greska pri promeni selekcije");                
            }
           
        }



        private void btn_proizvodi_Click(object sender, EventArgs e)
        {
            lbl_selektovaniNaziv.Text = btn_proizvodi.ButtonText;
            try
            {
                // System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#FFCC66");
                kki.PostaviDesniPanel(btn_clanovi, btn_narudzbenica, btn_proizvodi, pnl_selektovanoDugme,
                                       pnl_left, btn_kreiraj, btn_promeni, btn_Obrisi, btn_pretraga);


                btn_kreiraj.ButtonText = " Nov";
                btn_promeni.ButtonText = "Promeni";
                pnl_selektovanoDugme.Location = new Point(0, 185);

                KontrolerKIGamingProizvod.ucitajGamingProizvode(dgv_podaci);

            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Greska sa serverom?");
                Komunikacija.Instanca.PokreniLogin = true;
                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Greska pri promeni selekcije");
            }

        }

        private void btn_odjava_Click(object sender, EventArgs e)
        {
            Komunikacija.Instanca.PokreniLogin = true;
            this.Dispose();


            //Komunikacija.Instanca.odjaviSe();
            MessageBox.Show("Uspesno odjavljen!");
            //FrmPrijavljivanje prijava = new FrmPrijavljivanje();
            //this.Hide();
            //this.Owner = prijava;
            //prijava.Show();
           

        }

        private void btn_pretraga_TextChange(object sender, EventArgs e)
        {
            try
            {
                //Omoguca pretrazivanje naloga
                if (pnl_selektovanoDugme.Location.X.Equals(0) && pnl_selektovanoDugme.Location.Y.Equals(109))
                {
                    // object lista = Komunikacija.Instanca.pretragaNaloga(btn_pretraga.Text);
                    _listaNaloga = new BindingList<Clan>(Komunikacija.Instanca.pretragaNaloga(btn_pretraga.Text));

                    // _listaNaloga.Where(c => btn_pretraga.Text.ToLower().Contains(c.Adresa.ToLower().ToString()));
                    dgv_podaci.DataSource = (BindingList<Clan>)_listaNaloga;

                }
                if (pnl_selektovanoDugme.Location == (new Point(0, 147)))
                {
                    _listaNarudzbenica = new BindingList<Narudzbenica>(Komunikacija.Instanca.pretragaNarudzbenica(btn_pretraga.Text));
                    dgv_podaci.DataSource = _listaNarudzbenica;
                }
                //pretrazivanje proizvoda
                if (pnl_selektovanoDugme.Location == (new Point(0, 185)))
                {
                    _listaGamingProizvoda = new BindingList<GamingProizvod>(Komunikacija.Instanca.pretragaProizvoda(btn_pretraga.Text));
                    dgv_podaci.DataSource = _listaGamingProizvoda;
                    btn_pretraga.BackColor = Color.Green;
                }
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Greska sa serverom?");
                Komunikacija.Instanca.PokreniLogin = true;
                this.Dispose();
            }
            catch (Exception ex) {
                MessageBox.Show("Greska pri pretrazi.");               
            }
        }

        public Image stringToImage(string inputString)
        {
            byte[] imageBytes = Encoding.Unicode.GetBytes(inputString);

            // Don't need to use the constructor that takes the starting offset and length
            // as we're using the whole byte array.
            MemoryStream ms = new MemoryStream(imageBytes);

            Image image = Image.FromStream(ms, true, true);

            return image;
        }

        private void btn_kreiraj_Click(object sender, EventArgs e)
        {
            if (Komunikacija.Instanca == null) {
                MessageBox.Show("KOmunikacija ne postoji");
            }
            try
            {
                if (pnl_selektovanoDugme.Location == (new Point(0, 109)))
                {
                    if (Komunikacija.Instanca == null)
                    {
                        MessageBox.Show("KOmunikacija ne postoji ###");
                    }
                    FrmKreirajNalog kNalog = new FrmKreirajNalog();
                    kNalog.ShowDialog();
                    KontrolerKINalog.ucitajNaloge(dgv_podaci);                  
                   
                }
                if (pnl_selektovanoDugme.Location == new Point(0, 147))
                {
                    FrmNarudzbenica fNar = new FrmNarudzbenica();
                    fNar.ShowDialog();
                    KontrolerKINarudzbenica.ucitajNarudzbenice(dgv_podaci);
                }

                if (pnl_selektovanoDugme.Location == new Point(0, 185))
                {
                    FrmNovProizvod kProizvod = new FrmNovProizvod();
                    kProizvod.ShowDialog();
                    KontrolerKIGamingProizvod.ucitajGamingProizvode(dgv_podaci);
                }
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Greska sa serverom?");
                Komunikacija.Instanca.PokreniLogin = true;
                this.Dispose();
            }
            catch (Exception ex) {
                MessageBox.Show("Greska pri kreiranju!");
            }
        }
            
            
        

        private void btn_Obrisi_Click(object sender, EventArgs e)
        {
            if (pnl_selektovanoDugme.Location == new Point(0, 109)) {
                try
                {
                    Osoba os = KontrolerKINalog.vratiNalogIzForme(lbl_clanskiBrojIzabranogClana, lbl_OsobaIzabranogClana,txt_imeIzabranogClana, txt_prezimeIzabranogClana,
                                                                txt_telefonIzabranogClana, txt_emailIzbranogClana, txt_adresaIzabranogClana);
                    //todo
                    Clan cl = new Clan
                    {
                        ClanskiBroj = Convert.ToInt32(lbl_clanskiBrojIzabranogClana.Text),
                    };
                    if (Komunikacija.Instanca.ObrisiNalog(cl))
                    {
                        MessageBox.Show("Sistem je obrisao nalog");
                        pnl_prikazElemenata.Hide();
                        ukljuciDugmad();
                        _listaNaloga = new BindingList<Clan>(Komunikacija.Instanca.vratiSveNaloge());
                        dgv_podaci.DataSource = _listaNaloga;
                        dgv_podaci.Refresh();
                    }
                    else {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Sistem ne može da obriše nalog");
                }
                
                
            }
            if (pnl_selektovanoDugme.Location == new Point(0, 147)) {
                try
                {


                    Narudzbenica nar = vratiNarudzbenicuIzForme();

                    if (Komunikacija.Instanca.obrisiNarudzbenicu(nar))
                    {
                        MessageBox.Show("Sistem je obrisao narudzbinu");
                        pnl_narudzbenica.Hide();
                        ukljuciDugmad();
                        _listaNarudzbenica = new BindingList<Narudzbenica>(Komunikacija.Instanca.vratiSveNarudzbenice());
                        dgv_podaci.DataSource = _listaNarudzbenica;
                        dgv_podaci.Refresh();
                    }
                    else {
                        MessageBox.Show("Sistem ne može da obriše  narudzbinu");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            if (pnl_selektovanoDugme.Location == new Point(0, 185)) {
                try
                {
                    

                    GamingProizvod gp = vratiGamingProizvodIzPomocneForme();

                    if (Komunikacija.Instanca.obrisiGamingProizvod(gp)){
                        MessageBox.Show("Sistem je obrisao Gaming proizvod!");
                        pnl_izabraniGamingProizvod.Hide();
                        ukljuciDugmad();
                        _listaGamingProizvoda = new BindingList<GamingProizvod>(Komunikacija.Instanca.ucitajGamingProizvode());
                        dgv_podaci.DataSource = _listaGamingProizvoda;
                        dgv_podaci.Refresh();
                    }
                    else {
                        MessageBox.Show("Sistem ne može da izbriše Gaming proizvod ");
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private Narudzbenica vratiNarudzbenicuIzForme()
        {
            return new Narudzbenica {
                Korisnik = Komunikacija.Instanca.vratiNalogPoUslovu(lbl_clanskiNalog.Text),
                DatumOd = Convert.ToDateTime(txt_DatumODNarudzbenica.Text),
                DatumDo = Convert.ToDateTime(txt_datumDONarudzbenica.Text),
                SifraNarudzbenice = Convert.ToInt32(lbl_sifraNarudzbenice.Text),
                UkupanIznos = Convert.ToInt64(txt_ukupanIznos.Text),
                stavke = _listaStavkinarudzbenica,
            };
            
        }


        private void obrisiGamingProizvod()
        {

            try
            {
                GamingProizvod proizvod = new GamingProizvod
                {
                    proizvodID = Convert.ToInt32(lbl_ProizvodID.Text)
                };

            //    if (kontroler.kontroler.instanca.obrisigamingproizvod(proizvod))
            //        //{
            //        messagebox.show("sistem je obrisao gaming proizvod.");
            //    pnl_izabranigamingproizvod.visible = false;
            //    ukljucidugmad();
            //    _listagamingproizvoda = new bindinglist<gamingproizvod>(kontroler.kontroler.instanca.ucitajgamingproizvode());
            //    dgv_podaci.datasource = _listagamingproizvoda;
            //    dgv_podaci.refresh();



            //}
            //    else {
            //    throw new exception();
            //}


        }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da obrise Gaming proizvod.");
            }
        }

        
        private void btn_promeni_Click(object sender, EventArgs e)
        {
            ///U pitanju su nalozi
            if (pnl_selektovanoDugme.Location == new Point(0, 109))
            {
                try
                {                   
                    Osoba os = KontrolerKINalog.vratiNalogIzForme(lbl_clanskiBrojIzabranogClana,lbl_OsobaIzabranogClana,txt_imeIzabranogClana,txt_prezimeIzabranogClana,
                                                                txt_telefonIzabranogClana,txt_emailIzbranogClana,txt_adresaIzabranogClana);
                    if (Komunikacija.Instanca.promeniOsobu(os))
                    {
                        MessageBox.Show("Nalog je promenjen!");                        
                        pnl_prikazElemenata.Hide();
                        ukljuciDugmad();
                        KontrolerKINalog.ucitajNaloge(dgv_podaci);
                    }
                    else {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Sistem ne moze da promeni nalog!");
                }
                dgv_podaci.Refresh();


            } else if (pnl_selektovanoDugme.Location == new Point(0, 147)) {

                try
                {                                
                    Narudzbenica n = vratiNarudzbenicuIzForme();
                    if (Komunikacija.Instanca.azurirajNarudzbenicu(n))
                    {
                        MessageBox.Show("Narudzbina je azurirana!");
                        pnl_narudzbenica.Hide();
                        ukljuciDugmad();
                        KontrolerKINarudzbenica.ucitajNarudzbenice(dgv_podaci);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Sistem ne može da ažurira narudzbinu");
                }



            } else if (pnl_selektovanoDugme.Location == new Point(0,185)) {
                try
                {
                    GamingProizvod g = vratiGamingProizvodIzPomocneForme();
                    MessageBox.Show("Proizvod : \n" + g.Naziv + "\n " + g.proizvodID + "\nProizvodjac : \n" + g.proizvodjac.ProizvodjacID + "\n" + g.proizvodjac.Naziv);

                    if (Komunikacija.Instanca.promeniGamingProizvod(g))
                    {
                        MessageBox.Show("Uspesno je promenjen Gaming Proizvod!");
                        pnl_izabraniGamingProizvod.Hide();
                        ukljuciDugmad();
                        KontrolerKIGamingProizvod.ucitajGamingProizvode(dgv_podaci);
                    }
                    else {

                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private GamingProizvod vratiGamingProizvodIzPomocneForme()
        {
            return new GamingProizvod
            {
                proizvodID = Convert.ToInt32(lbl_ProizvodID.Text),
                model = lbl_modelGProizvoda.Text,
                cena = Convert.ToInt32(txt_cenaIzabranogGamingProizvoda.Text),
                Naziv = lbl_nazivGProizvoda.Text,
                karakteristike = txt_karakteristikeIzabranogGamingProizvoda.Text,
                raspolozivoStanje = Convert.ToInt32(txt_kolicinaIzabranogGamingProizvoda.Text),
                proizvodjac = new Proizvodjac
                {
                    ProizvodjacID = Convert.ToInt32(lbl_proizvodjacID.Text),
                    Naziv = lbl_nazivProizvodjacaIzbProizvoda.Text,
                    Adresa = txt_adresaIzabranogProizvodjaca.Text,
                    Telefon = txt_telefonIzabranogProizvodjac.Text
                }


            };
        }

       

        private void prikazGamingProizvoda(GamingProizvod gproizvod)
        {
            lbl_ProizvodID.Text = gproizvod.proizvodID.ToString();
            lbl_nazivGProizvoda.Text = gproizvod.Naziv;
            lbl_modelGProizvoda.Text = gproizvod.model;
            lbl_nazivProizvodjacaIzbProizvoda.Text = gproizvod.proizvodjac.Naziv;
            txt_cenaIzabranogGamingProizvoda.Text = gproizvod.cena.ToString();
            txt_kolicinaIzabranogGamingProizvoda.Text = gproizvod.raspolozivoStanje.ToString();
            txt_karakteristikeIzabranogGamingProizvoda.Text = gproizvod.karakteristike;

            txt_telefonIzabranogProizvodjac.Text = gproizvod.proizvodjac.Telefon;
            txt_adresaIzabranogProizvodjaca.Text = gproizvod.proizvodjac.Adresa;

           
          
        }

        private GamingProizvod vratiGamingProizvod(int idProizvod)
        {
            foreach (var proizvod in _listaGamingProizvoda) {
                if (proizvod.proizvodID == idProizvod) {
                    return proizvod;
                }
            }
            return null;
        }

        /// <summary>
        /// Forma za unos novog clana 
        /// Njen prikaz
        /// </summary>
        /// <param name="n"></param>
        private void pozoviFormuZaPromenuNaloga(Clan n) {
            lbl_OsobaIzabranogClana.Text = n.osoba.OsobaId.ToString();
            lbl_clanskiBrojIzabranogClana.Text = n.ClanskiBroj.ToString();
            txt_imeIzabranogClana.Text = n.osoba.Ime;
            txt_prezimeIzabranogClana.Text = n.osoba.Prezime;
            //txt_imeIzabranogClana.Text = n.ImePrezime.Substring(0, n.ImePrezime.IndexOf(" "));
            //txt_prezimeIzabranogClana.Text = n.ImePrezime.Substring(n.ImePrezime.IndexOf(" ") + 1);
            txt_telefonIzabranogClana.Text = n.osoba.Telefon;
            //TO DO EMAIL
            txt_emailIzbranogClana.Text = n.osoba.Email;
            txt_adresaIzabranogClana.Text = n.osoba.Adresa;
        }

        /// <summary>
        /// Za sada ne potrebna
        /// </summary>
        /// <returns></returns>
        private Clan napraviNalogPrekoTabele(DataGridViewCellEventArgs e) {
            return new Clan {
                ClanskiBroj = Convert.ToInt32(dgv_podaci.Rows[e.RowIndex].Cells[0].Value.ToString()),
                osoba = new Osoba { 
                    Ime = dgv_podaci.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Prezime = dgv_podaci.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Telefon = dgv_podaci.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Adresa = dgv_podaci.Rows[e.RowIndex].Cells[4].Value.ToString()
                },
                
                
            };
        }

        private void IskljuciDugmad()
        {
            btn_kreiraj.Enabled = false;
            btn_promeni.Enabled = true;
            btn_Obrisi.Enabled = true;
            btn_proizvodi.Enabled = false;
            btn_narudzbenica.Enabled = false;
            btn_odjava.Enabled = false;
            btn_clanovi.Enabled = false;
            btn_pretraga.Enabled = false;
        }
        private void ukljuciDugmad()
        {
            btn_kreiraj.Enabled = true;
            btn_promeni.Enabled = false;
            btn_Obrisi.Enabled = false;
            btn_proizvodi.Enabled = true;
            btn_narudzbenica.Enabled = true;
            btn_odjava.Enabled = true;
            btn_clanovi.Enabled = true;
            btn_pretraga.Enabled = true;
        }


        private void btn_ponistiPromene_Click(object sender, EventArgs e)
        {

            ukljuciDugmad();
            pnl_prikazElemenata.Hide();
            
        }

        private void btn_nazadProizvod_Click(object sender, EventArgs e)
        {
            ukljuciDugmad();
            pnl_izabraniGamingProizvod.Visible = false;
        }


        /// <summary>
        /// Popraviti nacin za brisanje clanova
        /// obratiti paznju na narudzbenicu i pproizvod
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


       

        

        private void lbl_plusMinusKar_Click(object sender, EventArgs e)
        {
            if (lbl_plusMinusKar.Text == "+") {

                KontrolerKIGamingProizvod.PrikaziPodatkeOProizvodu(lbl_plusMinusKar, txt_karakteristikeIzabranogGamingProizvoda, pnl_plusUMinusProizvodjac, pnl_plusUMinusKarakteristike,
                           lbl_proizvodjacIzbProizvda, lbl_nazivProizvodjacaIzbProizvoda, pnl_podaciIzabranogProizvodjaca);
                //lbl_plusMinusKar.Text = "-";
                //txt_karakteristikeIzabranogGamingProizvoda.Visible = true;
                //pnl_plusUMinusProizvodjac.Location = new Point(pnl_plusUMinusKarakteristike.Location.X,pnl_plusUMinusKarakteristike.Location.Y+95);
                //lbl_proizvodjacIzbProizvda.Location = new Point(pnl_plusUMinusKarakteristike.Location.X+26, pnl_plusUMinusKarakteristike.Location.Y + 95);
                //lbl_nazivProizvodjacaIzbProizvoda.Location = new Point(lbl_proizvodjacIzbProizvda.Location.X + 84, lbl_proizvodjacIzbProizvda.Location.Y + 10);
                //pnl_podaciIzabranogProizvodjaca.Location = new Point(lbl_proizvodjacIzbProizvda.Location.X + 5, lbl_proizvodjacIzbProizvda.Location.Y + 28);
            }
            else {
                KontrolerKIGamingProizvod.SakrijPodatkeOProizvodu(lbl_plusMinusKar, txt_karakteristikeIzabranogGamingProizvoda, pnl_plusUMinusProizvodjac, pnl_plusUMinusKarakteristike,
                           lbl_proizvodjacIzbProizvda, lbl_nazivProizvodjacaIzbProizvoda, pnl_podaciIzabranogProizvodjaca);
                //lbl_plusMinusKar.Text = "+";
                //pnl_plusUMinusProizvodjac.Location = new Point(pnl_plusUMinusKarakteristike.Location.X, pnl_plusUMinusKarakteristike.Location.Y+42);
                //txt_karakteristikeIzabranogGamingProizvoda.Visible = false;
                //lbl_proizvodjacIzbProizvda.Location = new Point(pnl_plusUMinusKarakteristike.Location.X + 26, pnl_plusUMinusKarakteristike.Location.Y + 42);
                //lbl_nazivProizvodjacaIzbProizvoda.Location = new Point(lbl_proizvodjacIzbProizvda.Location.X + 84, lbl_proizvodjacIzbProizvda.Location.Y + 10);
                //pnl_podaciIzabranogProizvodjaca.Location = new Point(lbl_proizvodjacIzbProizvda.Location.X + 5, lbl_proizvodjacIzbProizvda.Location.Y + 28);

            }
        }

        private void lbl_minusUPlusProiz_Click(object sender, EventArgs e)
        {
            if (lbl_minusUPlusProiz.Text == "+")
            {
                lbl_minusUPlusProiz.Text = "-";
                if (lbl_plusMinusKar.Text == "+")
                {
                    //promeni poziciju gore
                    pnl_podaciIzabranogProizvodjaca.Location = new Point(lbl_proizvodjacIzbProizvda.Location.X + 5, lbl_proizvodjacIzbProizvda.Location.Y + 28);
                }
                if (lbl_plusMinusKar.Text == "-") {
                    pnl_podaciIzabranogProizvodjaca.Location = new Point(lbl_proizvodjacIzbProizvda.Location.X + 5, lbl_proizvodjacIzbProizvda.Location.Y + 28);

                }

                pnl_podaciIzabranogProizvodjaca.Visible = true;
               
            }
            else {
                lbl_minusUPlusProiz.Text = "+";
                pnl_podaciIzabranogProizvodjaca.Visible = false;
                pnl_podaciIzabranogProizvodjaca.Location = new Point(lbl_proizvodjacIzbProizvda.Location.X + 5, lbl_proizvodjacIzbProizvda.Location.Y + 28);

            }
        }

        private void dgv_podaci_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (pnl_selektovanoDugme.Location == new Point(0, 109))
                {
                        Clan n = Komunikacija.Instanca.vratiNalogPoUslovu(((Clan)dgv_podaci.Rows[e.RowIndex].DataBoundItem).ClanskiBroj.ToString());
                        KontrolerKINalog.nalog = n;
                        KontrolerKINalog.prikazNaloga(pnl_prikazElemenata, lbl_clanskiBrojIzabranogClana, lbl_OsobaIzabranogClana, txt_imeIzabranogClana, txt_prezimeIzabranogClana,
                            txt_telefonIzabranogClana, txt_emailIzbranogClana, txt_adresaIzabranogClana);
                        IskljuciDugmad();
                }
                else if (pnl_selektovanoDugme.Location == new Point(0, 147))
                {
                        //Narudzbenica n = vratiNarudzbenicuIzListe(((Narudzbenica)dgv_podaci.Rows[e.RowIndex].DataBoundItem).SifraNarudzbenice);
                        Narudzbenica na = Komunikacija.Instanca.vratiNarudzbenicu(((Narudzbenica)dgv_podaci.Rows[e.RowIndex].DataBoundItem).SifraNarudzbenice.ToString());
                        na.Korisnik = Komunikacija.Instanca.vratiNalogPoUslovu(na.Korisnik.ClanskiBroj.ToString());
                        Debug.WriteLine("" + na.SifraNarudzbenice);
                        na.stavke = Komunikacija.Instanca.vratiStavkeNarudzbenice(na.SifraNarudzbenice);
                        //pnl_narudzbenica.Show();
                        // pnl_narudzbenica.Size = new Size(448,291);
                        //pozoviFormuZaNarudzbenicu(na);
                        
                        KontrolerKINarudzbenica.narudzbenica = na;
                        KontrolerKINarudzbenica.prikazNarudzbenice(pnl_narudzbenica, txt_ImePrezimeClanaNarudzbenica, txt_emailClanaNarudzbenica, txt_telefonClanaNarudzbenica,
                            lbl_clanskiNalog, lbl_sifraNarudzbenice, txt_DatumODNarudzbenica, txt_datumDONarudzbenica, txt_ukupanIznos, dgv_stavkeNarudzbenice);

                        IskljuciDugmad();
                        _listaStavkinarudzbenica = na.stavke;
                }
                else if (pnl_selektovanoDugme.Location == new Point(0, 185))
                {


                    GamingProizvod proizvod = Komunikacija.Instanca.vratiProizvod(((GamingProizvod)dgv_podaci.Rows[e.RowIndex].DataBoundItem).proizvodID.ToString());
                    proizvod.proizvodjac = Komunikacija.Instanca.vratiProizvodjaca(proizvod.proizvodjac.ProizvodjacID.ToString());
                    KontrolerKIGamingProizvod.proizvod = proizvod;

                    KontrolerKIGamingProizvod.prikazGamingProizvoda(pnl_izabraniGamingProizvod, lbl_nazivGProizvoda, lbl_modelGProizvoda, txt_cenaIzabranogGamingProizvoda, txt_karakteristikeIzabranogGamingProizvoda,
                        txt_kolicinaIzabranogGamingProizvoda, lbl_nazivProizvodjacaIzbProizvoda, txt_telefonIzabranogProizvodjac, txt_adresaIzabranogProizvodjaca, lbl_ProizvodID, lbl_proizvodjacID);
                    IskljuciDugmad();
                }


            }
            catch (InvalidCastException ex) {
                MessageBox.Show("Greska sa serverom!");
                Komunikacija.Instanca.PokreniLogin = true;
                this.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sistem ne može da pronađe odabranu stavku");
            }
        
        }

        private Narudzbenica vratiNarudzbenicuIzListe(int sifraNarudzbenice)
        {
            foreach (Narudzbenica nar in _listaNarudzbenica)
            {
                if (nar.SifraNarudzbenice == sifraNarudzbenice) {
                    return nar;
                }
            }
            return null;
        }

        private void pozoviFormuZaNarudzbenicu(Narudzbenica n)
        {
            txt_ImePrezimeClanaNarudzbenica.Text = n.Korisnik.ToString();
            //TO DO EMAIL
            txt_emailClanaNarudzbenica.Text = n.Korisnik.osoba.Email;
            txt_telefonClanaNarudzbenica.Text = n.Korisnik.osoba.Telefon;
            lbl_clanskiNalog.Text = n.Korisnik.ClanskiBroj.ToString();

            lbl_sifraNarudzbenice.Text = n.SifraNarudzbenice.ToString();

            txt_DatumODNarudzbenica.Text = n.DatumOd.ToShortDateString();
            txt_datumDONarudzbenica.Text = n.DatumDo.ToShortDateString();
            txt_ukupanIznos.Text = n.UkupanIznos.ToString();

            dgv_stavkeNarudzbenice.DataSource = n.stavke;
            _listaStavkinarudzbenica = n.stavke;
        }

        private void pozoviFormuZaGamingProizvod(GamingProizvod proizvod)
        {
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

       

        private void btn_ponistiNarudzbenicu_Click(object sender, EventArgs e)
        {
            ukljuciDugmad();
            pnl_narudzbenica.Hide();

        }

        private void frm_glavna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Komunikacija.Instanca.Kraj();
        }


    }
}
