using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormApp
{
    public partial class DatatypeUI : Form
    {
        public DatatypeUI()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            //int age = 0;
            //string name = "asad";
            //double salary = 500.50;
            //bool isDone = true;

            //string name = "ali";
            //int firstNumber = 10;
            //int secondNumber = firstNumber;
            //double thirdNumber = firstNumber;

            //secondNumber = (int)thirdNumber;
            //secondNumber = Convert.ToInt32(thirdNumber);

            //name = Convert.ToString(secondNumber);
            //name = secondNumber.ToString();

            if(itemComboBox.Text == "Items")
            {
                MessageBox.Show("Select item");
            }
            else
            {
                MessageBox.Show(itemComboBox.Text + " is selected");
            }
        }
    }
}
