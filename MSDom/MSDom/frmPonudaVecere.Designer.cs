namespace MSDom
{
    partial class frmPonudaVecere
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
            this.uiOutputPonudaVecere = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPonudaVecere)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionPonistiOdabir
            // 
            this.uiActionPonistiOdabir.Location = new System.Drawing.Point(335, 214);
            this.uiActionPonistiOdabir.Name = "uiActionPonistiOdabir";
            this.uiActionPonistiOdabir.Size = new System.Drawing.Size(174, 23);
            this.uiActionPonistiOdabir.TabIndex = 5;
            this.uiActionPonistiOdabir.Text = "Poništi moj odabir";
            this.uiActionPonistiOdabir.UseVisualStyleBackColor = true;
            // 
            // uiActionSpremiOdabir
            // 
            this.uiActionSpremiOdabir.Location = new System.Drawing.Point(61, 214);
            this.uiActionSpremiOdabir.Name = "uiActionSpremiOdabir";
            this.uiActionSpremiOdabir.Size = new System.Drawing.Size(174, 23);
            this.uiActionSpremiOdabir.TabIndex = 4;
            this.uiActionSpremiOdabir.Text = "Spremi odabir";
            this.uiActionSpremiOdabir.UseVisualStyleBackColor = true;
            // 
            // uiOutputPonudaVecere
            // 
            this.uiOutputPonudaVecere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPonudaVecere.Location = new System.Drawing.Point(61, 40);
            this.uiOutputPonudaVecere.Name = "uiOutputPonudaVecere";
            this.uiOutputPonudaVecere.Size = new System.Drawing.Size(448, 160);
            this.uiOutputPonudaVecere.TabIndex = 3;
            // 
            // frmPonudaVecere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 293);
            this.Controls.Add(this.uiActionPonistiOdabir);
            this.Controls.Add(this.uiActionSpremiOdabir);
            this.Controls.Add(this.uiOutputPonudaVecere);
            this.Name = "frmPonudaVecere";
            this.Text = "Ponuda večere";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPonudaVecere)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiActionPonistiOdabir;
        private System.Windows.Forms.Button uiActionSpremiOdabir;
        private System.Windows.Forms.DataGridView uiOutputPonudaVecere;
    }
}