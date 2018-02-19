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
    //Should maximum quantity be a settings variable?

    public partial class QuantityChange : Form
    {
        public int currQuantity = 0;

        public QuantityChange()
        {
            InitializeComponent();
        }

        public QuantityChange(int quantitySent)
        {
            InitializeComponent();
            quantityUpDownBox.Value = quantitySent;
            currQuantity = quantitySent;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            currQuantity = -1;
            this.Hide();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            if (currQuantity == Convert.ToInt32(quantityUpDownBox.Value))
                currQuantity = -1;
            else
                currQuantity = Convert.ToInt32(quantityUpDownBox.Value);

            this.Hide();
        }

        private void quantityUpDownBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Confirm_Button.PerformClick();
        }
    }
}
