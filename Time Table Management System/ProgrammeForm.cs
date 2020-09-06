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
    public partial class ProgrammeForm : Form
    {
        public ProgrammeForm()
        {
            InitializeComponent();
        }
        ProgrammeClass c = new ProgrammeClass();

        private void btnAddProgramme_Click(object sender, EventArgs e)
        {
            string pname = textBoxProgrammeName.Text;
            if (pname == "")
            {
                MessageBox.Show("Empty Fields !", "ERROR");
            }
            else
            {
                //get values from input fields
                c.ProgrammeName = pname;

                //Insert data into database using method in class
                bool success = c.Insert(c);

                if (success == true)
                {
                    MessageBox.Show("New Programme Inserted");
                    //load data on data gridview
                    DataTable dt = c.Select();
                    dataGridViewProgrammes.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Faild to Insert Programme");
                }
            }
           
        }

        private void btnUpdateProgramme_Click(object sender, EventArgs e)
        {
            string pid = textBoxProgrammeID.Text;
            if (pid == "")
            {
                MessageBox.Show("Item Not Selected !", "ERROR");
            }
            else
            {
                //get values from input fields
                c.ProgrammeID = Convert.ToInt32(pid);
                c.ProgrammeName = textBoxProgrammeName.Text;

                bool success = c.Update(c);
                if (success == true)
                {
                    MessageBox.Show("Programme Details Updated Successfully");
                    //load data on data gridview
                    DataTable dt = c.Select();
                    dataGridViewProgrammes.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Faild to Update Programme Details");
                }
            }
           
        }

        private void btnDeleteProgramme_Click(object sender, EventArgs e)
        {
            string pid = textBoxProgrammeID.Text;
            if (pid == "")
            {
                MessageBox.Show("Item Not Selected !", "ERROR");
            }
            else
            {
                c.ProgrammeID = Convert.ToInt32(pid);
                if (MessageBox.Show("Do You Want to Delete Item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool success = c.Delete(c);

                    if (success == true)
                    {
                        MessageBox.Show("Programme Details Deleted Successfully");
                        //load data on data gridview
                        DataTable dt = c.Select();
                        dataGridViewProgrammes.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Faild to Delete Programme Details");
                    }
                }
                else
                {
                    MessageBox.Show("Item Not Deleted", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void ProgrammeForm_Load(object sender, EventArgs e)
        {
            //load data on data gridview
            DataTable dt = c.Select();
            dataGridViewProgrammes.DataSource = dt;
        }

        private void dataGridViewProgrammes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data
            int rowIndex = e.RowIndex;
            textBoxProgrammeID.Text = dataGridViewProgrammes.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxProgrammeName.Text = dataGridViewProgrammes.Rows[rowIndex].Cells[1].Value.ToString();
        }
    }
}
