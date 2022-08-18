
namespace Warehouse
{
    partial class EditProductForm
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtWholesalePrice = new System.Windows.Forms.TextBox();
            this.txtRetailPrice = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(300, 215);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 22);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Փոփոխել";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Անվանում";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Մեծածախ գին";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Մանրածախ գին";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Նշումներ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 9);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 23);
            this.txtName.TabIndex = 7;
            // 
            // txtWholesalePrice
            // 
            this.txtWholesalePrice.Location = new System.Drawing.Point(133, 34);
            this.txtWholesalePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWholesalePrice.Name = "txtWholesalePrice";
            this.txtWholesalePrice.Size = new System.Drawing.Size(249, 23);
            this.txtWholesalePrice.TabIndex = 8;
            this.txtWholesalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInput_KeyPress);
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.Location = new System.Drawing.Point(133, 58);
            this.txtRetailPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Size = new System.Drawing.Size(249, 23);
            this.txtRetailPrice.TabIndex = 9;
            this.txtRetailPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInput_KeyPress);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(133, 83);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(249, 128);
            this.txtNotes.TabIndex = 10;
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 271);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtRetailPrice);
            this.Controls.Add(this.txtWholesalePrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEdit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditProductForm";
            this.Text = "Ապրանքի խմբագրում";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtWholesalePrice;
        private System.Windows.Forms.TextBox txtRetailPrice;
        private System.Windows.Forms.TextBox txtNotes;
    }
}