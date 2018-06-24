namespace MSDom
{
    partial class frmPotsjetnici
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
            this.uiOutputPotsjetnici = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uiActionObrisi = new System.Windows.Forms.Button();
            this.uiActionAzuriraj = new System.Windows.Forms.Button();
            this.uiActionDodaj = new System.Windows.Forms.Button();
            this.podsjetnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumVrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razlogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPotsjetnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podsjetnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputPotsjetnici
            // 
            this.uiOutputPotsjetnici.AutoGenerateColumns = false;
            this.uiOutputPotsjetnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPotsjetnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.korisnikIdDataGridViewTextBoxColumn,
            this.datumVrijemeDataGridViewTextBoxColumn,
            this.razlogDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn});
            this.uiOutputPotsjetnici.DataSource = this.podsjetnikBindingSource;
            this.uiOutputPotsjetnici.Location = new System.Drawing.Point(12, 26);
            this.uiOutputPotsjetnici.Name = "uiOutputPotsjetnici";
            this.uiOutputPotsjetnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputPotsjetnici.Size = new System.Drawing.Size(659, 150);
            this.uiOutputPotsjetnici.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis podsjetnika";
            // 
            // uiActionObrisi
            // 
            this.uiActionObrisi.Location = new System.Drawing.Point(13, 183);
            this.uiActionObrisi.Name = "uiActionObrisi";
            this.uiActionObrisi.Size = new System.Drawing.Size(149, 23);
            this.uiActionObrisi.TabIndex = 2;
            this.uiActionObrisi.Text = "Obriši potsjetnik";
            this.uiActionObrisi.UseVisualStyleBackColor = true;
            this.uiActionObrisi.Click += new System.EventHandler(this.uiActionObrisi_Click);
            // 
            // uiActionAzuriraj
            // 
            this.uiActionAzuriraj.Location = new System.Drawing.Point(265, 183);
            this.uiActionAzuriraj.Name = "uiActionAzuriraj";
            this.uiActionAzuriraj.Size = new System.Drawing.Size(149, 23);
            this.uiActionAzuriraj.TabIndex = 3;
            this.uiActionAzuriraj.Text = "Ažuriraj potsjetnik";
            this.uiActionAzuriraj.UseVisualStyleBackColor = true;
            this.uiActionAzuriraj.Click += new System.EventHandler(this.uiActionAzuriraj_Click);
            // 
            // uiActionDodaj
            // 
            this.uiActionDodaj.Location = new System.Drawing.Point(521, 182);
            this.uiActionDodaj.Name = "uiActionDodaj";
            this.uiActionDodaj.Size = new System.Drawing.Size(150, 23);
            this.uiActionDodaj.TabIndex = 4;
            this.uiActionDodaj.Text = "Novi potsjetnik";
            this.uiActionDodaj.UseVisualStyleBackColor = true;
            this.uiActionDodaj.Click += new System.EventHandler(this.uiActionDodaj_Click);
            // 
            // podsjetnikBindingSource
            // 
            this.podsjetnikBindingSource.DataSource = typeof(MSDom.podsjetnik);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // korisnikIdDataGridViewTextBoxColumn
            // 
            this.korisnikIdDataGridViewTextBoxColumn.DataPropertyName = "korisnikId";
            this.korisnikIdDataGridViewTextBoxColumn.HeaderText = "korisnikId";
            this.korisnikIdDataGridViewTextBoxColumn.Name = "korisnikIdDataGridViewTextBoxColumn";
            // 
            // datumVrijemeDataGridViewTextBoxColumn
            // 
            this.datumVrijemeDataGridViewTextBoxColumn.DataPropertyName = "datumVrijeme";
            this.datumVrijemeDataGridViewTextBoxColumn.HeaderText = "datumVrijeme";
            this.datumVrijemeDataGridViewTextBoxColumn.Name = "datumVrijemeDataGridViewTextBoxColumn";
            // 
            // razlogDataGridViewTextBoxColumn
            // 
            this.razlogDataGridViewTextBoxColumn.DataPropertyName = "razlog";
            this.razlogDataGridViewTextBoxColumn.HeaderText = "razlog";
            this.razlogDataGridViewTextBoxColumn.Name = "razlogDataGridViewTextBoxColumn";
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmPotsjetnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 230);
            this.Controls.Add(this.uiActionDodaj);
            this.Controls.Add(this.uiActionAzuriraj);
            this.Controls.Add(this.uiActionObrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputPotsjetnici);
            this.Name = "frmPotsjetnici";
            this.Text = "Potsjetnici";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPotsjetnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podsjetnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uiOutputPotsjetnici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uiActionObrisi;
        private System.Windows.Forms.Button uiActionAzuriraj;
        private System.Windows.Forms.Button uiActionDodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumVrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razlogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource podsjetnikBindingSource;
    }
}