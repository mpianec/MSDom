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
            this.pitanjeSAnketeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sastanakSDoktoromBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanarIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumVrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnik1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSastanak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitanjeSAnketeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sastanakSDoktoromBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputSastanak
            // 
            this.uiOutputSastanak.AutoGenerateColumns = false;
            this.uiOutputSastanak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputSastanak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.stanarIdDataGridViewTextBoxColumn,
            this.doktorIdDataGridViewTextBoxColumn,
            this.datumVrijemeDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.korisnik1DataGridViewTextBoxColumn});
            this.uiOutputSastanak.DataSource = this.sastanakSDoktoromBindingSource;
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
            // pitanjeSAnketeBindingSource
            // 
            this.pitanjeSAnketeBindingSource.DataSource = typeof(MSDom.pitanjeSAnkete);
            // 
            // sastanakSDoktoromBindingSource
            // 
            this.sastanakSDoktoromBindingSource.DataSource = typeof(MSDom.sastanakSDoktorom);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // stanarIdDataGridViewTextBoxColumn
            // 
            this.stanarIdDataGridViewTextBoxColumn.DataPropertyName = "stanarId";
            this.stanarIdDataGridViewTextBoxColumn.HeaderText = "stanarId";
            this.stanarIdDataGridViewTextBoxColumn.Name = "stanarIdDataGridViewTextBoxColumn";
            // 
            // doktorIdDataGridViewTextBoxColumn
            // 
            this.doktorIdDataGridViewTextBoxColumn.DataPropertyName = "doktorId";
            this.doktorIdDataGridViewTextBoxColumn.HeaderText = "doktorId";
            this.doktorIdDataGridViewTextBoxColumn.Name = "doktorIdDataGridViewTextBoxColumn";
            // 
            // datumVrijemeDataGridViewTextBoxColumn
            // 
            this.datumVrijemeDataGridViewTextBoxColumn.DataPropertyName = "datumVrijeme";
            this.datumVrijemeDataGridViewTextBoxColumn.HeaderText = "datumVrijeme";
            this.datumVrijemeDataGridViewTextBoxColumn.Name = "datumVrijemeDataGridViewTextBoxColumn";
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisnik1DataGridViewTextBoxColumn
            // 
            this.korisnik1DataGridViewTextBoxColumn.DataPropertyName = "korisnik1";
            this.korisnik1DataGridViewTextBoxColumn.HeaderText = "korisnik1";
            this.korisnik1DataGridViewTextBoxColumn.Name = "korisnik1DataGridViewTextBoxColumn";
            this.korisnik1DataGridViewTextBoxColumn.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pitanjeSAnketeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sastanakSDoktoromBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uiOutputSastanak;
        private System.Windows.Forms.Button uiActionObrisi;
        private System.Windows.Forms.BindingSource pitanjeSAnketeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanarIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumVrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnik1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sastanakSDoktoromBindingSource;
    }
}