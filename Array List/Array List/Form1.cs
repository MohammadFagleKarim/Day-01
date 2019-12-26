using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_List
{
    public partial class Form1 : Form
    {
        List<string> names = new List<string> { "Asif" };
        List<int> ages = new List<int> { 25 };

        public Form1()
        {
            InitializeComponent();
        }

        private void ShowCustomer()
        {
            //string message = "";
            //foreach (string name in names)
            //{
            //    message += "Name: " + name + "\n";
            //}
            //nameTB.Text = "";
            //MessageBox.Show(message);

            string message = "";
            for (int i = 0; i < names.Count(); i++)
            {
                message += "Name: " + names[i] + " " + "Age: " + ages[i] + "\n";
            }
            nameTB.Text = "";
            MessageBox.Show(message);
        }

        private void AddCustomer(string name, int age)
        {
            names.Add(name);
            ages.Add(age);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //names.Add(nameTB.Text);
            //ages.Add(Convert.ToInt32(ageTB.Text));

            try
            {
                if(!String.IsNullOrEmpty(ageTB.Text))
                {
                    AddCustomer(nameTB.Text, Convert.ToInt32(ageTB.Text));
                }
                else
                {
                    MessageBox.Show("Please enter age.");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            ShowCustomer();
            MessageBox.Show("Sucessfully added");
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            ShowCustomer();
        }
    }
}
