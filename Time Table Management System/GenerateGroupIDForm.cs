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
    public partial class GenerateGroupIDForm : Form
    {
        GroupIDClass c = new GroupIDClass();
        public GenerateGroupIDForm()
        {
            InitializeComponent();
        }

        private void dataGridViewRoomDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GenerateGroupIDForm_Load(object sender, EventArgs e)
        {
            //load data on data gridview
            DataTable dt = c.Select();
            dataGridViewGroupID.DataSource = dt;

            //Fill Combobox with YearandSemester,Programme,GroupNumber
            //Databse Connection
            string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            //Step1 - database connection

            SqlConnection conn = new SqlConnection(constring);


            conn.Open();
            //SQL update in database
            string sql = "SELECT YearandSemester FROM Table_YearandSemester ORDER BY YearandSemesterID desc";

            //Creating SQL Command 
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.ExecuteNonQuery();
            dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxYearandSemester.Items.Add(dr["YearandSemester"].ToString());
            }
            conn.Close();

            conn.Open();
            //SQL update in database
            string sql2 = "SELECT ProgrammeName FROM Table_Programmes ORDER BY ProgrammeID desc";

            //Creating SQL Command 
            SqlCommand cmd2 = new SqlCommand(sql2, conn);

            cmd2.ExecuteNonQuery();
            dt = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            adapter2.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxProgramme.Items.Add(dr["ProgrammeName"].ToString());
            }
            conn.Close();

            conn.Open();
            //SQL update in database
            string sql3 = "SELECT GroupNumbers FROM Table_GroupNumbers ORDER BY GroupNumbersID desc";

            //Creating SQL Command 
            SqlCommand cmd3 = new SqlCommand(sql3, conn);

            cmd2.ExecuteNonQuery();
            dt = new DataTable();
            SqlDataAdapter adapter3 = new SqlDataAdapter(cmd3);
            adapter3.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxGroupNumber.Items.Add(dr["GroupNumbers"].ToString());
            }
            conn.Close();
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            //get values from input fields
            string YandS = comboBoxYearandSemester.Text;
            string Program = comboBoxProgramme.Text;
            string GNumber = comboBoxGroupNumber.Text;


            if (YandS == "" || Program == "" || GNumber == "")
            {
                MessageBox.Show("Empty Fields !", "ERROR");
            }
            else
            {
                string value = YandS + "." + Program + "." + GNumber;
                c.GeneratedGroupID = value;
                //Insert data into database using method in class
                bool success = c.Insert(c);

                if (success == true)
                {
                    MessageBox.Show("New GroupID Inserted");
                    //load data on data gridview
                    DataTable dt = c.Select();
                    dataGridViewGroupID.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Faild to Insert New Group ID");
                }
            }
           
        }

        private void btnDeleteecturer_Click(object sender, EventArgs e)
        {
            string value = textBoxGroupID.Text;
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
                        MessageBox.Show("GroupID Deleted Successfully");
                        //load data on data gridview
                        DataTable dt = c.Select();
                        dataGridViewGroupID.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Faild to Delete GroupID");
                    }
                }
                else
                {
                    MessageBox.Show("Item Not Deleted", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void dataGridViewGroupID_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data
            int rowIndex = e.RowIndex;
            textBoxGroupID.Text = dataGridViewGroupID.Rows[rowIndex].Cells[0].Value.ToString();
        }
    }
}
