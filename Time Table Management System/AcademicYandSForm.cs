using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Classes;

namespace Time_Table_Management_System
{
    public partial class AcademicYandSForm : Form
    {
        YearandSemesterClass c = new YearandSemesterClass();
        public AcademicYandSForm()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void AcademicYandSForm_Load(object sender, EventArgs e)
        {
            //Load Data on data grid View
            DataTable dt = c.Select();
            dataGridViewAcademicYearandSem.DataSource = dt;
        }

        private void btnAddYearandSemester_Click(object sender, EventArgs e)
        {
            //get values from input fields
            c.YearandSemester = textBoxYearandSemester.Text;

            //Insert data into database using method in class
            bool success = c.Insert(c);

            if (success == true)
            {
                MessageBox.Show("New Year and Semester Inserted");
                //load data on data gridview
                DataTable dt = c.Select();
                dataGridViewAcademicYearandSem.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Faild to Insert Year and Semester");
            }
        }

        private void btnUpdateYearandSemester_Click(object sender, EventArgs e)
        {
            //get values from input fields
            c.YearandSemesterID = Convert.ToInt32(textBoxYearandSemesterID.Text);
            c.YearandSemester = textBoxYearandSemester.Text;

            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Tag Details Updated Successfully");
                //load data on data gridview
                DataTable dt = c.Select();
                dataGridViewAcademicYearandSem.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Faild to Update Tag Details");
            }
        }

        private void btnDeleteYearandSemester_Click(object sender, EventArgs e)
        {
            c.YearandSemesterID = Convert.ToInt32(textBoxYearandSemesterID.Text);
            if (MessageBox.Show("Do You Want to Delete Item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool success = c.Delete(c);

                if (success == true)
                {
                    MessageBox.Show("Year and Semester Details Deleted Successfully");
                    //load data on data gridview
                    DataTable dt = c.Select();
                    dataGridViewAcademicYearandSem.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Faild to Delete Year and Semester Details");
                }
            }
            else
            {
                MessageBox.Show("Item Not Deleted", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewAcademicYearandSem_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data
            int rowIndex = e.RowIndex;
            textBoxYearandSemesterID.Text = dataGridViewAcademicYearandSem.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxYearandSemester.Text = dataGridViewAcademicYearandSem.Rows[rowIndex].Cells[1].Value.ToString();
        }
    }
}
