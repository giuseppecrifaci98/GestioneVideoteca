namespace GestioneVideoteca
{
    partial class formLogin
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
            this.lblAccessoTitle = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAccessoSubtitle = new System.Windows.Forms.Label();
            this.btnGoRegistrazione = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnAccedi = new System.Windows.Forms.Button();
            this.lblAccessoSubtitle2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAccessoTitle
            // 
            this.lblAccessoTitle.AutoSize = true;
            this.lblAccessoTitle.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessoTitle.ForeColor = System.Drawing.Color.Red;
            this.lblAccessoTitle.Location = new System.Drawing.Point(85, 9);
            this.lblAccessoTitle.Name = "lblAccessoTitle";
            this.lblAccessoTitle.Size = new System.Drawing.Size(96, 16);
            this.lblAccessoTitle.TabIndex = 17;
            this.lblAccessoTitle.Text = "Form di accesso";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(9, 132);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 16);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 16);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(103, 129);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(186, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(103, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 23);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblAccessoSubtitle
            // 
            this.lblAccessoSubtitle.AutoSize = true;
            this.lblAccessoSubtitle.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessoSubtitle.Location = new System.Drawing.Point(37, 42);
            this.lblAccessoSubtitle.Name = "lblAccessoSubtitle";
            this.lblAccessoSubtitle.Size = new System.Drawing.Size(219, 16);
            this.lblAccessoSubtitle.TabIndex = 22;
            this.lblAccessoSubtitle.Text = "Se non sei ancora registrati, registrati\r\n";
            // 
            // btnGoRegistrazione
            // 
            this.btnGoRegistrazione.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoRegistrazione.Location = new System.Drawing.Point(115, 219);
            this.btnGoRegistrazione.Name = "btnGoRegistrazione";
            this.btnGoRegistrazione.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGoRegistrazione.Size = new System.Drawing.Size(93, 41);
            this.btnGoRegistrazione.TabIndex = 4;
            this.btnGoRegistrazione.Text = "Registrati";
            this.btnGoRegistrazione.UseVisualStyleBackColor = true;
            this.btnGoRegistrazione.Click += new System.EventHandler(this.btnGoRegistrazione_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(214, 219);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 41);
            this.btnAnnulla.TabIndex = 5;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnAccedi
            // 
            this.btnAccedi.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccedi.Location = new System.Drawing.Point(12, 219);
            this.btnAccedi.Name = "btnAccedi";
            this.btnAccedi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAccedi.Size = new System.Drawing.Size(86, 41);
            this.btnAccedi.TabIndex = 3;
            this.btnAccedi.Text = "Accedi";
            this.btnAccedi.UseVisualStyleBackColor = true;
            this.btnAccedi.Click += new System.EventHandler(this.btnAccedi_Click);
            // 
            // lblAccessoSubtitle2
            // 
            this.lblAccessoSubtitle2.AutoSize = true;
            this.lblAccessoSubtitle2.Location = new System.Drawing.Point(30, 181);
            this.lblAccessoSubtitle2.Name = "lblAccessoSubtitle2";
            this.lblAccessoSubtitle2.Size = new System.Drawing.Size(259, 13);
            this.lblAccessoSubtitle2.TabIndex = 23;
            this.lblAccessoSubtitle2.Text = "Hai dimentico la password? Clicca qui per recuperarla";
            this.lblAccessoSubtitle2.Click += new System.EventHandler(this.lblAccessoSubtitle2_Click);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 278);
            this.Controls.Add(this.lblAccessoSubtitle2);
            this.Controls.Add(this.btnGoRegistrazione);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnAccedi);
            this.Controls.Add(this.lblAccessoSubtitle);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblAccessoTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formLogin_FormClosed);
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccessoTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAccessoSubtitle;
        private System.Windows.Forms.Button btnGoRegistrazione;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnAccedi;
        private System.Windows.Forms.Label lblAccessoSubtitle2;
    }
}