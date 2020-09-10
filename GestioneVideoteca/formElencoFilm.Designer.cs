namespace GestioneVideoteca
{
    partial class formElencoFilm
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
            this.lblElencoFIlmTitle = new System.Windows.Forms.Label();
            this.dgvElencoFilm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElencoFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblElencoFIlmTitle
            // 
            this.lblElencoFIlmTitle.AutoSize = true;
            this.lblElencoFIlmTitle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElencoFIlmTitle.ForeColor = System.Drawing.Color.Black;
            this.lblElencoFIlmTitle.Location = new System.Drawing.Point(210, 9);
            this.lblElencoFIlmTitle.Name = "lblElencoFIlmTitle";
            this.lblElencoFIlmTitle.Size = new System.Drawing.Size(303, 20);
            this.lblElencoFIlmTitle.TabIndex = 19;
            this.lblElencoFIlmTitle.Text = "Questi sono tutti i film che sono presenti";
            // 
            // dgvElencoFilm
            // 
            this.dgvElencoFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElencoFilm.Location = new System.Drawing.Point(12, 44);
            this.dgvElencoFilm.Name = "dgvElencoFilm";
            this.dgvElencoFilm.Size = new System.Drawing.Size(776, 279);
            this.dgvElencoFilm.TabIndex = 20;
            // 
            // formElencoFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 356);
            this.Controls.Add(this.dgvElencoFilm);
            this.Controls.Add(this.lblElencoFIlmTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formElencoFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elcno dei film";
            this.Load += new System.EventHandler(this.formElencoFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElencoFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElencoFIlmTitle;
        private System.Windows.Forms.DataGridView dgvElencoFilm;
    }
}