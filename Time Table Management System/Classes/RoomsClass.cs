using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Table_Management_System.Classes
{
    class RoomsClass
    {
        //Getters and Setters

        public int RoomID { get; set; }
        public string BuildingName { get; set; }
        public string RoomName { get; set; }

        //Databse Connection
        static string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        //Selecting data from database
        public DataTable Select()
        {
            //Step1 - database connection
            SqlConnection conn = new SqlConnection(constring);
            DataTable dt = new DataTable();
            try
            {
                //Step2 - SQL Query
                string sql = "SELECT * FROM Table_Rooms";

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
        public bool Insert(RoomsClass c)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;

            //Step1 - Connect database
            SqlConnection conn = new SqlConnection(constring);
            try
            {
                //Step2 - Create SQL query to insert data
                string sql = "INSERT INTO Table_Rooms(BuildingName,RoomName) VALUES(@BuildingID,@RoomName)";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameter to add Data
                cmd.Parameters.AddWithValue("@BuildingID", c.BuildingName);
                cmd.Parameters.AddWithValue("@RoomName", c.RoomName);

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
        public bool Update(RoomsClass c)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                //SQL update in database
                string sql = "UPDATE Table_Rooms SET BuildingName=@BuildingName,RoomName=@RoomName WHERE RoomID=@RoomID";

                //Creating SQL Command 
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameters to add value
                cmd.Parameters.AddWithValue("@RoomID", c.RoomID);
                cmd.Parameters.AddWithValue("@BuildingName", c.BuildingName);
                cmd.Parameters.AddWithValue("@RoomName", c.RoomName);

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
        public bool Delete(RoomsClass c)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(constring);
            try
            {
                string sql = "DELETE FROM Table_Rooms WHERE RoomID=@RoomID";
                //Creating SQL Command 
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameters to add value
                cmd.Parameters.AddWithValue("@RoomID", c.RoomID);
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
