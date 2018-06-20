namespace MSDom
{
    partial class frmBrisanjeAzuriranjeJelovnika
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
            this.uiOutputPopisJelovnika = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uiActionAzuriraj = new System.Windows.Forms.Button();
            this.izborBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPopisJelovnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izborBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputPopisJelovnika
            // 
            this.uiOutputPopisJelovnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPopisJelovnika.Location = new System.Drawing.Point(13, 47);
            this.uiOutputPopisJelovnika.Name = "uiOutputPopisJelovnika";
            this.uiOutputPopisJelovnika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputPopisJelovnika.Size = new System.Drawing.Size(681, 176);
            this.uiOutputPopisJelovnika.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis jelovnika";
            // 
            // uiActionAzuriraj
            // 
            this.uiActionAzuriraj.Location = new System.Drawing.Point(516, 229);
            this.uiActionAzuriraj.Name = "uiActionAzuriraj";
            this.uiActionAzuriraj.Size = new System.Drawing.Size(178, 23);
            this.uiActionAzuriraj.TabIndex = 3;
            this.uiActionAzuriraj.Text = "Ažuriraj jelovnik";
            this.uiActionAzuriraj.UseVisualStyleBackColor = true;
            this.uiActionAzuriraj.Click += new System.EventHandler(this.uiActionAzuriraj_Click);
            // 
            // izborBindingSource
            // 
            this.izborBindingSource.DataSource = typeof(MSDom.izbor);
            // 
            // frmBrisanjeAzuriranjeJelovnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 294);
            this.Controls.Add(this.uiActionAzuriraj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputPopisJelovnika);
            this.Name = "frmBrisanjeAzuriranjeJelovnika";
            this.Text = "Brisanje / ažuriranje jelovnika";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPopisJelovnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izborBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uiOutputPopisJelovnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uiActionAzuriraj;
        private System.Windows.Forms.BindingSource izborBindingSource;
    }
}