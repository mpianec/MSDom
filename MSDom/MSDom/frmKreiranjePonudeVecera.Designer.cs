namespace MSDom
{
    partial class frmKreiranjePonudeVecera
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
            this.uiOutputDanasnjaPonudaVecera = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uiOutputPopisVecera = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDanasnjaPonudaVecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPopisVecera)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionMakni
            // 
            this.uiActionMakni.Location = new System.Drawing.Point(575, 473);
            this.uiActionMakni.Name = "uiActionMakni";
            this.uiActionMakni.Size = new System.Drawing.Size(161, 23);
            this.uiActionMakni.TabIndex = 19;
            this.uiActionMakni.Text = "Makni s današnje ponude";
            this.uiActionMakni.UseVisualStyleBackColor = true;
            this.uiActionMakni.Click += new System.EventHandler(this.uiActionMakni_Click);
            // 
            // uiActionDodaj
            // 
            this.uiActionDodaj.Location = new System.Drawing.Point(575, 251);
            this.uiActionDodaj.Name = "uiActionDodaj";
            this.uiActionDodaj.Size = new System.Drawing.Size(161, 23);
            this.uiActionDodaj.TabIndex = 18;
            this.uiActionDodaj.Text = "Dodaj u današnju ponudu";
            this.uiActionDodaj.UseVisualStyleBackColor = true;
            this.uiActionDodaj.Click += new System.EventHandler(this.uiActionDodaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Današnja ponuda";
            // 
            // uiOutputDanasnjaPonudaVecera
            // 
            this.uiOutputDanasnjaPonudaVecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputDanasnjaPonudaVecera.Location = new System.Drawing.Point(15, 289);
            this.uiOutputDanasnjaPonudaVecera.Name = "uiOutputDanasnjaPonudaVecera";
            this.uiOutputDanasnjaPonudaVecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputDanasnjaPonudaVecera.Size = new System.Drawing.Size(721, 172);
            this.uiOutputDanasnjaPonudaVecera.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Popis večera";
            // 
            // uiOutputPopisVecera
            // 
            this.uiOutputPopisVecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPopisVecera.Location = new System.Drawing.Point(12, 63);
            this.uiOutputPopisVecera.Name = "uiOutputPopisVecera";
            this.uiOutputPopisVecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputPopisVecera.Size = new System.Drawing.Size(724, 172);
            this.uiOutputPopisVecera.TabIndex = 14;
            // 
            // frmKreiranjePonudeVecera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.uiActionMakni);
            this.Controls.Add(this.uiActionDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiOutputDanasnjaPonudaVecera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputPopisVecera);
            this.Name = "frmKreiranjePonudeVecera";
            this.Text = "Kreiranje ponude večera";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDanasnjaPonudaVecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPopisVecera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uiActionMakni;
        private System.Windows.Forms.Button uiActionDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView uiOutputDanasnjaPonudaVecera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiOutputPopisVecera;
    }
}