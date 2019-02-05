namespace MSDom
{
    partial class frmKreiranjeNarudzbenice
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uiActionKreirajNarudzbenicu = new System.Windows.Forms.Button();
            this.uiActionIspis = new System.Windows.Forms.Button();
            this.uiActionDodajStavke = new System.Windows.Forms.Button();
            this.uiActionObrisi = new System.Windows.Forms.Button();
            this.narudzbenicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // uiActionKreirajNarudzbenicu
            // 
            this.uiActionKreirajNarudzbenicu.Location = new System.Drawing.Point(12, 288);
            this.uiActionKreirajNarudzbenicu.Name = "uiActionKreirajNarudzbenicu";
            this.uiActionKreirajNarudzbenicu.Size = new System.Drawing.Size(75, 23);
            this.uiActionKreirajNarudzbenicu.TabIndex = 1;
            this.uiActionKreirajNarudzbenicu.Text = "Kreiraj";
            this.uiActionKreirajNarudzbenicu.UseVisualStyleBackColor = true;
            this.uiActionKreirajNarudzbenicu.Click += new System.EventHandler(this.uiActionKreirajNarudzbenicu_Click);
            // 
            // uiActionIspis
            // 
            this.uiActionIspis.Location = new System.Drawing.Point(167, 288);
            this.uiActionIspis.Name = "uiActionIspis";
            this.uiActionIspis.Size = new System.Drawing.Size(75, 23);
            this.uiActionIspis.TabIndex = 2;
            this.uiActionIspis.Text = "Ispis";
            this.uiActionIspis.UseVisualStyleBackColor = true;
            this.uiActionIspis.Click += new System.EventHandler(this.uiActionIspis_Click);
            // 
            // uiActionDodajStavke
            // 
            this.uiActionDodajStavke.Location = new System.Drawing.Point(323, 288);
            this.uiActionDodajStavke.Name = "uiActionDodajStavke";
            this.uiActionDodajStavke.Size = new System.Drawing.Size(89, 23);
            this.uiActionDodajStavke.TabIndex = 3;
            this.uiActionDodajStavke.Text = "Dodaj stavke";
            this.uiActionDodajStavke.UseVisualStyleBackColor = true;
            this.uiActionDodajStavke.Click += new System.EventHandler(this.uiActionDodajStavke_Click);
            // 
            // uiActionObrisi
            // 
            this.uiActionObrisi.Location = new System.Drawing.Point(498, 288);
            this.uiActionObrisi.Name = "uiActionObrisi";
            this.uiActionObrisi.Size = new System.Drawing.Size(75, 23);
            this.uiActionObrisi.TabIndex = 4;
            this.uiActionObrisi.Text = "Obriši";
            this.uiActionObrisi.UseVisualStyleBackColor = true;
            this.uiActionObrisi.Click += new System.EventHandler(this.uiActionObrisi_Click);
            // 
            // narudzbenicaBindingSource
            // 
            this.narudzbenicaBindingSource.DataSource = typeof(MSDom.narudzbenica);
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(MSDom.korisnik);
            // 
            // frmKreiranjeNarudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiActionObrisi);
            this.Controls.Add(this.uiActionDodajStavke);
            this.Controls.Add(this.uiActionIspis);
            this.Controls.Add(this.uiActionKreirajNarudzbenicu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmKreiranjeNarudzbenice";
            this.Text = "frmKreiranjeNarudzbenice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource;
        private System.Windows.Forms.Button uiActionKreirajNarudzbenicu;
        private System.Windows.Forms.Button uiActionIspis;
        private System.Windows.Forms.Button uiActionDodajStavke;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.Button uiActionObrisi;
    }
}