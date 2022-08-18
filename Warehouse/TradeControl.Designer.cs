
namespace Warehouse
{
    partial class TradeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTrade = new System.Windows.Forms.DataGridView();
            this.btnSell = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radWholesale = new System.Windows.Forms.RadioButton();
            this.radRetail = new System.Windows.Forms.RadioButton();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.chkLend = new System.Windows.Forms.CheckBox();
            this.btnSales = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtByWhom = new System.Windows.Forms.TextBox();
            this.btnRepay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTrade
            // 
            this.dgvTrade.AllowUserToAddRows = false;
            this.dgvTrade.AllowUserToDeleteRows = false;
            this.dgvTrade.AllowUserToOrderColumns = true;
            this.dgvTrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTrade.Location = new System.Drawing.Point(12, 136);
            this.dgvTrade.MultiSelect = false;
            this.dgvTrade.Name = "dgvTrade";
            this.dgvTrade.RowHeadersWidth = 51;
            this.dgvTrade.RowTemplate.Height = 29;
            this.dgvTrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrade.Size = new System.Drawing.Size(955, 265);
            this.dgvTrade.TabIndex = 3;
            this.dgvTrade.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrade_CellValueChanged);
            // 
            // btnSell
            // 
            this.btnSell.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSell.Location = new System.Drawing.Point(15, 499);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(251, 36);
            this.btnSell.TabIndex = 4;
            this.btnSell.Text = "Վաճառել";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.Color.Navy;
            this.lblPrice.Location = new System.Drawing.Point(108, 404);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 54);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Գումար";
            // 
            // radWholesale
            // 
            this.radWholesale.AutoSize = true;
            this.radWholesale.Location = new System.Drawing.Point(14, 13);
            this.radWholesale.Name = "radWholesale";
            this.radWholesale.Size = new System.Drawing.Size(106, 24);
            this.radWholesale.TabIndex = 8;
            this.radWholesale.TabStop = true;
            this.radWholesale.Text = "Մեծածախ";
            this.radWholesale.UseVisualStyleBackColor = true;
            // 
            // radRetail
            // 
            this.radRetail.AutoSize = true;
            this.radRetail.Location = new System.Drawing.Point(14, 43);
            this.radRetail.Name = "radRetail";
            this.radRetail.Size = new System.Drawing.Size(119, 24);
            this.radRetail.TabIndex = 9;
            this.radRetail.TabStop = true;
            this.radRetail.Text = "Մանրածախ";
            this.radRetail.UseVisualStyleBackColor = true;
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Location = new System.Drawing.Point(12, 101);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(132, 29);
            this.btnRemoveRow.TabIndex = 10;
            this.btnRemoveRow.Text = "Հեռացնել տողը";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // chkLend
            // 
            this.chkLend.AutoSize = true;
            this.chkLend.Location = new System.Drawing.Point(17, 461);
            this.chkLend.Name = "chkLend";
            this.chkLend.Size = new System.Drawing.Size(167, 24);
            this.chkLend.TabIndex = 11;
            this.chkLend.Text = "պարտքով վաճառք";
            this.chkLend.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(694, 43);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(271, 42);
            this.btnSales.TabIndex = 12;
            this.btnSales.Text = "Վաճառքի ցուցակ";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(694, 13);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(271, 27);
            this.datePicker.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRepay);
            this.groupBox1.Controls.Add(this.txtByWhom);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(667, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 153);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Վճարումներ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Գումար";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Վճարող";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(91, 36);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(182, 27);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInput_KeyPress);
            // 
            // txtByWhom
            // 
            this.txtByWhom.Location = new System.Drawing.Point(91, 69);
            this.txtByWhom.Name = "txtByWhom";
            this.txtByWhom.Size = new System.Drawing.Size(182, 27);
            this.txtByWhom.TabIndex = 3;
            // 
            // btnRepay
            // 
            this.btnRepay.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRepay.Location = new System.Drawing.Point(91, 102);
            this.btnRepay.Name = "btnRepay";
            this.btnRepay.Size = new System.Drawing.Size(182, 36);
            this.btnRepay.TabIndex = 5;
            this.btnRepay.Text = "Հաստատել";
            this.btnRepay.UseVisualStyleBackColor = true;
            this.btnRepay.Click += new System.EventHandler(this.btnRepay_Click);
            // 
            // TradeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.chkLend);
            this.Controls.Add(this.btnRemoveRow);
            this.Controls.Add(this.radRetail);
            this.Controls.Add(this.radWholesale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.dgvTrade);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TradeControl";
            this.Size = new System.Drawing.Size(981, 751);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrade;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radWholesale;
        private System.Windows.Forms.RadioButton radRetail;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.CheckBox chkLend;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRepay;
        private System.Windows.Forms.TextBox txtByWhom;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
