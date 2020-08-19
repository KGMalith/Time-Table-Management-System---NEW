using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Classes
{
    class LecturerClass
    {
        //Getters and Setters

        public int LecturerID { get; set; }
        public string LecturerName { get; set; }
        public string EmployeeID { get; set; }
        public string LecturerFaculty { get; set; }
        public string LecturerDepartment { get; set; }
        public string LecturerCenter { get; set; }
        public string LecturerBuilding { get; set; }
        public string LecturerLevel { get; set; }
        public string LecturerRank { get; set; }
        //Databse Connection
        static string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        public DataTable Select()
        {
            //Step1 - database connection
            SqlConnection conn = new SqlConnection(constring);
            DataTable dt = new DataTable();
            try
            {
                //Step2 - SQL Query
                string sql = "SELECT * FROM Table_Lecturer";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating SQL adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Inserting Data into Databse
        public bool Insert(LecturerClass c)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;

            //Step1 - Connect database
            SqlConnection conn = new SqlConnection(constring);
            try
            {
                //Step2 - Create SQL query to insert data
                string sql = "INSERT INTO Table_Lecturer(LuecturerName,EmployeeID,LecturerFaculty,LecturerDepartment,LecturerCenter,LecturerBuilding,LecturerLevel,LecturerRank) VALUES(@LuecturerName,@EmployeeID,@LecturerFaculty,@LecturerDepartment,@LecturerCenter,@LecturerBuilding,@LecturerLevel,@LecturerRank)";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameter to add Data
                cmd.Parameters.AddWithValue("@LuecturerName", c.LecturerName);
                cmd.Parameters.AddWithValue("@EmployeeID", c.EmployeeID);
                cmd.Parameters.AddWithValue("@LecturerFaculty", c.LecturerFaculty);
                cmd.Parameters.AddWithValue("@LecturerDepartment", c.LecturerDepartment);
                cmd.Parameters.AddWithValue("@LecturerCenter", c.LecturerCenter);
                cmd.Parameters.AddWithValue("@LecturerBuilding", c.LecturerBuilding);
                cmd.Parameters.AddWithValue("@LecturerLevel", c.LecturerLevel);
                cmd.Parameters.AddWithValue("@LecturerRank", c.LecturerRank);

                //Connection Open
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then the value of rows wil be greater than 0 else it value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //Method to Update data in database from our application
        public bool Update(LecturerClass c)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                //SQL update in database
                string sql = "UPDATE Table_Lecturer SET LuecturerName=@LuecturerName,EmployeeID=@EmployeeID,LecturerFaculty=@LecturerFaculty,LecturerDepartment=@LecturerDepartment,LecturerCenter=@LecturerCenter,LecturerBuilding=@LecturerBuilding,LecturerLevel=@LecturerLevel,LecturerRank=@LecturerRank WHERE LecturerID=@LecturerID";

                //Creating SQL Command 
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameters to add value
                cmd.Parameters.AddWithValue("@LecturerID", c.LecturerID);
                cmd.Parameters.AddWithValue("@LuecturerName", c.LecturerName);
                cmd.Parameters.AddWithValue("@EmployeeID", c.EmployeeID);
                cmd.Parameters.AddWithValue("@LecturerFaculty", c.LecturerFaculty);
                cmd.Parameters.AddWithValue("@LecturerDepartment", c.LecturerDepartment);
                cmd.Parameters.AddWithValue("@LecturerCenter", c.LecturerCenter);
                cmd.Parameters.AddWithValue("@LecturerBuilding", c.LecturerBuilding);
                cmd.Parameters.AddWithValue("@LecturerLevel", c.LecturerLevel);
                cmd.Parameters.AddWithValue("@LecturerRank", c.LecturerRank);

                //Open database Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }

            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        //Method to Delete data in database from our application
        public bool Delete(LecturerClass c)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(constring);
            try
            {
                string sql = "DELETE FROM Table_Lecturer WHERE LecturerID=@LecturerID";
                //Creating SQL Command 
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameters to add value
                cmd.Parameters.AddWithValue("@LecturerID", c.LecturerID);
                //Open database Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
