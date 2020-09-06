using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Classes;

namespace Time_Table_Management_System
{
    public partial class GenerateSubGroupIDForm : Form
    {
        SubGroupIDClass c = new SubGroupIDClass();
        public GenerateSubGroupIDForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GenerateSubGroupIDForm_Load(object sender, EventArgs e)
        {
            //load data on data gridview
            DataTable dt = c.Select();
            dataGridViewSubGroupID.DataSource = dt;

            //Fill Combobox with GroupID,Sub Group Number
            //Databse Connection
            string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            //Step1 - database connection
            SqlConnection conn = new SqlConnection(constring);

            conn.Open();
            //SQL update in database
            string sql = "SELECT GeneratedGroupID FROM Table_GroupID ORDER BY GroupID desc";

            //Creating SQL Command 
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.ExecuteNonQuery();
            dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxGroupID.Items.Add(dr["GeneratedGroupID"].ToString());
            }
            conn.Close();

            conn.Open();
            //SQL update in database
            string sql2 = "SELECT SubGroupNumber FROM Table_SubGroupNumbers ORDER BY SubGroupID desc";

            //Creating SQL Command 
            SqlCommand cmd2 = new SqlCommand(sql2, conn);

            cmd2.ExecuteNonQuery();
            dt = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            adapter2.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxSubGroupNumber.Items.Add(dr["SubGroupNumber"].ToString());
            }
            conn.Close();
        }

        private void btnAddSubGroupID_Click(object sender, EventArgs e)
        {
            //get values from input fields
            string GroupID = comboBoxGroupID.Text;
            string SubGroupNum = comboBoxSubGroupNumber.Text;

            if (GroupID == "" || SubGroupNum == "")
            {
                MessageBox.Show("Empty Fields !", "ERROR");
            }
            else
            {
                string value = GroupID + "." + SubGroupNum;
                c.GeneratedSubGroupID = value;
                //Insert data into database using method in class
                bool success = c.Insert(c);

                if (success == true)
                {
                    MessageBox.Show("New Sub GroupID Inserted");
                    //load data on data gridview
                    DataTable dt = c.Select();
                    dataGridViewSubGroupID.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Faild to Insert New Sub Group ID");
                }
            }
        }

        private void btnDeleteSubGroupID_Click(object sender, EventArgs e)
        {
            string value = textBoxSubGroupID.Text;
            if (value == "")
            {
                MessageBox.Show("Item Not Selected !", "ERROR");
            }
            else
            {
                c.GroupID = Convert.ToInt32(value);
                if (MessageBox.Show("Do You Want to Delete Item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool success = c.Delete(c);

                    if (success == true)
                    {
                        MessageBox.Show("Sub GroupID Deleted Successfully");
                        //load data on data gridview
                        DataTable dt = c.Select();
                        dataGridViewSubGroupID.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Faild to Delete Sub GroupID");
                    }
                }
                else
                {
                    MessageBox.Show("Item Not Deleted", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridViewSubGroupID_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data
            int rowIndex = e.RowIndex;
            textBoxSubGroupID.Text = dataGridViewSubGroupID.Rows[rowIndex].Cells[0].Value.ToString();
        }
    }
}
