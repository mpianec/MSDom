namespace MSDom
{
    partial class frmSastanakSDoktorom
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
            this.uiInputStanar = new System.Windows.Forms.ComboBox();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiInputDoktor = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiActionUgovori = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiInputStanar
            // 
            this.uiInputStanar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uiInputStanar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uiInputStanar.DataSource = this.korisnikBindingSource;
            this.uiInputStanar.DisplayMember = "ime";
            this.uiInputStanar.FormattingEnabled = true;
            this.uiInputStanar.Location = new System.Drawing.Point(186, 42);
            this.uiInputStanar.Name = "uiInputStanar";
            this.uiInputStanar.Size = new System.Drawing.Size(221, 21);
            this.uiInputStanar.TabIndex = 0;
            this.uiInputStanar.ValueMember = "id";
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(MSDom.korisnik);
            // 
            // uiInputDoktor
            // 
            this.uiInputDoktor.DataSource = this.korisnikBindingSource;
            this.uiInputDoktor.DisplayMember = "ime";
            this.uiInputDoktor.FormattingEnabled = true;
            this.uiInputDoktor.Location = new System.Drawing.Point(186, 87);
            this.uiInputDoktor.Name = "uiInputDoktor";
            this.uiInputDoktor.Size = new System.Drawing.Size(221, 21);
            this.uiInputDoktor.TabIndex = 1;
            this.uiInputDoktor.ValueMember = "id";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stanar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum";
            // 
            // uiActionUgovori
            // 
            this.uiActionUgovori.Location = new System.Drawing.Point(214, 193);
            this.uiActionUgovori.Name = "uiActionUgovori";
            this.uiActionUgovori.Size = new System.Drawing.Size(163, 40);
            this.uiActionUgovori.TabIndex = 6;
            this.uiActionUgovori.Text = "Ugovori novi sastanak s doktorom";
            this.uiActionUgovori.UseVisualStyleBackColor = true;
            this.uiActionUgovori.Click += new System.EventHandler(this.uiActionUgovori_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pritisnite F1 za pomoć";
            // 
            // frmSastanakSDoktorom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 279);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiActionUgovori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.uiInputDoktor);
            this.Controls.Add(this.uiInputStanar);
            this.Name = "frmSastanakSDoktorom";
            this.Text = "Ugovaranje sastanka s doktorom";
            this.Load += new System.EventHandler(this.frmSastanakSDoktorom_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSastanakSDoktorom_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uiInputStanar;
        private System.Windows.Forms.ComboBox uiInputDoktor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uiActionUgovori;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.Label label4;
    }
}