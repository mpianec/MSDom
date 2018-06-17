namespace MSDom
{
    partial class frmOdabirDorucka
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
            this.uiOutputPonudaDorucka = new System.Windows.Forms.DataGridView();
            this.uiActionSpremiOdabir = new System.Windows.Forms.Button();
            this.uiActionPonistiOdabir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPonudaDorucka)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputPonudaDorucka
            // 
            this.uiOutputPonudaDorucka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPonudaDorucka.Location = new System.Drawing.Point(50, 40);
            this.uiOutputPonudaDorucka.Name = "uiOutputPonudaDorucka";
            this.uiOutputPonudaDorucka.Size = new System.Drawing.Size(448, 160);
            this.uiOutputPonudaDorucka.TabIndex = 0;
            // 
            // uiActionSpremiOdabir
            // 
            this.uiActionSpremiOdabir.Location = new System.Drawing.Point(50, 214);
            this.uiActionSpremiOdabir.Name = "uiActionSpremiOdabir";
            this.uiActionSpremiOdabir.Size = new System.Drawing.Size(174, 23);
            this.uiActionSpremiOdabir.TabIndex = 1;
            this.uiActionSpremiOdabir.Text = "Spremi odabir";
            this.uiActionSpremiOdabir.UseVisualStyleBackColor = true;
            // 
            // uiActionPonistiOdabir
            // 
            this.uiActionPonistiOdabir.Location = new System.Drawing.Point(324, 214);
            this.uiActionPonistiOdabir.Name = "uiActionPonistiOdabir";
            this.uiActionPonistiOdabir.Size = new System.Drawing.Size(174, 23);
            this.uiActionPonistiOdabir.TabIndex = 2;
            this.uiActionPonistiOdabir.Text = "Poništi moj odabir";
            this.uiActionPonistiOdabir.UseVisualStyleBackColor = true;
            // 
            // frmOdabirDorucka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 302);
            this.Controls.Add(this.uiActionPonistiOdabir);
            this.Controls.Add(this.uiActionSpremiOdabir);
            this.Controls.Add(this.uiOutputPonudaDorucka);
            this.Name = "frmOdabirDorucka";
            this.Text = "Ponuda doručka";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPonudaDorucka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uiOutputPonudaDorucka;
        private System.Windows.Forms.Button uiActionSpremiOdabir;
        private System.Windows.Forms.Button uiActionPonistiOdabir;
    }
}