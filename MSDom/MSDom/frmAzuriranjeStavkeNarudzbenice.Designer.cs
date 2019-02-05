namespace MSDom
{
    partial class frmAzuriranjeStavkeNarudzbenice
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
            this.components = new System.ComponentModel.Container();
            this.uiOutputIdStavke = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiOutputNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiInputKolicina = new System.Windows.Forms.TextBox();
            this.uiActionAzuriraj = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputIdStavke
            // 
            this.uiOutputIdStavke.Location = new System.Drawing.Point(82, 44);
            this.uiOutputIdStavke.Name = "uiOutputIdStavke";
            this.uiOutputIdStavke.ReadOnly = true;
            this.uiOutputIdStavke.Size = new System.Drawing.Size(181, 20);
            this.uiOutputIdStavke.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id stavke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv lijeka";
            // 
            // uiOutputNaziv
            // 
            this.uiOutputNaziv.Location = new System.Drawing.Point(82, 76);
            this.uiOutputNaziv.Name = "uiOutputNaziv";
            this.uiOutputNaziv.ReadOnly = true;
            this.uiOutputNaziv.Size = new System.Drawing.Size(181, 20);
            this.uiOutputNaziv.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kolicina";
            // 
            // uiInputKolicina
            // 
            this.uiInputKolicina.Location = new System.Drawing.Point(82, 109);
            this.uiInputKolicina.Name = "uiInputKolicina";
            this.uiInputKolicina.Size = new System.Drawing.Size(181, 20);
            this.uiInputKolicina.TabIndex = 4;
            // 
            // uiActionAzuriraj
            // 
            this.uiActionAzuriraj.Location = new System.Drawing.Point(142, 149);
            this.uiActionAzuriraj.Name = "uiActionAzuriraj";
            this.uiActionAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.uiActionAzuriraj.TabIndex = 6;
            this.uiActionAzuriraj.Text = "Ažuriraj";
            this.uiActionAzuriraj.UseVisualStyleBackColor = true;
            this.uiActionAzuriraj.Click += new System.EventHandler(this.uiActionAzuriraj_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(MSDom.stavkeNarudzbenice);
            // 
            // frmAzuriranjeStavkeNarudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 196);
            this.Controls.Add(this.uiActionAzuriraj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiInputKolicina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiOutputNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputIdStavke);
            this.Name = "frmAzuriranjeStavkeNarudzbenice";
            this.Text = "frmAzuriranjeStavkeNarudzbenice";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiOutputIdStavke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiOutputNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiInputKolicina;
        private System.Windows.Forms.Button uiActionAzuriraj;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}