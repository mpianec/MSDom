namespace MSDom
{
    partial class frmDodajLijekStanaru
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
            this.uiOutputPrikazLijekova = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.uiActionDodaj = new System.Windows.Forms.Button();
            this.uiActionObrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uiOutputLijekoviZaDijagnozu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikLijekasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekoviZaDijagnozusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeNarudzbenicesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviZaDijagnozuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nalazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.uiOutputPretraga = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPrikazLijekova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputLijekoviZaDijagnozu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviZaDijagnozuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalazBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputPrikazLijekova
            // 
            this.uiOutputPrikazLijekova.AutoGenerateColumns = false;
            this.uiOutputPrikazLijekova.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiOutputPrikazLijekova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPrikazLijekova.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.korisnikLijekasDataGridViewTextBoxColumn,
            this.lijekoviZaDijagnozusDataGridViewTextBoxColumn,
            this.stavkeNarudzbenicesDataGridViewTextBoxColumn});
            this.uiOutputPrikazLijekova.DataSource = this.lijekBindingSource;
            this.uiOutputPrikazLijekova.Location = new System.Drawing.Point(12, 103);
            this.uiOutputPrikazLijekova.Name = "uiOutputPrikazLijekova";
            this.uiOutputPrikazLijekova.Size = new System.Drawing.Size(368, 268);
            this.uiOutputPrikazLijekova.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(904, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pritisnite F1 za pomoć";
            // 
            // uiActionDodaj
            // 
            this.uiActionDodaj.Location = new System.Drawing.Point(12, 377);
            this.uiActionDodaj.Name = "uiActionDodaj";
            this.uiActionDodaj.Size = new System.Drawing.Size(115, 39);
            this.uiActionDodaj.TabIndex = 7;
            this.uiActionDodaj.Text = "Dodaj";
            this.uiActionDodaj.UseVisualStyleBackColor = true;
            this.uiActionDodaj.Click += new System.EventHandler(this.uiActionDodaj_Click);
            // 
            // uiActionObrisi
            // 
            this.uiActionObrisi.Location = new System.Drawing.Point(445, 377);
            this.uiActionObrisi.Name = "uiActionObrisi";
            this.uiActionObrisi.Size = new System.Drawing.Size(115, 39);
            this.uiActionObrisi.TabIndex = 8;
            this.uiActionObrisi.Text = "Obriši";
            this.uiActionObrisi.UseVisualStyleBackColor = true;
            this.uiActionObrisi.Click += new System.EventHandler(this.uiActionObrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Izaberite lijek";
            // 
            // uiOutputLijekoviZaDijagnozu
            // 
            this.uiOutputLijekoviZaDijagnozu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiOutputLijekoviZaDijagnozu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputLijekoviZaDijagnozu.Location = new System.Drawing.Point(445, 103);
            this.uiOutputLijekoviZaDijagnozu.Name = "uiOutputLijekoviZaDijagnozu";
            this.uiOutputLijekoviZaDijagnozu.Size = new System.Drawing.Size(569, 268);
            this.uiOutputLijekoviZaDijagnozu.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pregled dodanih lijekova dijagnozi";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 57;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.Width = 68;
            // 
            // korisnikLijekasDataGridViewTextBoxColumn
            // 
            this.korisnikLijekasDataGridViewTextBoxColumn.DataPropertyName = "korisnikLijekas";
            this.korisnikLijekasDataGridViewTextBoxColumn.HeaderText = "korisnikLijekas";
            this.korisnikLijekasDataGridViewTextBoxColumn.Name = "korisnikLijekasDataGridViewTextBoxColumn";
            this.korisnikLijekasDataGridViewTextBoxColumn.Visible = false;
            this.korisnikLijekasDataGridViewTextBoxColumn.Width = 101;
            // 
            // lijekoviZaDijagnozusDataGridViewTextBoxColumn
            // 
            this.lijekoviZaDijagnozusDataGridViewTextBoxColumn.DataPropertyName = "lijekoviZaDijagnozus";
            this.lijekoviZaDijagnozusDataGridViewTextBoxColumn.HeaderText = "lijekoviZaDijagnozus";
            this.lijekoviZaDijagnozusDataGridViewTextBoxColumn.Name = "lijekoviZaDijagnozusDataGridViewTextBoxColumn";
            this.lijekoviZaDijagnozusDataGridViewTextBoxColumn.Visible = false;
            this.lijekoviZaDijagnozusDataGridViewTextBoxColumn.Width = 129;
            // 
            // stavkeNarudzbenicesDataGridViewTextBoxColumn
            // 
            this.stavkeNarudzbenicesDataGridViewTextBoxColumn.DataPropertyName = "stavkeNarudzbenices";
            this.stavkeNarudzbenicesDataGridViewTextBoxColumn.HeaderText = "stavkeNarudzbenices";
            this.stavkeNarudzbenicesDataGridViewTextBoxColumn.Name = "stavkeNarudzbenicesDataGridViewTextBoxColumn";
            this.stavkeNarudzbenicesDataGridViewTextBoxColumn.Visible = false;
            this.stavkeNarudzbenicesDataGridViewTextBoxColumn.Width = 135;
            // 
            // lijekBindingSource
            // 
            this.lijekBindingSource.DataSource = typeof(MSDom.lijek);
            // 
            // lijekoviZaDijagnozuBindingSource
            // 
            this.lijekoviZaDijagnozuBindingSource.DataSource = typeof(MSDom.lijekoviZaDijagnozu);
            // 
            // nalazBindingSource
            // 
            this.nalazBindingSource.DataSource = typeof(MSDom.nalaz);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pretraži lijekove";
            // 
            // uiOutputPretraga
            // 
            this.uiOutputPretraga.Location = new System.Drawing.Point(108, 23);
            this.uiOutputPretraga.Name = "uiOutputPretraga";
            this.uiOutputPretraga.Size = new System.Drawing.Size(139, 20);
            this.uiOutputPretraga.TabIndex = 14;
            this.uiOutputPretraga.TextChanged += new System.EventHandler(this.uiOutputPretraga_TextChanged);
            // 
            // frmDodajLijekStanaru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 450);
            this.Controls.Add(this.uiOutputPretraga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiOutputLijekoviZaDijagnozu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiActionObrisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiActionDodaj);
            this.Controls.Add(this.uiOutputPrikazLijekova);
            this.Name = "frmDodajLijekStanaru";
            this.Text = "Dodjeljivanje lijeka stanaru";
            this.Load += new System.EventHandler(this.frmDodajLijekStanaru_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDodajLijekStanaru_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPrikazLijekova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputLijekoviZaDijagnozu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviZaDijagnozuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalazBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uiOutputPrikazLijekova;
        private System.Windows.Forms.BindingSource lijekoviZaDijagnozuBindingSource;
        private System.Windows.Forms.BindingSource nalazBindingSource;
        private System.Windows.Forms.BindingSource lijekBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikLijekasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lijekoviZaDijagnozusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeNarudzbenicesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button uiActionDodaj;
        private System.Windows.Forms.Button uiActionObrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiOutputLijekoviZaDijagnozu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiOutputPretraga;
    }
}