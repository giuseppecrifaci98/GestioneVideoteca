namespace GestioneVideoteca
{
    partial class formRegistrazione
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegisrati = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfermaPassword = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbCitta = new System.Windows.Forms.ComboBox();
            this.cmbGenerePreferito = new System.Windows.Forms.ComboBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfermaPassword = new System.Windows.Forms.Label();
            this.lblGenerePreferito = new System.Windows.Forms.Label();
            this.lblCitta = new System.Windows.Forms.Label();
            this.lblRegistrazioneTitolo = new System.Windows.Forms.Label();
            this.lblRegistratiSubtitle = new System.Windows.Forms.Label();
            this.btnGoToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegisrati
            // 
            this.btnRegisrati.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisrati.Location = new System.Drawing.Point(16, 353);
            this.btnRegisrati.Name = "btnRegisrati";
            this.btnRegisrati.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegisrati.Size = new System.Drawing.Size(86, 41);
            this.btnRegisrati.TabIndex = 8;
            this.btnRegisrati.Text = "Registra";
            this.btnRegisrati.UseVisualStyleBackColor = true;
            this.btnRegisrati.Click += new System.EventHandler(this.btnRegisrati_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(218, 353);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 41);
            this.btnAnnulla.TabIndex = 10;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // txtCognome
            // 
            this.txtCognome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCognome.Location = new System.Drawing.Point(172, 70);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(121, 23);
            this.txtCognome.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(172, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(172, 188);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(121, 23);
            this.txtPassword.TabIndex = 4;
            // 
            // txtConfermaPassword
            // 
            this.txtConfermaPassword.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfermaPassword.Location = new System.Drawing.Point(172, 225);
            this.txtConfermaPassword.Name = "txtConfermaPassword";
            this.txtConfermaPassword.PasswordChar = '*';
            this.txtConfermaPassword.Size = new System.Drawing.Size(121, 23);
            this.txtConfermaPassword.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(172, 111);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 23);
            this.txtNome.TabIndex = 2;
            // 
            // cmbCitta
            // 
            this.cmbCitta.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCitta.FormattingEnabled = true;
            this.cmbCitta.Location = new System.Drawing.Point(172, 263);
            this.cmbCitta.Name = "cmbCitta";
            this.cmbCitta.Size = new System.Drawing.Size(121, 24);
            this.cmbCitta.TabIndex = 6;
            // 
            // cmbGenerePreferito
            // 
            this.cmbGenerePreferito.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenerePreferito.FormattingEnabled = true;
            this.cmbGenerePreferito.Location = new System.Drawing.Point(172, 304);
            this.cmbGenerePreferito.Name = "cmbGenerePreferito";
            this.cmbGenerePreferito.Size = new System.Drawing.Size(121, 24);
            this.cmbGenerePreferito.TabIndex = 7;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCognome.Location = new System.Drawing.Point(19, 77);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(66, 16);
            this.lblCognome.TabIndex = 9;
            this.lblCognome.Text = "Cognome:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(16, 114);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(47, 16);
            this.lbNome.TabIndex = 10;
            this.lbNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(16, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 16);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(16, 188);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 16);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password:";
            // 
            // lblConfermaPassword
            // 
            this.lblConfermaPassword.AutoSize = true;
            this.lblConfermaPassword.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfermaPassword.Location = new System.Drawing.Point(16, 232);
            this.lblConfermaPassword.Name = "lblConfermaPassword";
            this.lblConfermaPassword.Size = new System.Drawing.Size(131, 16);
            this.lblConfermaPassword.TabIndex = 13;
            this.lblConfermaPassword.Text = "Conferma Password:";
            // 
            // lblGenerePreferito
            // 
            this.lblGenerePreferito.AutoSize = true;
            this.lblGenerePreferito.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerePreferito.Location = new System.Drawing.Point(16, 312);
            this.lblGenerePreferito.Name = "lblGenerePreferito";
            this.lblGenerePreferito.Size = new System.Drawing.Size(110, 16);
            this.lblGenerePreferito.TabIndex = 14;
            this.lblGenerePreferito.Text = "Genere Preferito:";
            // 
            // lblCitta
            // 
            this.lblCitta.AutoSize = true;
            this.lblCitta.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitta.Location = new System.Drawing.Point(16, 271);
            this.lblCitta.Name = "lblCitta";
            this.lblCitta.Size = new System.Drawing.Size(42, 16);
            this.lblCitta.TabIndex = 15;
            this.lblCitta.Text = "Città:";
            // 
            // lblRegistrazioneTitolo
            // 
            this.lblRegistrazioneTitolo.AutoSize = true;
            this.lblRegistrazioneTitolo.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrazioneTitolo.ForeColor = System.Drawing.Color.Red;
            this.lblRegistrazioneTitolo.Location = new System.Drawing.Point(92, 9);
            this.lblRegistrazioneTitolo.Name = "lblRegistrazioneTitolo";
            this.lblRegistrazioneTitolo.Size = new System.Drawing.Size(132, 16);
            this.lblRegistrazioneTitolo.TabIndex = 16;
            this.lblRegistrazioneTitolo.Text = "Form di Registrazione";
            // 
            // lblRegistratiSubtitle
            // 
            this.lblRegistratiSubtitle.AutoSize = true;
            this.lblRegistratiSubtitle.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistratiSubtitle.Location = new System.Drawing.Point(13, 40);
            this.lblRegistratiSubtitle.Name = "lblRegistratiSubtitle";
            this.lblRegistratiSubtitle.Size = new System.Drawing.Size(264, 16);
            this.lblRegistratiSubtitle.TabIndex = 17;
            this.lblRegistratiSubtitle.Text = "Se non sei ancora registrato registrati o accedi";
            // 
            // btnGoToLogin
            // 
            this.btnGoToLogin.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToLogin.Location = new System.Drawing.Point(119, 353);
            this.btnGoToLogin.Name = "btnGoToLogin";
            this.btnGoToLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGoToLogin.Size = new System.Drawing.Size(93, 41);
            this.btnGoToLogin.TabIndex = 9;
            this.btnGoToLogin.Text = "Vai al login";
            this.btnGoToLogin.UseVisualStyleBackColor = true;
            this.btnGoToLogin.Click += new System.EventHandler(this.btnGoToLogin_Click);
            // 
            // formRegistrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 408);
            this.Controls.Add(this.btnGoToLogin);
            this.Controls.Add(this.lblRegistratiSubtitle);
            this.Controls.Add(this.lblRegistrazioneTitolo);
            this.Controls.Add(this.lblCitta);
            this.Controls.Add(this.lblGenerePreferito);
            this.Controls.Add(this.lblConfermaPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.cmbGenerePreferito);
            this.Controls.Add(this.cmbCitta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtConfermaPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnRegisrati);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formRegistrazione";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrazione";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formRegistrazione_FormClosed);
            this.Load += new System.EventHandler(this.formRegistrazione_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisrati;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfermaPassword;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbCitta;
        private System.Windows.Forms.ComboBox cmbGenerePreferito;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfermaPassword;
        private System.Windows.Forms.Label lblGenerePreferito;
        private System.Windows.Forms.Label lblCitta;
        private System.Windows.Forms.Label lblRegistrazioneTitolo;
        private System.Windows.Forms.Label lblRegistratiSubtitle;
        private System.Windows.Forms.Button btnGoToLogin;
    }
}

