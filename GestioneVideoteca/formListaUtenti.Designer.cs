namespace GestioneVideoteca
{
    partial class formListaUtenti
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
            this.lblGestioneUtenteTitle = new System.Windows.Forms.Label();
            this.dgvListaUtenti = new System.Windows.Forms.DataGridView();
            this.tabControlGestioneUtente = new System.Windows.Forms.TabPage();
            this.lblGestioneUtenteEliminaID = new System.Windows.Forms.Label();
            this.txtGestioneUtenteDeleteId = new System.Windows.Forms.TextBox();
            this.btnGestioneUtenteEliminaUtente = new System.Windows.Forms.Button();
            this.btnGestioneUtenteAnnulla = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lblGestioneUtenteModificaIDUtente = new System.Windows.Forms.Label();
            this.txtGestioneUtenteModificaIDUtente = new System.Windows.Forms.TextBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAnnullaUpdateUser = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblGestioneUtenteModificaUtenteIDUtente = new System.Windows.Forms.Label();
            this.lblGestioneUtenteModificaUtenteNome = new System.Windows.Forms.Label();
            this.lblGestioneUtenteModificaUtenteCognome = new System.Windows.Forms.Label();
            this.lblGestioneUtenteModificaUtentEmail = new System.Windows.Forms.Label();
            this.txtGestioneUtenteModificaNome = new System.Windows.Forms.TextBox();
            this.txtGestioneUtenteModificaCognome = new System.Windows.Forms.TextBox();
            this.txtGestioneUtenteModificaEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUtenti)).BeginInit();
            this.tabControlGestioneUtente.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGestioneUtenteTitle
            // 
            this.lblGestioneUtenteTitle.AutoSize = true;
            this.lblGestioneUtenteTitle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneUtenteTitle.ForeColor = System.Drawing.Color.Black;
            this.lblGestioneUtenteTitle.Location = new System.Drawing.Point(313, 9);
            this.lblGestioneUtenteTitle.Name = "lblGestioneUtenteTitle";
            this.lblGestioneUtenteTitle.Size = new System.Drawing.Size(90, 20);
            this.lblGestioneUtenteTitle.TabIndex = 20;
            this.lblGestioneUtenteTitle.Text = "Benvenuto";
            // 
            // dgvListaUtenti
            // 
            this.dgvListaUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUtenti.Location = new System.Drawing.Point(21, 51);
            this.dgvListaUtenti.Name = "dgvListaUtenti";
            this.dgvListaUtenti.Size = new System.Drawing.Size(767, 356);
            this.dgvListaUtenti.TabIndex = 21;
            // 
            // tabControlGestioneUtente
            // 
            this.tabControlGestioneUtente.Controls.Add(this.btnGestioneUtenteAnnulla);
            this.tabControlGestioneUtente.Controls.Add(this.btnGestioneUtenteEliminaUtente);
            this.tabControlGestioneUtente.Controls.Add(this.txtGestioneUtenteDeleteId);
            this.tabControlGestioneUtente.Controls.Add(this.lblGestioneUtenteEliminaID);
            this.tabControlGestioneUtente.Location = new System.Drawing.Point(4, 22);
            this.tabControlGestioneUtente.Name = "tabControlGestioneUtente";
            this.tabControlGestioneUtente.Padding = new System.Windows.Forms.Padding(3);
            this.tabControlGestioneUtente.Size = new System.Drawing.Size(759, 144);
            this.tabControlGestioneUtente.TabIndex = 0;
            this.tabControlGestioneUtente.Text = "Elimina Utente";
            this.tabControlGestioneUtente.UseVisualStyleBackColor = true;
            // 
            // lblGestioneUtenteEliminaID
            // 
            this.lblGestioneUtenteEliminaID.AutoSize = true;
            this.lblGestioneUtenteEliminaID.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneUtenteEliminaID.Location = new System.Drawing.Point(22, 16);
            this.lblGestioneUtenteEliminaID.Name = "lblGestioneUtenteEliminaID";
            this.lblGestioneUtenteEliminaID.Size = new System.Drawing.Size(66, 16);
            this.lblGestioneUtenteEliminaID.TabIndex = 22;
            this.lblGestioneUtenteEliminaID.Text = "Id utente:";
            // 
            // txtGestioneUtenteDeleteId
            // 
            this.txtGestioneUtenteDeleteId.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestioneUtenteDeleteId.Location = new System.Drawing.Point(94, 13);
            this.txtGestioneUtenteDeleteId.Name = "txtGestioneUtenteDeleteId";
            this.txtGestioneUtenteDeleteId.Size = new System.Drawing.Size(108, 23);
            this.txtGestioneUtenteDeleteId.TabIndex = 23;
            // 
            // btnGestioneUtenteEliminaUtente
            // 
            this.btnGestioneUtenteEliminaUtente.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestioneUtenteEliminaUtente.Location = new System.Drawing.Point(25, 58);
            this.btnGestioneUtenteEliminaUtente.Name = "btnGestioneUtenteEliminaUtente";
            this.btnGestioneUtenteEliminaUtente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGestioneUtenteEliminaUtente.Size = new System.Drawing.Size(86, 41);
            this.btnGestioneUtenteEliminaUtente.TabIndex = 24;
            this.btnGestioneUtenteEliminaUtente.Text = "Elimina";
            this.btnGestioneUtenteEliminaUtente.UseVisualStyleBackColor = true;
            this.btnGestioneUtenteEliminaUtente.Click += new System.EventHandler(this.btnGestioneUtenteEliminaUtente_Click);
            // 
            // btnGestioneUtenteAnnulla
            // 
            this.btnGestioneUtenteAnnulla.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestioneUtenteAnnulla.Location = new System.Drawing.Point(117, 58);
            this.btnGestioneUtenteAnnulla.Name = "btnGestioneUtenteAnnulla";
            this.btnGestioneUtenteAnnulla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGestioneUtenteAnnulla.Size = new System.Drawing.Size(86, 41);
            this.btnGestioneUtenteAnnulla.TabIndex = 25;
            this.btnGestioneUtenteAnnulla.Text = "Annulla";
            this.btnGestioneUtenteAnnulla.UseVisualStyleBackColor = true;
            this.btnGestioneUtenteAnnulla.Click += new System.EventHandler(this.btnGestioneUtenteAnnulla_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabControlGestioneUtente);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(21, 430);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(767, 170);
            this.tabControl1.TabIndex = 23;
            // 
            // lblGestioneUtenteModificaIDUtente
            // 
            this.lblGestioneUtenteModificaIDUtente.AutoSize = true;
            this.lblGestioneUtenteModificaIDUtente.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneUtenteModificaIDUtente.Location = new System.Drawing.Point(25, 24);
            this.lblGestioneUtenteModificaIDUtente.Name = "lblGestioneUtenteModificaIDUtente";
            this.lblGestioneUtenteModificaIDUtente.Size = new System.Drawing.Size(0, 16);
            this.lblGestioneUtenteModificaIDUtente.TabIndex = 24;
            // 
            // txtGestioneUtenteModificaIDUtente
            // 
            this.txtGestioneUtenteModificaIDUtente.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestioneUtenteModificaIDUtente.Location = new System.Drawing.Point(97, 21);
            this.txtGestioneUtenteModificaIDUtente.Name = "txtGestioneUtenteModificaIDUtente";
            this.txtGestioneUtenteModificaIDUtente.ReadOnly = true;
            this.txtGestioneUtenteModificaIDUtente.Size = new System.Drawing.Size(108, 23);
            this.txtGestioneUtenteModificaIDUtente.TabIndex = 25;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Location = new System.Drawing.Point(242, 63);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdateUser.Size = new System.Drawing.Size(86, 41);
            this.btnUpdateUser.TabIndex = 26;
            this.btnUpdateUser.Text = "Modifica";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnAnnullaUpdateUser
            // 
            this.btnAnnullaUpdateUser.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnullaUpdateUser.Location = new System.Drawing.Point(334, 63);
            this.btnAnnullaUpdateUser.Name = "btnAnnullaUpdateUser";
            this.btnAnnullaUpdateUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAnnullaUpdateUser.Size = new System.Drawing.Size(86, 41);
            this.btnAnnullaUpdateUser.TabIndex = 27;
            this.btnAnnullaUpdateUser.Text = "Annulla";
            this.btnAnnullaUpdateUser.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtGestioneUtenteModificaEmail);
            this.tabPage2.Controls.Add(this.txtGestioneUtenteModificaCognome);
            this.tabPage2.Controls.Add(this.txtGestioneUtenteModificaNome);
            this.tabPage2.Controls.Add(this.lblGestioneUtenteModificaUtentEmail);
            this.tabPage2.Controls.Add(this.lblGestioneUtenteModificaUtenteCognome);
            this.tabPage2.Controls.Add(this.lblGestioneUtenteModificaUtenteNome);
            this.tabPage2.Controls.Add(this.lblGestioneUtenteModificaUtenteIDUtente);
            this.tabPage2.Controls.Add(this.btnAnnullaUpdateUser);
            this.tabPage2.Controls.Add(this.btnUpdateUser);
            this.tabPage2.Controls.Add(this.txtGestioneUtenteModificaIDUtente);
            this.tabPage2.Controls.Add(this.lblGestioneUtenteModificaIDUtente);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(759, 144);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modifica Utente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblGestioneUtenteModificaUtenteIDUtente
            // 
            this.lblGestioneUtenteModificaUtenteIDUtente.AutoSize = true;
            this.lblGestioneUtenteModificaUtenteIDUtente.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneUtenteModificaUtenteIDUtente.Location = new System.Drawing.Point(25, 24);
            this.lblGestioneUtenteModificaUtenteIDUtente.Name = "lblGestioneUtenteModificaUtenteIDUtente";
            this.lblGestioneUtenteModificaUtenteIDUtente.Size = new System.Drawing.Size(66, 16);
            this.lblGestioneUtenteModificaUtenteIDUtente.TabIndex = 28;
            this.lblGestioneUtenteModificaUtenteIDUtente.Text = "Id utente:";
            // 
            // lblGestioneUtenteModificaUtenteNome
            // 
            this.lblGestioneUtenteModificaUtenteNome.AutoSize = true;
            this.lblGestioneUtenteModificaUtenteNome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneUtenteModificaUtenteNome.Location = new System.Drawing.Point(44, 58);
            this.lblGestioneUtenteModificaUtenteNome.Name = "lblGestioneUtenteModificaUtenteNome";
            this.lblGestioneUtenteModificaUtenteNome.Size = new System.Drawing.Size(47, 16);
            this.lblGestioneUtenteModificaUtenteNome.TabIndex = 29;
            this.lblGestioneUtenteModificaUtenteNome.Text = "Nome:";
            // 
            // lblGestioneUtenteModificaUtenteCognome
            // 
            this.lblGestioneUtenteModificaUtenteCognome.AutoSize = true;
            this.lblGestioneUtenteModificaUtenteCognome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneUtenteModificaUtenteCognome.Location = new System.Drawing.Point(25, 88);
            this.lblGestioneUtenteModificaUtenteCognome.Name = "lblGestioneUtenteModificaUtenteCognome";
            this.lblGestioneUtenteModificaUtenteCognome.Size = new System.Drawing.Size(66, 16);
            this.lblGestioneUtenteModificaUtenteCognome.TabIndex = 30;
            this.lblGestioneUtenteModificaUtenteCognome.Text = "Cognome:";
            // 
            // lblGestioneUtenteModificaUtentEmail
            // 
            this.lblGestioneUtenteModificaUtentEmail.AutoSize = true;
            this.lblGestioneUtenteModificaUtentEmail.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneUtenteModificaUtentEmail.Location = new System.Drawing.Point(239, 28);
            this.lblGestioneUtenteModificaUtentEmail.Name = "lblGestioneUtenteModificaUtentEmail";
            this.lblGestioneUtenteModificaUtentEmail.Size = new System.Drawing.Size(44, 16);
            this.lblGestioneUtenteModificaUtentEmail.TabIndex = 31;
            this.lblGestioneUtenteModificaUtentEmail.Text = "Email";
            this.lblGestioneUtenteModificaUtentEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGestioneUtenteModificaNome
            // 
            this.txtGestioneUtenteModificaNome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestioneUtenteModificaNome.Location = new System.Drawing.Point(97, 58);
            this.txtGestioneUtenteModificaNome.Name = "txtGestioneUtenteModificaNome";
            this.txtGestioneUtenteModificaNome.Size = new System.Drawing.Size(108, 23);
            this.txtGestioneUtenteModificaNome.TabIndex = 32;
            // 
            // txtGestioneUtenteModificaCognome
            // 
            this.txtGestioneUtenteModificaCognome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestioneUtenteModificaCognome.Location = new System.Drawing.Point(97, 94);
            this.txtGestioneUtenteModificaCognome.Name = "txtGestioneUtenteModificaCognome";
            this.txtGestioneUtenteModificaCognome.Size = new System.Drawing.Size(108, 23);
            this.txtGestioneUtenteModificaCognome.TabIndex = 33;
            // 
            // txtGestioneUtenteModificaEmail
            // 
            this.txtGestioneUtenteModificaEmail.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestioneUtenteModificaEmail.Location = new System.Drawing.Point(312, 28);
            this.txtGestioneUtenteModificaEmail.Name = "txtGestioneUtenteModificaEmail";
            this.txtGestioneUtenteModificaEmail.Size = new System.Drawing.Size(108, 23);
            this.txtGestioneUtenteModificaEmail.TabIndex = 34;
            // 
            // formListaUtenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvListaUtenti);
            this.Controls.Add(this.lblGestioneUtenteTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formListaUtenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione Utenti";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formListaUtenti_FormClosed);
            this.Load += new System.EventHandler(this.formListaUtenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUtenti)).EndInit();
            this.tabControlGestioneUtente.ResumeLayout(false);
            this.tabControlGestioneUtente.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestioneUtenteTitle;
        private System.Windows.Forms.DataGridView dgvListaUtenti;
        private System.Windows.Forms.TabPage tabControlGestioneUtente;
        private System.Windows.Forms.Button btnGestioneUtenteAnnulla;
        private System.Windows.Forms.Button btnGestioneUtenteEliminaUtente;
        private System.Windows.Forms.TextBox txtGestioneUtenteDeleteId;
        private System.Windows.Forms.Label lblGestioneUtenteEliminaID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtGestioneUtenteModificaEmail;
        private System.Windows.Forms.TextBox txtGestioneUtenteModificaCognome;
        private System.Windows.Forms.TextBox txtGestioneUtenteModificaNome;
        private System.Windows.Forms.Label lblGestioneUtenteModificaUtentEmail;
        private System.Windows.Forms.Label lblGestioneUtenteModificaUtenteCognome;
        private System.Windows.Forms.Label lblGestioneUtenteModificaUtenteNome;
        private System.Windows.Forms.Label lblGestioneUtenteModificaUtenteIDUtente;
        private System.Windows.Forms.Button btnAnnullaUpdateUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.TextBox txtGestioneUtenteModificaIDUtente;
        private System.Windows.Forms.Label lblGestioneUtenteModificaIDUtente;
    }
}