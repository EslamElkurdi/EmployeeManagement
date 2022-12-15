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
    public partial class Department : Form
    {
        Functions con;
        public Department()
        {
            InitializeComponent();
            con = new Functions();
            ShowListDepartment();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }




        int key = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing data");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Update DepartmentTb1 set DepName = '{0}' where DepId = {1}";
                    Query = string.Format(Query, DepNameTb.Text, key);
                    con.SetData(Query);
                    ShowListDepartment();
                    MessageBox.Show("Updated...");
                    //clear();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        




        private void ShowListDepartment()
        {
            try {

                string Query = "select * from DepartmentTb1";
                guna2DataGridView1.DataSource = con.GetData(Query);


            } catch (Exception ex) {

                MessageBox.Show(ex.ToString());

            }


            

        }

        // Create Add button Code in Department

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!");
                }
                else {
                    string Dep = DepNameTb.Text;
                    string Query = "insert into DepartmentTb1 values ('{0}')";
                    Query = String.Format(Query,DepNameTb.Text);
                    con.SetData(Query);
                    ShowListDepartment();
                    MessageBox.Show("Added Item!!");
                    DepNameTb.Text = "";

                }
            }
            catch (Exception Ex) {

                MessageBox.Show(Ex.Message);
            }

        }


        int Key = 0;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DepNameTb.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (DepNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Salaries obj = new Salaries();
            obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }
    }
}
