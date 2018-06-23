namespace MSDom
{
    partial class frmStvoriAnketu
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
            this.uiActionDodajPitanje = new System.Windows.Forms.Button();
            this.uiOutputPitanjaNaAnketi = new System.Windows.Forms.DataGridView();
            this.anketaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pitanjeSAnketeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionStvoriPitanje = new System.Windows.Forms.Button();
            this.uiActionStvoriAnketu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiInputDatumAnkete = new System.Windows.Forms.DateTimePicker();
            this.uiInputUnosPitanja = new System.Windows.Forms.TextBox();
            this.uiInputNazivAnkete = new System.Windows.Forms.TextBox();
            this.uiOutputComboAnkete = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiOutputComboPitanja = new System.Windows.Forms.ComboBox();
            this.pitanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPitanjaNaAnketi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitanjeSAnketeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitanjeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiActionDodajPitanje
            // 
            this.uiActionDodajPitanje.Location = new System.Drawing.Point(284, 207);
            this.uiActionDodajPitanje.Name = "uiActionDodajPitanje";
            this.uiActionDodajPitanje.Size = new System.Drawing.Size(75, 23);
            this.uiActionDodajPitanje.TabIndex = 0;
            this.uiActionDodajPitanje.Text = "Dodaj";
            this.uiActionDodajPitanje.UseVisualStyleBackColor = true;
            this.uiActionDodajPitanje.Click += new System.EventHandler(this.uiActionDodajPitanje_Click);
            // 
            // uiOutputPitanjaNaAnketi
            // 
            this.uiOutputPitanjaNaAnketi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiOutputPitanjaNaAnketi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPitanjaNaAnketi.Location = new System.Drawing.Point(116, 236);
            this.uiOutputPitanjaNaAnketi.Name = "uiOutputPitanjaNaAnketi";
            this.uiOutputPitanjaNaAnketi.Size = new System.Drawing.Size(394, 118);
            this.uiOutputPitanjaNaAnketi.TabIndex = 3;
            // 
            // anketaBindingSource
            // 
            this.anketaBindingSource.DataSource = typeof(MSDom.anketa);
            // 
            // pitanjeSAnketeBindingSource
            // 
            this.pitanjeSAnketeBindingSource.DataSource = typeof(MSDom.pitanjeSAnkete);
            // 
            // uiActionStvoriPitanje
            // 
            this.uiActionStvoriPitanje.Location = new System.Drawing.Point(104, 56);
            this.uiActionStvoriPitanje.Name = "uiActionStvoriPitanje";
            this.uiActionStvoriPitanje.Size = new System.Drawing.Size(91, 23);
            this.uiActionStvoriPitanje.TabIndex = 4;
            this.uiActionStvoriPitanje.Text = "Spremi";
            this.uiActionStvoriPitanje.UseVisualStyleBackColor = true;
            this.uiActionStvoriPitanje.Click += new System.EventHandler(this.uiInputDodajPitanje_Click);
            // 
            // uiActionStvoriAnketu
            // 
            this.uiActionStvoriAnketu.Location = new System.Drawing.Point(385, 94);
            this.uiActionStvoriAnketu.Name = "uiActionStvoriAnketu";
            this.uiActionStvoriAnketu.Size = new System.Drawing.Size(91, 23);
            this.uiActionStvoriAnketu.TabIndex = 5;
            this.uiActionStvoriAnketu.Text = "Spremi";
            this.uiActionStvoriAnketu.UseVisualStyleBackColor = true;
            this.uiActionStvoriAnketu.Click += new System.EventHandler(this.uiActionStvoriAnketu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unesi pitanje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Unesi naziv ankete";
            // 
            // uiInputDatumAnkete
            // 
            this.uiInputDatumAnkete.Location = new System.Drawing.Point(328, 68);
            this.uiInputDatumAnkete.Name = "uiInputDatumAnkete";
            this.uiInputDatumAnkete.Size = new System.Drawing.Size(200, 20);
            this.uiInputDatumAnkete.TabIndex = 8;
            // 
            // uiInputUnosPitanja
            // 
            this.uiInputUnosPitanja.Location = new System.Drawing.Point(47, 30);
            this.uiInputUnosPitanja.Name = "uiInputUnosPitanja";
            this.uiInputUnosPitanja.Size = new System.Drawing.Size(213, 20);
            this.uiInputUnosPitanja.TabIndex = 9;
            // 
            // uiInputNazivAnkete
            // 
            this.uiInputNazivAnkete.Location = new System.Drawing.Point(328, 32);
            this.uiInputNazivAnkete.Name = "uiInputNazivAnkete";
            this.uiInputNazivAnkete.Size = new System.Drawing.Size(132, 20);
            this.uiInputNazivAnkete.TabIndex = 10;
            // 
            // uiOutputComboAnkete
            // 
            this.uiOutputComboAnkete.DataSource = this.anketaBindingSource;
            this.uiOutputComboAnkete.DisplayMember = "naziv";
            this.uiOutputComboAnkete.FormattingEnabled = true;
            this.uiOutputComboAnkete.Location = new System.Drawing.Point(59, 165);
            this.uiOutputComboAnkete.Name = "uiOutputComboAnkete";
            this.uiOutputComboAnkete.Size = new System.Drawing.Size(121, 21);
            this.uiOutputComboAnkete.TabIndex = 11;
            this.uiOutputComboAnkete.ValueMember = "id";
            this.uiOutputComboAnkete.SelectedIndexChanged += new System.EventHandler(this.uiOutputComboAnkete_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Odaberi anketu koju želiš popuniti: ";
            // 
            // uiOutputComboPitanja
            // 
            this.uiOutputComboPitanja.DataSource = this.pitanjeBindingSource;
            this.uiOutputComboPitanja.DisplayMember = "pitanje1";
            this.uiOutputComboPitanja.FormattingEnabled = true;
            this.uiOutputComboPitanja.Location = new System.Drawing.Point(340, 165);
            this.uiOutputComboPitanja.Name = "uiOutputComboPitanja";
            this.uiOutputComboPitanja.Size = new System.Drawing.Size(284, 21);
            this.uiOutputComboPitanja.TabIndex = 13;
            this.uiOutputComboPitanja.ValueMember = "id";
            // 
            // pitanjeBindingSource
            // 
            this.pitanjeBindingSource.DataSource = typeof(MSDom.pitanje);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Odaberi pitanje koje želiš dodati na anketu: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiInputNazivAnkete);
            this.groupBox1.Controls.Add(this.uiActionStvoriPitanje);
            this.groupBox1.Controls.Add(this.uiActionStvoriAnketu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.uiInputDatumAnkete);
            this.groupBox1.Controls.Add(this.uiInputUnosPitanja);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 134);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kreiraj";
            // 
            // frmStvoriAnketu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 385);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiOutputComboPitanja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiOutputComboAnkete);
            this.Controls.Add(this.uiOutputPitanjaNaAnketi);
            this.Controls.Add(this.uiActionDodajPitanje);
            this.Name = "frmStvoriAnketu";
            this.Text = "Stvaranje ankete";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPitanjaNaAnketi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitanjeSAnketeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitanjeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionDodajPitanje;
        private System.Windows.Forms.BindingSource anketaBindingSource;
        private System.Windows.Forms.BindingSource pitanjeSAnketeBindingSource;
        private System.Windows.Forms.DataGridView uiOutputPitanjaNaAnketi;
        private System.Windows.Forms.Button uiActionStvoriPitanje;
        private System.Windows.Forms.Button uiActionStvoriAnketu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker uiInputDatumAnkete;
        private System.Windows.Forms.TextBox uiInputUnosPitanja;
        private System.Windows.Forms.TextBox uiInputNazivAnkete;
        private System.Windows.Forms.ComboBox uiOutputComboAnkete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox uiOutputComboPitanja;
        private System.Windows.Forms.BindingSource pitanjeBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}