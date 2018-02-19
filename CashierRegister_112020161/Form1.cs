using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSTaskDialog; //https://www.codeproject.com/Articles/21276/Vista-TaskDialog-Wrapper-and-Emulator

//Use PSTaskDialog library for message/information boxes| use cTaskDialog.ShowTaskDialogBox function (2nd overload)

namespace CashierRegister_112020161
{
    public partial class Form1 : Form
    {
        const int BARCODE_COL = 0;
        const int DESCRIPTION_COL = 1;
        const int QUANTITY_COL = 2;
        const int UNIT_PRICE_COL = 3;
        const int TOTAL_PRICE_COL = 4;

        public Form1()
        {
            InitializeComponent();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            InventoryForm openForm = new InventoryForm();

        }

        private void ItemEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int quantity = 1;
                double unitPrice = 0.00;

                if (textBoxUnitPrice.Text != "")
                {
                    unitPrice = Convert.ToDouble(textBoxUnitPrice.Text);
                }

                if (textBoxQuantity.Text != "")
                {
                    quantity = Convert.ToInt32(textBoxQuantity.Text);
                }

                if (textBoxScanenterBarcode.Text != "")
                {
                    InsertItemInList(textBoxScanenterBarcode.Text, quantity, unitPrice);
                    textBoxScanenterBarcode.Clear();
                    textBoxQuantity.Clear();
                    textBoxUnitPrice.Clear();
                }
                else
                    cTaskDialog.ShowTaskDialogBox(this, "Enter Barcode!", "Please enter a barcode!", "", "", "", "", "", "", eTaskDialogButtons.OK, eSysIcons.Information, eSysIcons.Information);
            }

        }

        private void InsertItemInList(string barcode, int quantity, double unitPrice)
        {
            int itemIndex = -1;

            if (!doesBarcodeExistInList(barcode, ref itemIndex))
            {
                ListViewItem newItem = new ListViewItem(textBoxScanenterBarcode.Text);
                newItem.Tag = barcode;
                newItem.SubItems.Add("DESCRIPTION");
                newItem.SubItems.Add(quantity.ToString());
                newItem.SubItems.Add(unitPrice.ToString("C"));
                newItem.SubItems.Add((unitPrice * quantity).ToString("C"));

                ListOfItemView.Items.Add(newItem);
            }
            else
            {
                int quantityInt = Convert.ToInt32(ListOfItemView.Items[itemIndex].SubItems[QUANTITY_COL].Text);
                ListOfItemView.Items[itemIndex].SubItems[QUANTITY_COL].Text = (quantityInt + quantity).ToString();
            }
        }

        private bool doesBarcodeExistInList(string barcode, ref int index)
        {
            ListViewItem tempItem = new ListViewItem(barcode);

            int count = 0;

            foreach (ListViewItem item in ListOfItemView.Items)
            {
                if (item.Tag.ToString() == barcode)
                {
                    index = count;
                    return true;
                }

                count++;
            }

            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListOfItemView.Columns[BARCODE_COL].Width = 133;
            ListOfItemView.Columns[DESCRIPTION_COL].Width = 167;
            ListOfItemView.Columns[QUANTITY_COL].Width = 112;
            ListOfItemView.Columns[UNIT_PRICE_COL].Width = 120;
            ListOfItemView.Columns[TOTAL_PRICE_COL].Width = 120;
        }

        private bool isAnItemSelected()
        {
            if (ListOfItemView.SelectedIndices.Count > 0)
                return true;

            return false;
        }

        private void buttonQuantityChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isAnItemSelected())
                    throw new NoItemSelected(this);

                quantityRetrieveAndStore(ListOfItemView.SelectedIndices[0]);
            }
            catch(NoItemSelected)
            {
                //Nothing
            }

        }

        private void quantityRetrieveAndStore(int listIndex)
        {
            int qnt = Convert.ToInt32(ListOfItemView.Items[listIndex].SubItems[QUANTITY_COL].Text);
            quantityAdjust(ref qnt);

            if (qnt == -1)
            {
                cTaskDialog.ShowTaskDialogBox(this, "Quantity Update", "Quantity was unchanged!", "", "", "", "", "", "", eTaskDialogButtons.OK, eSysIcons.Information, eSysIcons.Information);
            }
            else if (qnt == 0)
            {
                DeleteItem(listIndex);
            }
            else if (qnt > 0)
            {
                ListOfItemView.Items[listIndex].SubItems[QUANTITY_COL].Text = qnt.ToString();
                updateTotalPriceCol(listIndex);
                cTaskDialog.ShowTaskDialogBox(this, "Quantity Update", "Quantity was updated!", "", "", "", "", "", "", eTaskDialogButtons.OK, eSysIcons.Information, eSysIcons.Information);
            }
        }

        private void quantityAdjust(ref int quantity)
        {
            QuantityChange newQ = new QuantityChange(quantity);
            newQ.ShowDialog();

            quantity = newQ.currQuantity;
            newQ.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isAnItemSelected())
                    throw new NoItemSelected(this);

                DeleteItem(ListOfItemView.SelectedIndices[0]);
            }
            catch (NoItemSelected)
            {
                //Nothing
            }
        }

        private void DeleteItem(int listIndex)
        {
            ListOfItemView.Items[listIndex].Remove();
            cTaskDialog.ShowTaskDialogBox(this, "Quantity Update", "Item was removed!", "", "", "", "", "", "", eTaskDialogButtons.OK, eSysIcons.Information, eSysIcons.Information);
        }

        private void buttonDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isAnItemSelected())
                    throw new NoItemSelected(this);

                DialogResult cancel = cTaskDialog.ShowTaskDialogBox(this, "Which Price?", "Which price should be discounted?", "", "", "", "", "", "Item Unit Price|Item Total Price", eTaskDialogButtons.Cancel, eSysIcons.Question, eSysIcons.Question);

                int PriceSelect = -1;

                if (cancel != DialogResult.Cancel)
                {
                    if (cTaskDialog.CommandButtonResult == 0)
                        PriceSelect = UNIT_PRICE_COL;
                    else if (cTaskDialog.CommandButtonResult == 1)
                        PriceSelect = TOTAL_PRICE_COL;

                    ApplyDiscount(ListOfItemView.SelectedIndices[0], PriceSelect);
                }
            }
            catch (NoItemSelected)
            {
                //Nothing
            }
        }

        private void ApplyDiscount(int listIndex, int TypeOfPrice)
        {
            if (TypeOfPrice == -1)
                cTaskDialog.ShowTaskDialogBox(this, "No Selection!", "Please select an option!", "", "", "", "", "", "", eTaskDialogButtons.OK, eSysIcons.Information, eSysIcons.Information);

            double finalDiscountedAmt = 0;
            discountAdjust(ref finalDiscountedAmt, Convert.ToDouble(ListOfItemView.Items[listIndex].SubItems[TypeOfPrice].Text.Substring(1)));

            if (finalDiscountedAmt == -1)
            {
                cTaskDialog.ShowTaskDialogBox(this, "Discount Update", "No discount was applied!", "", "", "", "", "", "", eTaskDialogButtons.OK, eSysIcons.Information, eSysIcons.Information);
            }
            else if (finalDiscountedAmt >= 0)
            {
                ListOfItemView.Items[listIndex].SubItems[TypeOfPrice].Text = finalDiscountedAmt.ToString("C");

                if (TypeOfPrice == UNIT_PRICE_COL)
                    updateTotalPriceCol(listIndex);

                cTaskDialog.ShowTaskDialogBox(this, "Discount Update", "Discount was applied!", "", "", "", "", "", "", eTaskDialogButtons.OK, eSysIcons.Information, eSysIcons.Information);
            }
        }

        private void updateTotalPriceCol(int listIndex)
        {
            double finalUnitPrice = Convert.ToDouble(ListOfItemView.Items[listIndex].SubItems[UNIT_PRICE_COL].Text.Substring(1));

            double TotalItemPrice = finalUnitPrice * Convert.ToDouble(ListOfItemView.Items[listIndex].SubItems[QUANTITY_COL].Text);
            ListOfItemView.Items[listIndex].SubItems[TOTAL_PRICE_COL].Text = TotalItemPrice.ToString("C");
        }

        private void discountAdjust(ref double discountFinal, double initialPrice)
        {
            DiscountForm newD = new DiscountForm(initialPrice);
            newD.ShowDialog();

            discountFinal = newD.currDiscountAmt;
            newD.Close();
        }
    }

    class NoItemSelected:Exception
    {
        public NoItemSelected(Form owner)
        {
            cTaskDialog.ShowTaskDialogBox(owner, "No Item Selected!", "Please select at least one item.", "", "", "", "", "", "", eTaskDialogButtons.OK, eSysIcons.Information, eSysIcons.Information);
        }
    };
}
