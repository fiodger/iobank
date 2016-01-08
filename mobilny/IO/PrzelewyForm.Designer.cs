namespace IO
{
    partial class PrzelewyForm
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
            this.nazwaOdbiorcy = new System.Windows.Forms.Label();
            this.numerRachunku = new System.Windows.Forms.Label();
            this.Tytul = new System.Windows.Forms.Label();
            this.Kwota = new System.Windows.Forms.Label();
            this.numerRachunkuWartosc = new System.Windows.Forms.TextBox();
            this.nazwaOdbiorcyWartosc = new System.Windows.Forms.TextBox();
            this.tytulWartosc = new System.Windows.Forms.TextBox();
            this.kwotaWartosc = new System.Windows.Forms.TextBox();
            this.Wyloguj = new System.Windows.Forms.Button();
            this.konto = new System.Windows.Forms.Button();
            this.wyślij = new System.Windows.Forms.Button();
            this.fail = new System.Windows.Forms.Label();
            this.sukces = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nazwaOdbiorcy
            // 
            this.nazwaOdbiorcy.AutoSize = true;
            this.nazwaOdbiorcy.Location = new System.Drawing.Point(13, 93);
            this.nazwaOdbiorcy.Name = "nazwaOdbiorcy";
            this.nazwaOdbiorcy.Size = new System.Drawing.Size(89, 13);
            this.nazwaOdbiorcy.TabIndex = 0;
            this.nazwaOdbiorcy.Text = "Nazwa odbiorcy: ";
            // 
            // numerRachunku
            // 
            this.numerRachunku.AutoSize = true;
            this.numerRachunku.Location = new System.Drawing.Point(12, 63);
            this.numerRachunku.Name = "numerRachunku";
            this.numerRachunku.Size = new System.Drawing.Size(132, 13);
            this.numerRachunku.TabIndex = 1;
            this.numerRachunku.Text = "Numer rachunku odbiorcy:";
            // 
            // Tytul
            // 
            this.Tytul.AutoSize = true;
            this.Tytul.Location = new System.Drawing.Point(13, 130);
            this.Tytul.Name = "Tytul";
            this.Tytul.Size = new System.Drawing.Size(77, 13);
            this.Tytul.TabIndex = 2;
            this.Tytul.Text = "Tytuł przelewu";
            // 
            // Kwota
            // 
            this.Kwota.AutoSize = true;
            this.Kwota.Location = new System.Drawing.Point(13, 161);
            this.Kwota.Name = "Kwota";
            this.Kwota.Size = new System.Drawing.Size(37, 13);
            this.Kwota.TabIndex = 3;
            this.Kwota.Text = "Kwota";
            // 
            // numerRachunkuWartosc
            // 
            this.numerRachunkuWartosc.Location = new System.Drawing.Point(163, 63);
            this.numerRachunkuWartosc.Name = "numerRachunkuWartosc";
            this.numerRachunkuWartosc.Size = new System.Drawing.Size(137, 20);
            this.numerRachunkuWartosc.TabIndex = 4;
            // 
            // nazwaOdbiorcyWartosc
            // 
            this.nazwaOdbiorcyWartosc.Location = new System.Drawing.Point(163, 93);
            this.nazwaOdbiorcyWartosc.Name = "nazwaOdbiorcyWartosc";
            this.nazwaOdbiorcyWartosc.Size = new System.Drawing.Size(137, 20);
            this.nazwaOdbiorcyWartosc.TabIndex = 5;
            // 
            // tytulWartosc
            // 
            this.tytulWartosc.Location = new System.Drawing.Point(163, 127);
            this.tytulWartosc.Name = "tytulWartosc";
            this.tytulWartosc.Size = new System.Drawing.Size(137, 20);
            this.tytulWartosc.TabIndex = 6;
            // 
            // kwotaWartosc
            // 
            this.kwotaWartosc.Location = new System.Drawing.Point(163, 161);
            this.kwotaWartosc.Name = "kwotaWartosc";
            this.kwotaWartosc.Size = new System.Drawing.Size(122, 20);
            this.kwotaWartosc.TabIndex = 7;
            // 
            // Wyloguj
            // 
            this.Wyloguj.Location = new System.Drawing.Point(240, 12);
            this.Wyloguj.Name = "Wyloguj";
            this.Wyloguj.Size = new System.Drawing.Size(75, 23);
            this.Wyloguj.TabIndex = 8;
            this.Wyloguj.Text = "Wyloguj";
            this.Wyloguj.UseVisualStyleBackColor = true;
            this.Wyloguj.Click += new System.EventHandler(this.wyloguj);
            // 
            // konto
            // 
            this.konto.Location = new System.Drawing.Point(27, 12);
            this.konto.Name = "konto";
            this.konto.Size = new System.Drawing.Size(75, 23);
            this.konto.TabIndex = 9;
            this.konto.Text = "Konto";
            this.konto.UseVisualStyleBackColor = true;
            this.konto.Click += new System.EventHandler(this.mojeKonto);
            // 
            // wyślij
            // 
            this.wyślij.Location = new System.Drawing.Point(225, 210);
            this.wyślij.Name = "wyślij";
            this.wyślij.Size = new System.Drawing.Size(75, 23);
            this.wyślij.TabIndex = 10;
            this.wyślij.Text = "Wyślij";
            this.wyślij.UseVisualStyleBackColor = true;
            this.wyślij.Click += new System.EventHandler(this.przekazDane);
            // 
            // fail
            // 
            this.fail.AutoSize = true;
            this.fail.ForeColor = System.Drawing.Color.Red;
            this.fail.Location = new System.Drawing.Point(24, 188);
            this.fail.Name = "fail";
            this.fail.Size = new System.Drawing.Size(130, 13);
            this.fail.TabIndex = 11;
            this.fail.Text = "Operacja nie powiodła się";
            this.fail.Visible = false;
            // 
            // sukces
            // 
            this.sukces.AutoSize = true;
            this.sukces.Cursor = System.Windows.Forms.Cursors.Cross;
            this.sukces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sukces.Location = new System.Drawing.Point(24, 210);
            this.sukces.Name = "sukces";
            this.sukces.Size = new System.Drawing.Size(113, 13);
            this.sukces.TabIndex = 12;
            this.sukces.Text = "Operacja powiodła się";
            this.sukces.Visible = false;
            // 
            // PrzelewyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 261);
            this.Controls.Add(this.sukces);
            this.Controls.Add(this.fail);
            this.Controls.Add(this.wyślij);
            this.Controls.Add(this.konto);
            this.Controls.Add(this.Wyloguj);
            this.Controls.Add(this.kwotaWartosc);
            this.Controls.Add(this.tytulWartosc);
            this.Controls.Add(this.nazwaOdbiorcyWartosc);
            this.Controls.Add(this.numerRachunkuWartosc);
            this.Controls.Add(this.Kwota);
            this.Controls.Add(this.Tytul);
            this.Controls.Add(this.numerRachunku);
            this.Controls.Add(this.nazwaOdbiorcy);
            this.Name = "PrzelewyForm";
            this.Text = "Transakcje";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazwaOdbiorcy;
        private System.Windows.Forms.Label numerRachunku;
        private System.Windows.Forms.Label Tytul;
        private System.Windows.Forms.Label Kwota;
        private System.Windows.Forms.TextBox numerRachunkuWartosc;
        private System.Windows.Forms.TextBox nazwaOdbiorcyWartosc;
        private System.Windows.Forms.TextBox tytulWartosc;
        private System.Windows.Forms.TextBox kwotaWartosc;
        private System.Windows.Forms.Button Wyloguj;
        private System.Windows.Forms.Button konto;
        private System.Windows.Forms.Button wyślij;
        private System.Windows.Forms.Label fail;
        private System.Windows.Forms.Label sukces;
    }
}