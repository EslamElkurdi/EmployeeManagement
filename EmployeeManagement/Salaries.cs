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
    public partial class Salaries : Form
    {

        Functions Con;
        public Salaries()
        {
            
            InitializeComponent();
            Con = new Functions();
            ShowSalary();
            GetEmp();
        }

        private void GetEmp()
        {
            string Query = "select * from EmployeeTb1";
            CbEmployee.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
            CbEmployee.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
            CbEmployee.DataSource = Con.GetData(Query);
        }

        private void ShowSalary()
        {
            try
            {
                string Query = "Select * from SalaryTb1";
                listSalary.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                
            }

        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (CbEmployee.SelectedIndex == -1 || DayTb.Text == "" || PeriodTb.Text == "")
            //    {
            //        MessageBox.Show("Missing Data!!!");
            //    }
            //    else
            //    {
            //        period = PeriodTb.Value.Date.Month.ToString() + "-" + PeriodTb.Value.Date.Year.ToString();
            //        int Amount = DSal * Convert.ToInt32(DayTb.Text);
            //        int Days = Convert.ToInt32(DayTb.Text);
            //        string Query = "insert into SalaryTbl values ({0},{1},'{2}',{3},'{4}')";
            //        Query = string.Format(Query, EmpCb.SelectedValue.ToString(), Days, period, Amount, DateTime.Today.Date);
            //        Con.SetData(Query);
            //        ShowSalary();
            //        MessageBox.Show("Salary Paid");
            //        DayTb.Text = "";

            //    }

            //}
            //catch (Exception Ex)
            //{
            //    MessageBox.Show(Ex.Message);
            //}

        

    }
}
}
