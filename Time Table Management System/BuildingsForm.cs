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
    public partial class BuildingsForm : Form
    {
        public BuildingsForm()
        {
            InitializeComponent();
        }
        BuildingsClass c = new BuildingsClass();
        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            string value = textBoxBuildingName.Text;

            if(value == "")
            {
                MessageBox.Show("Empty Fields !", "ERROR");
            }
            else
            {
                //get values from input fields
                c.BuildingName = value;

                //Insert data into database using method in class
                bool success = c.Insert(c);

                if (success == true)
                {
                    MessageBox.Show("New Building Inserted");
                }
                else
                {
                    MessageBox.Show("Faild to Insert Building");
                }

                //load data on data gridview
                DataTable dt = c.Select();
                dataGridViewBuilding.DataSource = dt;
            }
            
        }

        private void dataGridViewBuilding_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void BuildingsForm_Load(object sender, EventArgs e)
        {
            //load data on data gridview
            DataTable dt = c.Select();
            dataGridViewBuilding.DataSource = dt;
        }

        private void dataGridViewBuilding_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data
            int rowIndex = e.RowIndex;
            textBoxBuildingID.Text = dataGridViewBuilding.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxBuildingName.Text = dataGridViewBuilding.Rows[rowIndex].Cells[1].Value.ToString();
        }

        private void btnUpdateBuilding_Click(object sender, EventArgs e)
        {

            string valueID = textBoxBuildingID.Text;
            if(valueID == "")
            {
                MessageBox.Show("Item Not Selected !", "ERROR");
            }
            else
            {
                //get values from input fields
                c.BuildingID = Convert.ToInt32(valueID);
                c.BuildingName = textBoxBuildingName.Text;

                bool success = c.Update(c);
                if (success == true)
                {
                    MessageBox.Show("Building Name Updated Successfully");
                    //load data on data gridview
                    DataTable dt = c.Select();
                    dataGridViewBuilding.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Faild to Update Building");
                }
            }
           
            
        }

        private void btnDeleteBuilding_Click(object sender, EventArgs e)
        {
            string valueID = textBoxBuildingID.Text;

            if(valueID == "")
            {
                MessageBox.Show("Item Not Selected !", "ERROR");
            }
            else
            {
                c.BuildingID = Convert.ToInt32(valueID);
                if (MessageBox.Show("Do You Want to Delete Item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool success = c.Delete(c);

                    if (success == true)
                    {
                        MessageBox.Show("Building Name Deleted Successfully");
                        //load data on data gridview
                        DataTable dt = c.Select();
                        dataGridViewBuilding.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Faild to Delete Building");
                    }
                }
                else
                {
                    MessageBox.Show("Item Not Deleted", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
    }
}
