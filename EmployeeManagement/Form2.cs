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
    public partial class Form2 : Form
    {
        Functions Con;
        public Form2()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmp();
            GetDepartment();
        }


        private void ShowEmp()
        {
            string Query = "Select * from EmployeeTbl";
            EmpList.DataSource = Con.GetData(Query);
        }

        private void GetDepartment()
        {
            string Query = "Select * from DepartTbl";
            EmpDepartment.DisplayMember = Con.GetData(Query).Columns["DepName"].ToString();
            EmpDepartment.ValueMember = Con.GetData(Query).Columns["DepId"].ToString();
            EmpDepartment.DataSource = Con.GetData(Query);
        }
       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
