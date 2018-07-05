namespace MSDom
{
    partial class frmAnketa
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pitanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anketaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uiOutputAnkete = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pitanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pitanjeBindingSource
            // 
            this.pitanjeBindingSource.DataSource = typeof(MSDom.pitanje);
            // 
            // anketaBindingSource
            // 
            this.anketaBindingSource.DataSource = typeof(MSDom.anketa);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DSPitanje";
            reportDataSource3.Value = this.pitanjeBindingSource;
            reportDataSource4.Name = "DSAnketa";
            reportDataSource4.Value = this.anketaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MSDom.rprtAnketa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-4, 51);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(809, 491);
            this.reportViewer1.TabIndex = 0;
            // 
            // uiOutputAnkete
            // 
            this.uiOutputAnkete.DataSource = this.anketaBindingSource;
            this.uiOutputAnkete.DisplayMember = "naziv";
            this.uiOutputAnkete.FormattingEnabled = true;
            this.uiOutputAnkete.Location = new System.Drawing.Point(3, 24);
            this.uiOutputAnkete.Name = "uiOutputAnkete";
            this.uiOutputAnkete.Size = new System.Drawing.Size(121, 21);
            this.uiOutputAnkete.TabIndex = 1;
            this.uiOutputAnkete.ValueMember = "id";
            this.uiOutputAnkete.SelectedIndexChanged += new System.EventHandler(this.uiOutputAnkete_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anketa za ispis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(695, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pritisnite F1 za pomoć";
            // 
            // frmAnketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 541);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputAnkete);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmAnketa";
            this.Text = "Ispis ankete";
            this.Load += new System.EventHandler(this.frmAnketa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAnketa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pitanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pitanjeBindingSource;
        private System.Windows.Forms.ComboBox uiOutputAnkete;
        private System.Windows.Forms.BindingSource anketaBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}