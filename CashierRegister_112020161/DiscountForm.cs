using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierRegister_112020161
{
    public partial class DiscountForm : Form
    {
        public double currDiscountAmt = 0;
        public double initialAmount;

        public DiscountForm(double initialAmt)
        {
            InitializeComponent();
            DiscountTypeDropDownBox.Text = "-";
            initialAmount = initialAmt;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            currDiscountAmt = -1;
            this.Hide();
        }

        private void quantityUpDownBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Confirm_Button.PerformClick();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            double amtToDiscount = Convert.ToDouble(quantityUpDownBox.Value);

            if (amtToDiscount == 0)
                currDiscountAmt = -1;
            else
            {
                if (DiscountTypeDropDownBox.Text == "-")
                {
                    currDiscountAmt = initialAmount - Convert.ToDouble(quantityUpDownBox.Value);
                }
                else if (DiscountTypeDropDownBox.Text == "%")
                {
                    double amtToSub = initialAmount * (double)(quantityUpDownBox.Value / 100);
                    currDiscountAmt = initialAmount - amtToSub;
                }
            }

            this.Hide();
        }
    }
}
