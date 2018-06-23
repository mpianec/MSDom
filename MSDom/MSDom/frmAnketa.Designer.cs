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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pitanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anketaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uiOutputAnkete = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            reportDataSource1.Name = "DSPitanje";
            reportDataSource1.Value = this.pitanjeBindingSource;
            reportDataSource2.Name = "DSAnketa";
            reportDataSource2.Value = this.anketaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MSDom.rprtAnketa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-4, 51);
            this.reportViewer1.Name = "reportViewer1";
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
            // frmAnketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputAnkete);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmAnketa";
            this.Text = "Ispis ankete";
            this.Load += new System.EventHandler(this.frmAnketa_Load);
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
    }
}