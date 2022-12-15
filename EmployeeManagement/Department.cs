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
                DepList.DataSource = con.GetData(Query);


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



    }
}
