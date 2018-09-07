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
            this.lijekoviZaDijagnozuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nalazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.label1 = new System.Windows.Forms.Label();
            this.uiOutputPrikaz = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviZaDijagnozuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lijekoviZaDijagnozuBindingSource
            // 
            this.lijekoviZaDijagnozuBindingSource.DataSource = typeof(MSDom.lijekoviZaDijagnozu);
            // 
            // nalazBindingSource
            // 
            this.nalazBindingSource.DataSource = typeof(MSDom.nalaz);
            // 
            // lijekBindingSource
            // 
            this.lijekBindingSource.DataSource = typeof(MSDom.lijek);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 26);
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
            this.uiOutputPrikaz.Location = new System.Drawing.Point(31, 51);
            this.uiOutputPrikaz.Name = "uiOutputPrikaz";
            this.uiOutputPrikaz.Size = new System.Drawing.Size(119, 21);
            this.uiOutputPrikaz.TabIndex = 2;
            this.uiOutputPrikaz.ValueMember = "id";
            this.uiOutputPrikaz.SelectedIndexChanged += new System.EventHandler(this.uiOutputPrikaz_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pritisnite F1 za pomoć";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ispis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmNarudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiOutputPrikaz);
            this.Controls.Add(this.label1);
            this.Name = "frmNarudzbenice";
            this.Text = "frmNarudzbenice";
            this.Load += new System.EventHandler(this.frmNarudzbenice_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNarudzbenice_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviZaDijagnozuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource lijekoviZaDijagnozuBindingSource;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uiOutputPrikaz;
        private System.Windows.Forms.BindingSource nalazBindingSource;
        private System.Windows.Forms.BindingSource lijekBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}