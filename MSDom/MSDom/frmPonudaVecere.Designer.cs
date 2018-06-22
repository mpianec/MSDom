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
            this.uiOutputVasIzbor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPonudaVecere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputVasIzbor)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionPonistiOdabir
            // 
            this.uiActionPonistiOdabir.Location = new System.Drawing.Point(533, 340);
            this.uiActionPonistiOdabir.Name = "uiActionPonistiOdabir";
            this.uiActionPonistiOdabir.Size = new System.Drawing.Size(174, 23);
            this.uiActionPonistiOdabir.TabIndex = 5;
            this.uiActionPonistiOdabir.Text = "Poništi moj odabir";
            this.uiActionPonistiOdabir.UseVisualStyleBackColor = true;
            this.uiActionPonistiOdabir.Click += new System.EventHandler(this.uiActionPonistiOdabir_Click);
            // 
            // uiActionSpremiOdabir
            // 
            this.uiActionSpremiOdabir.Location = new System.Drawing.Point(533, 208);
            this.uiActionSpremiOdabir.Name = "uiActionSpremiOdabir";
            this.uiActionSpremiOdabir.Size = new System.Drawing.Size(174, 23);
            this.uiActionSpremiOdabir.TabIndex = 4;
            this.uiActionSpremiOdabir.Text = "Spremi odabir";
            this.uiActionSpremiOdabir.UseVisualStyleBackColor = true;
            this.uiActionSpremiOdabir.Click += new System.EventHandler(this.uiActionSpremiOdabir_Click);
            // 
            // uiOutputPonudaVecere
            // 
            this.uiOutputPonudaVecere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPonudaVecere.Location = new System.Drawing.Point(61, 40);
            this.uiOutputPonudaVecere.Name = "uiOutputPonudaVecere";
            this.uiOutputPonudaVecere.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputPonudaVecere.Size = new System.Drawing.Size(646, 162);
            this.uiOutputPonudaVecere.TabIndex = 3;
            // 
            // uiOutputVasIzbor
            // 
            this.uiOutputVasIzbor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputVasIzbor.Location = new System.Drawing.Point(61, 251);
            this.uiOutputVasIzbor.Name = "uiOutputVasIzbor";
            this.uiOutputVasIzbor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputVasIzbor.Size = new System.Drawing.Size(646, 83);
            this.uiOutputVasIzbor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Današnja ponuda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vaš izbor";
            // 
            // frmPonudaVecere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputVasIzbor);
            this.Controls.Add(this.uiActionPonistiOdabir);
            this.Controls.Add(this.uiActionSpremiOdabir);
            this.Controls.Add(this.uiOutputPonudaVecere);
            this.Name = "frmPonudaVecere";
            this.Text = "Ponuda večere";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPonudaVecere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputVasIzbor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionPonistiOdabir;
        private System.Windows.Forms.Button uiActionSpremiOdabir;
        private System.Windows.Forms.DataGridView uiOutputPonudaVecere;
        private System.Windows.Forms.DataGridView uiOutputVasIzbor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}