
namespace ClubCar_TestTrack_AlphaVersion
{
    partial class Holidays
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
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.lbl_Holiday_Name = new System.Windows.Forms.Label();
            this.txb_Holiday_Name = new System.Windows.Forms.TextBox();
            this.txb_Holidays_Date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit_Button
            // 
            this.Submit_Button.Location = new System.Drawing.Point(24, 358);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(115, 36);
            this.Submit_Button.TabIndex = 1;
            this.Submit_Button.Text = "Next";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(163, 358);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(130, 36);
            this.Update_Button.TabIndex = 2;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(308, 358);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(130, 36);
            this.Delete_Button.TabIndex = 28;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(455, 358);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(130, 36);
            this.Clear_Button.TabIndex = 29;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(605, 358);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(130, 36);
            this.Exit_Button.TabIndex = 30;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            // 
            // lbl_Holiday_Name
            // 
            this.lbl_Holiday_Name.AutoSize = true;
            this.lbl_Holiday_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Holiday_Name.Location = new System.Drawing.Point(12, 23);
            this.lbl_Holiday_Name.Name = "lbl_Holiday_Name";
            this.lbl_Holiday_Name.Size = new System.Drawing.Size(152, 25);
            this.lbl_Holiday_Name.TabIndex = 31;
            this.lbl_Holiday_Name.Text = "Holiday Name:";
            // 
            // txb_Holiday_Name
            // 
            this.txb_Holiday_Name.Location = new System.Drawing.Point(183, 28);
            this.txb_Holiday_Name.Name = "txb_Holiday_Name";
            this.txb_Holiday_Name.Size = new System.Drawing.Size(255, 20);
            this.txb_Holiday_Name.TabIndex = 32;
            // 
            // txb_Holidays_Date
            // 
            this.txb_Holidays_Date.Location = new System.Drawing.Point(183, 96);
            this.txb_Holidays_Date.Name = "txb_Holidays_Date";
            this.txb_Holidays_Date.Size = new System.Drawing.Size(255, 20);
            this.txb_Holidays_Date.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Holidays Date:";
            // 
            // Holidays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Holidays_Date);
            this.Controls.Add(this.txb_Holiday_Name);
            this.Controls.Add(this.lbl_Holiday_Name);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Submit_Button);
            this.Name = "Holidays";
            this.Text = "Holidays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label lbl_Holiday_Name;
        private System.Windows.Forms.TextBox txb_Holiday_Name;
        private System.Windows.Forms.TextBox txb_Holidays_Date;
        private System.Windows.Forms.Label label1;
    }
}