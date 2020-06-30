namespace Server
{
    partial class GlavnaFormaServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaFormaServer));
            this.lbl_vremeNaServeru = new System.Windows.Forms.Label();
            this.lbl_brojKorinika = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_PrijavljeniKorisnici = new System.Windows.Forms.DataGridView();
            this.lbl_spisakZaposlenih = new System.Windows.Forms.Label();
            this.btnb_turnOn = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_turnOff = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PrijavljeniKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnb_turnOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_turnOff)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_vremeNaServeru
            // 
            this.lbl_vremeNaServeru.AutoSize = true;
            this.lbl_vremeNaServeru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lbl_vremeNaServeru.Location = new System.Drawing.Point(202, 116);
            this.lbl_vremeNaServeru.Name = "lbl_vremeNaServeru";
            this.lbl_vremeNaServeru.Size = new System.Drawing.Size(37, 13);
            this.lbl_vremeNaServeru.TabIndex = 2;
            this.lbl_vremeNaServeru.Text = "Vreme";
            // 
            // lbl_brojKorinika
            // 
            this.lbl_brojKorinika.AutoSize = true;
            this.lbl_brojKorinika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lbl_brojKorinika.Location = new System.Drawing.Point(30, 116);
            this.lbl_brojKorinika.Name = "lbl_brojKorinika";
            this.lbl_brojKorinika.Size = new System.Drawing.Size(114, 13);
            this.lbl_brojKorinika.TabIndex = 3;
            this.lbl_brojKorinika.Text = "Korisnici na serveru (0)";
            this.lbl_brojKorinika.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(258, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgv_PrijavljeniKorisnici
            // 
            this.dgv_PrijavljeniKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PrijavljeniKorisnici.Location = new System.Drawing.Point(21, 154);
            this.dgv_PrijavljeniKorisnici.Name = "dgv_PrijavljeniKorisnici";
            this.dgv_PrijavljeniKorisnici.Size = new System.Drawing.Size(240, 91);
            this.dgv_PrijavljeniKorisnici.TabIndex = 5;
            this.dgv_PrijavljeniKorisnici.Visible = false;
            // 
            // lbl_spisakZaposlenih
            // 
            this.lbl_spisakZaposlenih.AutoSize = true;
            this.lbl_spisakZaposlenih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spisakZaposlenih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lbl_spisakZaposlenih.Location = new System.Drawing.Point(18, 114);
            this.lbl_spisakZaposlenih.Name = "lbl_spisakZaposlenih";
            this.lbl_spisakZaposlenih.Size = new System.Drawing.Size(15, 16);
            this.lbl_spisakZaposlenih.TabIndex = 6;
            this.lbl_spisakZaposlenih.Text = "+";
            this.lbl_spisakZaposlenih.Click += new System.EventHandler(this.lbl_spisakZaposlenih_Click);
            // 
            // btnb_turnOn
            // 
            this.btnb_turnOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnb_turnOn.Image = ((System.Drawing.Image)(resources.GetObject("btnb_turnOn.Image")));
            this.btnb_turnOn.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnb_turnOn.ImageActive")));
            this.btnb_turnOn.Location = new System.Drawing.Point(109, 12);
            this.btnb_turnOn.Name = "btnb_turnOn";
            this.btnb_turnOn.Size = new System.Drawing.Size(80, 80);
            this.btnb_turnOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnb_turnOn.TabIndex = 8;
            this.btnb_turnOn.TabStop = false;
            this.btnb_turnOn.Zoom = 10;
            this.btnb_turnOn.Click += new System.EventHandler(this.btnb_turnOn_Click);
            // 
            // btn_turnOff
            // 
            this.btn_turnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btn_turnOff.Image = ((System.Drawing.Image)(resources.GetObject("btn_turnOff.Image")));
            this.btn_turnOff.ImageActive = ((System.Drawing.Image)(resources.GetObject("btn_turnOff.ImageActive")));
            this.btn_turnOff.Location = new System.Drawing.Point(21, 12);
            this.btn_turnOff.Name = "btn_turnOff";
            this.btn_turnOff.Size = new System.Drawing.Size(80, 80);
            this.btn_turnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_turnOff.TabIndex = 9;
            this.btn_turnOff.TabStop = false;
            this.btn_turnOff.Visible = false;
            this.btn_turnOff.Zoom = 10;
            this.btn_turnOff.Click += new System.EventHandler(this.btn_turnOff_Click);
            // 
            // GlavnaFormaServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(284, 138);
            this.Controls.Add(this.btn_turnOff);
            this.Controls.Add(this.btnb_turnOn);
            this.Controls.Add(this.lbl_spisakZaposlenih);
            this.Controls.Add(this.dgv_PrijavljeniKorisnici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_brojKorinika);
            this.Controls.Add(this.lbl_vremeNaServeru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GlavnaFormaServer";
            this.Text = "GlavnaFormaServer";
            this.Load += new System.EventHandler(this.GlavnaFormaServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PrijavljeniKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnb_turnOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_turnOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_vremeNaServeru;
        private System.Windows.Forms.Label lbl_brojKorinika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_PrijavljeniKorisnici;
        private System.Windows.Forms.Label lbl_spisakZaposlenih;
        private Bunifu.Framework.UI.BunifuImageButton btnb_turnOn;
        private Bunifu.Framework.UI.BunifuImageButton btn_turnOff;
    }
}