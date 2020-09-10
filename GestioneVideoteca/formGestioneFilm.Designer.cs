namespace GestioneVideoteca
{
    partial class formGestioneFilm
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
            this.lblGestioneFilmTitle = new System.Windows.Forms.Label();
            this.lblGestioneFilmElencoFilm = new System.Windows.Forms.Label();
            this.cmbGestioneFilmElencoFilm = new System.Windows.Forms.ComboBox();
            this.lblGestioneFilmChoose = new System.Windows.Forms.Label();
            this.chkGestioneFilmDelete = new System.Windows.Forms.CheckBox();
            this.chkGestioneFilmUpdate = new System.Windows.Forms.CheckBox();
            this.chkGestioneFilmCreate = new System.Windows.Forms.CheckBox();
            this.lblGestioneFilmNewFilm = new System.Windows.Forms.Label();
            this.txtGestioneFilmNuovoFilm = new System.Windows.Forms.TextBox();
            this.lblGestioneFilmUpdateFilm = new System.Windows.Forms.Label();
            this.txtGestioneFilmModificaFilm = new System.Windows.Forms.TextBox();
            this.btnGestioneFilm = new System.Windows.Forms.Button();
            this.btnGestioneFilmAnnulla = new System.Windows.Forms.Button();
            this.lblGestioneFilmElencoGenere = new System.Windows.Forms.Label();
            this.cmbGestioneFilmElencoGenere = new System.Windows.Forms.ComboBox();
            this.lblGestioneFilmDataUscita = new System.Windows.Forms.Label();
            this.dtpDataUscita = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblGestioneFilmTitle
            // 
            this.lblGestioneFilmTitle.AutoSize = true;
            this.lblGestioneFilmTitle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneFilmTitle.ForeColor = System.Drawing.Color.Black;
            this.lblGestioneFilmTitle.Location = new System.Drawing.Point(12, 22);
            this.lblGestioneFilmTitle.Name = "lblGestioneFilmTitle";
            this.lblGestioneFilmTitle.Size = new System.Drawing.Size(252, 20);
            this.lblGestioneFilmTitle.TabIndex = 21;
            this.lblGestioneFilmTitle.Text = "Questa è l\'are di modifica dei film";
            // 
            // lblGestioneFilmElencoFilm
            // 
            this.lblGestioneFilmElencoFilm.AutoSize = true;
            this.lblGestioneFilmElencoFilm.Location = new System.Drawing.Point(13, 78);
            this.lblGestioneFilmElencoFilm.Name = "lblGestioneFilmElencoFilm";
            this.lblGestioneFilmElencoFilm.Size = new System.Drawing.Size(78, 13);
            this.lblGestioneFilmElencoFilm.TabIndex = 23;
            this.lblGestioneFilmElencoFilm.Text = "Elenco dei Film";
            // 
            // cmbGestioneFilmElencoFilm
            // 
            this.cmbGestioneFilmElencoFilm.FormattingEnabled = true;
            this.cmbGestioneFilmElencoFilm.Location = new System.Drawing.Point(115, 75);
            this.cmbGestioneFilmElencoFilm.Name = "cmbGestioneFilmElencoFilm";
            this.cmbGestioneFilmElencoFilm.Size = new System.Drawing.Size(240, 21);
            this.cmbGestioneFilmElencoFilm.TabIndex = 28;
            this.cmbGestioneFilmElencoFilm.SelectedIndexChanged += new System.EventHandler(this.cmbGestioneFilmElencoFilm_SelectedIndexChanged);
            // 
            // lblGestioneFilmChoose
            // 
            this.lblGestioneFilmChoose.AutoSize = true;
            this.lblGestioneFilmChoose.Location = new System.Drawing.Point(13, 114);
            this.lblGestioneFilmChoose.Name = "lblGestioneFilmChoose";
            this.lblGestioneFilmChoose.Size = new System.Drawing.Size(36, 13);
            this.lblGestioneFilmChoose.TabIndex = 29;
            this.lblGestioneFilmChoose.Text = "Scegli";
            // 
            // chkGestioneFilmDelete
            // 
            this.chkGestioneFilmDelete.AutoSize = true;
            this.chkGestioneFilmDelete.Location = new System.Drawing.Point(69, 113);
            this.chkGestioneFilmDelete.Name = "chkGestioneFilmDelete";
            this.chkGestioneFilmDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkGestioneFilmDelete.Size = new System.Drawing.Size(59, 17);
            this.chkGestioneFilmDelete.TabIndex = 30;
            this.chkGestioneFilmDelete.Text = "Elimina";
            this.chkGestioneFilmDelete.UseVisualStyleBackColor = true;
            this.chkGestioneFilmDelete.CheckedChanged += new System.EventHandler(this.chkGestioneFilmDelete_CheckedChanged);
            // 
            // chkGestioneFilmUpdate
            // 
            this.chkGestioneFilmUpdate.AutoSize = true;
            this.chkGestioneFilmUpdate.Location = new System.Drawing.Point(153, 113);
            this.chkGestioneFilmUpdate.Name = "chkGestioneFilmUpdate";
            this.chkGestioneFilmUpdate.Size = new System.Drawing.Size(66, 17);
            this.chkGestioneFilmUpdate.TabIndex = 31;
            this.chkGestioneFilmUpdate.Text = "Modifica";
            this.chkGestioneFilmUpdate.UseVisualStyleBackColor = true;
            this.chkGestioneFilmUpdate.CheckedChanged += new System.EventHandler(this.chkGestioneFilmUpdate_CheckedChanged);
            // 
            // chkGestioneFilmCreate
            // 
            this.chkGestioneFilmCreate.AutoSize = true;
            this.chkGestioneFilmCreate.Location = new System.Drawing.Point(241, 114);
            this.chkGestioneFilmCreate.Name = "chkGestioneFilmCreate";
            this.chkGestioneFilmCreate.Size = new System.Drawing.Size(114, 17);
            this.chkGestioneFilmCreate.TabIndex = 34;
            this.chkGestioneFilmCreate.Text = "Crea un nuovo film";
            this.chkGestioneFilmCreate.UseVisualStyleBackColor = true;
            this.chkGestioneFilmCreate.CheckedChanged += new System.EventHandler(this.chkGestioneFilmCreate_CheckedChanged);
            // 
            // lblGestioneFilmNewFilm
            // 
            this.lblGestioneFilmNewFilm.AutoSize = true;
            this.lblGestioneFilmNewFilm.Location = new System.Drawing.Point(13, 273);
            this.lblGestioneFilmNewFilm.Name = "lblGestioneFilmNewFilm";
            this.lblGestioneFilmNewFilm.Size = new System.Drawing.Size(106, 13);
            this.lblGestioneFilmNewFilm.TabIndex = 35;
            this.lblGestioneFilmNewFilm.Text = "Nome del nuovo film:";
            // 
            // txtGestioneFilmNuovoFilm
            // 
            this.txtGestioneFilmNuovoFilm.Location = new System.Drawing.Point(153, 270);
            this.txtGestioneFilmNuovoFilm.Name = "txtGestioneFilmNuovoFilm";
            this.txtGestioneFilmNuovoFilm.Size = new System.Drawing.Size(212, 20);
            this.txtGestioneFilmNuovoFilm.TabIndex = 36;
            // 
            // lblGestioneFilmUpdateFilm
            // 
            this.lblGestioneFilmUpdateFilm.AutoSize = true;
            this.lblGestioneFilmUpdateFilm.Location = new System.Drawing.Point(13, 326);
            this.lblGestioneFilmUpdateFilm.Name = "lblGestioneFilmUpdateFilm";
            this.lblGestioneFilmUpdateFilm.Size = new System.Drawing.Size(198, 13);
            this.lblGestioneFilmUpdateFilm.TabIndex = 37;
            this.lblGestioneFilmUpdateFilm.Text = "Nome nuovo del film che vuoi modificare";
            // 
            // txtGestioneFilmModificaFilm
            // 
            this.txtGestioneFilmModificaFilm.Location = new System.Drawing.Point(143, 349);
            this.txtGestioneFilmModificaFilm.Name = "txtGestioneFilmModificaFilm";
            this.txtGestioneFilmModificaFilm.Size = new System.Drawing.Size(212, 20);
            this.txtGestioneFilmModificaFilm.TabIndex = 38;
            // 
            // btnGestioneFilm
            // 
            this.btnGestioneFilm.Location = new System.Drawing.Point(16, 386);
            this.btnGestioneFilm.Name = "btnGestioneFilm";
            this.btnGestioneFilm.Size = new System.Drawing.Size(75, 23);
            this.btnGestioneFilm.TabIndex = 39;
            this.btnGestioneFilm.Text = "Salva";
            this.btnGestioneFilm.UseVisualStyleBackColor = true;
            this.btnGestioneFilm.Click += new System.EventHandler(this.btnGestioneFilm_Click);
            // 
            // btnGestioneFilmAnnulla
            // 
            this.btnGestioneFilmAnnulla.Location = new System.Drawing.Point(280, 386);
            this.btnGestioneFilmAnnulla.Name = "btnGestioneFilmAnnulla";
            this.btnGestioneFilmAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnGestioneFilmAnnulla.TabIndex = 40;
            this.btnGestioneFilmAnnulla.Text = "Annulla";
            this.btnGestioneFilmAnnulla.UseVisualStyleBackColor = true;
            this.btnGestioneFilmAnnulla.Click += new System.EventHandler(this.btnGestioneFilmAnnulla_Click);
            // 
            // lblGestioneFilmElencoGenere
            // 
            this.lblGestioneFilmElencoGenere.AutoSize = true;
            this.lblGestioneFilmElencoGenere.Location = new System.Drawing.Point(13, 149);
            this.lblGestioneFilmElencoGenere.Name = "lblGestioneFilmElencoGenere";
            this.lblGestioneFilmElencoGenere.Size = new System.Drawing.Size(89, 13);
            this.lblGestioneFilmElencoGenere.TabIndex = 41;
            this.lblGestioneFilmElencoGenere.Text = "Elenco dei generi";
            // 
            // cmbGestioneFilmElencoGenere
            // 
            this.cmbGestioneFilmElencoGenere.FormattingEnabled = true;
            this.cmbGestioneFilmElencoGenere.Location = new System.Drawing.Point(115, 149);
            this.cmbGestioneFilmElencoGenere.Name = "cmbGestioneFilmElencoGenere";
            this.cmbGestioneFilmElencoGenere.Size = new System.Drawing.Size(240, 21);
            this.cmbGestioneFilmElencoGenere.TabIndex = 42;
            this.cmbGestioneFilmElencoGenere.SelectedIndexChanged += new System.EventHandler(this.cmbGestioneFilmElencoGenere_SelectedIndexChanged);
            // 
            // lblGestioneFilmDataUscita
            // 
            this.lblGestioneFilmDataUscita.AutoSize = true;
            this.lblGestioneFilmDataUscita.Location = new System.Drawing.Point(13, 202);
            this.lblGestioneFilmDataUscita.Name = "lblGestioneFilmDataUscita";
            this.lblGestioneFilmDataUscita.Size = new System.Drawing.Size(75, 13);
            this.lblGestioneFilmDataUscita.TabIndex = 43;
            this.lblGestioneFilmDataUscita.Text = "Data di uscita:";
            // 
            // dtpDataUscita
            // 
            this.dtpDataUscita.Location = new System.Drawing.Point(115, 202);
            this.dtpDataUscita.Name = "dtpDataUscita";
            this.dtpDataUscita.Size = new System.Drawing.Size(240, 20);
            this.dtpDataUscita.TabIndex = 44;
            // 
            // formGestioneFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 433);
            this.Controls.Add(this.dtpDataUscita);
            this.Controls.Add(this.lblGestioneFilmDataUscita);
            this.Controls.Add(this.cmbGestioneFilmElencoGenere);
            this.Controls.Add(this.lblGestioneFilmElencoGenere);
            this.Controls.Add(this.btnGestioneFilmAnnulla);
            this.Controls.Add(this.btnGestioneFilm);
            this.Controls.Add(this.txtGestioneFilmModificaFilm);
            this.Controls.Add(this.lblGestioneFilmUpdateFilm);
            this.Controls.Add(this.txtGestioneFilmNuovoFilm);
            this.Controls.Add(this.lblGestioneFilmNewFilm);
            this.Controls.Add(this.chkGestioneFilmCreate);
            this.Controls.Add(this.chkGestioneFilmUpdate);
            this.Controls.Add(this.chkGestioneFilmDelete);
            this.Controls.Add(this.lblGestioneFilmChoose);
            this.Controls.Add(this.cmbGestioneFilmElencoFilm);
            this.Controls.Add(this.lblGestioneFilmElencoFilm);
            this.Controls.Add(this.lblGestioneFilmTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formGestioneFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione Film";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formGestioneFilm_FormClosed);
            this.Load += new System.EventHandler(this.formGestioneFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestioneFilmTitle;
        private System.Windows.Forms.Label lblGestioneFilmElencoFilm;
        private System.Windows.Forms.ComboBox cmbGestioneFilmElencoFilm;
        private System.Windows.Forms.Label lblGestioneFilmChoose;
        private System.Windows.Forms.CheckBox chkGestioneFilmDelete;
        private System.Windows.Forms.CheckBox chkGestioneFilmUpdate;
        private System.Windows.Forms.CheckBox chkGestioneFilmCreate;
        private System.Windows.Forms.Label lblGestioneFilmNewFilm;
        private System.Windows.Forms.TextBox txtGestioneFilmNuovoFilm;
        private System.Windows.Forms.Label lblGestioneFilmUpdateFilm;
        private System.Windows.Forms.TextBox txtGestioneFilmModificaFilm;
        private System.Windows.Forms.Button btnGestioneFilm;
        private System.Windows.Forms.Button btnGestioneFilmAnnulla;
        private System.Windows.Forms.Label lblGestioneFilmElencoGenere;
        private System.Windows.Forms.ComboBox cmbGestioneFilmElencoGenere;
        private System.Windows.Forms.Label lblGestioneFilmDataUscita;
        private System.Windows.Forms.DateTimePicker dtpDataUscita;
    }
}