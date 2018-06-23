namespace MSDom
{
    partial class frmZdravstveniKarton
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uiActionDodajNoviZdravstveniKarton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // uiActionDodajNoviZdravstveniKarton
            // 
            this.uiActionDodajNoviZdravstveniKarton.Location = new System.Drawing.Point(569, 299);
            this.uiActionDodajNoviZdravstveniKarton.Name = "uiActionDodajNoviZdravstveniKarton";
            this.uiActionDodajNoviZdravstveniKarton.Size = new System.Drawing.Size(176, 40);
            this.uiActionDodajNoviZdravstveniKarton.TabIndex = 1;
            this.uiActionDodajNoviZdravstveniKarton.Text = "Dodaj novi nalaz";
            this.uiActionDodajNoviZdravstveniKarton.UseVisualStyleBackColor = true;
            // 
            // frmZdravstveniKarton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 397);
            this.Controls.Add(this.uiActionDodajNoviZdravstveniKarton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmZdravstveniKarton";
            this.Text = "frmZdravstveniKarton";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button uiActionDodajNoviZdravstveniKarton;
    }
}