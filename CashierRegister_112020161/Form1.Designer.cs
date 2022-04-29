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
            this.PayButton = new System.Windows.Forms.Button();
            this.TotalPriceView = new System.Windows.Forms.ListView();
            this.buttonPriceChange = new System.Windows.Forms.Button();
            this.buttonQuantityChange = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonvDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonDiscount = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.PayButton.Text = "Cash";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // TotalPriceView
            // 
            this.TotalPriceView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalPriceView.BackColor = System.Drawing.SystemColors.MenuText;
            this.TotalPriceView.HideSelection = false;
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
            this.buttonPriceChange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPriceChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonPriceChange.Location = new System.Drawing.Point(268, 474);
            this.buttonPriceChange.Name = "buttonPriceChange";
            this.buttonPriceChange.Size = new System.Drawing.Size(114, 30);
            this.buttonPriceChange.TabIndex = 7;
            this.buttonPriceChange.Text = "Price Change";
            this.buttonPriceChange.UseVisualStyleBackColor = true;
            // 
            // buttonQuantityChange
            // 
            this.buttonQuantityChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuantityChange.AutoSize = true;
            this.buttonQuantityChange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonQuantityChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonQuantityChange.Location = new System.Drawing.Point(244, 527);
            this.buttonQuantityChange.Name = "buttonQuantityChange";
            this.buttonQuantityChange.Size = new System.Drawing.Size(138, 30);
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
            this.buttonReport.Location = new System.Drawing.Point(388, 529);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(138, 49);
            this.buttonReport.TabIndex = 11;
            this.buttonReport.Text = "Products";
            this.buttonReport.UseVisualStyleBackColor = true;
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
            this.ListOfItemView.HideSelection = false;
            this.ListOfItemView.Location = new System.Drawing.Point(12, 77);
            this.ListOfItemView.Name = "ListOfItemView";
            this.ListOfItemView.Size = new System.Drawing.Size(695, 384);
            this.ListOfItemView.TabIndex = 4;
            this.ListOfItemView.UseCompatibleStateImageBehavior = false;
            this.ListOfItemView.View = System.Windows.Forms.View.Details;
            this.ListOfItemView.SelectedIndexChanged += new System.EventHandler(this.ListOfItemView_SelectedIndexChanged);
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button1.Location = new System.Drawing.Point(713, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 59);
            this.button1.TabIndex = 19;
            this.button1.Text = "Debit / Credit Card";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonvDelete
            // 
            this.buttonvDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonvDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonvDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonvDelete.Location = new System.Drawing.Point(12, 527);
            this.buttonvDelete.Name = "buttonvDelete";
            this.buttonvDelete.Size = new System.Drawing.Size(110, 49);
            this.buttonvDelete.TabIndex = 1;
            this.buttonvDelete.Text = "Option";
            this.buttonvDelete.UseVisualStyleBackColor = true;
            this.buttonvDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.Location = new System.Drawing.Point(15, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 49);
            this.button2.TabIndex = 20;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button4.Location = new System.Drawing.Point(536, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 49);
            this.button4.TabIndex = 22;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button3.Location = new System.Drawing.Point(128, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 49);
            this.button3.TabIndex = 21;
            this.button3.Text = "Discount";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonDiscount
            // 
            this.buttonDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDiscount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDiscount.Location = new System.Drawing.Point(128, 528);
            this.buttonDiscount.Name = "buttonDiscount";
            this.buttonDiscount.Size = new System.Drawing.Size(110, 49);
            this.buttonDiscount.TabIndex = 9;
            this.buttonDiscount.Text = "Discount";
            this.buttonDiscount.UseVisualStyleBackColor = true;
            this.buttonDiscount.Click += new System.EventHandler(this.buttonDiscount_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button5.Location = new System.Drawing.Point(536, 526);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 49);
            this.button5.TabIndex = 23;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.AutoSize = true;
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button6.Location = new System.Drawing.Point(423, 474);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 30);
            this.button6.TabIndex = 24;
            this.button6.Text = "Check Price";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button7.Location = new System.Drawing.Point(713, 385);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 49);
            this.button7.TabIndex = 25;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button8.Location = new System.Drawing.Point(829, 385);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 49);
            this.button8.TabIndex = 26;
            this.button8.Text = "Delete";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button9.Location = new System.Drawing.Point(945, 385);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 49);
            this.button9.TabIndex = 27;
            this.button9.Text = "Delete";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1090, 588);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxUnitPrice);
            this.Controls.Add(this.UnitPriceLabel);
            this.Controls.Add(this.ListOfItemView);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxScanenterBarcode);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.BarcodeLabel);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonDiscount);
            this.Controls.Add(this.buttonQuantityChange);
            this.Controls.Add(this.buttonPriceChange);
            this.Controls.Add(this.TotalPriceView);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.buttonvDelete);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "YD Techs - Retail Software";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.ListView TotalPriceView;
        private System.Windows.Forms.Button buttonPriceChange;
        private System.Windows.Forms.Button buttonQuantityChange;
        private System.Windows.Forms.Button buttonReport;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonvDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonDiscount;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

