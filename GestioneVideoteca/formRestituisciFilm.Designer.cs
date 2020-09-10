namespace GestioneVideoteca
{
    partial class formRestituisciFilm
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
            this.lblRestituisciFilmTitle = new System.Windows.Forms.Label();
            this.lblRestituisciFilmUsername = new System.Windows.Forms.Label();
            this.txtRestituisciFilmUsername = new System.Windows.Forms.TextBox();
            this.lblRestituisciFilmGenerePreferito = new System.Windows.Forms.Label();
            this.txtRestituisciFilmGenerePreferito = new System.Windows.Forms.TextBox();
            this.lblRestituiscifilmScegliFilm = new System.Windows.Forms.Label();
            this.cmbRestituisciFilm = new System.Windows.Forms.ComboBox();
            this.btnRestitusciFilm = new System.Windows.Forms.Button();
            this.btnRestitusciFilmAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRestituisciFilmTitle
            // 
            this.lblRestituisciFilmTitle.AutoSize = true;
            this.lblRestituisciFilmTitle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestituisciFilmTitle.ForeColor = System.Drawing.Color.Red;
            this.lblRestituisciFilmTitle.Location = new System.Drawing.Point(12, 20);
            this.lblRestituisciFilmTitle.Name = "lblRestituisciFilmTitle";
            this.lblRestituisciFilmTitle.Size = new System.Drawing.Size(323, 20);
            this.lblRestituisciFilmTitle.TabIndex = 20;
            this.lblRestituisciFilmTitle.Text = "Benvenuto nel area di restituzione del film";
            // 
            // lblRestituisciFilmUsername
            // 
            this.lblRestituisciFilmUsername.AutoSize = true;
            this.lblRestituisciFilmUsername.Location = new System.Drawing.Point(13, 72);
            this.lblRestituisciFilmUsername.Name = "lblRestituisciFilmUsername";
            this.lblRestituisciFilmUsername.Size = new System.Drawing.Size(58, 13);
            this.lblRestituisciFilmUsername.TabIndex = 21;
            this.lblRestituisciFilmUsername.Text = "Username:";
            // 
            // txtRestituisciFilmUsername
            // 
            this.txtRestituisciFilmUsername.Location = new System.Drawing.Point(123, 72);
            this.txtRestituisciFilmUsername.Name = "txtRestituisciFilmUsername";
            this.txtRestituisciFilmUsername.ReadOnly = true;
            this.txtRestituisciFilmUsername.Size = new System.Drawing.Size(203, 20);
            this.txtRestituisciFilmUsername.TabIndex = 25;
            // 
            // lblRestituisciFilmGenerePreferito
            // 
            this.lblRestituisciFilmGenerePreferito.AutoSize = true;
            this.lblRestituisciFilmGenerePreferito.Location = new System.Drawing.Point(13, 123);
            this.lblRestituisciFilmGenerePreferito.Name = "lblRestituisciFilmGenerePreferito";
            this.lblRestituisciFilmGenerePreferito.Size = new System.Drawing.Size(87, 13);
            this.lblRestituisciFilmGenerePreferito.TabIndex = 26;
            this.lblRestituisciFilmGenerePreferito.Text = "Genere Preferito:";
            // 
            // txtRestituisciFilmGenerePreferito
            // 
            this.txtRestituisciFilmGenerePreferito.Location = new System.Drawing.Point(123, 123);
            this.txtRestituisciFilmGenerePreferito.Name = "txtRestituisciFilmGenerePreferito";
            this.txtRestituisciFilmGenerePreferito.ReadOnly = true;
            this.txtRestituisciFilmGenerePreferito.Size = new System.Drawing.Size(203, 20);
            this.txtRestituisciFilmGenerePreferito.TabIndex = 27;
            // 
            // lblRestituiscifilmScegliFilm
            // 
            this.lblRestituiscifilmScegliFilm.AutoSize = true;
            this.lblRestituiscifilmScegliFilm.Location = new System.Drawing.Point(13, 173);
            this.lblRestituiscifilmScegliFilm.Name = "lblRestituiscifilmScegliFilm";
            this.lblRestituiscifilmScegliFilm.Size = new System.Drawing.Size(69, 13);
            this.lblRestituiscifilmScegliFilm.TabIndex = 28;
            this.lblRestituiscifilmScegliFilm.Text = "Scegli un film";
            // 
            // cmbRestituisciFilm
            // 
            this.cmbRestituisciFilm.FormattingEnabled = true;
            this.cmbRestituisciFilm.Location = new System.Drawing.Point(123, 173);
            this.cmbRestituisciFilm.Name = "cmbRestituisciFilm";
            this.cmbRestituisciFilm.Size = new System.Drawing.Size(212, 21);
            this.cmbRestituisciFilm.TabIndex = 29;
            this.cmbRestituisciFilm.SelectedIndexChanged += new System.EventHandler(this.cmbRestituisciFilm_SelectedIndexChanged);
            // 
            // btnRestitusciFilm
            // 
            this.btnRestitusciFilm.Location = new System.Drawing.Point(16, 218);
            this.btnRestitusciFilm.Name = "btnRestitusciFilm";
            this.btnRestitusciFilm.Size = new System.Drawing.Size(126, 40);
            this.btnRestitusciFilm.TabIndex = 30;
            this.btnRestitusciFilm.Text = "Restituisci Film";
            this.btnRestitusciFilm.UseVisualStyleBackColor = true;
            this.btnRestitusciFilm.Click += new System.EventHandler(this.btnRestitusciFilm_Click);
            // 
            // btnRestitusciFilmAnnulla
            // 
            this.btnRestitusciFilmAnnulla.Location = new System.Drawing.Point(209, 218);
            this.btnRestitusciFilmAnnulla.Name = "btnRestitusciFilmAnnulla";
            this.btnRestitusciFilmAnnulla.Size = new System.Drawing.Size(126, 40);
            this.btnRestitusciFilmAnnulla.TabIndex = 31;
            this.btnRestitusciFilmAnnulla.Text = "Annulla";
            this.btnRestitusciFilmAnnulla.UseVisualStyleBackColor = true;
            this.btnRestitusciFilmAnnulla.Click += new System.EventHandler(this.btnRestitusciFilmAnnulla_Click);
            // 
            // formRestituisciFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 270);
            this.Controls.Add(this.btnRestitusciFilmAnnulla);
            this.Controls.Add(this.btnRestitusciFilm);
            this.Controls.Add(this.cmbRestituisciFilm);
            this.Controls.Add(this.lblRestituiscifilmScegliFilm);
            this.Controls.Add(this.txtRestituisciFilmGenerePreferito);
            this.Controls.Add(this.lblRestituisciFilmGenerePreferito);
            this.Controls.Add(this.txtRestituisciFilmUsername);
            this.Controls.Add(this.lblRestituisciFilmUsername);
            this.Controls.Add(this.lblRestituisciFilmTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formRestituisciFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area Restituzione Film";
            this.Load += new System.EventHandler(this.formRestituisciFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRestituisciFilmTitle;
        private System.Windows.Forms.Label lblRestituisciFilmUsername;
        private System.Windows.Forms.TextBox txtRestituisciFilmUsername;
        private System.Windows.Forms.Label lblRestituisciFilmGenerePreferito;
        private System.Windows.Forms.TextBox txtRestituisciFilmGenerePreferito;
        private System.Windows.Forms.Label lblRestituiscifilmScegliFilm;
        private System.Windows.Forms.ComboBox cmbRestituisciFilm;
        private System.Windows.Forms.Button btnRestitusciFilm;
        private System.Windows.Forms.Button btnRestitusciFilmAnnulla;
    }
}