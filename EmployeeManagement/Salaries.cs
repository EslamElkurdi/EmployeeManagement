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

        int DSal = 0;
        string period = "";


        private void GetSal()
        {
            string Query = "select * from EmployeeTb1 where EmpId = {0}";
            Query = string.Format(Query, CbEmployee.SelectedValue.ToString());
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                DSal = Convert.ToInt32(dr["EmpSal"].ToString());
            }

            if (DayAttend.Text == "")
            {
                salaryAmount.Text = "Rs  " + (d * DSal);
            }
            else if (Convert.ToInt32(DayAttend.Text) > 31)
            {
                MessageBox.Show("Days Can Not be Greater than 31");
            }
            else
            {
                d = Convert.ToInt32(DayAttend.Text);
                salaryAmount.Text = "Rs  " + (d * DSal);
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

        int d = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (CbEmployee.SelectedIndex == -1 || DayAttend.Text == "" || salaryAmount.Text == "")
                {
                    MessageBox.Show("missing data!!!");
                }
                else
                {
                    period = PeriodDate.Value.Date.Month.ToString() + "-" + PeriodDate.Value.Date.Year.ToString();
                    int amount = DSal * Convert.ToInt32(DayAttend.Text);
                    int days = Convert.ToInt32(DayAttend.Text);
                    string query = "insert into SalaryTb1 values ({0},{1},'{2}',{3},'{4}')";
                    query = string.Format(query, CbEmployee.SelectedValue.ToString(), days, period, amount, DateTime.Today.Date);
                    Con.SetData(query);
                    ShowSalary();
                    MessageBox.Show("salary paid");
                    DayAttend.Text = "";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void periodTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSal();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Department obj = new Department();
            obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Salaries obj = new Salaries();
            obj.Show();
            this.Hide();
        }
    }
}
