namespace MSDom
{
    partial class frmAzuriranjeKorisnika
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
            this.components = new System.ComponentModel.Container();
            this.uiInputBrojSobe = new System.Windows.Forms.ComboBox();
            this.sobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiInputUloga = new System.Windows.Forms.ComboBox();
            this.ulogaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionSpremi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiInputKorisnickoIme = new System.Windows.Forms.TextBox();
            this.uiInputLozinka = new System.Windows.Forms.TextBox();
            this.uiInputPrezime = new System.Windows.Forms.TextBox();
            this.uiInputIme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uiInputID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiInputBrojSobe
            // 
            this.uiInputBrojSobe.DataSource = this.sobaBindingSource;
            this.uiInputBrojSobe.DisplayMember = "brojSobe";
            this.uiInputBrojSobe.FormattingEnabled = true;
            this.uiInputBrojSobe.Location = new System.Drawing.Point(211, 109);
            this.uiInputBrojSobe.Name = "uiInputBrojSobe";
            this.uiInputBrojSobe.Size = new System.Drawing.Size(271, 21);
            this.uiInputBrojSobe.TabIndex = 28;
            this.uiInputBrojSobe.ValueMember = "id";
            // 
            // sobaBindingSource
            // 
            this.sobaBindingSource.DataSource = typeof(MSDom.soba);
            // 
            // uiInputUloga
            // 
            this.uiInputUloga.DataSource = this.ulogaBindingSource;
            this.uiInputUloga.DisplayMember = "naziv";
            this.uiInputUloga.FormattingEnabled = true;
            this.uiInputUloga.Location = new System.Drawing.Point(211, 134);
            this.uiInputUloga.Name = "uiInputUloga";
            this.uiInputUloga.Size = new System.Drawing.Size(271, 21);
            this.uiInputUloga.TabIndex = 27;
            this.uiInputUloga.ValueMember = "id";
            // 
            // ulogaBindingSource
            // 
            this.ulogaBindingSource.DataSource = typeof(MSDom.uloga);
            // 
            // uiActionSpremi
            // 
            this.uiActionSpremi.Location = new System.Drawing.Point(211, 215);
            this.uiActionSpremi.Name = "uiActionSpremi";
            this.uiActionSpremi.Size = new System.Drawing.Size(271, 23);
            this.uiActionSpremi.TabIndex = 26;
            this.uiActionSpremi.Text = "Spremi";
            this.uiActionSpremi.UseVisualStyleBackColor = true;
            this.uiActionSpremi.Click += new System.EventHandler(this.uiActionSpremi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Lozinka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Korisničko ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Uloga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Broj sobe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ime";
            // 
            // uiInputKorisnickoIme
            // 
            this.uiInputKorisnickoIme.Location = new System.Drawing.Point(211, 162);
            this.uiInputKorisnickoIme.Name = "uiInputKorisnickoIme";
            this.uiInputKorisnickoIme.Size = new System.Drawing.Size(271, 20);
            this.uiInputKorisnickoIme.TabIndex = 19;
            // 
            // uiInputLozinka
            // 
            this.uiInputLozinka.Location = new System.Drawing.Point(211, 188);
            this.uiInputLozinka.Name = "uiInputLozinka";
            this.uiInputLozinka.Size = new System.Drawing.Size(271, 20);
            this.uiInputLozinka.TabIndex = 18;
            // 
            // uiInputPrezime
            // 
            this.uiInputPrezime.Location = new System.Drawing.Point(211, 84);
            this.uiInputPrezime.Name = "uiInputPrezime";
            this.uiInputPrezime.Size = new System.Drawing.Size(271, 20);
            this.uiInputPrezime.TabIndex = 17;
            // 
            // uiInputIme
            // 
            this.uiInputIme.Location = new System.Drawing.Point(211, 58);
            this.uiInputIme.Name = "uiInputIme";
            this.uiInputIme.Size = new System.Drawing.Size(271, 20);
            this.uiInputIme.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "ID";
            // 
            // uiInputID
            // 
            this.uiInputID.Location = new System.Drawing.Point(211, 32);
            this.uiInputID.Name = "uiInputID";
            this.uiInputID.ReadOnly = true;
            this.uiInputID.Size = new System.Drawing.Size(271, 20);
            this.uiInputID.TabIndex = 29;
            // 
            // frmAzuriranjeKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 285);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uiInputID);
            this.Controls.Add(this.uiInputBrojSobe);
            this.Controls.Add(this.uiInputUloga);
            this.Controls.Add(this.uiActionSpremi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiInputKorisnickoIme);
            this.Controls.Add(this.uiInputLozinka);
            this.Controls.Add(this.uiInputPrezime);
            this.Controls.Add(this.uiInputIme);
            this.Name = "frmAzuriranjeKorisnika";
            this.Text = "Ažuriranje korisnika";
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uiInputBrojSobe;
        private System.Windows.Forms.ComboBox uiInputUloga;
        private System.Windows.Forms.Button uiActionSpremi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiInputKorisnickoIme;
        private System.Windows.Forms.TextBox uiInputLozinka;
        private System.Windows.Forms.TextBox uiInputPrezime;
        private System.Windows.Forms.TextBox uiInputIme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uiInputID;
        private System.Windows.Forms.BindingSource sobaBindingSource;
        private System.Windows.Forms.BindingSource ulogaBindingSource;
    }
}