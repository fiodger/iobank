namespace IO
{
    partial class LoginForm
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
            this.login = new System.Windows.Forms.Label();
            this.loginEditBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.passwordEditBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.niepoprawny = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Enabled = false;
            this.login.ForeColor = System.Drawing.SystemColors.MenuText;
            this.login.Location = new System.Drawing.Point(78, 106);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(33, 13);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            // 
            // loginEditBox
            // 
            this.loginEditBox.Location = new System.Drawing.Point(138, 106);
            this.loginEditBox.Name = "loginEditBox";
            this.loginEditBox.Size = new System.Drawing.Size(100, 20);
            this.loginEditBox.TabIndex = 1;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Enabled = false;
            this.password.ForeColor = System.Drawing.SystemColors.MenuText;
            this.password.Location = new System.Drawing.Point(78, 141);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(36, 13);
            this.password.TabIndex = 0;
            this.password.Text = "Hasło";
            // 
            // passwordEditBox
            // 
            this.passwordEditBox.Location = new System.Drawing.Point(138, 141);
            this.passwordEditBox.Name = "passwordEditBox";
            this.passwordEditBox.Size = new System.Drawing.Size(100, 20);
            this.passwordEditBox.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(196, 214);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Zaloguj";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.zaloguj);
            // 
            // niepoprawny
            // 
            this.niepoprawny.AutoSize = true;
            this.niepoprawny.BackColor = System.Drawing.Color.Transparent;
            this.niepoprawny.ForeColor = System.Drawing.Color.Red;
            this.niepoprawny.Location = new System.Drawing.Point(59, 177);
            this.niepoprawny.Name = "niepoprawny";
            this.niepoprawny.Size = new System.Drawing.Size(201, 13);
            this.niepoprawny.TabIndex = 4;
            this.niepoprawny.Text = "Podany login lub hasło są nieprawidłowe";
            this.niepoprawny.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(304, 349);
            this.Controls.Add(this.niepoprawny);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordEditBox);
            this.Controls.Add(this.loginEditBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Name = "LoginForm";
            this.Text = "Ekran Logowania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox loginEditBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passwordEditBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label niepoprawny;
    }
}

