
namespace Exercitiul7
{
    partial class Form2
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
            this.txtEchipaNoua = new System.Windows.Forms.TextBox();
            this.btnAdaugareEchipa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Echipa noua";
            // 
            // txtEchipaNoua
            // 
            this.txtEchipaNoua.Location = new System.Drawing.Point(63, 117);
            this.txtEchipaNoua.Name = "txtEchipaNoua";
            this.txtEchipaNoua.Size = new System.Drawing.Size(352, 22);
            this.txtEchipaNoua.TabIndex = 1;
            // 
            // btnAdaugareEchipa
            // 
            this.btnAdaugareEchipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugareEchipa.Location = new System.Drawing.Point(129, 233);
            this.btnAdaugareEchipa.Name = "btnAdaugareEchipa";
            this.btnAdaugareEchipa.Size = new System.Drawing.Size(209, 44);
            this.btnAdaugareEchipa.TabIndex = 2;
            this.btnAdaugareEchipa.Text = "Adaugare";
            this.btnAdaugareEchipa.UseVisualStyleBackColor = true;
            this.btnAdaugareEchipa.Click += new System.EventHandler(this.btnAdaugareEchipa_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 350);
            this.Controls.Add(this.btnAdaugareEchipa);
            this.Controls.Add(this.txtEchipaNoua);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEchipaNoua;
        private System.Windows.Forms.Button btnAdaugareEchipa;
    }
}