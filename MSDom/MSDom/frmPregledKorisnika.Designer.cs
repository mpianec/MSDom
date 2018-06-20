namespace MSDom
{
    partial class frmPregledKorisnika
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
            this.uiOutputKorisnici = new System.Windows.Forms.DataGridView();
            this.uiActionAzurirajKorisnika = new System.Windows.Forms.Button();
            this.sobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ulogaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputKorisnici
            // 
            this.uiOutputKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputKorisnici.Location = new System.Drawing.Point(13, 13);
            this.uiOutputKorisnici.Name = "uiOutputKorisnici";
            this.uiOutputKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputKorisnici.Size = new System.Drawing.Size(993, 173);
            this.uiOutputKorisnici.TabIndex = 0;
            // 
            // uiActionAzurirajKorisnika
            // 
            this.uiActionAzurirajKorisnika.Location = new System.Drawing.Point(857, 202);
            this.uiActionAzurirajKorisnika.Name = "uiActionAzurirajKorisnika";
            this.uiActionAzurirajKorisnika.Size = new System.Drawing.Size(149, 23);
            this.uiActionAzurirajKorisnika.TabIndex = 2;
            this.uiActionAzurirajKorisnika.Text = "Ažuriraj korisnika";
            this.uiActionAzurirajKorisnika.UseVisualStyleBackColor = true;
            this.uiActionAzurirajKorisnika.Click += new System.EventHandler(this.uiActionAzurirajKorisnika_Click);
            // 
            // sobaBindingSource
            // 
            this.sobaBindingSource.DataSource = typeof(MSDom.soba);
            // 
            // ulogaBindingSource
            // 
            this.ulogaBindingSource.DataSource = typeof(MSDom.uloga);
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(MSDom.korisnik);
            // 
            // frmPregledKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 282);
            this.Controls.Add(this.uiActionAzurirajKorisnika);
            this.Controls.Add(this.uiOutputKorisnici);
            this.Name = "frmPregledKorisnika";
            this.Text = "Pregled korisnika";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uiOutputKorisnici;
        private System.Windows.Forms.Button uiActionAzurirajKorisnika;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.BindingSource sobaBindingSource;
        private System.Windows.Forms.BindingSource ulogaBindingSource;
    }
}