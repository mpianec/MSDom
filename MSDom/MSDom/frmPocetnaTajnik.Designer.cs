namespace MSDom
{
    partial class frmPocetnaTajnik
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
            this.label1 = new System.Windows.Forms.Label();
            this.uiActionStvoriAnketu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vaše mogučnosti:";
            // 
            // uiActionStvoriAnketu
            // 
            this.uiActionStvoriAnketu.Location = new System.Drawing.Point(116, 47);
            this.uiActionStvoriAnketu.Name = "uiActionStvoriAnketu";
            this.uiActionStvoriAnketu.Size = new System.Drawing.Size(153, 23);
            this.uiActionStvoriAnketu.TabIndex = 2;
            this.uiActionStvoriAnketu.Text = "Stvorite anketu za stanare";
            this.uiActionStvoriAnketu.UseVisualStyleBackColor = true;
            this.uiActionStvoriAnketu.Click += new System.EventHandler(this.uiActionStvoriAnketu_Click);
            // 
            // frmPocetnaTajnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 275);
            this.Controls.Add(this.uiActionStvoriAnketu);
            this.Controls.Add(this.label1);
            this.Name = "frmPocetnaTajnik";
            this.Text = "frmPocetnaTajnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uiActionStvoriAnketu;
    }
}