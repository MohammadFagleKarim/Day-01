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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text, seid = seidTB.Text, phone = phoneTB.Text;
            MessageBox.Show("Hello ! " + "Name:" + name + "\n" + "SEID: " + seid + "\n" + "Phone: " + phone);
            showLabel.Text = "Name:" + name + "\n" + "SEID: " + seid + "\n" + "Phone: " + phone;
            
        }
    }
}
