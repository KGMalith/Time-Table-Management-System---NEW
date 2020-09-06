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
    public partial class LecturerDetailsForm : Form
    {
        public LecturerDetailsForm()
        {
            InitializeComponent();
        }
        LecturerClass c = new LecturerClass();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LecturerDetailsForm_Load(object sender, EventArgs e)
        {
            //load data on data gridview
            DataTable dt = c.Select();
            dataGridViewLecturerDetails.DataSource = dt;

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
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxLBuilding.Items.Add(dr["BuildingName"].ToString());
            }
            conn.Close();
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            string lecName = textBoxLecturerName.Text;
            string empID = textBoxEmployeeID.Text;
            string faculty = comboBoxFaculty.Text;
            string dept = comboBoxDepartment.Text;
            string center = comboBoxCenter.Text;
            string building = comboBoxLBuilding.Text;
            string level = comboBoxLevel.Text;
            string Rank = textBoxRank.Text;

            if (lecName == "" || empID == "" || faculty == "" || dept == "" || center == "" || building == "" || level == "" || Rank == "")
            {
                MessageBox.Show("Empty Fields !", "ERROR");
            }
            else
            {
                //get values from input fields
                c.LecturerName = lecName;
                c.EmployeeID = empID;
                c.LecturerFaculty = faculty;
                c.LecturerDepartment = dept;
                c.LecturerCenter = center;
                c.LecturerBuilding = building;
                c.LecturerLevel = level;
                c.LecturerRank = Rank;

                //Insert data into database using method in class
                bool success = c.Insert(c);

                if (success == true)
                {
                    MessageBox.Show("New Lecture Inserted");
                    //load data on data gridview
                    DataTable dt = c.Select();
                    dataGridViewLecturerDetails.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Faild to Insert Room");
                }
            }
           
        }


        private void btnUpdateLecturer_Click(object sender, EventArgs e)
        {
            string lecid = textBoxLecturerID.Text;
            if (lecid == "")
            {
                MessageBox.Show("Item Not Selected !", "ERROR");
            }
            else
            {
                //get values from input fields
                c.LecturerID = Convert.ToInt32(lecid);
                c.LecturerName = textBoxLecturerName.Text;
                c.EmployeeID = textBoxEmployeeID.Text;
                c.LecturerFaculty = comboBoxFaculty.Text;
                c.LecturerDepartment = comboBoxDepartment.Text;
                c.LecturerCenter = comboBoxCenter.Text;
                c.LecturerBuilding = comboBoxLBuilding.Text;
                c.LecturerLevel = comboBoxLevel.Text;
                c.LecturerRank = textBoxRank.Text;

                bool success = c.Update(c);
                if (success == true)
                {
                    MessageBox.Show("Lecturer Details Updated Successfully");
                    //load data on data gridview
                    DataTable dt = c.Select();
                    dataGridViewLecturerDetails.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Faild to Update Lecturer Details");
                }
            }
            
        }

        private void btnDeleteecturer_Click(object sender, EventArgs e)
        {
            string lecid = textBoxLecturerID.Text;
            if (lecid == "")
            {
                MessageBox.Show("Item Not Selected !", "ERROR");
            }

            else
            {
                c.LecturerID = Convert.ToInt32(lecid);
                if (MessageBox.Show("Do You Want to Delete Item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool success = c.Delete(c);

                    if (success == true)
                    {
                        MessageBox.Show("Lecturer Details Deleted Successfully");
                        //load data on data gridview
                        DataTable dt = c.Select();
                        dataGridViewLecturerDetails.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Faild to Delete Lecturer Details");
                    }
                }
                else
                {
                    MessageBox.Show("Item Not Deleted", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void dataGridViewLecturerDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data
            int rowIndex = e.RowIndex;
            textBoxLecturerID.Text = dataGridViewLecturerDetails.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxLecturerName.Text = dataGridViewLecturerDetails.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxEmployeeID.Text = dataGridViewLecturerDetails.Rows[rowIndex].Cells[2].Value.ToString();
            comboBoxFaculty.Text = dataGridViewLecturerDetails.Rows[rowIndex].Cells[3].Value.ToString();
            comboBoxDepartment.Text = dataGridViewLecturerDetails.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxCenter.Text = dataGridViewLecturerDetails.Rows[rowIndex].Cells[5].Value.ToString();
            comboBoxLBuilding.Text = dataGridViewLecturerDetails.Rows[rowIndex].Cells[6].Value.ToString();
            comboBoxLevel.Text = dataGridViewLecturerDetails.Rows[rowIndex].Cells[7].Value.ToString();
            textBoxRank.Text = dataGridViewLecturerDetails.Rows[rowIndex].Cells[8].Value.ToString();
        }

        
    }
}
