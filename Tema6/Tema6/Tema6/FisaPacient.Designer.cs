
namespace Tema6
{
    partial class FisaPacient
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
            this.lblPacienti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPacienti
            // 
            this.lblPacienti.AutoSize = true;
            this.lblPacienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacienti.Location = new System.Drawing.Point(391, 54);
            this.lblPacienti.Name = "lblPacienti";
            this.lblPacienti.Size = new System.Drawing.Size(232, 29);
            this.lblPacienti.TabIndex = 1;
            this.lblPacienti.Text = "Vizualizare pacient";
            // 
            // FisaPacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 818);
            this.Controls.Add(this.lblPacienti);
            this.Name = "FisaPacient";
            this.Text = "Fisa Pacient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPacienti;
    }
}