
using Warehouse.EventArguments;
using Warehouse.ViewModels;

namespace Warehouse
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlAllProducts = new Warehouse.AllProductsControl();
            this.ctrlTrade = new Warehouse.TradeControl();
            this.SuspendLayout();
            // 
            // ctrlAllProducts
            // 
            this.ctrlAllProducts.Location = new System.Drawing.Point(1061, 15);
            this.ctrlAllProducts.Name = "ctrlAllProducts";
            this.ctrlAllProducts.Size = new System.Drawing.Size(847, 870);
            this.ctrlAllProducts.TabIndex = 6;
            this.ctrlAllProducts.ProductChosen += new System.EventHandler<Warehouse.EventArguments.ProductChosenEventArgs>(this.ctrlAllProducts_ProductChosen);
            // 
            // ctrlTrade
            // 
            this.ctrlTrade.Location = new System.Drawing.Point(12, 15);
            this.ctrlTrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlTrade.Name = "ctrlTrade";
            this.ctrlTrade.Size = new System.Drawing.Size(983, 590);
            this.ctrlTrade.TabIndex = 7;
            this.ctrlTrade.QuantitiesChanged += new System.EventHandler(this.ctrlTrade_QuantitiesChanged);
            this.ctrlTrade.Load += new System.EventHandler(this.ctrlTrade_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.ctrlTrade);
            this.Controls.Add(this.ctrlAllProducts);
            this.Name = "MainForm";
            this.Text = "WareHouse";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private AllProductsControl ctrlAllProducts;
        private TradeControl ctrlTrade;
    }
}

