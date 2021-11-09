
namespace Tema6
{
    partial class Pacient
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
            this.lblNumeCautat = new System.Windows.Forms.Label();
            this.txtNumeCautat = new System.Windows.Forms.TextBox();
            this.btnCautareNume = new System.Windows.Forms.Button();
            this.dgvBazaDate = new System.Windows.Forms.DataGridView();
            this.btnAdaugaConsultatie = new System.Windows.Forms.Button();
            this.btnVizualizareFisaPacient = new System.Windows.Forms.Button();
            this.btnAdgRadiografii = new System.Windows.Forms.Button();
            this.btnInchidereAplicatie = new System.Windows.Forms.Button();
            this.btnAdaugaPacient = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBazaDate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPacienti
            // 
            this.lblPacienti.AutoSize = true;
            this.lblPacienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacienti.Location = new System.Drawing.Point(425, 33);
            this.lblPacienti.Name = "lblPacienti";
            this.lblPacienti.Size = new System.Drawing.Size(107, 29);
            this.lblPacienti.TabIndex = 0;
            this.lblPacienti.Text = "Pacienti";
            // 
            // lblNumeCautat
            // 
            this.lblNumeCautat.AutoSize = true;
            this.lblNumeCautat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeCautat.Location = new System.Drawing.Point(55, 107);
            this.lblNumeCautat.Name = "lblNumeCautat";
            this.lblNumeCautat.Size = new System.Drawing.Size(197, 20);
            this.lblNumeCautat.TabIndex = 1;
            this.lblNumeCautat.Text = "Introduceti numele cautat";
            // 
            // txtNumeCautat
            // 
            this.txtNumeCautat.Location = new System.Drawing.Point(324, 105);
            this.txtNumeCautat.Name = "txtNumeCautat";
            this.txtNumeCautat.Size = new System.Drawing.Size(337, 22);
            this.txtNumeCautat.TabIndex = 2;
            // 
            // btnCautareNume
            // 
            this.btnCautareNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautareNume.Location = new System.Drawing.Point(749, 92);
            this.btnCautareNume.Name = "btnCautareNume";
            this.btnCautareNume.Size = new System.Drawing.Size(137, 45);
            this.btnCautareNume.TabIndex = 3;
            this.btnCautareNume.Text = "Cauta";
            this.btnCautareNume.UseVisualStyleBackColor = true;
            this.btnCautareNume.Click += new System.EventHandler(this.btnCautareNume_Click);
            // 
            // dgvBazaDate
            // 
            this.dgvBazaDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBazaDate.Location = new System.Drawing.Point(59, 188);
            this.dgvBazaDate.Name = "dgvBazaDate";
            this.dgvBazaDate.RowHeadersWidth = 51;
            this.dgvBazaDate.RowTemplate.Height = 24;
            this.dgvBazaDate.Size = new System.Drawing.Size(827, 319);
            this.dgvBazaDate.TabIndex = 4;
            this.dgvBazaDate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBazaDate_CellContentClick);
            // 
            // btnAdaugaConsultatie
            // 
            this.btnAdaugaConsultatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaConsultatie.Location = new System.Drawing.Point(294, 567);
            this.btnAdaugaConsultatie.Name = "btnAdaugaConsultatie";
            this.btnAdaugaConsultatie.Size = new System.Drawing.Size(193, 66);
            this.btnAdaugaConsultatie.TabIndex = 5;
            this.btnAdaugaConsultatie.Text = "Adauga consultatie";
            this.btnAdaugaConsultatie.UseVisualStyleBackColor = true;
            this.btnAdaugaConsultatie.Click += new System.EventHandler(this.btnAdaugaConsultatie_Click);
            // 
            // btnVizualizareFisaPacient
            // 
            this.btnVizualizareFisaPacient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVizualizareFisaPacient.Location = new System.Drawing.Point(749, 567);
            this.btnVizualizareFisaPacient.Name = "btnVizualizareFisaPacient";
            this.btnVizualizareFisaPacient.Size = new System.Drawing.Size(193, 66);
            this.btnVizualizareFisaPacient.TabIndex = 6;
            this.btnVizualizareFisaPacient.Text = "Vizualizare fisa pacient";
            this.btnVizualizareFisaPacient.UseVisualStyleBackColor = true;
            this.btnVizualizareFisaPacient.Click += new System.EventHandler(this.btnVizualizareFisaPacient_Click);
            // 
            // btnAdgRadiografii
            // 
            this.btnAdgRadiografii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdgRadiografii.Location = new System.Drawing.Point(527, 567);
            this.btnAdgRadiografii.Name = "btnAdgRadiografii";
            this.btnAdgRadiografii.Size = new System.Drawing.Size(193, 66);
            this.btnAdgRadiografii.TabIndex = 7;
            this.btnAdgRadiografii.Text = "Adauga radiografii";
            this.btnAdgRadiografii.UseVisualStyleBackColor = true;
            this.btnAdgRadiografii.Click += new System.EventHandler(this.btnAdgRadiografii_Click);
            // 
            // btnInchidereAplicatie
            // 
            this.btnInchidereAplicatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInchidereAplicatie.Location = new System.Drawing.Point(378, 775);
            this.btnInchidereAplicatie.Name = "btnInchidereAplicatie";
            this.btnInchidereAplicatie.Size = new System.Drawing.Size(193, 66);
            this.btnInchidereAplicatie.TabIndex = 8;
            this.btnInchidereAplicatie.Text = "Inchide aplicatia";
            this.btnInchidereAplicatie.UseVisualStyleBackColor = true;
            this.btnInchidereAplicatie.Click += new System.EventHandler(this.btnInchidereAplicatie_Click);
            // 
            // btnAdaugaPacient
            // 
            this.btnAdaugaPacient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaPacient.Location = new System.Drawing.Point(59, 567);
            this.btnAdaugaPacient.Name = "btnAdaugaPacient";
            this.btnAdaugaPacient.Size = new System.Drawing.Size(193, 66);
            this.btnAdaugaPacient.TabIndex = 9;
            this.btnAdaugaPacient.Text = "Adauga pacient";
            this.btnAdaugaPacient.UseVisualStyleBackColor = true;
            this.btnAdaugaPacient.Click += new System.EventHandler(this.btnAdaugaPacient_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.Location = new System.Drawing.Point(378, 671);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(193, 66);
            this.btnStergere.TabIndex = 10;
            this.btnStergere.Text = "Stergere pacient";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // Pacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 902);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnAdaugaPacient);
            this.Controls.Add(this.btnInchidereAplicatie);
            this.Controls.Add(this.btnAdgRadiografii);
            this.Controls.Add(this.btnVizualizareFisaPacient);
            this.Controls.Add(this.btnAdaugaConsultatie);
            this.Controls.Add(this.dgvBazaDate);
            this.Controls.Add(this.btnCautareNume);
            this.Controls.Add(this.txtNumeCautat);
            this.Controls.Add(this.lblNumeCautat);
            this.Controls.Add(this.lblPacienti);
            this.Name = "Pacient";
            this.Text = "Pacienti";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBazaDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPacienti;
        private System.Windows.Forms.Label lblNumeCautat;
        private System.Windows.Forms.TextBox txtNumeCautat;
        private System.Windows.Forms.Button btnCautareNume;
        private System.Windows.Forms.DataGridView dgvBazaDate;
        private System.Windows.Forms.Button btnAdaugaConsultatie;
        private System.Windows.Forms.Button btnVizualizareFisaPacient;
        private System.Windows.Forms.Button btnAdgRadiografii;
        private System.Windows.Forms.Button btnInchidereAplicatie;
        private System.Windows.Forms.Button btnAdaugaPacient;
        private System.Windows.Forms.Button btnStergere;
    }
}

