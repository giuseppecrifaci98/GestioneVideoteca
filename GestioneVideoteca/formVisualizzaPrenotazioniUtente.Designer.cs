namespace GestioneVideoteca
{
    partial class formVisualizzaPrenotazioniUtente
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
            this.lblVisualizzaPrenotazioniUtenteTitle = new System.Windows.Forms.Label();
            this.dgvMostraPrenotazioni = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraPrenotazioni)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVisualizzaPrenotazioniUtenteTitle
            // 
            this.lblVisualizzaPrenotazioniUtenteTitle.AutoSize = true;
            this.lblVisualizzaPrenotazioniUtenteTitle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizzaPrenotazioniUtenteTitle.ForeColor = System.Drawing.Color.Black;
            this.lblVisualizzaPrenotazioniUtenteTitle.Location = new System.Drawing.Point(206, 18);
            this.lblVisualizzaPrenotazioniUtenteTitle.Name = "lblVisualizzaPrenotazioniUtenteTitle";
            this.lblVisualizzaPrenotazioniUtenteTitle.Size = new System.Drawing.Size(305, 20);
            this.lblVisualizzaPrenotazioniUtenteTitle.TabIndex = 20;
            this.lblVisualizzaPrenotazioniUtenteTitle.Text = "Questi sono tutti i film che hai prenotato";
            // 
            // dgvMostraPrenotazioni
            // 
            this.dgvMostraPrenotazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostraPrenotazioni.Location = new System.Drawing.Point(24, 72);
            this.dgvMostraPrenotazioni.Name = "dgvMostraPrenotazioni";
            this.dgvMostraPrenotazioni.Size = new System.Drawing.Size(764, 310);
            this.dgvMostraPrenotazioni.TabIndex = 21;
            // 
            // formVisualizzaPrenotazioniUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.dgvMostraPrenotazioni);
            this.Controls.Add(this.lblVisualizzaPrenotazioniUtenteTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formVisualizzaPrenotazioniUtente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formVisualizzaPrenotazioniUtente";
            this.Load += new System.EventHandler(this.formVisualizzaPrenotazioniUtente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraPrenotazioni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisualizzaPrenotazioniUtenteTitle;
        private System.Windows.Forms.DataGridView dgvMostraPrenotazioni;
    }
}