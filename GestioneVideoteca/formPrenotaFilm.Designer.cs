namespace GestioneVideoteca
{
    partial class formPrenotaFilm
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
            this.lblPrenotaFilmTitle = new System.Windows.Forms.Label();
            this.lblPrenotaFilmUsername = new System.Windows.Forms.Label();
            this.lblPrenotaFilmGenerePreferito = new System.Windows.Forms.Label();
            this.lblPrenotafilmScegliFilm = new System.Windows.Forms.Label();
            this.txtPrenotaFIlmGenerePreferito = new System.Windows.Forms.TextBox();
            this.txtPrenotaFilmUsername = new System.Windows.Forms.TextBox();
            this.chkPrenotaFilmGenerePreferito = new System.Windows.Forms.CheckBox();
            this.cmbPrenotaFilmElencoFilm = new System.Windows.Forms.ComboBox();
            this.btnPrenotafilm = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrenotaFilmTitle
            // 
            this.lblPrenotaFilmTitle.AutoSize = true;
            this.lblPrenotaFilmTitle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenotaFilmTitle.ForeColor = System.Drawing.Color.Red;
            this.lblPrenotaFilmTitle.Location = new System.Drawing.Point(12, 9);
            this.lblPrenotaFilmTitle.Name = "lblPrenotaFilmTitle";
            this.lblPrenotaFilmTitle.Size = new System.Drawing.Size(276, 20);
            this.lblPrenotaFilmTitle.TabIndex = 19;
            this.lblPrenotaFilmTitle.Text = "Benvenuto nell\'area di prenotazione";
            // 
            // lblPrenotaFilmUsername
            // 
            this.lblPrenotaFilmUsername.AutoSize = true;
            this.lblPrenotaFilmUsername.Location = new System.Drawing.Point(13, 56);
            this.lblPrenotaFilmUsername.Name = "lblPrenotaFilmUsername";
            this.lblPrenotaFilmUsername.Size = new System.Drawing.Size(58, 13);
            this.lblPrenotaFilmUsername.TabIndex = 20;
            this.lblPrenotaFilmUsername.Text = "Username:";
            // 
            // lblPrenotaFilmGenerePreferito
            // 
            this.lblPrenotaFilmGenerePreferito.AutoSize = true;
            this.lblPrenotaFilmGenerePreferito.Location = new System.Drawing.Point(13, 98);
            this.lblPrenotaFilmGenerePreferito.Name = "lblPrenotaFilmGenerePreferito";
            this.lblPrenotaFilmGenerePreferito.Size = new System.Drawing.Size(87, 13);
            this.lblPrenotaFilmGenerePreferito.TabIndex = 21;
            this.lblPrenotaFilmGenerePreferito.Text = "Genere Preferito:";
            // 
            // lblPrenotafilmScegliFilm
            // 
            this.lblPrenotafilmScegliFilm.AutoSize = true;
            this.lblPrenotafilmScegliFilm.Location = new System.Drawing.Point(13, 137);
            this.lblPrenotafilmScegliFilm.Name = "lblPrenotafilmScegliFilm";
            this.lblPrenotafilmScegliFilm.Size = new System.Drawing.Size(69, 13);
            this.lblPrenotafilmScegliFilm.TabIndex = 22;
            this.lblPrenotafilmScegliFilm.Text = "Scegli un film";
            // 
            // txtPrenotaFIlmGenerePreferito
            // 
            this.txtPrenotaFIlmGenerePreferito.Location = new System.Drawing.Point(144, 98);
            this.txtPrenotaFIlmGenerePreferito.Name = "txtPrenotaFIlmGenerePreferito";
            this.txtPrenotaFIlmGenerePreferito.ReadOnly = true;
            this.txtPrenotaFIlmGenerePreferito.Size = new System.Drawing.Size(100, 20);
            this.txtPrenotaFIlmGenerePreferito.TabIndex = 23;
            // 
            // txtPrenotaFilmUsername
            // 
            this.txtPrenotaFilmUsername.Location = new System.Drawing.Point(144, 56);
            this.txtPrenotaFilmUsername.Name = "txtPrenotaFilmUsername";
            this.txtPrenotaFilmUsername.ReadOnly = true;
            this.txtPrenotaFilmUsername.Size = new System.Drawing.Size(100, 20);
            this.txtPrenotaFilmUsername.TabIndex = 24;
            // 
            // chkPrenotaFilmGenerePreferito
            // 
            this.chkPrenotaFilmGenerePreferito.AutoSize = true;
            this.chkPrenotaFilmGenerePreferito.Location = new System.Drawing.Point(283, 101);
            this.chkPrenotaFilmGenerePreferito.Name = "chkPrenotaFilmGenerePreferito";
            this.chkPrenotaFilmGenerePreferito.Size = new System.Drawing.Size(101, 17);
            this.chkPrenotaFilmGenerePreferito.TabIndex = 25;
            this.chkPrenotaFilmGenerePreferito.Text = "Mostra tutti i film";
            this.chkPrenotaFilmGenerePreferito.UseVisualStyleBackColor = true;
            this.chkPrenotaFilmGenerePreferito.CheckedChanged += new System.EventHandler(this.chkPrenotaFilmGenerePreferito_CheckedChanged);
            // 
            // cmbPrenotaFilmElencoFilm
            // 
            this.cmbPrenotaFilmElencoFilm.FormattingEnabled = true;
            this.cmbPrenotaFilmElencoFilm.Location = new System.Drawing.Point(144, 137);
            this.cmbPrenotaFilmElencoFilm.Name = "cmbPrenotaFilmElencoFilm";
            this.cmbPrenotaFilmElencoFilm.Size = new System.Drawing.Size(240, 21);
            this.cmbPrenotaFilmElencoFilm.TabIndex = 26;
            // 
            // btnPrenotafilm
            // 
            this.btnPrenotafilm.Location = new System.Drawing.Point(16, 191);
            this.btnPrenotafilm.Name = "btnPrenotafilm";
            this.btnPrenotafilm.Size = new System.Drawing.Size(75, 23);
            this.btnPrenotafilm.TabIndex = 27;
            this.btnPrenotafilm.Text = "Prenota";
            this.btnPrenotafilm.UseVisualStyleBackColor = true;
            this.btnPrenotafilm.Click += new System.EventHandler(this.btnPrenotafilm_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(309, 191);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 28;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // formPrenotaFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 228);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnPrenotafilm);
            this.Controls.Add(this.cmbPrenotaFilmElencoFilm);
            this.Controls.Add(this.chkPrenotaFilmGenerePreferito);
            this.Controls.Add(this.txtPrenotaFilmUsername);
            this.Controls.Add(this.txtPrenotaFIlmGenerePreferito);
            this.Controls.Add(this.lblPrenotafilmScegliFilm);
            this.Controls.Add(this.lblPrenotaFilmGenerePreferito);
            this.Controls.Add(this.lblPrenotaFilmUsername);
            this.Controls.Add(this.lblPrenotaFilmTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formPrenotaFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPrenotaFilm";
            this.Load += new System.EventHandler(this.formPrenotaFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrenotaFilmTitle;
        private System.Windows.Forms.Label lblPrenotaFilmUsername;
        private System.Windows.Forms.Label lblPrenotaFilmGenerePreferito;
        private System.Windows.Forms.Label lblPrenotafilmScegliFilm;
        private System.Windows.Forms.TextBox txtPrenotaFIlmGenerePreferito;
        private System.Windows.Forms.TextBox txtPrenotaFilmUsername;
        private System.Windows.Forms.CheckBox chkPrenotaFilmGenerePreferito;
        private System.Windows.Forms.ComboBox cmbPrenotaFilmElencoFilm;
        private System.Windows.Forms.Button btnPrenotafilm;
        private System.Windows.Forms.Button btnAnnulla;
    }
}