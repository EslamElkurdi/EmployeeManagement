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
            string Query = "Select * from EmployeeTb1";
            EmpList.DataSource = Con.GetData(Query);
        }

        private void GetDepartment()
        {
            string Query = "Select * from DepartmentTb1";
            EmpDepartment.DisplayMember = Con.GetData(Query).Columns["DepName"].ToString();
            EmpDepartment.ValueMember = Con.GetData(Query).Columns["DepId"].ToString();
            EmpDepartment.DataSource = Con.GetData(Query);
        }
        public void clear()
        {
            EmpName.Text = "";
            EmpGender.SelectedIndex = -1;
            EmpDepartment.SelectedIndex = -1;
            EmpSalary.Text = "";
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
            try
            {
                if (EmpName.Text == "" || EmpGender.SelectedIndex == -1 || EmpDepartment.SelectedIndex == -1 || EmpSalary.Text == "")
                {
                    MessageBox.Show("Missing data");
                }
                else
                {
                    string Emp = EmpName.Text;
                    string Gen = EmpGender.SelectedItem.ToString();
                    string Dep = EmpDepartment.SelectedValue.ToString();
                    string DDb = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string jDate = dateTimePickerJoin.Value.ToString("yyyy-MM-dd");
                    int Salary = Convert.ToInt32(EmpSalary.Text);
                    string Query = "insert into EmployeeTbl values ('{0}','{1}','{2}','{3}','{4}','{5}')";
                    Query = string.Format(Query, Emp, Gen, Dep, DDb, jDate, Salary);
                    Con.SetData(Query);
                    MessageBox.Show("Added...");
                    ShowEmp();
                    clear();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EmpName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpName.Text == "" || EmpGender.SelectedIndex == -1 || EmpDepartment.SelectedIndex == -1 || EmpSalary.Text == "")
                {
                    MessageBox.Show("Missing data");
                }
                else
                {
                    string Emp = EmpName.Text;
                    string Gen = EmpGender.SelectedItem.ToString();
                    string Dep = EmpDepartment.SelectedValue.ToString();
                    string DDb = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string jDate = dateTimePickerJoin.Value.ToString("yyyy-MM-dd");
                    int Salary = Convert.ToInt32(EmpSalary.Text);
                    string Query = "Update into EmployeeTbl set EmpName ='{0}', EmpGen ='{1}',EmpDep ='{2}', EmpDDB='{3}',EmpJDate='{4}',EmpSal='{5}'where key={6}";
                    Query = string.Format(Query, Emp, Gen, Dep, DDb, jDate, Salary, key);
                    Con.SetData(Query);
                    MessageBox.Show("Updated...");
                    ShowEmp();
                    clear();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int key = 0;
        private void EmpList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpName.Text = EmpList.SelectedRows[0].Cells[1].Value.ToString();
            EmpGender.Text = EmpList.SelectedRows[0].Cells[2].Value.ToString();
            EmpDepartment.SelectedValue = EmpList.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker1.Text = EmpList.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePickerJoin.Text = EmpList.SelectedRows[0].Cells[5].Value.ToString();
            EmpSalary.Text = EmpList.SelectedRows[0].Cells[6].Value.ToString();
            if (EmpName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmpList.SelectedRows[0].Cells[0].Value.ToString());
            }

        }
    }
}
