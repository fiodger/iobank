namespace IO
{
    partial class PomocForm
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
            this.pomocEditBox = new System.Windows.Forms.TextBox();
            this.wylogujButton = new System.Windows.Forms.Button();
            this.KontoForm = new System.Windows.Forms.Button();
            this.Wyslij = new System.Windows.Forms.Button();
            this.sukces = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pomocEditBox
            // 
            this.pomocEditBox.Location = new System.Drawing.Point(35, 71);
            this.pomocEditBox.Multiline = true;
            this.pomocEditBox.Name = "pomocEditBox";
            this.pomocEditBox.Size = new System.Drawing.Size(267, 185);
            this.pomocEditBox.TabIndex = 0;
            // 
            // wylogujButton
            // 
            this.wylogujButton.Location = new System.Drawing.Point(240, 22);
            this.wylogujButton.Name = "wylogujButton";
            this.wylogujButton.Size = new System.Drawing.Size(75, 23);
            this.wylogujButton.TabIndex = 1;
            this.wylogujButton.Text = "Wyloguj";
            this.wylogujButton.UseVisualStyleBackColor = true;
            this.wylogujButton.Click += new System.EventHandler(this.wyloguj);
            // 
            // KontoForm
            // 
            this.KontoForm.Location = new System.Drawing.Point(24, 22);
            this.KontoForm.Name = "KontoForm";
            this.KontoForm.Size = new System.Drawing.Size(75, 23);
            this.KontoForm.TabIndex = 2;
            this.KontoForm.Text = "Konto";
            this.KontoForm.UseVisualStyleBackColor = true;
            this.KontoForm.Click += new System.EventHandler(this.mojeKonto);
            // 
            // Wyslij
            // 
            this.Wyslij.Location = new System.Drawing.Point(240, 277);
            this.Wyslij.Name = "Wyslij";
            this.Wyslij.Size = new System.Drawing.Size(75, 23);
            this.Wyslij.TabIndex = 3;
            this.Wyslij.Text = "Wyślij";
            this.Wyslij.UseVisualStyleBackColor = true;
            this.Wyslij.Click += new System.EventHandler(this.wyslij);
            // 
            // sukces
            // 
            this.sukces.AutoSize = true;
            this.sukces.ForeColor = System.Drawing.Color.SeaGreen;
            this.sukces.Location = new System.Drawing.Point(87, 261);
            this.sukces.Name = "sukces";
            this.sukces.Size = new System.Drawing.Size(155, 13);
            this.sukces.TabIndex = 4;
            this.sukces.Text = "Wiadomość wysłana pomyślnie";
            this.sukces.Visible = false;
            // 
            // PomocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 312);
            this.Controls.Add(this.sukces);
            this.Controls.Add(this.Wyslij);
            this.Controls.Add(this.KontoForm);
            this.Controls.Add(this.wylogujButton);
            this.Controls.Add(this.pomocEditBox);
            this.Name = "PomocForm";
            this.Text = "Pomoc";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pomocEditBox;
        private System.Windows.Forms.Button wylogujButton;
        private System.Windows.Forms.Button KontoForm;
        private System.Windows.Forms.Button Wyslij;
        private System.Windows.Forms.Label sukces;
    }
}