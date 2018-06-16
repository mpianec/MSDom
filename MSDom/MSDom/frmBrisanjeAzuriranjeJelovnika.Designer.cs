namespace MSDom
{
    partial class frmBrisanjeAzuriranjeJelovnika
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
            this.uiOutputPopisJelovnika = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uiActionObrisi = new System.Windows.Forms.Button();
            this.uiActionAzuriraj = new System.Windows.Forms.Button();
            this.uiActionSpremiPromjene = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPopisJelovnika)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputPopisJelovnika
            // 
            this.uiOutputPopisJelovnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPopisJelovnika.Location = new System.Drawing.Point(13, 47);
            this.uiOutputPopisJelovnika.Name = "uiOutputPopisJelovnika";
            this.uiOutputPopisJelovnika.Size = new System.Drawing.Size(579, 176);
            this.uiOutputPopisJelovnika.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis jelovnika";
            // 
            // uiActionObrisi
            // 
            this.uiActionObrisi.Location = new System.Drawing.Point(13, 229);
            this.uiActionObrisi.Name = "uiActionObrisi";
            this.uiActionObrisi.Size = new System.Drawing.Size(178, 23);
            this.uiActionObrisi.TabIndex = 2;
            this.uiActionObrisi.Text = "Obriši jelovnik";
            this.uiActionObrisi.UseVisualStyleBackColor = true;
            // 
            // uiActionAzuriraj
            // 
            this.uiActionAzuriraj.Location = new System.Drawing.Point(211, 229);
            this.uiActionAzuriraj.Name = "uiActionAzuriraj";
            this.uiActionAzuriraj.Size = new System.Drawing.Size(178, 23);
            this.uiActionAzuriraj.TabIndex = 3;
            this.uiActionAzuriraj.Text = "Ažuriraj jelovnik";
            this.uiActionAzuriraj.UseVisualStyleBackColor = true;
            // 
            // uiActionSpremiPromjene
            // 
            this.uiActionSpremiPromjene.Location = new System.Drawing.Point(414, 229);
            this.uiActionSpremiPromjene.Name = "uiActionSpremiPromjene";
            this.uiActionSpremiPromjene.Size = new System.Drawing.Size(178, 23);
            this.uiActionSpremiPromjene.TabIndex = 4;
            this.uiActionSpremiPromjene.Text = "Spremi promjene";
            this.uiActionSpremiPromjene.UseVisualStyleBackColor = true;
            // 
            // frmBrisanjeAzuriranjeJelovnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiActionSpremiPromjene);
            this.Controls.Add(this.uiActionAzuriraj);
            this.Controls.Add(this.uiActionObrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputPopisJelovnika);
            this.Name = "frmBrisanjeAzuriranjeJelovnika";
            this.Text = "Brisanje / ažuriranje jelovnika";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPopisJelovnika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uiOutputPopisJelovnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uiActionObrisi;
        private System.Windows.Forms.Button uiActionAzuriraj;
        private System.Windows.Forms.Button uiActionSpremiPromjene;
    }
}