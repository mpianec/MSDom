namespace MSDom
{
    partial class frmPocetnaSpremacica
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
            this.label1 = new System.Windows.Forms.Label();
            this.uiActionPonistiRezervacije = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vaše mogučnosti:";
            // 
            // uiActionPonistiRezervacije
            // 
            this.uiActionPonistiRezervacije.Location = new System.Drawing.Point(137, 81);
            this.uiActionPonistiRezervacije.Name = "uiActionPonistiRezervacije";
            this.uiActionPonistiRezervacije.Size = new System.Drawing.Size(120, 23);
            this.uiActionPonistiRezervacije.TabIndex = 2;
            this.uiActionPonistiRezervacije.Text = "Poništi rezervacije";
            this.uiActionPonistiRezervacije.UseVisualStyleBackColor = true;
            this.uiActionPonistiRezervacije.Click += new System.EventHandler(this.uiInputPonistiRezervacije_Click);
            // 
            // frmPocetnaSpremacica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 278);
            this.Controls.Add(this.uiActionPonistiRezervacije);
            this.Controls.Add(this.label1);
            this.Name = "frmPocetnaSpremacica";
            this.Text = "Spremačica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uiActionPonistiRezervacije;
    }
}