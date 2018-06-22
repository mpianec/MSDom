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
            this.uiOutputVasOdabir = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPonudaRucka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputVasOdabir)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionPonistiOdabir
            // 
            this.uiActionPonistiOdabir.Location = new System.Drawing.Point(513, 285);
            this.uiActionPonistiOdabir.Name = "uiActionPonistiOdabir";
            this.uiActionPonistiOdabir.Size = new System.Drawing.Size(174, 23);
            this.uiActionPonistiOdabir.TabIndex = 5;
            this.uiActionPonistiOdabir.Text = "Poništi moj odabir";
            this.uiActionPonistiOdabir.UseVisualStyleBackColor = true;
            this.uiActionPonistiOdabir.Click += new System.EventHandler(this.uiActionPonistiOdabir_Click);
            // 
            // uiActionSpremiOdabir
            // 
            this.uiActionSpremiOdabir.Location = new System.Drawing.Point(513, 178);
            this.uiActionSpremiOdabir.Name = "uiActionSpremiOdabir";
            this.uiActionSpremiOdabir.Size = new System.Drawing.Size(174, 23);
            this.uiActionSpremiOdabir.TabIndex = 4;
            this.uiActionSpremiOdabir.Text = "Spremi odabir";
            this.uiActionSpremiOdabir.UseVisualStyleBackColor = true;
            this.uiActionSpremiOdabir.Click += new System.EventHandler(this.uiActionSpremiOdabir_Click);
            // 
            // uiOutputPonudaRucka
            // 
            this.uiOutputPonudaRucka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPonudaRucka.Location = new System.Drawing.Point(52, 39);
            this.uiOutputPonudaRucka.Name = "uiOutputPonudaRucka";
            this.uiOutputPonudaRucka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputPonudaRucka.Size = new System.Drawing.Size(635, 133);
            this.uiOutputPonudaRucka.TabIndex = 3;
            // 
            // uiOutputVasOdabir
            // 
            this.uiOutputVasOdabir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputVasOdabir.Location = new System.Drawing.Point(52, 215);
            this.uiOutputVasOdabir.Name = "uiOutputVasOdabir";
            this.uiOutputVasOdabir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputVasOdabir.Size = new System.Drawing.Size(635, 64);
            this.uiOutputVasOdabir.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Današnja ponuda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vaš odabir";
            // 
            // frmPonudaRucka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 347);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputVasOdabir);
            this.Controls.Add(this.uiActionPonistiOdabir);
            this.Controls.Add(this.uiActionSpremiOdabir);
            this.Controls.Add(this.uiOutputPonudaRucka);
            this.Name = "frmPonudaRucka";
            this.Text = "Ponuda ručka";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPonudaRucka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputVasOdabir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionPonistiOdabir;
        private System.Windows.Forms.Button uiActionSpremiOdabir;
        private System.Windows.Forms.DataGridView uiOutputPonudaRucka;
        private System.Windows.Forms.DataGridView uiOutputVasOdabir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}