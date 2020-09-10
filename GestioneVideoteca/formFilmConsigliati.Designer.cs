namespace GestioneVideoteca
{
    partial class formFilmConsigliati
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
            this.lblFilmConsigliatiTitle = new System.Windows.Forms.Label();
            this.lblFilmConsigliatiSubtitle = new System.Windows.Forms.Label();
            this.dgvFilmConsigliati = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmConsigliati)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilmConsigliatiTitle
            // 
            this.lblFilmConsigliatiTitle.AutoSize = true;
            this.lblFilmConsigliatiTitle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmConsigliatiTitle.ForeColor = System.Drawing.Color.Black;
            this.lblFilmConsigliatiTitle.Location = new System.Drawing.Point(240, 22);
            this.lblFilmConsigliatiTitle.Name = "lblFilmConsigliatiTitle";
            this.lblFilmConsigliatiTitle.Size = new System.Drawing.Size(90, 20);
            this.lblFilmConsigliatiTitle.TabIndex = 19;
            this.lblFilmConsigliatiTitle.Text = "Benvenuto";
            // 
            // lblFilmConsigliatiSubtitle
            // 
            this.lblFilmConsigliatiSubtitle.AutoSize = true;
            this.lblFilmConsigliatiSubtitle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmConsigliatiSubtitle.ForeColor = System.Drawing.Color.Black;
            this.lblFilmConsigliatiSubtitle.Location = new System.Drawing.Point(166, 59);
            this.lblFilmConsigliatiSubtitle.Name = "lblFilmConsigliatiSubtitle";
            this.lblFilmConsigliatiSubtitle.Size = new System.Drawing.Size(90, 20);
            this.lblFilmConsigliatiSubtitle.TabIndex = 20;
            this.lblFilmConsigliatiSubtitle.Text = "Benvenuto";
            // 
            // dgvFilmConsigliati
            // 
            this.dgvFilmConsigliati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmConsigliati.Location = new System.Drawing.Point(12, 108);
            this.dgvFilmConsigliati.Name = "dgvFilmConsigliati";
            this.dgvFilmConsigliati.Size = new System.Drawing.Size(741, 226);
            this.dgvFilmConsigliati.TabIndex = 21;
            // 
            // formFilmConsigliati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.dgvFilmConsigliati);
            this.Controls.Add(this.lblFilmConsigliatiSubtitle);
            this.Controls.Add(this.lblFilmConsigliatiTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formFilmConsigliati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film consigliati";
            this.Load += new System.EventHandler(this.formFilmConsigliati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmConsigliati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilmConsigliatiTitle;
        private System.Windows.Forms.Label lblFilmConsigliatiSubtitle;
        private System.Windows.Forms.DataGridView dgvFilmConsigliati;
    }
}