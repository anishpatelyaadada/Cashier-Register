namespace CashierRegister_112020161
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
            this.Inventory = new System.Windows.Forms.Button();
            this.buttonvDelete = new System.Windows.Forms.Button();
            this.PayButton = new System.Windows.Forms.Button();
            this.CheckPrice = new System.Windows.Forms.Button();
            this.TotalPriceView = new System.Windows.Forms.ListView();
            this.buttonPriceChange = new System.Windows.Forms.Button();
            this.buttonQuantityChange = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonOption = new System.Windows.Forms.Button();
            this.buttonDiscount = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.BarcodeLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.textBoxScanenterBarcode = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.BarcodeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListOfItemView = new System.Windows.Forms.ListView();
            this.UnitPriceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Inventory
            // 
            this.Inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Inventory.Location = new System.Drawing.Point(12, 545);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(197, 31);
            this.Inventory.TabIndex = 0;
            this.Inventory.Text = "Inventory";
            this.Inventory.UseVisualStyleBackColor = true;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // buttonvDelete
            // 
            this.buttonvDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonvDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonvDelete.Location = new System.Drawing.Point(713, 320);
            this.buttonvDelete.Name = "buttonvDelete";
            this.buttonvDelete.Size = new System.Drawing.Size(110, 49);
            this.buttonvDelete.TabIndex = 1;
            this.buttonvDelete.Text = "Delete";
            this.buttonvDelete.UseVisualStyleBackColor = true;
            this.buttonvDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // PayButton
            // 
            this.PayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PayButton.AutoSize = true;
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.PayButton.Location = new System.Drawing.Point(713, 255);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(368, 59);
            this.PayButton.TabIndex = 2;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = true;
            // 
            // CheckPrice
            // 
            this.CheckPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CheckPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CheckPrice.Location = new System.Drawing.Point(215, 545);
            this.CheckPrice.Name = "CheckPrice";
            this.CheckPrice.Size = new System.Drawing.Size(197, 31);
            this.CheckPrice.TabIndex = 3;
            this.CheckPrice.Text = "Check Price";
            this.CheckPrice.UseVisualStyleBackColor = true;
            // 
            // TotalPriceView
            // 
            this.TotalPriceView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalPriceView.BackColor = System.Drawing.SystemColors.MenuText;
            this.TotalPriceView.Location = new System.Drawing.Point(713, 12);
            this.TotalPriceView.Name = "TotalPriceView";
            this.TotalPriceView.Size = new System.Drawing.Size(368, 237);
            this.TotalPriceView.TabIndex = 5;
            this.TotalPriceView.UseCompatibleStateImageBehavior = false;
            // 
            // buttonPriceChange
            // 
            this.buttonPriceChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPriceChange.AutoSize = true;
            this.buttonPriceChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonPriceChange.Location = new System.Drawing.Point(969, 320);
            this.buttonPriceChange.Name = "buttonPriceChange";
            this.buttonPriceChange.Size = new System.Drawing.Size(114, 49);
            this.buttonPriceChange.TabIndex = 7;
            this.buttonPriceChange.Text = "Price Change";
            this.buttonPriceChange.UseVisualStyleBackColor = true;
            // 
            // buttonQuantityChange
            // 
            this.buttonQuantityChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuantityChange.AutoSize = true;
            this.buttonQuantityChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonQuantityChange.Location = new System.Drawing.Point(829, 321);
            this.buttonQuantityChange.Name = "buttonQuantityChange";
            this.buttonQuantityChange.Size = new System.Drawing.Size(138, 49);
            this.buttonQuantityChange.TabIndex = 8;
            this.buttonQuantityChange.Text = "Quantity Change";
            this.buttonQuantityChange.UseVisualStyleBackColor = true;
            this.buttonQuantityChange.Click += new System.EventHandler(this.buttonQuantityChange_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonReport.Location = new System.Drawing.Point(841, 375);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(110, 49);
            this.buttonReport.TabIndex = 11;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // buttonOption
            // 
            this.buttonOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonOption.Location = new System.Drawing.Point(969, 375);
            this.buttonOption.Name = "buttonOption";
            this.buttonOption.Size = new System.Drawing.Size(110, 49);
            this.buttonOption.TabIndex = 10;
            this.buttonOption.Text = "Option";
            this.buttonOption.UseVisualStyleBackColor = true;
            // 
            // buttonDiscount
            // 
            this.buttonDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDiscount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDiscount.Location = new System.Drawing.Point(713, 375);
            this.buttonDiscount.Name = "buttonDiscount";
            this.buttonDiscount.Size = new System.Drawing.Size(110, 49);
            this.buttonDiscount.TabIndex = 9;
            this.buttonDiscount.Text = "Discount";
            this.buttonDiscount.UseVisualStyleBackColor = true;
            this.buttonDiscount.Click += new System.EventHandler(this.buttonDiscount_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSearch.Location = new System.Drawing.Point(597, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(110, 49);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // BarcodeLabel
            // 
            this.BarcodeLabel.AutoSize = true;
            this.BarcodeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BarcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BarcodeLabel.Location = new System.Drawing.Point(12, 12);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Size = new System.Drawing.Size(171, 17);
            this.BarcodeLabel.TabIndex = 13;
            this.BarcodeLabel.Text = "Enter / Scan Barcode.......";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.QuantityLabel.Location = new System.Drawing.Point(245, 12);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(61, 17);
            this.QuantityLabel.TabIndex = 14;
            this.QuantityLabel.Text = "Quantity";
            // 
            // textBoxScanenterBarcode
            // 
            this.textBoxScanenterBarcode.Location = new System.Drawing.Point(15, 32);
            this.textBoxScanenterBarcode.Name = "textBoxScanenterBarcode";
            this.textBoxScanenterBarcode.Size = new System.Drawing.Size(197, 20);
            this.textBoxScanenterBarcode.TabIndex = 15;
            this.textBoxScanenterBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemEnter_KeyDown);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(248, 32);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(142, 20);
            this.textBoxQuantity.TabIndex = 16;
            this.textBoxQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemEnter_KeyDown);
            // 
            // BarcodeCol
            // 
            this.BarcodeCol.Text = "Barcode";
            // 
            // DescriptionCol
            // 
            this.DescriptionCol.Text = "Item Descrition";
            // 
            // QuantityCol
            // 
            this.QuantityCol.Text = "Item Quantity";
            // 
            // ListOfItemView
            // 
            this.ListOfItemView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListOfItemView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BarcodeCol,
            this.DescriptionCol,
            this.QuantityCol,
            this.UnitPriceCol,
            this.TotalPrice});
            this.ListOfItemView.Location = new System.Drawing.Point(12, 77);
            this.ListOfItemView.Name = "ListOfItemView";
            this.ListOfItemView.Size = new System.Drawing.Size(695, 445);
            this.ListOfItemView.TabIndex = 4;
            this.ListOfItemView.UseCompatibleStateImageBehavior = false;
            this.ListOfItemView.View = System.Windows.Forms.View.Details;
            // 
            // UnitPriceCol
            // 
            this.UnitPriceCol.Text = "Unit Price";
            // 
            // TotalPrice
            // 
            this.TotalPrice.Text = "Total Price";
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UnitPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UnitPriceLabel.Location = new System.Drawing.Point(421, 12);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(69, 17);
            this.UnitPriceLabel.TabIndex = 17;
            this.UnitPriceLabel.Text = "Unit Price";
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(424, 32);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(108, 20);
            this.textBoxUnitPrice.TabIndex = 18;
            this.textBoxUnitPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemEnter_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1090, 588);
            this.Controls.Add(this.textBoxUnitPrice);
            this.Controls.Add(this.UnitPriceLabel);
            this.Controls.Add(this.ListOfItemView);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxScanenterBarcode);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.BarcodeLabel);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonOption);
            this.Controls.Add(this.buttonDiscount);
            this.Controls.Add(this.buttonQuantityChange);
            this.Controls.Add(this.buttonPriceChange);
            this.Controls.Add(this.TotalPriceView);
            this.Controls.Add(this.CheckPrice);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.buttonvDelete);
            this.Controls.Add(this.Inventory);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inventory;
        private System.Windows.Forms.Button buttonvDelete;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Button CheckPrice;
        private System.Windows.Forms.ListView TotalPriceView;
        private System.Windows.Forms.Button buttonPriceChange;
        private System.Windows.Forms.Button buttonQuantityChange;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonOption;
        private System.Windows.Forms.Button buttonDiscount;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label BarcodeLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox textBoxScanenterBarcode;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.ColumnHeader BarcodeCol;
        private System.Windows.Forms.ColumnHeader DescriptionCol;
        private System.Windows.Forms.ColumnHeader QuantityCol;
        private System.Windows.Forms.ListView ListOfItemView;
        private System.Windows.Forms.ColumnHeader UnitPriceCol;
        private System.Windows.Forms.ColumnHeader TotalPrice;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
    }
}

