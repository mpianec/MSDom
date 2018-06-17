namespace MSDom
{
    partial class frmPonudaRucka
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
            this.uiActionPonistiOdabir = new System.Windows.Forms.Button();
            this.uiActionSpremiOdabir = new System.Windows.Forms.Button();
            this.uiOutputPonudaRucka = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPonudaRucka)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionPonistiOdabir
            // 
            this.uiActionPonistiOdabir.Location = new System.Drawing.Point(326, 213);
            this.uiActionPonistiOdabir.Name = "uiActionPonistiOdabir";
            this.uiActionPonistiOdabir.Size = new System.Drawing.Size(174, 23);
            this.uiActionPonistiOdabir.TabIndex = 5;
            this.uiActionPonistiOdabir.Text = "Poništi moj odabir";
            this.uiActionPonistiOdabir.UseVisualStyleBackColor = true;
            // 
            // uiActionSpremiOdabir
            // 
            this.uiActionSpremiOdabir.Location = new System.Drawing.Point(52, 213);
            this.uiActionSpremiOdabir.Name = "uiActionSpremiOdabir";
            this.uiActionSpremiOdabir.Size = new System.Drawing.Size(174, 23);
            this.uiActionSpremiOdabir.TabIndex = 4;
            this.uiActionSpremiOdabir.Text = "Spremi odabir";
            this.uiActionSpremiOdabir.UseVisualStyleBackColor = true;
            // 
            // uiOutputPonudaRucka
            // 
            this.uiOutputPonudaRucka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPonudaRucka.Location = new System.Drawing.Point(52, 39);
            this.uiOutputPonudaRucka.Name = "uiOutputPonudaRucka";
            this.uiOutputPonudaRucka.Size = new System.Drawing.Size(448, 160);
            this.uiOutputPonudaRucka.TabIndex = 3;
            // 
            // frmPonudaRucka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 282);
            this.Controls.Add(this.uiActionPonistiOdabir);
            this.Controls.Add(this.uiActionSpremiOdabir);
            this.Controls.Add(this.uiOutputPonudaRucka);
            this.Name = "frmPonudaRucka";
            this.Text = "Ponuda ručka";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPonudaRucka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiActionPonistiOdabir;
        private System.Windows.Forms.Button uiActionSpremiOdabir;
        private System.Windows.Forms.DataGridView uiOutputPonudaRucka;
    }
}