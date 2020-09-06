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
    public partial class RoomsForm : Form
    {
        RoomsClass c = new RoomsClass();
        public RoomsForm()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string bname = comboBoxBuildingName.Text;
            string rname = textBoxRoomName.Text;
            if (bname == "" || rname == "")
            {
                MessageBox.Show("Empty Fields !", "ERROR");
            }
            else
            {
                //get values from input fields
                c.BuildingName = bname;
                c.RoomName = rname;

                //Insert data into database using method in class
                bool success = c.Insert(c);

                if (success == true)
                {
                    MessageBox.Show("New Room Inserted");
                }
                else
                {
                    MessageBox.Show("Faild to Insert Room");
                }

                //load data on data gridview
                DataTable dt = c.Select();
                dataGridViewRoomDetails.DataSource = dt;
            }
           
        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {
            //load data on data gridview
            DataTable dt = c.Select();
            dataGridViewRoomDetails.DataSource = dt;

            //Fill Combobox with Building Names
            //Databse Connection
            string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            //Step1 - database connection
            
            SqlConnection conn = new SqlConnection(constring);
            
            
            conn.Open();
            //SQL update in database
            string sql = "SELECT BuildingName FROM Table_Buildings ORDER BY BuildingID desc";

            //Creating SQL Command 
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                comboBoxBuildingName.Items.Add(dr["BuildingName"].ToString());
            }
            conn.Close();

        }

        private void dataGridViewRoomDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data
            int rowIndex = e.RowIndex;
            textBoxRoomID.Text = dataGridViewRoomDetails.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxBuildingName.Text = dataGridViewRoomDetails.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxRoomName.Text = dataGridViewRoomDetails.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            string rid = textBoxRoomID.Text;
            if (rid == "")
            {
                MessageBox.Show("Item Not Selected !", "ERROR");
            }
            else
            {
                //get values from input fields
                c.RoomID = Convert.ToInt32(rid);
                c.BuildingName = comboBoxBuildingName.Text;
                c.RoomName = textBoxRoomName.Text;

                bool success = c.Update(c);
                if (success == true)
                {
                    MessageBox.Show("Building Name Updated Successfully");
                    //load data on data gridview
                    DataTable dt = c.Select();
                    dataGridViewRoomDetails.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Faild to Update Building");
                }
            }
           
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            string rid = textBoxRoomID.Text;
            if (rid == "")
            {
                MessageBox.Show("Item Not Selected !", "ERROR");
            }
            else
            {
                c.RoomID = Convert.ToInt32(rid);
                if (MessageBox.Show("Do You Want to Delete Item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool success = c.Delete(c);

                    if (success == true)
                    {
                        MessageBox.Show("Room Name Deleted Successfully");
                        //load data on data gridview
                        DataTable dt = c.Select();
                        dataGridViewRoomDetails.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Faild to Delete Room");
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
