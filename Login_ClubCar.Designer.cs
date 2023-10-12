
namespace ClubCar_TestTrack_AlphaVersion
{
    partial class Login_ClubCar
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
            this.txb_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.bttn_Login = new System.Windows.Forms.Button();
            this.bttn_Clear = new System.Windows.Forms.Button();
            this.bttn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // txb_Username
            // 
            this.txb_Username.Location = new System.Drawing.Point(193, 41);
            this.txb_Username.Name = "txb_Username";
            this.txb_Username.Size = new System.Drawing.Size(178, 20);
            this.txb_Username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to the Club Car Test Track Application";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(193, 78);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(178, 20);
            this.txb_Password.TabIndex = 4;
            // 
            // bttn_Login
            // 
            this.bttn_Login.Location = new System.Drawing.Point(37, 120);
            this.bttn_Login.Name = "bttn_Login";
            this.bttn_Login.Size = new System.Drawing.Size(105, 46);
            this.bttn_Login.TabIndex = 5;
            this.bttn_Login.Text = "Login";
            this.bttn_Login.UseVisualStyleBackColor = true;
            this.bttn_Login.Click += new System.EventHandler(this.bttn_Login_Click);
            // 
            // bttn_Clear
            // 
            this.bttn_Clear.Location = new System.Drawing.Point(177, 120);
            this.bttn_Clear.Name = "bttn_Clear";
            this.bttn_Clear.Size = new System.Drawing.Size(105, 46);
            this.bttn_Clear.TabIndex = 6;
            this.bttn_Clear.Text = "Clear";
            this.bttn_Clear.UseVisualStyleBackColor = true;
            this.bttn_Clear.Click += new System.EventHandler(this.bttn_Clear_Click);
            // 
            // bttn_Exit
            // 
            this.bttn_Exit.Location = new System.Drawing.Point(314, 120);
            this.bttn_Exit.Name = "bttn_Exit";
            this.bttn_Exit.Size = new System.Drawing.Size(105, 46);
            this.bttn_Exit.TabIndex = 7;
            this.bttn_Exit.Text = "Exit";
            this.bttn_Exit.UseVisualStyleBackColor = true;
            this.bttn_Exit.Click += new System.EventHandler(this.bttn_Exit_Click);
            // 
            // Login_ClubCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 196);
            this.Controls.Add(this.bttn_Exit);
            this.Controls.Add(this.bttn_Clear);
            this.Controls.Add(this.bttn_Login);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_Username);
            this.Controls.Add(this.label1);
            this.Name = "Login_ClubCar";
            this.Text = "Club Car Test Track";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Button bttn_Login;
        private System.Windows.Forms.Button bttn_Clear;
        private System.Windows.Forms.Button bttn_Exit;
    }
}