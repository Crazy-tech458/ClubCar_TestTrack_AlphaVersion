
namespace ClubCar_TestTrack_AlphaVersion
{
    partial class Main_Menu
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
            this.bttn_Car_Submission = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bttn_Holidays = new System.Windows.Forms.Button();
            this.bttn_Tracks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Club Car Test Track";
            // 
            // bttn_Car_Submission
            // 
            this.bttn_Car_Submission.Location = new System.Drawing.Point(35, 82);
            this.bttn_Car_Submission.Name = "bttn_Car_Submission";
            this.bttn_Car_Submission.Size = new System.Drawing.Size(138, 48);
            this.bttn_Car_Submission.TabIndex = 1;
            this.bttn_Car_Submission.Text = "Car Submission";
            this.bttn_Car_Submission.UseVisualStyleBackColor = true;
            this.bttn_Car_Submission.Click += new System.EventHandler(this.bttn_Car_Submission_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Employee Submission";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bttn_Employee_Submission);
            // 
            // bttn_Holidays
            // 
            this.bttn_Holidays.Location = new System.Drawing.Point(451, 82);
            this.bttn_Holidays.Name = "bttn_Holidays";
            this.bttn_Holidays.Size = new System.Drawing.Size(138, 48);
            this.bttn_Holidays.TabIndex = 3;
            this.bttn_Holidays.Text = "Holidays";
            this.bttn_Holidays.UseVisualStyleBackColor = true;
            this.bttn_Holidays.Click += new System.EventHandler(this.bttn_Holidays_Click);
            // 
            // bttn_Tracks
            // 
            this.bttn_Tracks.Location = new System.Drawing.Point(226, 189);
            this.bttn_Tracks.Name = "bttn_Tracks";
            this.bttn_Tracks.Size = new System.Drawing.Size(138, 48);
            this.bttn_Tracks.TabIndex = 4;
            this.bttn_Tracks.Text = "Tracks";
            this.bttn_Tracks.UseVisualStyleBackColor = true;
            this.bttn_Tracks.Click += new System.EventHandler(this.bttn_Tracks_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttn_Tracks);
            this.Controls.Add(this.bttn_Holidays);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bttn_Car_Submission);
            this.Controls.Add(this.label1);
            this.Name = "Main_Menu";
            this.Text = "Main_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_Car_Submission;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bttn_Holidays;
        private System.Windows.Forms.Button bttn_Tracks;
    }
}