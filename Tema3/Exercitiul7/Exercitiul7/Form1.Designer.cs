
namespace Exercitiul7
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
            this.lblEchipa = new System.Windows.Forms.Label();
            this.cmbEchipe = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gpbDetaliiJucator = new System.Windows.Forms.GroupBox();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.lblVarsta = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDataNasterii = new System.Windows.Forms.Label();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.lblCNP = new System.Windows.Forms.Label();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.lblPost = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.btnEchipaNoua = new System.Windows.Forms.Button();
            this.btnJucatorNou = new System.Windows.Forms.Button();
            this.gpbDetaliiJucator.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEchipa
            // 
            this.lblEchipa.AutoSize = true;
            this.lblEchipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEchipa.Location = new System.Drawing.Point(48, 27);
            this.lblEchipa.Name = "lblEchipa";
            this.lblEchipa.Size = new System.Drawing.Size(60, 20);
            this.lblEchipa.TabIndex = 0;
            this.lblEchipa.Text = "Echipa";
            // 
            // cmbEchipe
            // 
            this.cmbEchipe.FormattingEnabled = true;
            this.cmbEchipe.Location = new System.Drawing.Point(114, 27);
            this.cmbEchipe.Name = "cmbEchipe";
            this.cmbEchipe.Size = new System.Drawing.Size(204, 24);
            this.cmbEchipe.TabIndex = 1;
            this.cmbEchipe.SelectedIndexChanged += new System.EventHandler(this.cmbEchipe_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(52, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(335, 324);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // gpbDetaliiJucator
            // 
            this.gpbDetaliiJucator.Controls.Add(this.txtVarsta);
            this.gpbDetaliiJucator.Controls.Add(this.lblVarsta);
            this.gpbDetaliiJucator.Controls.Add(this.dateTimePicker1);
            this.gpbDetaliiJucator.Controls.Add(this.lblDataNasterii);
            this.gpbDetaliiJucator.Controls.Add(this.txtCNP);
            this.gpbDetaliiJucator.Controls.Add(this.lblCNP);
            this.gpbDetaliiJucator.Controls.Add(this.txtPost);
            this.gpbDetaliiJucator.Controls.Add(this.lblPost);
            this.gpbDetaliiJucator.Controls.Add(this.txtNume);
            this.gpbDetaliiJucator.Controls.Add(this.lblNume);
            this.gpbDetaliiJucator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDetaliiJucator.Location = new System.Drawing.Point(417, 80);
            this.gpbDetaliiJucator.Name = "gpbDetaliiJucator";
            this.gpbDetaliiJucator.Size = new System.Drawing.Size(454, 324);
            this.gpbDetaliiJucator.TabIndex = 3;
            this.gpbDetaliiJucator.TabStop = false;
            this.gpbDetaliiJucator.Text = "Detalii jucator";
            // 
            // txtVarsta
            // 
            this.txtVarsta.Location = new System.Drawing.Point(164, 252);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(65, 27);
            this.txtVarsta.TabIndex = 9;
            // 
            // lblVarsta
            // 
            this.lblVarsta.AutoSize = true;
            this.lblVarsta.Location = new System.Drawing.Point(70, 252);
            this.lblVarsta.Name = "lblVarsta";
            this.lblVarsta.Size = new System.Drawing.Size(58, 20);
            this.lblVarsta.TabIndex = 8;
            this.lblVarsta.Text = "Varsta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 201);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 27);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDataNasterii
            // 
            this.lblDataNasterii.AutoSize = true;
            this.lblDataNasterii.Location = new System.Drawing.Point(9, 208);
            this.lblDataNasterii.Name = "lblDataNasterii";
            this.lblDataNasterii.Size = new System.Drawing.Size(105, 20);
            this.lblDataNasterii.TabIndex = 6;
            this.lblDataNasterii.Text = "Data nasterii";
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(164, 149);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(253, 27);
            this.txtCNP.TabIndex = 5;
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Location = new System.Drawing.Point(70, 149);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(44, 20);
            this.lblCNP.TabIndex = 4;
            this.lblCNP.Text = "CNP";
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(164, 94);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(253, 27);
            this.txtPost.TabIndex = 3;
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(70, 94);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(43, 20);
            this.lblPost.TabIndex = 2;
            this.lblPost.Text = "Post";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(164, 40);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(253, 27);
            this.txtNume.TabIndex = 1;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(70, 40);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(53, 20);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // btnEchipaNoua
            // 
            this.btnEchipaNoua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEchipaNoua.Location = new System.Drawing.Point(324, 23);
            this.btnEchipaNoua.Name = "btnEchipaNoua";
            this.btnEchipaNoua.Size = new System.Drawing.Size(148, 29);
            this.btnEchipaNoua.TabIndex = 4;
            this.btnEchipaNoua.Text = "Echipa Noua";
            this.btnEchipaNoua.UseVisualStyleBackColor = true;
            this.btnEchipaNoua.Click += new System.EventHandler(this.btnEchipaNoua_Click);
            // 
            // btnJucatorNou
            // 
            this.btnJucatorNou.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJucatorNou.Location = new System.Drawing.Point(324, 441);
            this.btnJucatorNou.Name = "btnJucatorNou";
            this.btnJucatorNou.Size = new System.Drawing.Size(148, 29);
            this.btnJucatorNou.TabIndex = 5;
            this.btnJucatorNou.Text = "Jucator nou";
            this.btnJucatorNou.UseVisualStyleBackColor = true;
            this.btnJucatorNou.Click += new System.EventHandler(this.btnJucatorNou_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 513);
            this.Controls.Add(this.btnJucatorNou);
            this.Controls.Add(this.btnEchipaNoua);
            this.Controls.Add(this.gpbDetaliiJucator);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cmbEchipe);
            this.Controls.Add(this.lblEchipa);
            this.Name = "Form1";
            this.Text = "LPF";
            this.gpbDetaliiJucator.ResumeLayout(false);
            this.gpbDetaliiJucator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEchipa;
        private System.Windows.Forms.ComboBox cmbEchipe;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox gpbDetaliiJucator;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDataNasterii;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.Label lblVarsta;
        private System.Windows.Forms.Button btnEchipaNoua;
        private System.Windows.Forms.Button btnJucatorNou;
    }
}

