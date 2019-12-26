using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeArray
{
    public partial class Reverse : Form
    {
        int size = 0, index = 0;
        int[] arr = new int[10];
        int[] arrReverse = new int[10];
        public Reverse()
        {
            InitializeComponent();
        }

        private void addSizeBtn_Click(object sender, EventArgs e)
        {
            if (size < 10)
                size = Convert.ToInt32(sizeTB.Text);
            else
                MessageBox.Show("Size cannot be more than 10.");
        }

        private void showReverseBtn_Click(object sender, EventArgs e)
        {
            showRichTextBox.Text = "\n" + "The reversed array elements are: ";
            for (int j = size-1; j>=0; j--)
            {
                showRichTextBox.Text += arr[j] + " ";
            }
        }

        private void showElementsBtn_Click(object sender, EventArgs e)
        {
            showRichTextBox.Text = "The inserted elements are: ";
            for (int i = 0; i < size; i++)
            {
                arrReverse[i] = arr[i];
                showRichTextBox.Text += arrReverse[i] + " ";
            }
        }

        private void addElementBtn_Click(object sender, EventArgs e)
        {
            if (index < size)
            {
                arr[index] = Convert.ToInt32(elementTB.Text);
                index++;
            }
            else
                MessageBox.Show("Cannoy insert more than " +size + " elements.");
        }
    }
}
