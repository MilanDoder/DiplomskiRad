namespace Forme
{
    partial class FrmPrijavljivanje
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
            this.lbl_igraonica = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_potvrdi = new System.Windows.Forms.Button();
            this.lbl_close = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_username = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_igraonica
            // 
            this.lbl_igraonica.AutoSize = true;
            this.lbl_igraonica.Font = new System.Drawing.Font("Freestyle Script", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_igraonica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lbl_igraonica.Location = new System.Drawing.Point(121, 53);
            this.lbl_igraonica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_igraonica.Name = "lbl_igraonica";
            this.lbl_igraonica.Size = new System.Drawing.Size(160, 42);
            this.lbl_igraonica.TabIndex = 3;
            this.lbl_igraonica.Text = "Igraonica Zabac";
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.White;
            this.txt_Username.Location = new System.Drawing.Point(62, 175);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(206, 18);
            this.txt_Username.TabIndex = 4;
            this.txt_Username.Text = "Username";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(62, 263);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(206, 19);
            this.txt_password.TabIndex = 5;
            this.txt_password.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(18, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(18, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 7;
            // 
            // btn_potvrdi
            // 
            this.btn_potvrdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_potvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_potvrdi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_potvrdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btn_potvrdi.Location = new System.Drawing.Point(85, 340);
            this.btn_potvrdi.Name = "btn_potvrdi";
            this.btn_potvrdi.Size = new System.Drawing.Size(111, 46);
            this.btn_potvrdi.TabIndex = 8;
            this.btn_potvrdi.Text = "Potvrdi";
            this.btn_potvrdi.UseVisualStyleBackColor = false;
            this.btn_potvrdi.Click += new System.EventHandler(this.btn_potvrdi_Click);
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(278, 9);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(19, 18);
            this.lbl_close.TabIndex = 9;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Forme.Properties.Resources.LockWhite;
            this.pictureBox2.Location = new System.Drawing.Point(18, 248);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pb_username
            // 
            this.pb_username.Image = global::Forme.Properties.Resources.userWhite;
            this.pb_username.Location = new System.Drawing.Point(18, 160);
            this.pb_username.Margin = new System.Windows.Forms.Padding(4);
            this.pb_username.Name = "pb_username";
            this.pb_username.Size = new System.Drawing.Size(36, 34);
            this.pb_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_username.TabIndex = 1;
            this.pb_username.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forme.Properties.Resources.if_gamer_white_15369121;
            this.pictureBox1.Location = new System.Drawing.Point(18, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrijavljivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(309, 417);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.btn_potvrdi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_igraonica);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pb_username);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrijavljivanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrijavljivanje";
            this.Load += new System.EventHandler(this.FrmPrijavljivanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_username;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_igraonica;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_potvrdi;
        private System.Windows.Forms.Label lbl_close;
    }
}