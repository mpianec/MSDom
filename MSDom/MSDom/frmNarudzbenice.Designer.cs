namespace MSDom
{
    partial class frmNarudzbenice
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
            this.lijekoviZaDijagnozuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.uiOutputPrikaz = new System.Windows.Forms.ComboBox();
            this.nalazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviZaDijagnozuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalazBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lijekoviZaDijagnozuBindingSource
            // 
            this.lijekoviZaDijagnozuBindingSource.DataSource = typeof(MSDom.lijekoviZaDijagnozu);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DsNarudzbenice";
            reportDataSource1.Value = this.lijekoviZaDijagnozuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MSDom.IzvještajNarudžbenica.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 350);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prikaz narudžbenice";
            // 
            // uiOutputPrikaz
            // 
            this.uiOutputPrikaz.DataSource = this.nalazBindingSource;
            this.uiOutputPrikaz.DisplayMember = "nazivBolesti";
            this.uiOutputPrikaz.FormattingEnabled = true;
            this.uiOutputPrikaz.Location = new System.Drawing.Point(17, 34);
            this.uiOutputPrikaz.Name = "uiOutputPrikaz";
            this.uiOutputPrikaz.Size = new System.Drawing.Size(119, 21);
            this.uiOutputPrikaz.TabIndex = 2;
            this.uiOutputPrikaz.ValueMember = "id";
            // 
            // nalazBindingSource
            // 
            this.nalazBindingSource.DataSource = typeof(MSDom.nalaz);
            // 
            // frmNarudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiOutputPrikaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmNarudzbenice";
            this.Text = "frmNarudzbenice";
            this.Load += new System.EventHandler(this.frmNarudzbenice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviZaDijagnozuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalazBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource lijekoviZaDijagnozuBindingSource;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uiOutputPrikaz;
        private System.Windows.Forms.BindingSource nalazBindingSource;
    }
}