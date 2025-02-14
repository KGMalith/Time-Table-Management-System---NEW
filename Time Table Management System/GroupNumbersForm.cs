﻿using System;
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
    public partial class GroupNumbersForm : Form
    {
        public GroupNumbersForm()
        {
            InitializeComponent();
        }
        GroupNumbersClass c = new GroupNumbersClass();
        private void GroupNumbersForm_Load(object sender, EventArgs e)
        {
            //load data on data gridview
            DataTable dt = c.Select();
            dataGridViewGroupNumber.DataSource = dt;
        }

        private void btnAddGroupNumber_Click(object sender, EventArgs e)
        {
            string value = textBoxGroupNumber.Text;

            if(value == "")
            {
                MessageBox.Show("Empty Fields !", "ERROR");
            }
            else
            {
                //get values from input fields
                c.GroupNumbers = value;

                //Insert data into database using method in class
                bool success = c.Insert(c);

                if (success == true)
                {
                    MessageBox.Show("New Group Number Inserted");
                    //load data on data gridview
                    DataTable dt = c.Select();
                    dataGridViewGroupNumber.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Faild to Insert GroupNumber");
                }
            }
          
        }

        private void btnUpdateGroupNumber_Click(object sender, EventArgs e)
        {
            string groupNoID = textBoxGroupNumberID.Text;
            if (groupNoID == "")
            {
                MessageBox.Show("Item Not Selected !", "ERROR");
            }
            else
            {
                //get values from input fields
                c.GroupNumbersID = Convert.ToInt32(groupNoID);
                c.GroupNumbers = textBoxGroupNumber.Text;

                bool success = c.Update(c);
                if (success == true)
                {
                    MessageBox.Show("Group Number Details Updated Successfully");
                    //load data on data gridview
                    DataTable dt = c.Select();
                    dataGridViewGroupNumber.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Faild to Update Group Number Details");
                }
            }
            
        }

        private void btnDeleteGroupNumber_Click(object sender, EventArgs e)
        {
            string groupNoID = textBoxGroupNumberID.Text;
            if (groupNoID == "")
            {
                MessageBox.Show("Item Not Selected !", "ERROR");
            }
            else
            {
                c.GroupNumbersID = Convert.ToInt32(groupNoID);
                if (MessageBox.Show("Do You Want to Delete Item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool success = c.Delete(c);

                    if (success == true)
                    {
                        MessageBox.Show("Group Number Details Deleted Successfully");
                        //load data on data gridview
                        DataTable dt = c.Select();
                        dataGridViewGroupNumber.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Faild to Delete Group Number Details");
                    }
                }
                else
                {
                    MessageBox.Show("Item Not Deleted", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void dataGridViewGroupNumber_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data
            int rowIndex = e.RowIndex;
            textBoxGroupNumberID.Text = dataGridViewGroupNumber.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxGroupNumber.Text = dataGridViewGroupNumber.Rows[rowIndex].Cells[1].Value.ToString();
        }

        private void textBoxGroupNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Enter Numbers Only!", "ERROR");
            }
        }
    }
}
