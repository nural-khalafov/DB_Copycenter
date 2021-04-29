
namespace DB_Copycenter
{
    partial class RegistrationForm
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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPassTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.nameSurnameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(119, 92);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(150, 20);
            this.loginTextBox.TabIndex = 0;
            this.loginTextBox.Text = "Enter login";
            this.loginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(119, 150);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(150, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "Enter password";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPassTextBox
            // 
            this.confirmPassTextBox.Location = new System.Drawing.Point(119, 176);
            this.confirmPassTextBox.Name = "confirmPassTextBox";
            this.confirmPassTextBox.Size = new System.Drawing.Size(150, 20);
            this.confirmPassTextBox.TabIndex = 2;
            this.confirmPassTextBox.Text = "Confirm password";
            this.confirmPassTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmPassTextBox.UseSystemPasswordChar = true;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.Location = new System.Drawing.Point(147, 217);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(100, 53);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "REGISTER";
            this.registerButton.UseVisualStyleBackColor = true;
            // 
            // nameSurnameTextBox
            // 
            this.nameSurnameTextBox.Location = new System.Drawing.Point(119, 118);
            this.nameSurnameTextBox.Name = "nameSurnameTextBox";
            this.nameSurnameTextBox.Size = new System.Drawing.Size(150, 20);
            this.nameSurnameTextBox.TabIndex = 4;
            this.nameSurnameTextBox.Text = "Enter Name and Surname";
            this.nameSurnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(147, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(394, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameSurnameTextBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.confirmPassTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox confirmPassTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox nameSurnameTextBox;
        private System.Windows.Forms.Button button1;
    }
}