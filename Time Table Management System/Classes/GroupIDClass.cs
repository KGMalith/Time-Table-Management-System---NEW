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
    class GroupIDClass

    {
        //Getters and Setters
        public int GroupID { get; set; }
        public string GeneratedGroupID { get; set; }

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
                string sql = "SELECT * FROM Table_GroupID";

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
        public bool Insert(GroupIDClass c)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;

            //Step1 - Connect database
            SqlConnection conn = new SqlConnection(constring);
            try
            {
                //Step2 - Create SQL query to insert data
                string sql = "INSERT INTO Table_GroupID(GeneratedGroupID) VALUES(@GeneratedGroupID)";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameter to add Data
                cmd.Parameters.AddWithValue("@GeneratedGroupID", c.GeneratedGroupID);
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
     
        //Method to Delete data in database from our application
        public bool Delete(GroupIDClass c)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(constring);
            try
            {
                string sql = "DELETE FROM Table_GroupID WHERE GroupID=@GroupID";
                //Creating SQL Command 
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameters to add value
                cmd.Parameters.AddWithValue("@GroupID", c.GroupID);
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
