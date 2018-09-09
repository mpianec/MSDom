namespace MSDom
{
    partial class frmRezervacijaPraonice
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
            this.label5 = new System.Windows.Forms.Label();
            this.calendar1 = new Calendar.NET.Calendar();
            this.uiVrijemePredbilježbeOd = new System.Windows.Forms.DateTimePicker();
            this.uiVrijemePredbilježbeDo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiActionPredbilježi = new System.Windows.Forms.Button();
            this.uiInputDatumRezervacije = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.uiActionPoništiRezervaciju = new System.Windows.Forms.Button();
            this.uiOutputMojeRezervacije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uiOutputSlobodnePraonice = new System.Windows.Forms.DataGridView();
            this.uiActionRezervirajPraonicu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputMojeRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSlobodnePraonice)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Pritisnite F1 za pomoć";
            // 
            // calendar1
            // 
            this.calendar1.AllowEditingEvents = true;
            this.calendar1.CalendarDate = new System.DateTime(2018, 9, 5, 0, 0, 0, 0);
            this.calendar1.CalendarView = Calendar.NET.CalendarViews.Month;
            this.calendar1.DateHeaderFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.calendar1.DayOfWeekFont = new System.Drawing.Font("Arial", 10F);
            this.calendar1.DaysFont = new System.Drawing.Font("Arial", 10F);
            this.calendar1.DayViewTimeFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.calendar1.DimDisabledEvents = true;
            this.calendar1.HighlightCurrentDay = true;
            this.calendar1.LoadPresetHolidays = true;
            this.calendar1.Location = new System.Drawing.Point(418, 12);
            this.calendar1.Name = "calendar1";
            this.calendar1.ShowArrowControls = true;
            this.calendar1.ShowDashedBorderOnDisabledEvents = true;
            this.calendar1.ShowDateInHeader = true;
            this.calendar1.ShowDisabledEvents = false;
            this.calendar1.ShowEventTooltips = true;
            this.calendar1.ShowTodayButton = true;
            this.calendar1.Size = new System.Drawing.Size(610, 384);
            this.calendar1.TabIndex = 19;
            this.calendar1.TodayFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            // 
            // uiVrijemePredbilježbeOd
            // 
            this.uiVrijemePredbilježbeOd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uiVrijemePredbilježbeOd.Location = new System.Drawing.Point(6, 42);
            this.uiVrijemePredbilježbeOd.Name = "uiVrijemePredbilježbeOd";
            this.uiVrijemePredbilježbeOd.Size = new System.Drawing.Size(71, 20);
            this.uiVrijemePredbilježbeOd.TabIndex = 20;
            // 
            // uiVrijemePredbilježbeDo
            // 
            this.uiVrijemePredbilježbeDo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uiVrijemePredbilježbeDo.Location = new System.Drawing.Point(105, 42);
            this.uiVrijemePredbilježbeDo.Name = "uiVrijemePredbilježbeDo";
            this.uiVrijemePredbilježbeDo.Size = new System.Drawing.Size(71, 20);
            this.uiVrijemePredbilježbeDo.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Do";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiVrijemePredbilježbeOd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.uiVrijemePredbilježbeDo);
            this.groupBox1.Location = new System.Drawing.Point(32, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 74);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Predbilježba";
            // 
            // uiActionPredbilježi
            // 
            this.uiActionPredbilježi.Location = new System.Drawing.Point(238, 60);
            this.uiActionPredbilježi.Name = "uiActionPredbilježi";
            this.uiActionPredbilježi.Size = new System.Drawing.Size(75, 23);
            this.uiActionPredbilježi.TabIndex = 25;
            this.uiActionPredbilježi.Text = "Predbilježi";
            this.uiActionPredbilježi.UseVisualStyleBackColor = true;
            this.uiActionPredbilježi.Click += new System.EventHandler(this.uiActionPredbilježi_Click);
            // 
            // uiInputDatumRezervacije
            // 
            this.uiInputDatumRezervacije.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uiInputDatumRezervacije.Location = new System.Drawing.Point(225, 108);
            this.uiInputDatumRezervacije.Name = "uiInputDatumRezervacije";
            this.uiInputDatumRezervacije.Size = new System.Drawing.Size(200, 20);
            this.uiInputDatumRezervacije.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Moje rezervacije";
            // 
            // uiActionPoništiRezervaciju
            // 
            this.uiActionPoništiRezervaciju.Location = new System.Drawing.Point(300, 323);
            this.uiActionPoništiRezervaciju.Name = "uiActionPoništiRezervaciju";
            this.uiActionPoništiRezervaciju.Size = new System.Drawing.Size(75, 23);
            this.uiActionPoništiRezervaciju.TabIndex = 30;
            this.uiActionPoništiRezervaciju.Text = "Poništi rezervaciju";
            this.uiActionPoništiRezervaciju.UseVisualStyleBackColor = true;
            // 
            // uiOutputMojeRezervacije
            // 
            this.uiOutputMojeRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputMojeRezervacije.Location = new System.Drawing.Point(32, 311);
            this.uiOutputMojeRezervacije.Name = "uiOutputMojeRezervacije";
            this.uiOutputMojeRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputMojeRezervacije.Size = new System.Drawing.Size(262, 96);
            this.uiOutputMojeRezervacije.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Slobodne praonice";
            // 
            // uiOutputSlobodnePraonice
            // 
            this.uiOutputSlobodnePraonice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputSlobodnePraonice.Location = new System.Drawing.Point(32, 134);
            this.uiOutputSlobodnePraonice.Name = "uiOutputSlobodnePraonice";
            this.uiOutputSlobodnePraonice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputSlobodnePraonice.Size = new System.Drawing.Size(262, 150);
            this.uiOutputSlobodnePraonice.TabIndex = 27;
            // 
            // uiActionRezervirajPraonicu
            // 
            this.uiActionRezervirajPraonicu.Location = new System.Drawing.Point(300, 143);
            this.uiActionRezervirajPraonicu.Name = "uiActionRezervirajPraonicu";
            this.uiActionRezervirajPraonicu.Size = new System.Drawing.Size(75, 23);
            this.uiActionRezervirajPraonicu.TabIndex = 26;
            this.uiActionRezervirajPraonicu.Text = "Rezerviraj";
            this.uiActionRezervirajPraonicu.UseVisualStyleBackColor = true;
            // 
            // frmRezervacijaPraonice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 414);
            this.Controls.Add(this.uiInputDatumRezervacije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiActionPoništiRezervaciju);
            this.Controls.Add(this.uiOutputMojeRezervacije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputSlobodnePraonice);
            this.Controls.Add(this.uiActionRezervirajPraonicu);
            this.Controls.Add(this.uiActionPredbilježi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calendar1);
            this.Controls.Add(this.label5);
            this.Name = "frmRezervacijaPraonice";
            this.Text = "Rezervacija praonice";
            this.Load += new System.EventHandler(this.frmRezervacijaPraonice_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRezervacijaPraonice_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputMojeRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSlobodnePraonice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private Calendar.NET.Calendar calendar1;
        private System.Windows.Forms.DateTimePicker uiVrijemePredbilježbeOd;
        private System.Windows.Forms.DateTimePicker uiVrijemePredbilježbeDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uiActionPredbilježi;
        private System.Windows.Forms.DateTimePicker uiInputDatumRezervacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uiActionPoništiRezervaciju;
        private System.Windows.Forms.DataGridView uiOutputMojeRezervacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiOutputSlobodnePraonice;
        private System.Windows.Forms.Button uiActionRezervirajPraonicu;
    }
}