
namespace Spanzuratoarea
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPunctaj = new System.Windows.Forms.TextBox();
            this.btnIesire = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblLitereIncercate = new System.Windows.Forms.Label();
            this.lblCorecte = new System.Windows.Forms.Label();
            this.lblGresite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(66, 94);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(762, 182);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Punctaj";
            // 
            // txtPunctaj
            // 
            this.txtPunctaj.Location = new System.Drawing.Point(166, 383);
            this.txtPunctaj.Name = "txtPunctaj";
            this.txtPunctaj.Size = new System.Drawing.Size(131, 22);
            this.txtPunctaj.TabIndex = 2;
            // 
            // btnIesire
            // 
            this.btnIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIesire.Location = new System.Drawing.Point(686, 366);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(142, 49);
            this.btnIesire.TabIndex = 4;
            this.btnIesire.Text = "IESIRE";
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(453, 366);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(142, 49);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblLitereIncercate
            // 
            this.lblLitereIncercate.AutoSize = true;
            this.lblLitereIncercate.Location = new System.Drawing.Point(450, 320);
            this.lblLitereIncercate.Name = "lblLitereIncercate";
            this.lblLitereIncercate.Size = new System.Drawing.Size(46, 17);
            this.lblLitereIncercate.TabIndex = 6;
            this.lblLitereIncercate.Text = "label2";
            // 
            // lblCorecte
            // 
            this.lblCorecte.AutoSize = true;
            this.lblCorecte.Location = new System.Drawing.Point(163, 423);
            this.lblCorecte.Name = "lblCorecte";
            this.lblCorecte.Size = new System.Drawing.Size(46, 17);
            this.lblCorecte.TabIndex = 7;
            this.lblCorecte.Text = "label2";
            // 
            // lblGresite
            // 
            this.lblGresite.AutoSize = true;
            this.lblGresite.Location = new System.Drawing.Point(163, 451);
            this.lblGresite.Name = "lblGresite";
            this.lblGresite.Size = new System.Drawing.Size(46, 17);
            this.lblGresite.TabIndex = 8;
            this.lblGresite.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 495);
            this.Controls.Add(this.lblGresite);
            this.Controls.Add(this.lblCorecte);
            this.Controls.Add(this.lblLitereIncercate);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.txtPunctaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPunctaj;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblLitereIncercate;
        private System.Windows.Forms.Label lblCorecte;
        private System.Windows.Forms.Label lblGresite;
    }
}

