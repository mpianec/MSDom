namespace MSDom
{
    partial class frmAzurirajPotsjetnik
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
            this.uiActionAzuriraj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiInputRazlog = new System.Windows.Forms.TextBox();
            this.uiInptDatumVrijeme = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.uiInputId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uiActionAzuriraj
            // 
            this.uiActionAzuriraj.Location = new System.Drawing.Point(22, 260);
            this.uiActionAzuriraj.Name = "uiActionAzuriraj";
            this.uiActionAzuriraj.Size = new System.Drawing.Size(252, 23);
            this.uiActionAzuriraj.TabIndex = 9;
            this.uiActionAzuriraj.Text = "Ažuriraj";
            this.uiActionAzuriraj.UseVisualStyleBackColor = true;
            this.uiActionAzuriraj.Click += new System.EventHandler(this.uiActionAzuriraj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datum i vrijeme potsjetnika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Razlog potsjetnika";
            // 
            // uiInputRazlog
            // 
            this.uiInputRazlog.Location = new System.Drawing.Point(22, 76);
            this.uiInputRazlog.Multiline = true;
            this.uiInputRazlog.Name = "uiInputRazlog";
            this.uiInputRazlog.Size = new System.Drawing.Size(252, 104);
            this.uiInputRazlog.TabIndex = 6;
            // 
            // uiInptDatumVrijeme
            // 
            this.uiInptDatumVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uiInptDatumVrijeme.Location = new System.Drawing.Point(22, 217);
            this.uiInptDatumVrijeme.Name = "uiInptDatumVrijeme";
            this.uiInptDatumVrijeme.Size = new System.Drawing.Size(252, 20);
            this.uiInptDatumVrijeme.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID";
            // 
            // uiInputId
            // 
            this.uiInputId.Location = new System.Drawing.Point(22, 26);
            this.uiInputId.Name = "uiInputId";
            this.uiInputId.ReadOnly = true;
            this.uiInputId.Size = new System.Drawing.Size(252, 20);
            this.uiInputId.TabIndex = 11;
            // 
            // frmAzurirajPotsjetnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 310);
            this.Controls.Add(this.uiInputId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiActionAzuriraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiInputRazlog);
            this.Controls.Add(this.uiInptDatumVrijeme);
            this.Name = "frmAzurirajPotsjetnik";
            this.Text = "Ažuriranje potsjetnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionAzuriraj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiInputRazlog;
        private System.Windows.Forms.DateTimePicker uiInptDatumVrijeme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiInputId;
    }
}