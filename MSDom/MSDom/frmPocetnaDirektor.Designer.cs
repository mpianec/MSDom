namespace MSDom
{
    partial class frmPocetnaDirektor
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
            this.uiActionOdjava = new System.Windows.Forms.Button();
            this.uiActionRegistrirajNovogKorisnika = new System.Windows.Forms.Button();
            this.uiActionPregledKorisnika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(56, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vaše mogučnosti:";
            // 
            // uiActionOdjava
            // 
            this.uiActionOdjava.Location = new System.Drawing.Point(448, 21);
            this.uiActionOdjava.Name = "uiActionOdjava";
            this.uiActionOdjava.Size = new System.Drawing.Size(75, 23);
            this.uiActionOdjava.TabIndex = 1;
            this.uiActionOdjava.Text = "Odjava";
            this.uiActionOdjava.UseVisualStyleBackColor = true;
            // 
            // uiActionRegistrirajNovogKorisnika
            // 
            this.uiActionRegistrirajNovogKorisnika.Location = new System.Drawing.Point(126, 72);
            this.uiActionRegistrirajNovogKorisnika.Name = "uiActionRegistrirajNovogKorisnika";
            this.uiActionRegistrirajNovogKorisnika.Size = new System.Drawing.Size(166, 23);
            this.uiActionRegistrirajNovogKorisnika.TabIndex = 2;
            this.uiActionRegistrirajNovogKorisnika.Text = "Registrirajte novog korisnika";
            this.uiActionRegistrirajNovogKorisnika.UseVisualStyleBackColor = true;
            this.uiActionRegistrirajNovogKorisnika.Click += new System.EventHandler(this.uiActionRegistrirajNovogKorisnika_Click);
            // 
            // uiActionPregledKorisnika
            // 
            this.uiActionPregledKorisnika.Location = new System.Drawing.Point(126, 102);
            this.uiActionPregledKorisnika.Name = "uiActionPregledKorisnika";
            this.uiActionPregledKorisnika.Size = new System.Drawing.Size(166, 23);
            this.uiActionPregledKorisnika.TabIndex = 3;
            this.uiActionPregledKorisnika.Text = "Pregled korisnika";
            this.uiActionPregledKorisnika.UseVisualStyleBackColor = true;
            // 
            // frmPocetnaDirektor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 297);
            this.Controls.Add(this.uiActionPregledKorisnika);
            this.Controls.Add(this.uiActionRegistrirajNovogKorisnika);
            this.Controls.Add(this.uiActionOdjava);
            this.Controls.Add(this.label1);
            this.Name = "frmPocetnaDirektor";
            this.Text = "Direktor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uiActionOdjava;
        private System.Windows.Forms.Button uiActionRegistrirajNovogKorisnika;
        private System.Windows.Forms.Button uiActionPregledKorisnika;
    }
}