namespace GestioneVideoteca
{
    partial class formGestioneGenere
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
            this.lblGestioneGenereTitle = new System.Windows.Forms.Label();
            this.lblGestioneGenereElencoGeneri = new System.Windows.Forms.Label();
            this.cmbGestioneGenereElencoGeneri = new System.Windows.Forms.ComboBox();
            this.lblGestioneGenereChoose = new System.Windows.Forms.Label();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            this.lblGestioneGenereNewGenere = new System.Windows.Forms.Label();
            this.txtGestioneGenereNuovoGenere = new System.Windows.Forms.TextBox();
            this.chkCreate = new System.Windows.Forms.CheckBox();
            this.txtGestioneGenereModificaGenere = new System.Windows.Forms.TextBox();
            this.lblGestioneGenereUpdateGenere = new System.Windows.Forms.Label();
            this.btnGestioneGenere = new System.Windows.Forms.Button();
            this.btnGestioneGenereAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGestioneGenereTitle
            // 
            this.lblGestioneGenereTitle.AutoSize = true;
            this.lblGestioneGenereTitle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneGenereTitle.ForeColor = System.Drawing.Color.Black;
            this.lblGestioneGenereTitle.Location = new System.Drawing.Point(20, 9);
            this.lblGestioneGenereTitle.Name = "lblGestioneGenereTitle";
            this.lblGestioneGenereTitle.Size = new System.Drawing.Size(380, 20);
            this.lblGestioneGenereTitle.TabIndex = 20;
            this.lblGestioneGenereTitle.Text = "Questi sono tutti i generi dei film che sono presenti";
            // 
            // lblGestioneGenereElencoGeneri
            // 
            this.lblGestioneGenereElencoGeneri.AutoSize = true;
            this.lblGestioneGenereElencoGeneri.Location = new System.Drawing.Point(12, 65);
            this.lblGestioneGenereElencoGeneri.Name = "lblGestioneGenereElencoGeneri";
            this.lblGestioneGenereElencoGeneri.Size = new System.Drawing.Size(92, 13);
            this.lblGestioneGenereElencoGeneri.TabIndex = 22;
            this.lblGestioneGenereElencoGeneri.Text = "Elenco dei generi:";
            // 
            // cmbGestioneGenereElencoGeneri
            // 
            this.cmbGestioneGenereElencoGeneri.FormattingEnabled = true;
            this.cmbGestioneGenereElencoGeneri.Location = new System.Drawing.Point(129, 65);
            this.cmbGestioneGenereElencoGeneri.Name = "cmbGestioneGenereElencoGeneri";
            this.cmbGestioneGenereElencoGeneri.Size = new System.Drawing.Size(240, 21);
            this.cmbGestioneGenereElencoGeneri.TabIndex = 27;
            this.cmbGestioneGenereElencoGeneri.SelectedIndexChanged += new System.EventHandler(this.cmbGestioneGenereElencoGeneri_SelectedIndexChanged);
            // 
            // lblGestioneGenereChoose
            // 
            this.lblGestioneGenereChoose.AutoSize = true;
            this.lblGestioneGenereChoose.Location = new System.Drawing.Point(12, 114);
            this.lblGestioneGenereChoose.Name = "lblGestioneGenereChoose";
            this.lblGestioneGenereChoose.Size = new System.Drawing.Size(36, 13);
            this.lblGestioneGenereChoose.TabIndex = 28;
            this.lblGestioneGenereChoose.Text = "Scegli";
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(93, 114);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkDelete.Size = new System.Drawing.Size(59, 17);
            this.chkDelete.TabIndex = 29;
            this.chkDelete.Text = "Elimina";
            this.chkDelete.UseVisualStyleBackColor = true;
            this.chkDelete.CheckedChanged += new System.EventHandler(this.chkDelete_CheckedChanged);
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.Location = new System.Drawing.Point(190, 110);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.Size = new System.Drawing.Size(66, 17);
            this.chkUpdate.TabIndex = 30;
            this.chkUpdate.Text = "Modifica";
            this.chkUpdate.UseVisualStyleBackColor = true;
            this.chkUpdate.CheckedChanged += new System.EventHandler(this.chkUpdate_CheckedChanged);
            // 
            // lblGestioneGenereNewGenere
            // 
            this.lblGestioneGenereNewGenere.AutoSize = true;
            this.lblGestioneGenereNewGenere.Location = new System.Drawing.Point(12, 172);
            this.lblGestioneGenereNewGenere.Name = "lblGestioneGenereNewGenere";
            this.lblGestioneGenereNewGenere.Size = new System.Drawing.Size(115, 13);
            this.lblGestioneGenereNewGenere.TabIndex = 31;
            this.lblGestioneGenereNewGenere.Text = "Nome del nuvo genere";
            // 
            // txtGestioneGenereNuovoGenere
            // 
            this.txtGestioneGenereNuovoGenere.Location = new System.Drawing.Point(157, 169);
            this.txtGestioneGenereNuovoGenere.Name = "txtGestioneGenereNuovoGenere";
            this.txtGestioneGenereNuovoGenere.Size = new System.Drawing.Size(212, 20);
            this.txtGestioneGenereNuovoGenere.TabIndex = 32;
            // 
            // chkCreate
            // 
            this.chkCreate.AutoSize = true;
            this.chkCreate.Location = new System.Drawing.Point(294, 110);
            this.chkCreate.Name = "chkCreate";
            this.chkCreate.Size = new System.Drawing.Size(117, 17);
            this.chkCreate.TabIndex = 33;
            this.chkCreate.Text = "Crea nuovo genere";
            this.chkCreate.UseVisualStyleBackColor = true;
            this.chkCreate.CheckedChanged += new System.EventHandler(this.chkCreate_CheckedChanged);
            // 
            // txtGestioneGenereModificaGenere
            // 
            this.txtGestioneGenereModificaGenere.Location = new System.Drawing.Point(157, 246);
            this.txtGestioneGenereModificaGenere.Name = "txtGestioneGenereModificaGenere";
            this.txtGestioneGenereModificaGenere.Size = new System.Drawing.Size(212, 20);
            this.txtGestioneGenereModificaGenere.TabIndex = 34;
            // 
            // lblGestioneGenereUpdateGenere
            // 
            this.lblGestioneGenereUpdateGenere.AutoSize = true;
            this.lblGestioneGenereUpdateGenere.Location = new System.Drawing.Point(21, 221);
            this.lblGestioneGenereUpdateGenere.Name = "lblGestioneGenereUpdateGenere";
            this.lblGestioneGenereUpdateGenere.Size = new System.Drawing.Size(216, 13);
            this.lblGestioneGenereUpdateGenere.TabIndex = 35;
            this.lblGestioneGenereUpdateGenere.Text = "Nome nuovo del genere che vuoi modificare";
            // 
            // btnGestioneGenere
            // 
            this.btnGestioneGenere.Location = new System.Drawing.Point(15, 288);
            this.btnGestioneGenere.Name = "btnGestioneGenere";
            this.btnGestioneGenere.Size = new System.Drawing.Size(75, 23);
            this.btnGestioneGenere.TabIndex = 36;
            this.btnGestioneGenere.Text = "Salva";
            this.btnGestioneGenere.UseVisualStyleBackColor = true;
            this.btnGestioneGenere.Click += new System.EventHandler(this.btnGestioneGenere_Click);
            // 
            // btnGestioneGenereAnnulla
            // 
            this.btnGestioneGenereAnnulla.Location = new System.Drawing.Point(304, 288);
            this.btnGestioneGenereAnnulla.Name = "btnGestioneGenereAnnulla";
            this.btnGestioneGenereAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnGestioneGenereAnnulla.TabIndex = 37;
            this.btnGestioneGenereAnnulla.Text = "Annulla";
            this.btnGestioneGenereAnnulla.UseVisualStyleBackColor = true;
            this.btnGestioneGenereAnnulla.Click += new System.EventHandler(this.btnGestioneGenereAnnulla_Click);
            // 
            // formGestioneGenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 337);
            this.Controls.Add(this.btnGestioneGenereAnnulla);
            this.Controls.Add(this.btnGestioneGenere);
            this.Controls.Add(this.lblGestioneGenereUpdateGenere);
            this.Controls.Add(this.txtGestioneGenereModificaGenere);
            this.Controls.Add(this.chkCreate);
            this.Controls.Add(this.txtGestioneGenereNuovoGenere);
            this.Controls.Add(this.lblGestioneGenereNewGenere);
            this.Controls.Add(this.chkUpdate);
            this.Controls.Add(this.chkDelete);
            this.Controls.Add(this.lblGestioneGenereChoose);
            this.Controls.Add(this.cmbGestioneGenereElencoGeneri);
            this.Controls.Add(this.lblGestioneGenereElencoGeneri);
            this.Controls.Add(this.lblGestioneGenereTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formGestioneGenere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area gestione genere";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formGestioneGenere_FormClosed);
            this.Load += new System.EventHandler(this.formGestioneGenere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestioneGenereTitle;
        private System.Windows.Forms.Label lblGestioneGenereElencoGeneri;
        private System.Windows.Forms.ComboBox cmbGestioneGenereElencoGeneri;
        private System.Windows.Forms.Label lblGestioneGenereChoose;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkUpdate;
        private System.Windows.Forms.Label lblGestioneGenereNewGenere;
        private System.Windows.Forms.TextBox txtGestioneGenereNuovoGenere;
        private System.Windows.Forms.CheckBox chkCreate;
        private System.Windows.Forms.TextBox txtGestioneGenereModificaGenere;
        private System.Windows.Forms.Label lblGestioneGenereUpdateGenere;
        private System.Windows.Forms.Button btnGestioneGenere;
        private System.Windows.Forms.Button btnGestioneGenereAnnulla;
    }
}