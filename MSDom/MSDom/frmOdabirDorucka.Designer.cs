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
            this.label1 = new System.Windows.Forms.Label();
            this.uiOutputVasOdabir = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPonudaDorucka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputVasOdabir)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputPonudaDorucka
            // 
            this.uiOutputPonudaDorucka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPonudaDorucka.Location = new System.Drawing.Point(50, 40);
            this.uiOutputPonudaDorucka.Name = "uiOutputPonudaDorucka";
            this.uiOutputPonudaDorucka.Size = new System.Drawing.Size(616, 137);
            this.uiOutputPonudaDorucka.TabIndex = 0;
            // 
            // uiActionSpremiOdabir
            // 
            this.uiActionSpremiOdabir.Location = new System.Drawing.Point(492, 183);
            this.uiActionSpremiOdabir.Name = "uiActionSpremiOdabir";
            this.uiActionSpremiOdabir.Size = new System.Drawing.Size(174, 23);
            this.uiActionSpremiOdabir.TabIndex = 1;
            this.uiActionSpremiOdabir.Text = "Spremi odabir";
            this.uiActionSpremiOdabir.UseVisualStyleBackColor = true;
            this.uiActionSpremiOdabir.Click += new System.EventHandler(this.uiActionSpremiOdabir_Click);
            // 
            // uiActionPonistiOdabir
            // 
            this.uiActionPonistiOdabir.Location = new System.Drawing.Point(492, 307);
            this.uiActionPonistiOdabir.Name = "uiActionPonistiOdabir";
            this.uiActionPonistiOdabir.Size = new System.Drawing.Size(174, 23);
            this.uiActionPonistiOdabir.TabIndex = 2;
            this.uiActionPonistiOdabir.Text = "Poništi moj odabir";
            this.uiActionPonistiOdabir.UseVisualStyleBackColor = true;
            this.uiActionPonistiOdabir.Click += new System.EventHandler(this.uiActionPonistiOdabir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sutrašnja ponuda";
            // 
            // uiOutputVasOdabir
            // 
            this.uiOutputVasOdabir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputVasOdabir.Location = new System.Drawing.Point(50, 236);
            this.uiOutputVasOdabir.Name = "uiOutputVasOdabir";
            this.uiOutputVasOdabir.Size = new System.Drawing.Size(616, 65);
            this.uiOutputVasOdabir.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vaš odabir";
            // 
            // frmOdabirDorucka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 387);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiOutputVasOdabir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiActionPonistiOdabir);
            this.Controls.Add(this.uiActionSpremiOdabir);
            this.Controls.Add(this.uiOutputPonudaDorucka);
            this.Name = "frmOdabirDorucka";
            this.Text = "Ponuda doručka";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPonudaDorucka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputVasOdabir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uiOutputPonudaDorucka;
        private System.Windows.Forms.Button uiActionSpremiOdabir;
        private System.Windows.Forms.Button uiActionPonistiOdabir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiOutputVasOdabir;
        private System.Windows.Forms.Label label2;
    }
}