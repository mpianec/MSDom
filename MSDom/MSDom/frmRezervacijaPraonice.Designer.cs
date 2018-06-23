namespace MSDom
{
    partial class frmRezervacijaPraonice
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
            this.uiActionRezervirajPraonicu = new System.Windows.Forms.Button();
            this.uiOutputSlobodnePraonice = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uiOutputMojeRezervacije = new System.Windows.Forms.DataGridView();
            this.uiActionPoništiRezervaciju = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uiInputDatumRezervacije = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSlobodnePraonice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputMojeRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionRezervirajPraonicu
            // 
            this.uiActionRezervirajPraonicu.Location = new System.Drawing.Point(432, 42);
            this.uiActionRezervirajPraonicu.Name = "uiActionRezervirajPraonicu";
            this.uiActionRezervirajPraonicu.Size = new System.Drawing.Size(75, 23);
            this.uiActionRezervirajPraonicu.TabIndex = 0;
            this.uiActionRezervirajPraonicu.Text = "Rezerviraj";
            this.uiActionRezervirajPraonicu.UseVisualStyleBackColor = true;
            this.uiActionRezervirajPraonicu.Click += new System.EventHandler(this.uiActionRezervirajPraonicu_Click);
            // 
            // uiOutputSlobodnePraonice
            // 
            this.uiOutputSlobodnePraonice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputSlobodnePraonice.Location = new System.Drawing.Point(19, 42);
            this.uiOutputSlobodnePraonice.Name = "uiOutputSlobodnePraonice";
            this.uiOutputSlobodnePraonice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputSlobodnePraonice.Size = new System.Drawing.Size(393, 150);
            this.uiOutputSlobodnePraonice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Slobodne praonice";
            // 
            // uiOutputMojeRezervacije
            // 
            this.uiOutputMojeRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputMojeRezervacije.Location = new System.Drawing.Point(19, 219);
            this.uiOutputMojeRezervacije.Name = "uiOutputMojeRezervacije";
            this.uiOutputMojeRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputMojeRezervacije.Size = new System.Drawing.Size(393, 150);
            this.uiOutputMojeRezervacije.TabIndex = 3;
            // 
            // uiActionPoništiRezervaciju
            // 
            this.uiActionPoništiRezervaciju.Location = new System.Drawing.Point(432, 323);
            this.uiActionPoništiRezervaciju.Name = "uiActionPoništiRezervaciju";
            this.uiActionPoništiRezervaciju.Size = new System.Drawing.Size(75, 23);
            this.uiActionPoništiRezervaciju.TabIndex = 4;
            this.uiActionPoništiRezervaciju.Text = "Poništi rezervaciju";
            this.uiActionPoništiRezervaciju.UseVisualStyleBackColor = true;
            this.uiActionPoništiRezervaciju.Click += new System.EventHandler(this.uiActionPoništiRezervaciju_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Moje rezervacije";
            // 
            // uiInputDatumRezervacije
            // 
            this.uiInputDatumRezervacije.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uiInputDatumRezervacije.Location = new System.Drawing.Point(212, 16);
            this.uiInputDatumRezervacije.Name = "uiInputDatumRezervacije";
            this.uiInputDatumRezervacije.Size = new System.Drawing.Size(200, 20);
            this.uiInputDatumRezervacije.TabIndex = 6;
            // 
            // frmRezervacijaPraonice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 399);
            this.Controls.Add(this.uiInputDatumRezervacije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiActionPoništiRezervaciju);
            this.Controls.Add(this.uiOutputMojeRezervacije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputSlobodnePraonice);
            this.Controls.Add(this.uiActionRezervirajPraonicu);
            this.Name = "frmRezervacijaPraonice";
            this.Text = "Rezervacija praonice";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSlobodnePraonice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputMojeRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionRezervirajPraonicu;
        private System.Windows.Forms.DataGridView uiOutputSlobodnePraonice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiOutputMojeRezervacije;
        private System.Windows.Forms.Button uiActionPoništiRezervaciju;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker uiInputDatumRezervacije;
    }
}