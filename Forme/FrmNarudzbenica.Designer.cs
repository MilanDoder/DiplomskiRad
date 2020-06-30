namespace Forme
{
    partial class FrmNarudzbenica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNarudzbenica));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_korisnikClan = new System.Windows.Forms.ComboBox();
            this.cbx_proizvodi = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cenaProizvoda = new System.Windows.Forms.TextBox();
            this.txt_modelProizvoda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_kolicinaProizvoda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_StavkeNarudzbenice = new System.Windows.Forms.DataGridView();
            this.btn_sacuvajProizvod = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_ukupanIznos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_closeNarudzbenica = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_datumOd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_datumDo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mcal_datumOd = new System.Windows.Forms.MonthCalendar();
            this.mcal_DatumDo = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StavkeNarudzbenice)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forme.Properties.Resources.NotesIcon11;
            this.pictureBox1.Location = new System.Drawing.Point(104, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(175, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Narudzbenica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Korisnik :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(27, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 3;
            // 
            // cbx_korisnikClan
            // 
            this.cbx_korisnikClan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_korisnikClan.FormattingEnabled = true;
            this.cbx_korisnikClan.Location = new System.Drawing.Point(104, 86);
            this.cbx_korisnikClan.Name = "cbx_korisnikClan";
            this.cbx_korisnikClan.Size = new System.Drawing.Size(173, 21);
            this.cbx_korisnikClan.TabIndex = 4;
            this.cbx_korisnikClan.SelectedIndexChanged += new System.EventHandler(this.cbx_korisnikClan_SelectedIndexChanged);
            // 
            // cbx_proizvodi
            // 
            this.cbx_proizvodi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_proizvodi.FormattingEnabled = true;
            this.cbx_proizvodi.Location = new System.Drawing.Point(104, 156);
            this.cbx_proizvodi.Name = "cbx_proizvodi";
            this.cbx_proizvodi.Size = new System.Drawing.Size(173, 21);
            this.cbx_proizvodi.TabIndex = 7;
            this.cbx_proizvodi.SelectedIndexChanged += new System.EventHandler(this.cbx_proizvodi_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(27, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Proizvod :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(218, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cena :";
            // 
            // txt_cenaProizvoda
            // 
            this.txt_cenaProizvoda.Enabled = false;
            this.txt_cenaProizvoda.Location = new System.Drawing.Point(300, 264);
            this.txt_cenaProizvoda.Name = "txt_cenaProizvoda";
            this.txt_cenaProizvoda.Size = new System.Drawing.Size(69, 20);
            this.txt_cenaProizvoda.TabIndex = 9;
            // 
            // txt_modelProizvoda
            // 
            this.txt_modelProizvoda.Enabled = false;
            this.txt_modelProizvoda.Location = new System.Drawing.Point(300, 213);
            this.txt_modelProizvoda.Name = "txt_modelProizvoda";
            this.txt_modelProizvoda.Size = new System.Drawing.Size(69, 20);
            this.txt_modelProizvoda.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(218, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Model :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(223, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 1);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(223, 290);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(146, 1);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(27, 340);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(146, 1);
            this.panel5.TabIndex = 16;
            // 
            // txt_kolicinaProizvoda
            // 
            this.txt_kolicinaProizvoda.Location = new System.Drawing.Point(104, 315);
            this.txt_kolicinaProizvoda.Name = "txt_kolicinaProizvoda";
            this.txt_kolicinaProizvoda.Size = new System.Drawing.Size(69, 20);
            this.txt_kolicinaProizvoda.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kolicina :";
            // 
            // dgv_StavkeNarudzbenice
            // 
            this.dgv_StavkeNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StavkeNarudzbenice.Location = new System.Drawing.Point(27, 436);
            this.dgv_StavkeNarudzbenice.Name = "dgv_StavkeNarudzbenice";
            this.dgv_StavkeNarudzbenice.Size = new System.Drawing.Size(406, 150);
            this.dgv_StavkeNarudzbenice.TabIndex = 17;
            // 
            // btn_sacuvajProizvod
            // 
            this.btn_sacuvajProizvod.ActiveBorderThickness = 1;
            this.btn_sacuvajProizvod.ActiveCornerRadius = 20;
            this.btn_sacuvajProizvod.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(203)))), ((int)(((byte)(219)))));
            this.btn_sacuvajProizvod.ActiveForecolor = System.Drawing.Color.White;
            this.btn_sacuvajProizvod.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btn_sacuvajProizvod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btn_sacuvajProizvod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sacuvajProizvod.BackgroundImage")));
            this.btn_sacuvajProizvod.ButtonText = "Dodaj";
            this.btn_sacuvajProizvod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sacuvajProizvod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sacuvajProizvod.ForeColor = System.Drawing.Color.White;
            this.btn_sacuvajProizvod.IdleBorderThickness = 1;
            this.btn_sacuvajProizvod.IdleCornerRadius = 20;
            this.btn_sacuvajProizvod.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_sacuvajProizvod.IdleForecolor = System.Drawing.Color.White;
            this.btn_sacuvajProizvod.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btn_sacuvajProizvod.Location = new System.Drawing.Point(237, 390);
            this.btn_sacuvajProizvod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sacuvajProizvod.Name = "btn_sacuvajProizvod";
            this.btn_sacuvajProizvod.Size = new System.Drawing.Size(95, 38);
            this.btn_sacuvajProizvod.TabIndex = 21;
            this.btn_sacuvajProizvod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sacuvajProizvod.Click += new System.EventHandler(this.btn_sacuvajProizvod_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(203)))), ((int)(((byte)(219)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Sačuvaj";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(337, 594);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(95, 38);
            this.bunifuThinButton21.TabIndex = 22;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(203)))), ((int)(((byte)(219)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Izbriši";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(338, 390);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(95, 38);
            this.bunifuThinButton22.TabIndex = 23;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(27, 629);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(146, 1);
            this.panel6.TabIndex = 19;
            // 
            // txt_ukupanIznos
            // 
            this.txt_ukupanIznos.Enabled = false;
            this.txt_ukupanIznos.Location = new System.Drawing.Point(104, 604);
            this.txt_ukupanIznos.Name = "txt_ukupanIznos";
            this.txt_ukupanIznos.Size = new System.Drawing.Size(69, 20);
            this.txt_ukupanIznos.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 598);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Iznos :";
            // 
            // lbl_closeNarudzbenica
            // 
            this.lbl_closeNarudzbenica.AutoSize = true;
            this.lbl_closeNarudzbenica.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_closeNarudzbenica.ForeColor = System.Drawing.Color.White;
            this.lbl_closeNarudzbenica.Location = new System.Drawing.Point(415, 9);
            this.lbl_closeNarudzbenica.Name = "lbl_closeNarudzbenica";
            this.lbl_closeNarudzbenica.Size = new System.Drawing.Size(17, 20);
            this.lbl_closeNarudzbenica.TabIndex = 24;
            this.lbl_closeNarudzbenica.Text = "X";
            this.lbl_closeNarudzbenica.Click += new System.EventHandler(this.lbl_closeNarudzbenica_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(29, 290);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(146, 1);
            this.panel7.TabIndex = 30;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(29, 239);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(146, 1);
            this.panel8.TabIndex = 29;
            // 
            // txt_datumOd
            // 
            this.txt_datumOd.Location = new System.Drawing.Point(106, 213);
            this.txt_datumOd.Name = "txt_datumOd";
            this.txt_datumOd.Size = new System.Drawing.Size(69, 20);
            this.txt_datumOd.TabIndex = 28;
            this.txt_datumOd.MouseEnter += new System.EventHandler(this.txt_datumOd_MouseEnter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 28);
            this.label8.TabIndex = 27;
            this.label8.Text = "Datum od :";
            // 
            // txt_datumDo
            // 
            this.txt_datumDo.Location = new System.Drawing.Point(106, 264);
            this.txt_datumDo.Name = "txt_datumDo";
            this.txt_datumDo.Size = new System.Drawing.Size(69, 20);
            this.txt_datumDo.TabIndex = 26;
            this.txt_datumDo.MouseEnter += new System.EventHandler(this.txt_datumDo_MouseEnter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(24, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 28);
            this.label9.TabIndex = 25;
            this.label9.Text = "Datum do :";
            // 
            // mcal_datumOd
            // 
            this.mcal_datumOd.Location = new System.Drawing.Point(106, 213);
            this.mcal_datumOd.Name = "mcal_datumOd";
            this.mcal_datumOd.TabIndex = 31;
            this.mcal_datumOd.Visible = false;
            this.mcal_datumOd.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcal_datumOd_DateSelected);
            this.mcal_datumOd.MouseLeave += new System.EventHandler(this.mcal_datumOd_MouseLeave);
            // 
            // mcal_DatumDo
            // 
            this.mcal_DatumDo.Location = new System.Drawing.Point(106, 122);
            this.mcal_DatumDo.Name = "mcal_DatumDo";
            this.mcal_DatumDo.TabIndex = 32;
            this.mcal_DatumDo.Visible = false;
            this.mcal_DatumDo.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcal_DatumDo_DateSelected);
            this.mcal_DatumDo.MouseLeave += new System.EventHandler(this.mcal_DatumDo_MouseLeave);
            // 
            // FrmNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(439, 642);
            this.Controls.Add(this.mcal_DatumDo);
            this.Controls.Add(this.mcal_datumOd);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txt_datumOd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_datumDo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_closeNarudzbenica);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txt_ukupanIznos);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btn_sacuvajProizvod);
            this.Controls.Add(this.dgv_StavkeNarudzbenice);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_kolicinaProizvoda);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_modelProizvoda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_cenaProizvoda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_proizvodi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_korisnikClan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNarudzbenica";
            this.Text = "FrmNarudzbenica";
            this.Load += new System.EventHandler(this.FrmNarudzbenica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StavkeNarudzbenice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbx_korisnikClan;
        private System.Windows.Forms.ComboBox cbx_proizvodi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cenaProizvoda;
        private System.Windows.Forms.TextBox txt_modelProizvoda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_kolicinaProizvoda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_StavkeNarudzbenice;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_sacuvajProizvod;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_ukupanIznos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_closeNarudzbenica;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txt_datumOd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_datumDo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MonthCalendar mcal_datumOd;
        private System.Windows.Forms.MonthCalendar mcal_DatumDo;
    }
}