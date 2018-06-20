namespace MSDom
{
    partial class frmKreiranjePonudeDorucak
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
            this.uiOutputPopisDorucka = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uiOutputDanasnjaPonudaDorucka = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.uiActionDodaj = new System.Windows.Forms.Button();
            this.uiActionMakni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPopisDorucka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDanasnjaPonudaDorucka)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputPopisDorucka
            // 
            this.uiOutputPopisDorucka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPopisDorucka.Location = new System.Drawing.Point(12, 61);
            this.uiOutputPopisDorucka.Name = "uiOutputPopisDorucka";
            this.uiOutputPopisDorucka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputPopisDorucka.Size = new System.Drawing.Size(831, 172);
            this.uiOutputPopisDorucka.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis doručka";
            // 
            // uiOutputDanasnjaPonudaDorucka
            // 
            this.uiOutputDanasnjaPonudaDorucka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputDanasnjaPonudaDorucka.Location = new System.Drawing.Point(12, 280);
            this.uiOutputDanasnjaPonudaDorucka.Name = "uiOutputDanasnjaPonudaDorucka";
            this.uiOutputDanasnjaPonudaDorucka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputDanasnjaPonudaDorucka.Size = new System.Drawing.Size(831, 172);
            this.uiOutputDanasnjaPonudaDorucka.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Današnja ponuda";
            // 
            // uiActionDodaj
            // 
            this.uiActionDodaj.Location = new System.Drawing.Point(682, 245);
            this.uiActionDodaj.Name = "uiActionDodaj";
            this.uiActionDodaj.Size = new System.Drawing.Size(161, 23);
            this.uiActionDodaj.TabIndex = 4;
            this.uiActionDodaj.Text = "Dodaj u danasnju ponudu";
            this.uiActionDodaj.UseVisualStyleBackColor = true;
            this.uiActionDodaj.Click += new System.EventHandler(this.uiActionDodaj_Click);
            // 
            // uiActionMakni
            // 
            this.uiActionMakni.Location = new System.Drawing.Point(682, 458);
            this.uiActionMakni.Name = "uiActionMakni";
            this.uiActionMakni.Size = new System.Drawing.Size(161, 23);
            this.uiActionMakni.TabIndex = 5;
            this.uiActionMakni.Text = "Makni s danasnje ponude";
            this.uiActionMakni.UseVisualStyleBackColor = true;
            this.uiActionMakni.Click += new System.EventHandler(this.uiActionMakni_Click);
            // 
            // frmKreiranjePonudeDorucak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 493);
            this.Controls.Add(this.uiActionMakni);
            this.Controls.Add(this.uiActionDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiOutputDanasnjaPonudaDorucka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputPopisDorucka);
            this.Name = "frmKreiranjePonudeDorucak";
            this.Text = "Kreiranje ponude doručak";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPopisDorucka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDanasnjaPonudaDorucka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uiOutputPopisDorucka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiOutputDanasnjaPonudaDorucka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uiActionDodaj;
        private System.Windows.Forms.Button uiActionMakni;
    }
}