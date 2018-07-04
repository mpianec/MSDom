namespace MSDom
{
    partial class frmPregledSastanaka
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
            this.uiOutputSastanak = new System.Windows.Forms.DataGridView();
            this.uiActionObrisi = new System.Windows.Forms.Button();
            this.sastanakSDoktoromBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pitanjeSAnketeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSastanak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sastanakSDoktoromBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitanjeSAnketeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputSastanak
            // 
            this.uiOutputSastanak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputSastanak.Location = new System.Drawing.Point(-1, 0);
            this.uiOutputSastanak.Name = "uiOutputSastanak";
            this.uiOutputSastanak.Size = new System.Drawing.Size(802, 375);
            this.uiOutputSastanak.TabIndex = 0;
            // 
            // uiActionObrisi
            // 
            this.uiActionObrisi.Location = new System.Drawing.Point(296, 387);
            this.uiActionObrisi.Name = "uiActionObrisi";
            this.uiActionObrisi.Size = new System.Drawing.Size(222, 51);
            this.uiActionObrisi.TabIndex = 1;
            this.uiActionObrisi.Text = "Obriši sastanak";
            this.uiActionObrisi.UseVisualStyleBackColor = true;
            this.uiActionObrisi.Click += new System.EventHandler(this.uiActionObrisi_Click);
            // 
            // sastanakSDoktoromBindingSource
            // 
            this.sastanakSDoktoromBindingSource.DataSource = typeof(MSDom.sastanakSDoktorom);
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(MSDom.korisnik);
            // 
            // pitanjeSAnketeBindingSource
            // 
            this.pitanjeSAnketeBindingSource.DataSource = typeof(MSDom.pitanjeSAnkete);
            // 
            // frmPregledSastanaka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiActionObrisi);
            this.Controls.Add(this.uiOutputSastanak);
            this.Name = "frmPregledSastanaka";
            this.Text = "frmPregledSastanaka";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSastanak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sastanakSDoktoromBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitanjeSAnketeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uiOutputSastanak;
        private System.Windows.Forms.Button uiActionObrisi;
        private System.Windows.Forms.BindingSource pitanjeSAnketeBindingSource;
        private System.Windows.Forms.BindingSource sastanakSDoktoromBindingSource;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
    }
}