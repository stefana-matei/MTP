
namespace Exercitiul4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaleNo = new System.Windows.Forms.TextBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSaleKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLedgerNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLedgerKey = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStockLedgerKey = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.cmbFind = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lsbSaleInformation = new System.Windows.Forms.ListBox();
            this.gbProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remarks";
            // 
            // txtSaleNo
            // 
            this.txtSaleNo.Location = new System.Drawing.Point(149, 41);
            this.txtSaleNo.Name = "txtSaleNo";
            this.txtSaleNo.Size = new System.Drawing.Size(151, 22);
            this.txtSaleNo.TabIndex = 3;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(149, 92);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(293, 24);
            this.cmbCustomer.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(149, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(232, 22);
            this.dtpDate.TabIndex = 5;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(149, 145);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(293, 22);
            this.txtRemarks.TabIndex = 6;
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.txtAmount);
            this.gbProduct.Controls.Add(this.label6);
            this.gbProduct.Controls.Add(this.txtItemQty);
            this.gbProduct.Controls.Add(this.label5);
            this.gbProduct.Controls.Add(this.cmbProduct);
            this.gbProduct.Controls.Add(this.label4);
            this.gbProduct.Location = new System.Drawing.Point(149, 241);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(550, 164);
            this.gbProduct.TabIndex = 7;
            this.gbProduct.TabStop = false;
            this.gbProduct.Text = "Product";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(380, 93);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(125, 22);
            this.txtAmount.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Amount";
            // 
            // txtItemQty
            // 
            this.txtItemQty.Location = new System.Drawing.Point(117, 93);
            this.txtItemQty.Name = "txtItemQty";
            this.txtItemQty.Size = new System.Drawing.Size(164, 22);
            this.txtItemQty.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Item Qty";
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(117, 38);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(334, 24);
            this.cmbProduct.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sale key";
            // 
            // txtSaleKey
            // 
            this.txtSaleKey.Location = new System.Drawing.Point(688, 38);
            this.txtSaleKey.Name = "txtSaleKey";
            this.txtSaleKey.Size = new System.Drawing.Size(151, 22);
            this.txtSaleKey.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ledger No";
            // 
            // txtLedgerNo
            // 
            this.txtLedgerNo.Location = new System.Drawing.Point(606, 97);
            this.txtLedgerNo.Name = "txtLedgerNo";
            this.txtLedgerNo.Size = new System.Drawing.Size(48, 22);
            this.txtLedgerNo.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(685, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ledger Key";
            // 
            // txtLedgerKey
            // 
            this.txtLedgerKey.Location = new System.Drawing.Point(772, 94);
            this.txtLedgerKey.Name = "txtLedgerKey";
            this.txtLedgerKey.Size = new System.Drawing.Size(67, 22);
            this.txtLedgerKey.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(579, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Stock Ledger Key";
            // 
            // txtStockLedgerKey
            // 
            this.txtStockLedgerKey.Location = new System.Drawing.Point(725, 142);
            this.txtStockLedgerKey.Name = "txtStockLedgerKey";
            this.txtStockLedgerKey.Size = new System.Drawing.Size(114, 22);
            this.txtStockLedgerKey.TabIndex = 15;
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(329, 46);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(35, 17);
            this.lblFind.TabIndex = 16;
            this.lblFind.Text = "Find";
            // 
            // cmbFind
            // 
            this.cmbFind.FormattingEnabled = true;
            this.cmbFind.Location = new System.Drawing.Point(379, 43);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Size = new System.Drawing.Size(63, 24);
            this.cmbFind.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(149, 438);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(550, 59);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(350, 531);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "SALE INFORMATION";
            // 
            // lsbSaleInformation
            // 
            this.lsbSaleInformation.FormattingEnabled = true;
            this.lsbSaleInformation.ItemHeight = 16;
            this.lsbSaleInformation.Location = new System.Drawing.Point(149, 568);
            this.lsbSaleInformation.Name = "lsbSaleInformation";
            this.lsbSaleInformation.Size = new System.Drawing.Size(550, 164);
            this.lsbSaleInformation.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 744);
            this.Controls.Add(this.lsbSaleInformation);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbFind);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.txtStockLedgerKey);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtLedgerKey);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLedgerNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSaleKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbProduct);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.txtSaleNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbProduct.ResumeLayout(false);
            this.gbProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaleNo;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSaleKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLedgerNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLedgerKey;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStockLedgerKey;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.ComboBox cmbFind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lsbSaleInformation;
    }
}

