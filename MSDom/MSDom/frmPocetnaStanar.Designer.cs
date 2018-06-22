namespace MSDom
{
    partial class frmPocetnaStanar
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
            this.uiActionOdabirDorucka = new System.Windows.Forms.Button();
            this.uiActionOdabirRucka = new System.Windows.Forms.Button();
            this.uiActionOdabirVecere = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uiActionOdabirDorucka
            // 
            this.uiActionOdabirDorucka.Location = new System.Drawing.Point(132, 63);
            this.uiActionOdabirDorucka.Name = "uiActionOdabirDorucka";
            this.uiActionOdabirDorucka.Size = new System.Drawing.Size(148, 23);
            this.uiActionOdabirDorucka.TabIndex = 0;
            this.uiActionOdabirDorucka.Text = "Odabir doručka";
            this.uiActionOdabirDorucka.UseVisualStyleBackColor = true;
            this.uiActionOdabirDorucka.Click += new System.EventHandler(this.uiActionOdabirDorucka_Click);
            // 
            // uiActionOdabirRucka
            // 
            this.uiActionOdabirRucka.Location = new System.Drawing.Point(132, 93);
            this.uiActionOdabirRucka.Name = "uiActionOdabirRucka";
            this.uiActionOdabirRucka.Size = new System.Drawing.Size(148, 23);
            this.uiActionOdabirRucka.TabIndex = 1;
            this.uiActionOdabirRucka.Text = "Odabir ručka";
            this.uiActionOdabirRucka.UseVisualStyleBackColor = true;
            this.uiActionOdabirRucka.Click += new System.EventHandler(this.uiActionOdabirRucka_Click);
            // 
            // uiActionOdabirVecere
            // 
            this.uiActionOdabirVecere.Location = new System.Drawing.Point(132, 122);
            this.uiActionOdabirVecere.Name = "uiActionOdabirVecere";
            this.uiActionOdabirVecere.Size = new System.Drawing.Size(148, 23);
            this.uiActionOdabirVecere.TabIndex = 2;
            this.uiActionOdabirVecere.Text = "Odabir večere";
            this.uiActionOdabirVecere.UseVisualStyleBackColor = true;
            this.uiActionOdabirVecere.Click += new System.EventHandler(this.uiActionOdabirVecere_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Veše mogučnosti:";
            // 
            // frmPocetnaStanar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiActionOdabirVecere);
            this.Controls.Add(this.uiActionOdabirRucka);
            this.Controls.Add(this.uiActionOdabirDorucka);
            this.Name = "frmPocetnaStanar";
            this.Text = "Stanar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionOdabirDorucka;
        private System.Windows.Forms.Button uiActionOdabirRucka;
        private System.Windows.Forms.Button uiActionOdabirVecere;
        private System.Windows.Forms.Label label1;
    }
}