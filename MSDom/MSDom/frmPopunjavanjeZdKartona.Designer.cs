namespace MSDom
{
    partial class frmPopunjavanjeZdKartona
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
            this.uiOutputStanari = new System.Windows.Forms.DataGridView();
            this.uiOutputKorisnik = new System.Windows.Forms.ComboBox();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.uiActionNoviNalaz = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.uiInputStanar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uiInputDijagnoza = new System.Windows.Forms.TextBox();
            this.uiInputNazivBolesti = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputStanari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiOutputStanari
            // 
            this.uiOutputStanari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputStanari.Location = new System.Drawing.Point(32, 275);
            this.uiOutputStanari.Name = "uiOutputStanari";
            this.uiOutputStanari.Size = new System.Drawing.Size(944, 257);
            this.uiOutputStanari.TabIndex = 0;
            // 
            // uiOutputKorisnik
            // 
            this.uiOutputKorisnik.DataSource = this.korisnikBindingSource;
            this.uiOutputKorisnik.DisplayMember = "ime";
            this.uiOutputKorisnik.FormattingEnabled = true;
            this.uiOutputKorisnik.Location = new System.Drawing.Point(156, 241);
            this.uiOutputKorisnik.Name = "uiOutputKorisnik";
            this.uiOutputKorisnik.Size = new System.Drawing.Size(256, 21);
            this.uiOutputKorisnik.TabIndex = 1;
            this.uiOutputKorisnik.ValueMember = "id";
            this.uiOutputKorisnik.SelectedIndexChanged += new System.EventHandler(this.uiOutputKorisnik_SelectedIndexChanged);
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(MSDom.korisnik);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberi korisnika:";
            // 
            // uiActionNoviNalaz
            // 
            this.uiActionNoviNalaz.Location = new System.Drawing.Point(484, 78);
            this.uiActionNoviNalaz.Name = "uiActionNoviNalaz";
            this.uiActionNoviNalaz.Size = new System.Drawing.Size(212, 39);
            this.uiActionNoviNalaz.TabIndex = 3;
            this.uiActionNoviNalaz.Text = "Dodaj novi nalaz";
            this.uiActionNoviNalaz.UseVisualStyleBackColor = true;
            this.uiActionNoviNalaz.Click += new System.EventHandler(this.uiActionNoviNalaz_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.uiInputStanar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.uiInputDijagnoza);
            this.groupBox1.Controls.Add(this.uiInputNazivBolesti);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.uiActionNoviNalaz);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 211);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(252, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // uiInputStanar
            // 
            this.uiInputStanar.DataSource = this.korisnikBindingSource;
            this.uiInputStanar.DisplayMember = "ime";
            this.uiInputStanar.FormattingEnabled = true;
            this.uiInputStanar.Location = new System.Drawing.Point(252, 140);
            this.uiInputStanar.Name = "uiInputStanar";
            this.uiInputStanar.Size = new System.Drawing.Size(185, 21);
            this.uiInputStanar.TabIndex = 17;
            this.uiInputStanar.ValueMember = "id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Stanar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Dijagnoza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Naziv bolesti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Id nalaza";
            // 
            // uiInputDijagnoza
            // 
            this.uiInputDijagnoza.Location = new System.Drawing.Point(252, 100);
            this.uiInputDijagnoza.Name = "uiInputDijagnoza";
            this.uiInputDijagnoza.Size = new System.Drawing.Size(185, 20);
            this.uiInputDijagnoza.TabIndex = 12;
            // 
            // uiInputNazivBolesti
            // 
            this.uiInputNazivBolesti.Location = new System.Drawing.Point(252, 57);
            this.uiInputNazivBolesti.Name = "uiInputNazivBolesti";
            this.uiInputNazivBolesti.Size = new System.Drawing.Size(185, 20);
            this.uiInputNazivBolesti.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(866, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pritisnite F1 za pomoć";
            // 
            // frmPopunjavanjeZdKartona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 558);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputKorisnik);
            this.Controls.Add(this.uiOutputStanari);
            this.Name = "frmPopunjavanjeZdKartona";
            this.Text = "frmPopunjavanjeZdKartona";
            this.Load += new System.EventHandler(this.frmPopunjavanjeZdKartona_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPopunjavanjeZdKartona_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputStanari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uiOutputStanari;
        private System.Windows.Forms.ComboBox uiOutputKorisnik;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uiActionNoviNalaz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox uiInputStanar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uiInputDijagnoza;
        private System.Windows.Forms.TextBox uiInputNazivBolesti;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
    }
}