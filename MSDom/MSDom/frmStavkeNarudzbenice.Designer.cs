namespace MSDom
{
    partial class frmStavkeNarudzbenice
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
            this.uiInputKolicina = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uiActionDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikLijekasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekoviZaDijagnozusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeNarudzbenicesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiInputKolicina
            // 
            this.uiInputKolicina.Location = new System.Drawing.Point(55, 74);
            this.uiInputKolicina.Name = "uiInputKolicina";
            this.uiInputKolicina.Size = new System.Drawing.Size(128, 20);
            this.uiInputKolicina.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.korisnikLijekasDataGridViewTextBoxColumn,
            this.lijekoviZaDijagnozusDataGridViewTextBoxColumn,
            this.stavkeNarudzbenicesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lijekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 239);
            this.dataGridView1.TabIndex = 1;
            // 
            // uiActionDodaj
            // 
            this.uiActionDodaj.Location = new System.Drawing.Point(208, 74);
            this.uiActionDodaj.Name = "uiActionDodaj";
            this.uiActionDodaj.Size = new System.Drawing.Size(75, 23);
            this.uiActionDodaj.TabIndex = 2;
            this.uiActionDodaj.Text = "Dodaj";
            this.uiActionDodaj.UseVisualStyleBackColor = true;
            this.uiActionDodaj.Click += new System.EventHandler(this.uiActionDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kolicina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Izaberite lijek";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // korisnikLijekasDataGridViewTextBoxColumn
            // 
            this.korisnikLijekasDataGridViewTextBoxColumn.DataPropertyName = "korisnikLijekas";
            this.korisnikLijekasDataGridViewTextBoxColumn.HeaderText = "korisnikLijekas";
            this.korisnikLijekasDataGridViewTextBoxColumn.Name = "korisnikLijekasDataGridViewTextBoxColumn";
            this.korisnikLijekasDataGridViewTextBoxColumn.Visible = false;
            // 
            // lijekoviZaDijagnozusDataGridViewTextBoxColumn
            // 
            this.lijekoviZaDijagnozusDataGridViewTextBoxColumn.DataPropertyName = "lijekoviZaDijagnozus";
            this.lijekoviZaDijagnozusDataGridViewTextBoxColumn.HeaderText = "lijekoviZaDijagnozus";
            this.lijekoviZaDijagnozusDataGridViewTextBoxColumn.Name = "lijekoviZaDijagnozusDataGridViewTextBoxColumn";
            this.lijekoviZaDijagnozusDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeNarudzbenicesDataGridViewTextBoxColumn
            // 
            this.stavkeNarudzbenicesDataGridViewTextBoxColumn.DataPropertyName = "stavkeNarudzbenices";
            this.stavkeNarudzbenicesDataGridViewTextBoxColumn.HeaderText = "stavkeNarudzbenices";
            this.stavkeNarudzbenicesDataGridViewTextBoxColumn.Name = "stavkeNarudzbenicesDataGridViewTextBoxColumn";
            this.stavkeNarudzbenicesDataGridViewTextBoxColumn.Visible = false;
            // 
            // lijekBindingSource
            // 
            this.lijekBindingSource.DataSource = typeof(MSDom.lijek);
            // 
            // frmStavkeNarudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiActionDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uiInputKolicina);
            this.Name = "frmStavkeNarudzbenice";
            this.Text = "frmStavkeNarudzbenice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiInputKolicina;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikLijekasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lijekoviZaDijagnozusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeNarudzbenicesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lijekBindingSource;
        private System.Windows.Forms.Button uiActionDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}