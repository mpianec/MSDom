﻿namespace MSDom
{
    partial class frmNarudzbaLijekova
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
            this.uiOutputLijekovi = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikLijekasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekoviZaDijagnozusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiInputKolicina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiActionUnosKolicine = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uiInputKolicinaLijeka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiInputId = new System.Windows.Forms.TextBox();
            this.uiActionNoviLijek = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uiInputNaziv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputLijekovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiOutputLijekovi
            // 
            this.uiOutputLijekovi.AutoGenerateColumns = false;
            this.uiOutputLijekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputLijekovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.korisnikLijekasDataGridViewTextBoxColumn,
            this.lijekoviZaDijagnozusDataGridViewTextBoxColumn});
            this.uiOutputLijekovi.DataSource = this.lijekBindingSource;
            this.uiOutputLijekovi.Location = new System.Drawing.Point(38, 158);
            this.uiOutputLijekovi.Name = "uiOutputLijekovi";
            this.uiOutputLijekovi.Size = new System.Drawing.Size(695, 280);
            this.uiOutputLijekovi.TabIndex = 0;
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
            // lijekBindingSource
            // 
            this.lijekBindingSource.DataSource = typeof(MSDom.lijek);
            // 
            // uiInputKolicina
            // 
            this.uiInputKolicina.Location = new System.Drawing.Point(107, 50);
            this.uiInputKolicina.Name = "uiInputKolicina";
            this.uiInputKolicina.Size = new System.Drawing.Size(146, 20);
            this.uiInputKolicina.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Količina";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiActionUnosKolicine);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.uiInputKolicina);
            this.groupBox1.Location = new System.Drawing.Point(39, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Naručivanje nove količine lijeka";
            // 
            // uiActionUnosKolicine
            // 
            this.uiActionUnosKolicine.Location = new System.Drawing.Point(107, 85);
            this.uiActionUnosKolicine.Name = "uiActionUnosKolicine";
            this.uiActionUnosKolicine.Size = new System.Drawing.Size(145, 29);
            this.uiActionUnosKolicine.TabIndex = 3;
            this.uiActionUnosKolicine.Text = "Unesi";
            this.uiActionUnosKolicine.UseVisualStyleBackColor = true;
            this.uiActionUnosKolicine.Click += new System.EventHandler(this.uiActionUnosKolicine_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.uiInputKolicinaLijeka);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.uiInputId);
            this.groupBox2.Controls.Add(this.uiActionNoviLijek);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.uiInputNaziv);
            this.groupBox2.Location = new System.Drawing.Point(389, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 140);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodavanje novog lijeka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Količina";
            // 
            // uiInputKolicinaLijeka
            // 
            this.uiInputKolicinaLijeka.Location = new System.Drawing.Point(107, 76);
            this.uiInputKolicinaLijeka.Name = "uiInputKolicinaLijeka";
            this.uiInputKolicinaLijeka.Size = new System.Drawing.Size(146, 20);
            this.uiInputKolicinaLijeka.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id";
            // 
            // uiInputId
            // 
            this.uiInputId.Location = new System.Drawing.Point(107, 24);
            this.uiInputId.Name = "uiInputId";
            this.uiInputId.ReadOnly = true;
            this.uiInputId.Size = new System.Drawing.Size(146, 20);
            this.uiInputId.TabIndex = 4;
            // 
            // uiActionNoviLijek
            // 
            this.uiActionNoviLijek.Location = new System.Drawing.Point(107, 105);
            this.uiActionNoviLijek.Name = "uiActionNoviLijek";
            this.uiActionNoviLijek.Size = new System.Drawing.Size(145, 29);
            this.uiActionNoviLijek.TabIndex = 3;
            this.uiActionNoviLijek.Text = "Unesi";
            this.uiActionNoviLijek.UseVisualStyleBackColor = true;
            this.uiActionNoviLijek.Click += new System.EventHandler(this.uiActionNoviLijek_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv";
            // 
            // uiInputNaziv
            // 
            this.uiInputNaziv.Location = new System.Drawing.Point(107, 50);
            this.uiInputNaziv.Name = "uiInputNaziv";
            this.uiInputNaziv.Size = new System.Drawing.Size(146, 20);
            this.uiInputNaziv.TabIndex = 1;
            // 
            // frmNarudzbaLijekova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uiOutputLijekovi);
            this.Name = "frmNarudzbaLijekova";
            this.Text = "frmNarudzbaLijekova";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputLijekovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uiOutputLijekovi;
        private System.Windows.Forms.TextBox uiInputKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource lijekBindingSource;
        private System.Windows.Forms.Button uiActionUnosKolicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikLijekasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lijekoviZaDijagnozusDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button uiActionNoviLijek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiInputNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uiInputKolicinaLijeka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiInputId;
    }
}