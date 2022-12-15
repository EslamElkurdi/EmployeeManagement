using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else if (textBox1.Text == "Abdo" && textBox2.Text == "Abdo")
            {
                Form2 obj = new Form2();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorect Username Or Password");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
