namespace MSDom
{
    partial class frmPocetnaMedicinskaSestra
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
            this.uiActionNaruči = new System.Windows.Forms.Button();
            this.uiActionPopuniZdKarton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiActionNaruči
            // 
            this.uiActionNaruči.Location = new System.Drawing.Point(206, 151);
            this.uiActionNaruči.Name = "uiActionNaruči";
            this.uiActionNaruči.Size = new System.Drawing.Size(153, 36);
            this.uiActionNaruči.TabIndex = 9;
            this.uiActionNaruči.Text = "Dodavanje lijeka nalazima stanara";
            this.uiActionNaruči.UseVisualStyleBackColor = true;
            this.uiActionNaruči.Click += new System.EventHandler(this.uiActionNaruči_Click);
            // 
            // uiActionPopuniZdKarton
            // 
            this.uiActionPopuniZdKarton.Location = new System.Drawing.Point(206, 108);
            this.uiActionPopuniZdKarton.Name = "uiActionPopuniZdKarton";
            this.uiActionPopuniZdKarton.Size = new System.Drawing.Size(153, 37);
            this.uiActionPopuniZdKarton.TabIndex = 8;
            this.uiActionPopuniZdKarton.Text = "Naručivanje na sastanak kod doktora";
            this.uiActionPopuniZdKarton.UseVisualStyleBackColor = true;
            this.uiActionPopuniZdKarton.Click += new System.EventHandler(this.uiActionPopuniZdKarton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(94, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vaše mogučnosti:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pregled narudžbenica";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPocetnaMedicinskaSestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uiActionNaruči);
            this.Controls.Add(this.uiActionPopuniZdKarton);
            this.Controls.Add(this.label1);
            this.Name = "frmPocetnaMedicinskaSestra";
            this.Text = "frmPocetnaMedicinskaSestra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionNaruči;
        private System.Windows.Forms.Button uiActionPopuniZdKarton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}