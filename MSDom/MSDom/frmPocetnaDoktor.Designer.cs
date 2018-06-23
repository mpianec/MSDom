namespace MSDom
{
    partial class frmPocetnaDoktor
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
            this.uiActionPregledSastanaka = new System.Windows.Forms.Button();
            this.uiActionPopunjavanjeZdKartona = new System.Windows.Forms.Button();
            this.uiActionNaruciLijekove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(191, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vaše mogučnosti:";
            // 
            // uiActionPregledSastanaka
            // 
            this.uiActionPregledSastanaka.Location = new System.Drawing.Point(249, 154);
            this.uiActionPregledSastanaka.Name = "uiActionPregledSastanaka";
            this.uiActionPregledSastanaka.Size = new System.Drawing.Size(148, 23);
            this.uiActionPregledSastanaka.TabIndex = 7;
            this.uiActionPregledSastanaka.Text = "Pregled sastanaka";
            this.uiActionPregledSastanaka.UseVisualStyleBackColor = true;
            // 
            // uiActionPopunjavanjeZdKartona
            // 
            this.uiActionPopunjavanjeZdKartona.Location = new System.Drawing.Point(249, 124);
            this.uiActionPopunjavanjeZdKartona.Name = "uiActionPopunjavanjeZdKartona";
            this.uiActionPopunjavanjeZdKartona.Size = new System.Drawing.Size(148, 23);
            this.uiActionPopunjavanjeZdKartona.TabIndex = 6;
            this.uiActionPopunjavanjeZdKartona.Text = "Nalazi";
            this.uiActionPopunjavanjeZdKartona.UseVisualStyleBackColor = true;
            // 
            // uiActionNaruciLijekove
            // 
            this.uiActionNaruciLijekove.Location = new System.Drawing.Point(249, 183);
            this.uiActionNaruciLijekove.Name = "uiActionNaruciLijekove";
            this.uiActionNaruciLijekove.Size = new System.Drawing.Size(148, 23);
            this.uiActionNaruciLijekove.TabIndex = 10;
            this.uiActionNaruciLijekove.Text = "Naruči lijekove";
            this.uiActionNaruciLijekove.UseVisualStyleBackColor = true;
            // 
            // frmPocetnaDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 344);
            this.Controls.Add(this.uiActionNaruciLijekove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiActionPregledSastanaka);
            this.Controls.Add(this.uiActionPopunjavanjeZdKartona);
            this.Name = "frmPocetnaDoktor";
            this.Text = "frmPocetnaDoktor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uiActionPregledSastanaka;
        private System.Windows.Forms.Button uiActionPopunjavanjeZdKartona;
        private System.Windows.Forms.Button uiActionNaruciLijekove;
    }
}