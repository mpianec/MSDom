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
            this.uiActionRezervirajPraonicu = new System.Windows.Forms.Button();
            this.uiOutputSlobodnePraonice = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uiOutputMojeRezervacije = new System.Windows.Forms.DataGridView();
            this.uiActionPoništiRezervaciju = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uiInputDatumRezervacije = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.calendar1 = new Calendar.NET.Calendar();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSlobodnePraonice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputMojeRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionRezervirajPraonicu
            // 
            this.uiActionRezervirajPraonicu.Location = new System.Drawing.Point(287, 51);
            this.uiActionRezervirajPraonicu.Name = "uiActionRezervirajPraonicu";
            this.uiActionRezervirajPraonicu.Size = new System.Drawing.Size(75, 23);
            this.uiActionRezervirajPraonicu.TabIndex = 0;
            this.uiActionRezervirajPraonicu.Text = "Rezerviraj";
            this.uiActionRezervirajPraonicu.UseVisualStyleBackColor = true;
            this.uiActionRezervirajPraonicu.Click += new System.EventHandler(this.uiActionRezervirajPraonicu_Click);
            // 
            // uiOutputSlobodnePraonice
            // 
            this.uiOutputSlobodnePraonice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputSlobodnePraonice.Location = new System.Drawing.Point(19, 42);
            this.uiOutputSlobodnePraonice.Name = "uiOutputSlobodnePraonice";
            this.uiOutputSlobodnePraonice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputSlobodnePraonice.Size = new System.Drawing.Size(262, 150);
            this.uiOutputSlobodnePraonice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Slobodne praonice";
            // 
            // uiOutputMojeRezervacije
            // 
            this.uiOutputMojeRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputMojeRezervacije.Location = new System.Drawing.Point(19, 219);
            this.uiOutputMojeRezervacije.Name = "uiOutputMojeRezervacije";
            this.uiOutputMojeRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputMojeRezervacije.Size = new System.Drawing.Size(262, 150);
            this.uiOutputMojeRezervacije.TabIndex = 3;
            // 
            // uiActionPoništiRezervaciju
            // 
            this.uiActionPoništiRezervaciju.Location = new System.Drawing.Point(287, 231);
            this.uiActionPoništiRezervaciju.Name = "uiActionPoništiRezervaciju";
            this.uiActionPoništiRezervaciju.Size = new System.Drawing.Size(75, 23);
            this.uiActionPoništiRezervaciju.TabIndex = 4;
            this.uiActionPoništiRezervaciju.Text = "Poništi rezervaciju";
            this.uiActionPoništiRezervaciju.UseVisualStyleBackColor = true;
            this.uiActionPoništiRezervaciju.Click += new System.EventHandler(this.uiActionPoništiRezervaciju_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Moje rezervacije";
            // 
            // uiInputDatumRezervacije
            // 
            this.uiInputDatumRezervacije.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uiInputDatumRezervacije.Location = new System.Drawing.Point(212, 16);
            this.uiInputDatumRezervacije.Name = "uiInputDatumRezervacije";
            this.uiInputDatumRezervacije.Size = new System.Drawing.Size(200, 20);
            this.uiInputDatumRezervacije.TabIndex = 6;
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
            this.calendar1.CalendarDate = new System.DateTime(2018, 8, 9, 16, 15, 43, 346);
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
            // frmRezervacijaPraonice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 414);
            this.Controls.Add(this.calendar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uiInputDatumRezervacije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiActionPoništiRezervaciju);
            this.Controls.Add(this.uiOutputMojeRezervacije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputSlobodnePraonice);
            this.Controls.Add(this.uiActionRezervirajPraonicu);
            this.Name = "frmRezervacijaPraonice";
            this.Text = "Rezervacija praonice";
            this.Load += new System.EventHandler(this.frmRezervacijaPraonice_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRezervacijaPraonice_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputSlobodnePraonice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputMojeRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionRezervirajPraonicu;
        private System.Windows.Forms.DataGridView uiOutputSlobodnePraonice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiOutputMojeRezervacije;
        private System.Windows.Forms.Button uiActionPoništiRezervaciju;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker uiInputDatumRezervacije;
        private System.Windows.Forms.Label label5;
        private Calendar.NET.Calendar calendar1;
    }
}