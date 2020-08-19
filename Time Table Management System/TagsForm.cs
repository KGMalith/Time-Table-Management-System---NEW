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
    public partial class TagsForm : Form
    {
        public TagsForm()
        {
            InitializeComponent();
        }
        TagClass c = new TagClass();

        private void TagsForm_Load(object sender, EventArgs e)
        {
            //load data on data gridview
            DataTable dt = c.Select();
            dataGridViewTagDetails.DataSource = dt;
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            //get values from input fields
            c.TagName = textBoxTagName.Text;

            //Insert data into database using method in class
            bool success = c.Insert(c);

            if (success == true)
            {
                MessageBox.Show("New Tag Inserted");
                //load data on data gridview
                DataTable dt = c.Select();
                dataGridViewTagDetails.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Faild to Insert Tag");
            }
        }

        private void btnUpdateTag_Click(object sender, EventArgs e)
        {
            //get values from input fields
            c.TagID = Convert.ToInt32(textBoxTagID.Text);
            c.TagName = textBoxTagName.Text;

            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Tag Details Updated Successfully");
                //load data on data gridview
                DataTable dt = c.Select();
                dataGridViewTagDetails.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Faild to Update Tag Details");
            }
        }

        private void btnDeleteTag_Click(object sender, EventArgs e)
        {
            c.TagID = Convert.ToInt32(textBoxTagID.Text);
            if (MessageBox.Show("Do You Want to Delete Item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool success = c.Delete(c);

                if (success == true)
                {
                    MessageBox.Show("Tag Details Deleted Successfully");
                    //load data on data gridview
                    DataTable dt = c.Select();
                    dataGridViewTagDetails.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Faild to Delete Tag Details");
                }
            }
            else
            {
                MessageBox.Show("Item Not Deleted", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewTagDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data
            int rowIndex = e.RowIndex;
            textBoxTagID.Text = dataGridViewTagDetails.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxTagName.Text = dataGridViewTagDetails.Rows[rowIndex].Cells[1].Value.ToString();
        }
    }
}
