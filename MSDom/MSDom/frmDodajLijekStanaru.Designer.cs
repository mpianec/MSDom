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
            this.uiOutputPrikazLijekovaINalaza = new System.Windows.Forms.DataGridView();
            this.lijekoviZaDijagnozuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiInputNalaz = new System.Windows.Forms.ComboBox();
            this.nalazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiInputLijek = new System.Windows.Forms.ComboBox();
            this.lijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiActionDodaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPrikazLijekovaINalaza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviZaDijagnozuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiOutputPrikazLijekovaINalaza
            // 
            this.uiOutputPrikazLijekovaINalaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputPrikazLijekovaINalaza.Location = new System.Drawing.Point(33, 149);
            this.uiOutputPrikazLijekovaINalaza.Name = "uiOutputPrikazLijekovaINalaza";
            this.uiOutputPrikazLijekovaINalaza.Size = new System.Drawing.Size(732, 256);
            this.uiOutputPrikazLijekovaINalaza.TabIndex = 0;
            // 
            // lijekoviZaDijagnozuBindingSource
            // 
            this.lijekoviZaDijagnozuBindingSource.DataSource = typeof(MSDom.lijekoviZaDijagnozu);
            // 
            // uiInputNalaz
            // 
            this.uiInputNalaz.DataSource = this.nalazBindingSource;
            this.uiInputNalaz.DisplayMember = "dijagnoza";
            this.uiInputNalaz.FormattingEnabled = true;
            this.uiInputNalaz.Location = new System.Drawing.Point(87, 96);
            this.uiInputNalaz.Name = "uiInputNalaz";
            this.uiInputNalaz.Size = new System.Drawing.Size(176, 21);
            this.uiInputNalaz.TabIndex = 1;
            this.uiInputNalaz.ValueMember = "id";
            this.uiInputNalaz.SelectedIndexChanged += new System.EventHandler(this.uiInputNalaz_SelectedIndexChanged);
            // 
            // nalazBindingSource
            // 
            this.nalazBindingSource.DataSource = typeof(MSDom.nalaz);
            // 
            // uiInputLijek
            // 
            this.uiInputLijek.DataSource = this.lijekBindingSource;
            this.uiInputLijek.DisplayMember = "naziv";
            this.uiInputLijek.FormattingEnabled = true;
            this.uiInputLijek.Location = new System.Drawing.Point(87, 59);
            this.uiInputLijek.Name = "uiInputLijek";
            this.uiInputLijek.Size = new System.Drawing.Size(176, 21);
            this.uiInputLijek.TabIndex = 2;
            this.uiInputLijek.ValueMember = "id";
            // 
            // lijekBindingSource
            // 
            this.lijekBindingSource.DataSource = typeof(MSDom.lijek);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lijek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nalaz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id";
            // 
            // uiActionDodaj
            // 
            this.uiActionDodaj.Location = new System.Drawing.Point(321, 49);
            this.uiActionDodaj.Name = "uiActionDodaj";
            this.uiActionDodaj.Size = new System.Drawing.Size(115, 39);
            this.uiActionDodaj.TabIndex = 7;
            this.uiActionDodaj.Text = "Dodaj";
            this.uiActionDodaj.UseVisualStyleBackColor = true;
            this.uiActionDodaj.Click += new System.EventHandler(this.uiActionDodaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiActionDodaj);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.uiInputLijek);
            this.groupBox1.Controls.Add(this.uiInputNalaz);
            this.groupBox1.Location = new System.Drawing.Point(28, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 134);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje lijeka nalazu";
            // 
            // frmDodajLijekStanaru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uiOutputPrikazLijekovaINalaza);
            this.Name = "frmDodajLijekStanaru";
            this.Text = "frmDodajLijekStanaru";
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputPrikazLijekovaINalaza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviZaDijagnozuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uiOutputPrikazLijekovaINalaza;
        private System.Windows.Forms.BindingSource lijekoviZaDijagnozuBindingSource;
        private System.Windows.Forms.ComboBox uiInputNalaz;
        private System.Windows.Forms.ComboBox uiInputLijek;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uiActionDodaj;
        private System.Windows.Forms.BindingSource nalazBindingSource;
        private System.Windows.Forms.BindingSource lijekBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}