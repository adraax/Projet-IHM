namespace Main_project_VERON_MERLIN
{
    partial class Planning
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
            this.calendrier = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // calendrier
            // 
            this.calendrier.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.calendrier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendrier.Location = new System.Drawing.Point(0, 0);
            this.calendrier.Name = "calendrier";
            this.calendrier.TabIndex = 0;
            this.calendrier.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendrier_DateChanged);
            // 
            // Planning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 161);
            this.Controls.Add(this.calendrier);
            this.Name = "Planning";
            this.Text = "Planning";
            this.Load += new System.EventHandler(this.Planning_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendrier;
    }
}