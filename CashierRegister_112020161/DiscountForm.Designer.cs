namespace CashierRegister_112020161
{
    partial class DiscountForm
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
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.DiscountTypeDropDownBox = new System.Windows.Forms.ComboBox();
            this.quantityUpDownBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDownBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Location = new System.Drawing.Point(178, 121);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(75, 23);
            this.Confirm_Button.TabIndex = 7;
            this.Confirm_Button.Text = "Confirm";
            this.Confirm_Button.UseVisualStyleBackColor = true;
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(12, 121);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 6;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // infoLabel1
            // 
            this.infoLabel1.AutoSize = true;
            this.infoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel1.Location = new System.Drawing.Point(12, 9);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(247, 20);
            this.infoLabel1.TabIndex = 5;
            this.infoLabel1.Text = "Please enter a discount quantity...";
            // 
            // DiscountTypeDropDownBox
            // 
            this.DiscountTypeDropDownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiscountTypeDropDownBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.DiscountTypeDropDownBox.FormattingEnabled = true;
            this.DiscountTypeDropDownBox.Items.AddRange(new object[] {
            "-",
            "%"});
            this.DiscountTypeDropDownBox.Location = new System.Drawing.Point(152, 52);
            this.DiscountTypeDropDownBox.Name = "DiscountTypeDropDownBox";
            this.DiscountTypeDropDownBox.Size = new System.Drawing.Size(101, 63);
            this.DiscountTypeDropDownBox.TabIndex = 1;
            this.DiscountTypeDropDownBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.quantityUpDownBox_KeyDown);
            // 
            // quantityUpDownBox
            // 
            this.quantityUpDownBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityUpDownBox.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.quantityUpDownBox.Location = new System.Drawing.Point(26, 53);
            this.quantityUpDownBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.quantityUpDownBox.Name = "quantityUpDownBox";
            this.quantityUpDownBox.Size = new System.Drawing.Size(120, 62);
            this.quantityUpDownBox.TabIndex = 0;
            this.quantityUpDownBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.quantityUpDownBox_KeyDown);
            // 
            // DiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 159);
            this.Controls.Add(this.DiscountTypeDropDownBox);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.quantityUpDownBox);
            this.Controls.Add(this.infoLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiscountForm";
            this.Text = "DiscountForm";
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDownBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.ComboBox DiscountTypeDropDownBox;
        private System.Windows.Forms.NumericUpDown quantityUpDownBox;
    }
}