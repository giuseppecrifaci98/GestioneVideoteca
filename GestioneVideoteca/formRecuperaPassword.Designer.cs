namespace GestioneVideoteca
{
    partial class formRecuperaPassword
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
            this.lblRecuperoPasswordTitle = new System.Windows.Forms.Label();
            this.lblRecuperoPasswordSubtitle = new System.Windows.Forms.Label();
            this.lblRecuperaPasswordEmail = new System.Windows.Forms.Label();
            this.lblRecuperaPasswordPAssword = new System.Windows.Forms.Label();
            this.lblRecuperaPasswordConfermaPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfermaPassword = new System.Windows.Forms.TextBox();
            this.btnCambiaPassword = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRecuperoPasswordTitle
            // 
            this.lblRecuperoPasswordTitle.AutoSize = true;
            this.lblRecuperoPasswordTitle.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperoPasswordTitle.ForeColor = System.Drawing.Color.Red;
            this.lblRecuperoPasswordTitle.Location = new System.Drawing.Point(123, 9);
            this.lblRecuperoPasswordTitle.Name = "lblRecuperoPasswordTitle";
            this.lblRecuperoPasswordTitle.Size = new System.Drawing.Size(159, 16);
            this.lblRecuperoPasswordTitle.TabIndex = 18;
            this.lblRecuperoPasswordTitle.Text = "Form di recupera password";
            // 
            // lblRecuperoPasswordSubtitle
            // 
            this.lblRecuperoPasswordSubtitle.AutoSize = true;
            this.lblRecuperoPasswordSubtitle.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperoPasswordSubtitle.Location = new System.Drawing.Point(35, 43);
            this.lblRecuperoPasswordSubtitle.Name = "lblRecuperoPasswordSubtitle";
            this.lblRecuperoPasswordSubtitle.Size = new System.Drawing.Size(310, 16);
            this.lblRecuperoPasswordSubtitle.TabIndex = 23;
            this.lblRecuperoPasswordSubtitle.Text = "Completa i seguenti campi per recuperare la password";
            // 
            // lblRecuperaPasswordEmail
            // 
            this.lblRecuperaPasswordEmail.AutoSize = true;
            this.lblRecuperaPasswordEmail.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperaPasswordEmail.Location = new System.Drawing.Point(35, 103);
            this.lblRecuperaPasswordEmail.Name = "lblRecuperaPasswordEmail";
            this.lblRecuperaPasswordEmail.Size = new System.Drawing.Size(48, 16);
            this.lblRecuperaPasswordEmail.TabIndex = 24;
            this.lblRecuperaPasswordEmail.Text = "Email:";
            // 
            // lblRecuperaPasswordPAssword
            // 
            this.lblRecuperaPasswordPAssword.AutoSize = true;
            this.lblRecuperaPasswordPAssword.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperaPasswordPAssword.Location = new System.Drawing.Point(35, 146);
            this.lblRecuperaPasswordPAssword.Name = "lblRecuperaPasswordPAssword";
            this.lblRecuperaPasswordPAssword.Size = new System.Drawing.Size(69, 16);
            this.lblRecuperaPasswordPAssword.TabIndex = 25;
            this.lblRecuperaPasswordPAssword.Text = "Password:";
            // 
            // lblRecuperaPasswordConfermaPassword
            // 
            this.lblRecuperaPasswordConfermaPassword.AutoSize = true;
            this.lblRecuperaPasswordConfermaPassword.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperaPasswordConfermaPassword.Location = new System.Drawing.Point(35, 201);
            this.lblRecuperaPasswordConfermaPassword.Name = "lblRecuperaPasswordConfermaPassword";
            this.lblRecuperaPasswordConfermaPassword.Size = new System.Drawing.Size(131, 16);
            this.lblRecuperaPasswordConfermaPassword.TabIndex = 26;
            this.lblRecuperaPasswordConfermaPassword.Text = "Conferma Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(187, 103);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 23);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(187, 146);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(186, 23);
            this.txtPassword.TabIndex = 28;
            // 
            // txtConfermaPassword
            // 
            this.txtConfermaPassword.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfermaPassword.Location = new System.Drawing.Point(187, 201);
            this.txtConfermaPassword.Name = "txtConfermaPassword";
            this.txtConfermaPassword.PasswordChar = '*';
            this.txtConfermaPassword.Size = new System.Drawing.Size(186, 23);
            this.txtConfermaPassword.TabIndex = 29;
            // 
            // btnCambiaPassword
            // 
            this.btnCambiaPassword.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiaPassword.Location = new System.Drawing.Point(38, 259);
            this.btnCambiaPassword.Name = "btnCambiaPassword";
            this.btnCambiaPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCambiaPassword.Size = new System.Drawing.Size(86, 41);
            this.btnCambiaPassword.TabIndex = 30;
            this.btnCambiaPassword.Text = "Cambia Password";
            this.btnCambiaPassword.UseVisualStyleBackColor = true;
            this.btnCambiaPassword.Click += new System.EventHandler(this.btnCambiaPassword_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(296, 259);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAnnulla.Size = new System.Drawing.Size(86, 41);
            this.btnAnnulla.TabIndex = 31;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // formRecuperaPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 328);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnCambiaPassword);
            this.Controls.Add(this.txtConfermaPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblRecuperaPasswordConfermaPassword);
            this.Controls.Add(this.lblRecuperaPasswordPAssword);
            this.Controls.Add(this.lblRecuperaPasswordEmail);
            this.Controls.Add(this.lblRecuperoPasswordSubtitle);
            this.Controls.Add(this.lblRecuperoPasswordTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formRecuperaPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area di recupero della password";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formRecuperaPassword_FormClosed);
            this.Load += new System.EventHandler(this.formRecuperaPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecuperoPasswordTitle;
        private System.Windows.Forms.Label lblRecuperoPasswordSubtitle;
        private System.Windows.Forms.Label lblRecuperaPasswordEmail;
        private System.Windows.Forms.Label lblRecuperaPasswordPAssword;
        private System.Windows.Forms.Label lblRecuperaPasswordConfermaPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfermaPassword;
        private System.Windows.Forms.Button btnCambiaPassword;
        private System.Windows.Forms.Button btnAnnulla;
    }
}