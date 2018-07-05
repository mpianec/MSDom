namespace MSDom
{
    partial class frmPonistiRezervaciju
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
            this.uiOutputRezervacije = new System.Windows.Forms.DataGridView();
            this.uiActionPonisti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputRezervacije
            // 
            this.uiOutputRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputRezervacije.Location = new System.Drawing.Point(19, 61);
            this.uiOutputRezervacije.Name = "uiOutputRezervacije";
            this.uiOutputRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputRezervacije.Size = new System.Drawing.Size(480, 150);
            this.uiOutputRezervacije.TabIndex = 0;
            // 
            // uiActionPonisti
            // 
            this.uiActionPonisti.Location = new System.Drawing.Point(222, 245);
            this.uiActionPonisti.Name = "uiActionPonisti";
            this.uiActionPonisti.Size = new System.Drawing.Size(122, 23);
            this.uiActionPonisti.TabIndex = 1;
            this.uiActionPonisti.Text = "Poništi rezervaciju";
            this.uiActionPonisti.UseVisualStyleBackColor = true;
            this.uiActionPonisti.Click += new System.EventHandler(this.uiActionPonisti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rezervacije praonica: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pritisnite F1 za pomoć";
            // 
            // frmPonistiRezervaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 304);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiActionPonisti);
            this.Controls.Add(this.uiOutputRezervacije);
            this.Name = "frmPonistiRezervaciju";
            this.Text = "Poništavanje rezervacije";
            this.Load += new System.EventHandler(this.frmPonistiRezervaciju_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPonistiRezervaciju_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uiOutputRezervacije;
        private System.Windows.Forms.Button uiActionPonisti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}