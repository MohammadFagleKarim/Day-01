using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class Sale : Form
    {
        int index = 0;
        public Sale()
        {
            InitializeComponent();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            string[] customerName = new string[100];
            string[] contactNo = new string[50];
            string[] address = new string[100];
            int[] quantity = new int[50];
            int[] pricePerOrder = new int[50];
            int[] totalPrice = new int[50];
            string[] orderCombo = new String[20];

            customerName[index] = nameTB.Text;
            contactNo[index] = contactTB.Text;
            address[index] = addressTB.Text;
            quantity[index] = Convert.ToInt32(quantityTB.Text);
            pricePerOrder[index] = Convert.ToInt32(priceTB.Text);
            orderCombo[index] = orderComboBox.Text;

            if(nameTB.Text == null || contactTB.Text == null || addressTB.Text == null || 
                quantityTB.Text == null || priceTB.Text == null) {
                MessageBox.Show("You cannot keep it blank.");
            }
            else {
                MessageBox.Show("Sucessfully inserted an order.");
            }

            if(orderComboBox.Text == null) {
                MessageBox.Show("Selct item.");
            }
            else if(orderComboBox.Text == "Black Coffee") {
                totalPrice[index] = quantity[index] * pricePerOrder[index];
                showRichTextBox.Text += "Customer Name: " + customerName[index] + "\n" + "Contact No.: " + contactNo[index] + "\n" +
                    "Address: " + address[index] + "\n" + "Odered item: " + orderCombo[index] + "\n" + "Quantity: " + quantity[index] + 
                    "\n" + "Price Per " + orderCombo[index] + ": " + pricePerOrder[index] + "\n" + "Total Price: " + totalPrice[index] + "\n" + "\n";
            }
            else if (orderComboBox.Text == "Cold Coffee") {
                totalPrice[index] = quantity[index] * pricePerOrder[index];
                showRichTextBox.Text += "Customer Name: " + customerName[index] + "\n" + "Contact No.: " + contactNo[index] + "\n" +
                    "Address: " + address[index] + "\n" + "Odered item: " + orderCombo[index] + "\n" + "Quantity: " + quantity[index] +
                    "\n" + "Price Per " + orderCombo[index] + ": " + pricePerOrder[index] + "\n" + "Total Price: " + totalPrice[index] + "\n" + "\n";
            }
            else if (orderComboBox.Text == "Hot Coffee") {
                totalPrice[index] = quantity[index] * pricePerOrder[index];
                showRichTextBox.Text += "Customer Name: " + customerName[index] + "\n" + "Contact No.: " + contactNo[index] + "\n" +
                    "Address: " + address[index] + "\n" + "Odered item: " + orderCombo[index] + "\n" + "Quantity: " + quantity[index] +
                    "\n" + "Price Per " + orderCombo[index] + ": " + pricePerOrder[index] + "\n" + "Total Price: " + totalPrice[index] + "\n" + "\n";
            }
            else if (orderComboBox.Text == "Regular Coffee") {
                totalPrice[index] = quantity[index] * pricePerOrder[index];
                showRichTextBox.Text += "Customer Name: " + customerName[index] + "\n" + "Contact No.: " + contactNo[index] + "\n" +
                    "Address: " + address[index] + "\n" + "Odered item: " + orderCombo[index] + "\n" + "Quantity: " + quantity[index] +
                    "\n" + "Price Per " + orderCombo[index] + ": " + pricePerOrder[index] + "\n" + "Total Price: " + totalPrice[index] + "\n" + "\n";
            }

            index++;

            //string customerName, contactNo, address;
            //int quantity;
            //float pricePerOrder, totalPrice;

                //customerName = nameTB.Text;
                //contactNo = contactTB.Text;
                //address = addressTB.Text;
                //quantity = Convert.ToInt32(quantityTB.Text);
                //pricePerOrder = Convert.ToInt32(priceTB.Text);

                //if(quantityTB.Text == " ")
                //{
                //    MessageBox.Show("Insert a quantity");
                //}
                //if(orderComboBox.Text == null)
                //{
                //    MessageBox.Show("Selct item");
                //}
                //else if(orderComboBox.Text == "Black Coffee")
                //{
                //    totalPrice = quantity * pricePerOrder;
                //    showRichTextBox.Text = "Customer Name: " + customerName + "\n" + "Contact No.: " + contactNo + "\n" + 
                //        "Address: " + address + "\n" + "Odered item: " + orderComboBox.Text + "\n" + "Quantity: " + quantity + 
                //        "\n" + "Price Per " + orderComboBox.Text + ": " + pricePerOrder + "\n" + "Total Price: " + totalPrice;
                //}
                //else if (orderComboBox.Text == "Cold Coffee")
                //{
                //    totalPrice = quantity * pricePerOrder;
                //    showRichTextBox.Text = "Customer Name: " + customerName + "\n" + "Contact No.: " + contactNo + "\n" +
                //        "Address: " + address + "\n" + "Odered item: " + orderComboBox.Text + "\n" + "Quantity: " + quantity +
                //        "\n" + "Price Per " + orderComboBox.Text + ": " + pricePerOrder + "\n" + "Total Price: " + totalPrice;
                //}
                //else if (orderComboBox.Text == "Hot Coffee")
                //{
                //    totalPrice = quantity * pricePerOrder;
                //    showRichTextBox.Text = "Customer Name: " + customerName + "\n" + "Contact No.: " + contactNo + "\n" +
                //        "Address: " + address + "\n" + "Odered item: " + orderComboBox.Text + "\n" + "Quantity: " + quantity +
                //        "\n" + "Price Per " + orderComboBox.Text + ": " + pricePerOrder + "\n" + "Total Price: " + totalPrice;
                //}
                //else if (orderComboBox.Text == "Regular Coffee")
                //{
                //    totalPrice = quantity * pricePerOrder;
                //    showRichTextBox.Text = "Customer Name: " + customerName + "\n" + "Contact No.: " + contactNo + "\n" +
                //        "Address: " + address + "\n" + "Odered item: " + orderComboBox.Text + "\n" + "Quantity: " + quantity +
                //        "\n" + "Price Per " + orderComboBox.Text + ": " + pricePerOrder + "\n" + "Total Price: " + totalPrice;
                //}
        }
    }
}
