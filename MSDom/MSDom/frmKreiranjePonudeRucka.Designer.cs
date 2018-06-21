namespace MSDom
{
    partial class frmKreiranjePonudeRucka
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
            this.uiActionMakni = new System.Windows.Forms.Button();
            this.uiActionDodaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uiOutputDanasnjaPonudaRucka = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uiOutputPopisRucka = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDanasnjaPonudaRucka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPopisRucka)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionMakni
            // 
            this.uiActionMakni.Location = new System.Drawing.Point(575, 463);
            this.uiActionMakni.Name = "uiActionMakni";
            this.uiActionMakni.Size = new System.Drawing.Size(161, 23);
            this.uiActionMakni.TabIndex = 12;
            this.uiActionMakni.Text = "Makni s današnje ponude";
            this.uiActionMakni.UseVisualStyleBackColor = true;
            this.uiActionMakni.Click += new System.EventHandler(this.uiActionMakni_Click);
            // 
            // uiActionDodaj
            // 
            this.uiActionDodaj.Location = new System.Drawing.Point(575, 236);
            this.uiActionDodaj.Name = "uiActionDodaj";
            this.uiActionDodaj.Size = new System.Drawing.Size(161, 23);
            this.uiActionDodaj.TabIndex = 11;
            this.uiActionDodaj.Text = "Dodaj u današnju ponudu";
            this.uiActionDodaj.UseVisualStyleBackColor = true;
            this.uiActionDodaj.Click += new System.EventHandler(this.uiActionDodaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Današnja ponuda";
            // 
            // uiOutputDanasnjaPonudaRucka
            // 
            this.uiOutputDanasnjaPonudaRucka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputDanasnjaPonudaRucka.Location = new System.Drawing.Point(12, 285);
            this.uiOutputDanasnjaPonudaRucka.Name = "uiOutputDanasnjaPonudaRucka";
            this.uiOutputDanasnjaPonudaRucka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputDanasnjaPonudaRucka.Size = new System.Drawing.Size(724, 172);
            this.uiOutputDanasnjaPonudaRucka.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Popis ručka";
            // 
            // uiOutputPopisRucka
            // 
            this.uiOutputPopisRucka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPopisRucka.Location = new System.Drawing.Point(12, 58);
            this.uiOutputPopisRucka.Name = "uiOutputPopisRucka";
            this.uiOutputPopisRucka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputPopisRucka.Size = new System.Drawing.Size(724, 172);
            this.uiOutputPopisRucka.TabIndex = 7;
            // 
            // frmKreiranjePonudeRucka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.uiActionMakni);
            this.Controls.Add(this.uiActionDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiOutputDanasnjaPonudaRucka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputPopisRucka);
            this.Name = "frmKreiranjePonudeRucka";
            this.Text = "Kreiranje ponude ručka";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDanasnjaPonudaRucka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPopisRucka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uiActionMakni;
        private System.Windows.Forms.Button uiActionDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView uiOutputDanasnjaPonudaRucka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiOutputPopisRucka;
    }
}