
namespace Exercitiul7
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeJucator = new System.Windows.Forms.TextBox();
            this.btnAdaugareJucator = new System.Windows.Forms.Button();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.cmbPost = new System.Windows.Forms.ComboBox();
            this.lblCNP = new System.Windows.Forms.Label();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.lblEchipa = new System.Windows.Forms.Label();
            this.cmbEchipe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jucator nou";
            // 
            // txtNumeJucator
            // 
            this.txtNumeJucator.Location = new System.Drawing.Point(190, 170);
            this.txtNumeJucator.Name = "txtNumeJucator";
            this.txtNumeJucator.Size = new System.Drawing.Size(204, 22);
            this.txtNumeJucator.TabIndex = 2;
            // 
            // btnAdaugareJucator
            // 
            this.btnAdaugareJucator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugareJucator.Location = new System.Drawing.Point(138, 340);
            this.btnAdaugareJucator.Name = "btnAdaugareJucator";
            this.btnAdaugareJucator.Size = new System.Drawing.Size(209, 44);
            this.btnAdaugareJucator.TabIndex = 3;
            this.btnAdaugareJucator.Text = "Adaugare";
            this.btnAdaugareJucator.UseVisualStyleBackColor = true;
            this.btnAdaugareJucator.Click += new System.EventHandler(this.btnAdaugareJucator_Click);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(67, 172);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(53, 20);
            this.lblNume.TabIndex = 4;
            this.lblNume.Text = "Nume";
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost.Location = new System.Drawing.Point(67, 219);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(43, 20);
            this.lblPost.TabIndex = 5;
            this.lblPost.Text = "Post";
            // 
            // cmbPost
            // 
            this.cmbPost.FormattingEnabled = true;
            this.cmbPost.Items.AddRange(new object[] {
            "Portar",
            "Fundas",
            "Mijlocas",
            "Atacant"});
            this.cmbPost.Location = new System.Drawing.Point(190, 215);
            this.cmbPost.Name = "cmbPost";
            this.cmbPost.Size = new System.Drawing.Size(204, 24);
            this.cmbPost.TabIndex = 7;
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNP.Location = new System.Drawing.Point(67, 275);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(44, 20);
            this.lblCNP.TabIndex = 8;
            this.lblCNP.Text = "CNP";
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(190, 273);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(204, 22);
            this.txtCNP.TabIndex = 9;
            // 
            // lblEchipa
            // 
            this.lblEchipa.AutoSize = true;
            this.lblEchipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEchipa.Location = new System.Drawing.Point(67, 121);
            this.lblEchipa.Name = "lblEchipa";
            this.lblEchipa.Size = new System.Drawing.Size(60, 20);
            this.lblEchipa.TabIndex = 10;
            this.lblEchipa.Text = "Echipa";
            // 
            // cmbEchipe
            // 
            this.cmbEchipe.FormattingEnabled = true;
            this.cmbEchipe.Location = new System.Drawing.Point(190, 117);
            this.cmbEchipe.Name = "cmbEchipe";
            this.cmbEchipe.Size = new System.Drawing.Size(204, 24);
            this.cmbEchipe.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 428);
            this.Controls.Add(this.cmbEchipe);
            this.Controls.Add(this.lblEchipa);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.lblCNP);
            this.Controls.Add(this.cmbPost);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.btnAdaugareJucator);
            this.Controls.Add(this.txtNumeJucator);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeJucator;
        private System.Windows.Forms.Button btnAdaugareJucator;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.ComboBox cmbPost;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.Label lblEchipa;
        private System.Windows.Forms.ComboBox cmbEchipe;
    }
}