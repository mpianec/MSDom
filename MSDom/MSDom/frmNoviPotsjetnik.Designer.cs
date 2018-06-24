namespace MSDom
{
    partial class frmNoviPotsjetnik
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
            this.uiInptDatumVrijeme = new System.Windows.Forms.DateTimePicker();
            this.uiInputRazlog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiActionUnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiInptDatumVrijeme
            // 
            this.uiInptDatumVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uiInptDatumVrijeme.Location = new System.Drawing.Point(29, 170);
            this.uiInptDatumVrijeme.Name = "uiInptDatumVrijeme";
            this.uiInptDatumVrijeme.Size = new System.Drawing.Size(252, 20);
            this.uiInptDatumVrijeme.TabIndex = 0;
            // 
            // uiInputRazlog
            // 
            this.uiInputRazlog.Location = new System.Drawing.Point(29, 29);
            this.uiInputRazlog.Multiline = true;
            this.uiInputRazlog.Name = "uiInputRazlog";
            this.uiInputRazlog.Size = new System.Drawing.Size(252, 104);
            this.uiInputRazlog.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Razlog potsjetnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum i vrijeme potsjetnika";
            // 
            // uiActionUnos
            // 
            this.uiActionUnos.Location = new System.Drawing.Point(29, 213);
            this.uiActionUnos.Name = "uiActionUnos";
            this.uiActionUnos.Size = new System.Drawing.Size(252, 23);
            this.uiActionUnos.TabIndex = 4;
            this.uiActionUnos.Text = "Kreiraj ";
            this.uiActionUnos.UseVisualStyleBackColor = true;
            this.uiActionUnos.Click += new System.EventHandler(this.uiActionUnos_Click);
            // 
            // frmNoviPotsjetnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 268);
            this.Controls.Add(this.uiActionUnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiInputRazlog);
            this.Controls.Add(this.uiInptDatumVrijeme);
            this.Name = "frmNoviPotsjetnik";
            this.Text = "Kreiranje novog potsjetnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker uiInptDatumVrijeme;
        private System.Windows.Forms.TextBox uiInputRazlog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uiActionUnos;
    }
}