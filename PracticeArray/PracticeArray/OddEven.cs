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
    public partial class OddEven : Form
    {
        int s = 0;
        public OddEven()
        {
            InitializeComponent();
        }

        private void addElementBtn_Click(object sender, EventArgs e)
        {
            s = Convert.ToInt32(elementTB.Text);
            elementTB.Text = "";
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (s % 2 == 0)
            {
                checkTB.Text = s + " is Even";
            }
            else
            {
                checkTB.Text = s + " is Odd";
            }
        }
    }
}
