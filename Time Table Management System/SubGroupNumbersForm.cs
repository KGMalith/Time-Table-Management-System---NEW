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
    public partial class SubGroupNumbersForm : Form
    {
        public SubGroupNumbersForm()
        {
            InitializeComponent();
        }
        SubgroupNumberClass c = new SubgroupNumberClass();
        private void SubGroupNumbersForm_Load(object sender, EventArgs e)
        {
            //load data on data gridview
            DataTable dt = c.Select();
            dataGridViewSubGroupNumber.DataSource = dt;
        }

        private void btnAddSubGroupNumber_Click(object sender, EventArgs e)
        {
            //get values from input fields
            c.SubGroupNumber = textBoxSubgroupNumber.Text;

            //Insert data into database using method in class
            bool success = c.Insert(c);

            if (success == true)
            {
                MessageBox.Show("New Sub Group Number Inserted");
                //load data on data gridview
                DataTable dt = c.Select();
                dataGridViewSubGroupNumber.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Faild to Insert Sub Group Number");
            }
        }

        private void btnUpdateSubgroupNumber_Click(object sender, EventArgs e)
        {
            //get values from input fields
            c.SubGroupID = Convert.ToInt32(textBoxSubgroupID.Text);
            c.SubGroupNumber = textBoxSubgroupNumber.Text;

            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Sub Group Number Details Updated Successfully");
                //load data on data gridview
                DataTable dt = c.Select();
                dataGridViewSubGroupNumber.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Faild to Update Sub Group Number Details");
            }
        }

        private void btnDeleteSubGroupNumber_Click(object sender, EventArgs e)
        {
            c.SubGroupID = Convert.ToInt32(textBoxSubgroupID.Text);
            if (MessageBox.Show("Do You Want to Delete Item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool success = c.Delete(c);

                if (success == true)
                {
                    MessageBox.Show("Sub Group Number Details Deleted Successfully");
                    //load data on data gridview
                    DataTable dt = c.Select();
                    dataGridViewSubGroupNumber.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Faild to Delete Sub Group Number Details");
                }
            }
            else
            {
                MessageBox.Show("Item Not Deleted", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewSubGroupNumber_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data
            int rowIndex = e.RowIndex;
            textBoxSubgroupID.Text = dataGridViewSubGroupNumber.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxSubgroupNumber.Text = dataGridViewSubGroupNumber.Rows[rowIndex].Cells[1].Value.ToString();
        }
    }
}
