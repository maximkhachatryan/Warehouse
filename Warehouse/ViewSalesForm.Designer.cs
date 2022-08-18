
namespace Warehouse
{
    partial class ViewSalesForm
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
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSalesSum = new System.Windows.Forms.Label();
            this.dgvRepayments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRepaymentSum = new System.Windows.Forms.Label();
            this.lblOverallSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepayments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AllowUserToOrderColumns = true;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvSales.Location = new System.Drawing.Point(13, 81);
            this.dgvSales.MultiSelect = false;
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 29;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(982, 212);
            this.dgvSales.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(13, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 32);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // lblSalesSum
            // 
            this.lblSalesSum.AutoSize = true;
            this.lblSalesSum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalesSum.Location = new System.Drawing.Point(13, 296);
            this.lblSalesSum.Name = "lblSalesSum";
            this.lblSalesSum.Size = new System.Drawing.Size(23, 28);
            this.lblSalesSum.TabIndex = 5;
            this.lblSalesSum.Text = "0";
            // 
            // dgvRepayments
            // 
            this.dgvRepayments.AllowUserToAddRows = false;
            this.dgvRepayments.AllowUserToDeleteRows = false;
            this.dgvRepayments.AllowUserToOrderColumns = true;
            this.dgvRepayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepayments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvRepayments.Location = new System.Drawing.Point(12, 371);
            this.dgvRepayments.MultiSelect = false;
            this.dgvRepayments.Name = "dgvRepayments";
            this.dgvRepayments.ReadOnly = true;
            this.dgvRepayments.RowHeadersWidth = 51;
            this.dgvRepayments.RowTemplate.Height = 29;
            this.dgvRepayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepayments.Size = new System.Drawing.Size(982, 212);
            this.dgvRepayments.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Վաճառք";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Վճարումներ";
            // 
            // lblRepaymentSum
            // 
            this.lblRepaymentSum.AutoSize = true;
            this.lblRepaymentSum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRepaymentSum.Location = new System.Drawing.Point(13, 586);
            this.lblRepaymentSum.Name = "lblRepaymentSum";
            this.lblRepaymentSum.Size = new System.Drawing.Size(23, 28);
            this.lblRepaymentSum.TabIndex = 9;
            this.lblRepaymentSum.Text = "0";
            // 
            // lblOverallSum
            // 
            this.lblOverallSum.AutoSize = true;
            this.lblOverallSum.Location = new System.Drawing.Point(13, 644);
            this.lblOverallSum.Name = "lblOverallSum";
            this.lblOverallSum.Size = new System.Drawing.Size(100, 20);
            this.lblOverallSum.TabIndex = 10;
            this.lblOverallSum.Text = "Ընդհանուր ։ ";
            // 
            // ViewSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 707);
            this.Controls.Add(this.lblOverallSum);
            this.Controls.Add(this.lblRepaymentSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRepayments);
            this.Controls.Add(this.lblSalesSum);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgvSales);
            this.Name = "ViewSalesForm";
            this.Text = "Օրվա առևտուր";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSalesSum;
        private System.Windows.Forms.DataGridView dgvRepayments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRepaymentSum;
        private System.Windows.Forms.Label lblOverallSum;
    }
}