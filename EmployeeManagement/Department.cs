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
            ListDepartment();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void ListDepartment()
        {
            try {

                string Query = "select * from DepartmentTb1";
                DepList.DataSource = con.GetData(Query);


            } catch (Exception ex) {

                MessageBox.Show(ex.ToString());

            }
            

        }

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
                    ListDepartment();
                    MessageBox.Show("Added Item!!");
                    DepNameTb.Text = "";

                }
            }
            catch (Exception Ex) {

                MessageBox.Show(Ex.Message);
            }

        }



    }
}
