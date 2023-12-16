using System.Data.OleDb;
using System.Security.Cryptography.X509Certificates;

namespace B_A_Software
{
    partial class Login
    {
        OleDbConnection connection = new OleDbConnection();
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginBtn = new Button();
            EmployeeNumLab = new Label();
            PasswordLab = new Label();
            EmployeeNumTxtBox = new TextBox();
            PasswordTxtBox = new TextBox();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.Location = new Point(140, 216);
            LoginBtn.MinimumSize = new Size(120, 40);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(120, 40);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Einloggen";
            LoginBtn.TextAlign = ContentAlignment.TopCenter;
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // EmployeeNumLab
            // 
            EmployeeNumLab.AutoSize = true;
            EmployeeNumLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeNumLab.Location = new Point(21, 44);
            EmployeeNumLab.Name = "EmployeeNumLab";
            EmployeeNumLab.Size = new Size(145, 28);
            EmployeeNumLab.TabIndex = 1;
            EmployeeNumLab.Text = "Mitarbeiter Nr.:";
            // 
            // PasswordLab
            // 
            PasswordLab.AutoSize = true;
            PasswordLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLab.Location = new Point(21, 129);
            PasswordLab.Name = "PasswordLab";
            PasswordLab.Size = new Size(88, 28);
            PasswordLab.TabIndex = 2;
            PasswordLab.Text = "Passwort";
            // 
            // EmployeeNumTxtBox
            // 
            EmployeeNumTxtBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeNumTxtBox.Location = new Point(184, 44);
            EmployeeNumTxtBox.MinimumSize = new Size(150, 28);
            EmployeeNumTxtBox.Name = "EmployeeNumTxtBox";
            EmployeeNumTxtBox.Size = new Size(150, 28);
            EmployeeNumTxtBox.TabIndex = 3;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTxtBox.Location = new Point(184, 129);
            PasswordTxtBox.MinimumSize = new Size(150, 28);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.Size = new Size(150, 28);
            PasswordTxtBox.TabIndex = 4;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 277);
            Controls.Add(PasswordTxtBox);
            Controls.Add(EmployeeNumTxtBox);
            Controls.Add(PasswordLab);
            Controls.Add(EmployeeNumLab);
            Controls.Add(LoginBtn);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginBtn;
        private Label EmployeeNumLab;
        private Label PasswordLab;
        private TextBox EmployeeNumTxtBox;
        private TextBox PasswordTxtBox;
    }
}