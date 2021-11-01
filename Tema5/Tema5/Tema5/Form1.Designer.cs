
namespace Tema5
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
            this.lblNume = new System.Windows.Forms.Label();
            this.lblCNP = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.cmbTest = new System.Windows.Forms.ComboBox();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(189, 62);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(62, 24);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Nume";
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNP.Location = new System.Drawing.Point(189, 121);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(49, 24);
            this.lblCNP.TabIndex = 2;
            this.lblCNP.Text = "CNP";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(189, 193);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(46, 24);
            this.lblTest.TabIndex = 3;
            this.lblTest.Text = "Test";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(327, 64);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(347, 22);
            this.txtNume.TabIndex = 4;
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(327, 123);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(347, 22);
            this.txtCNP.TabIndex = 5;
            this.txtCNP.Leave += new System.EventHandler(this.txtCNP_Leave);
            // 
            // cmbTest
            // 
            this.cmbTest.FormattingEnabled = true;
            this.cmbTest.Location = new System.Drawing.Point(327, 193);
            this.cmbTest.Name = "cmbTest";
            this.cmbTest.Size = new System.Drawing.Size(183, 24);
            this.cmbTest.TabIndex = 6;
            // 
            // btnStartTest
            // 
            this.btnStartTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTest.Location = new System.Drawing.Point(367, 269);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(143, 39);
            this.btnStartTest.TabIndex = 7;
            this.btnStartTest.Text = "Incepe testul";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 330);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.cmbTest);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblCNP);
            this.Controls.Add(this.lblNume);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.ComboBox cmbTest;
        private System.Windows.Forms.Button btnStartTest;
    }
}

