namespace MSDom
{
    partial class frmJelovnikUnos
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
            this.uiInputPredjelo = new System.Windows.Forms.MaskedTextBox();
            this.uiInputMeso = new System.Windows.Forms.MaskedTextBox();
            this.uiInputPrilog = new System.Windows.Forms.MaskedTextBox();
            this.uiInputDesert = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uiInputKategorija = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uiActionUnos = new System.Windows.Forms.Button();
            this.izborKategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.izborKategorijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiInputPredjelo
            // 
            this.uiInputPredjelo.Location = new System.Drawing.Point(213, 62);
            this.uiInputPredjelo.Name = "uiInputPredjelo";
            this.uiInputPredjelo.Size = new System.Drawing.Size(258, 20);
            this.uiInputPredjelo.TabIndex = 0;
            // 
            // uiInputMeso
            // 
            this.uiInputMeso.Location = new System.Drawing.Point(213, 114);
            this.uiInputMeso.Name = "uiInputMeso";
            this.uiInputMeso.Size = new System.Drawing.Size(258, 20);
            this.uiInputMeso.TabIndex = 1;
            // 
            // uiInputPrilog
            // 
            this.uiInputPrilog.Location = new System.Drawing.Point(213, 88);
            this.uiInputPrilog.Name = "uiInputPrilog";
            this.uiInputPrilog.Size = new System.Drawing.Size(258, 20);
            this.uiInputPrilog.TabIndex = 2;
            // 
            // uiInputDesert
            // 
            this.uiInputDesert.Location = new System.Drawing.Point(213, 140);
            this.uiInputDesert.Name = "uiInputDesert";
            this.uiInputDesert.Size = new System.Drawing.Size(258, 20);
            this.uiInputDesert.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Predjelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prilog";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Meso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Desert";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kategorija";
            // 
            // uiInputKategorija
            // 
            this.uiInputKategorija.DataSource = this.izborKategorijaBindingSource;
            this.uiInputKategorija.DisplayMember = "imeKategorije";
            this.uiInputKategorija.FormattingEnabled = true;
            this.uiInputKategorija.Location = new System.Drawing.Point(213, 166);
            this.uiInputKategorija.Name = "uiInputKategorija";
            this.uiInputKategorija.Size = new System.Drawing.Size(258, 21);
            this.uiInputKategorija.TabIndex = 11;
            this.uiInputKategorija.ValueMember = "id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(40, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Unesite novi jelovnik:";
            // 
            // uiActionUnos
            // 
            this.uiActionUnos.Location = new System.Drawing.Point(213, 193);
            this.uiActionUnos.Name = "uiActionUnos";
            this.uiActionUnos.Size = new System.Drawing.Size(258, 23);
            this.uiActionUnos.TabIndex = 13;
            this.uiActionUnos.Text = "Unos";
            this.uiActionUnos.UseVisualStyleBackColor = true;
            this.uiActionUnos.Click += new System.EventHandler(this.uiActionUnos_Click);
            // 
            // izborKategorijaBindingSource
            // 
            this.izborKategorijaBindingSource.DataSource = typeof(MSDom.izborKategorija);
            // 
            // frmJelovnikUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 335);
            this.Controls.Add(this.uiActionUnos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uiInputKategorija);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiInputDesert);
            this.Controls.Add(this.uiInputPrilog);
            this.Controls.Add(this.uiInputMeso);
            this.Controls.Add(this.uiInputPredjelo);
            this.Name = "frmJelovnikUnos";
            this.Text = "Unos novog jelovnika";
            ((System.ComponentModel.ISupportInitialize)(this.izborKategorijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox uiInputPredjelo;
        private System.Windows.Forms.MaskedTextBox uiInputMeso;
        private System.Windows.Forms.MaskedTextBox uiInputPrilog;
        private System.Windows.Forms.MaskedTextBox uiInputDesert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox uiInputKategorija;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button uiActionUnos;
        private System.Windows.Forms.BindingSource izborKategorijaBindingSource;
    }
}