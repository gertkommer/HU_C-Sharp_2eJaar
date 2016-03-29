namespace _5._2___StoreFront
{
    partial class frmStore
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
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lboxInventory = new System.Windows.Forms.ListBox();
            this.lboxProducts = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblMoneyLeft1 = new System.Windows.Forms.Label();
            this.lblMoneyLeft2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(13, 13);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(51, 13);
            this.lblInventory.TabIndex = 0;
            this.lblInventory.Text = "Inventory";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(352, 13);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(49, 13);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Products";
            // 
            // lboxInventory
            // 
            this.lboxInventory.FormattingEnabled = true;
            this.lboxInventory.Location = new System.Drawing.Point(16, 32);
            this.lboxInventory.Name = "lboxInventory";
            this.lboxInventory.Size = new System.Drawing.Size(318, 186);
            this.lboxInventory.TabIndex = 2;
            // 
            // lboxProducts
            // 
            this.lboxProducts.FormattingEnabled = true;
            this.lboxProducts.Location = new System.Drawing.Point(355, 32);
            this.lboxProducts.Name = "lboxProducts";
            this.lboxProducts.Size = new System.Drawing.Size(336, 186);
            this.lboxProducts.TabIndex = 3;
            this.lboxProducts.SelectedIndexChanged += new System.EventHandler(this.lboxProducts_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(615, 226);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(534, 225);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 5;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblMoneyLeft1
            // 
            this.lblMoneyLeft1.AutoSize = true;
            this.lblMoneyLeft1.Location = new System.Drawing.Point(16, 234);
            this.lblMoneyLeft1.Name = "lblMoneyLeft1";
            this.lblMoneyLeft1.Size = new System.Drawing.Size(59, 13);
            this.lblMoneyLeft1.TabIndex = 6;
            this.lblMoneyLeft1.Text = "Money left:";
            // 
            // lblMoneyLeft2
            // 
            this.lblMoneyLeft2.AutoSize = true;
            this.lblMoneyLeft2.Location = new System.Drawing.Point(82, 234);
            this.lblMoneyLeft2.Name = "lblMoneyLeft2";
            this.lblMoneyLeft2.Size = new System.Drawing.Size(28, 13);
            this.lblMoneyLeft2.TabIndex = 7;
            this.lblMoneyLeft2.Text = "0,00";
            // 
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 261);
            this.Controls.Add(this.lblMoneyLeft2);
            this.Controls.Add(this.lblMoneyLeft1);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lboxProducts);
            this.Controls.Add(this.lboxInventory);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblInventory);
            this.Name = "frmStore";
            this.Text = "Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ListBox lboxInventory;
        private System.Windows.Forms.ListBox lboxProducts;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblMoneyLeft1;
        private System.Windows.Forms.Label lblMoneyLeft2;
    }
}