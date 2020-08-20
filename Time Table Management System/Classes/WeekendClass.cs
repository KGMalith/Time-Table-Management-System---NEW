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
    class WeekendClass
    {
        public int WeekendDetailsID { get; set; }
        public int NumberOfWorkingDays { get; set; }
        public bool IsSaturdayWorking { get; set; }
        public bool IsSundayWorking { get; set; }
        public int WorkingTimePerDayHours { get; set; }
        public int WorkingTimePerDayMinutes { get; set; }
        public bool TimeSlotsOneHour { get; set; }
        public bool TimeSlotsThirtyMin { get; set; }

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
                string sql = "SELECT * FROM Table_WeekendDetails";

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
        public bool Insert(WeekendClass c)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;

            //Step1 - Connect database
            SqlConnection conn = new SqlConnection(constring);
            try
            {
                //Step2 - Create SQL query to insert data
                string sql = "INSERT INTO Table_WeekendDetails(NumberOfWorkingDays,IsSaturdayWorking,IsSundayWorking,WorkingTimePerDayHours,WorkingTimePerDayMinutes,TimeSlotsOneHour,TimeSlotsThirtyMin) VALUES(@NumberOfWorkingDays,@IsSaturdayWorking,@IsSundayWorking,@WorkingTimePerDayHours,@WorkingTimePerDayMinutes,@TimeSlotsOneHour,@TimeSlotsThirtyMin)";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameter to add Data
                cmd.Parameters.AddWithValue("@NumberOfWorkingDays", c.NumberOfWorkingDays);
                cmd.Parameters.AddWithValue("@IsSaturdayWorking", c.IsSaturdayWorking);
                cmd.Parameters.AddWithValue("@IsSundayWorking", c.IsSundayWorking);
                cmd.Parameters.AddWithValue("@WorkingTimePerDayHours", c.WorkingTimePerDayHours);
                cmd.Parameters.AddWithValue("@WorkingTimePerDayMinutes", c.WorkingTimePerDayMinutes);
                cmd.Parameters.AddWithValue("@TimeSlotsOneHour", c.TimeSlotsOneHour);
                cmd.Parameters.AddWithValue("@TimeSlotsThirtyMin", c.TimeSlotsThirtyMin);
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
        public bool Update(WeekendClass c)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                //SQL update in database
                string sql = "UPDATE Table_WeekendDetails SET NumberOfWorkingDays=@NumberOfWorkingDays,IsSaturdayWorking=@IsSaturdayWorking,IsSundayWorking=@IsSundayWorking,WorkingTimePerDayHours=@WorkingTimePerDayHours,WorkingTimePerDayMinutes=@WorkingTimePerDayMinutes,TimeSlotsOneHour=@TimeSlotsOneHour,TimeSlotsThirtyMin=@TimeSlotsThirtyMin WHERE WeekendDetailsID=@WeekendDetailsID";

                //Creating SQL Command 
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameters to add value
                cmd.Parameters.AddWithValue("@WeekendDetailsID", c.WeekendDetailsID);
                cmd.Parameters.AddWithValue("@NumberOfWorkingDays", c.NumberOfWorkingDays);
                cmd.Parameters.AddWithValue("@IsSaturdayWorking", c.IsSaturdayWorking);
                cmd.Parameters.AddWithValue("@IsSundayWorking", c.IsSundayWorking);
                cmd.Parameters.AddWithValue("@WorkingTimePerDayHours", c.WorkingTimePerDayHours);
                cmd.Parameters.AddWithValue("@WorkingTimePerDayMinutes", c.WorkingTimePerDayMinutes);
                cmd.Parameters.AddWithValue("@TimeSlotsOneHour", c.TimeSlotsOneHour);
                cmd.Parameters.AddWithValue("@TimeSlotsThirtyMin", c.TimeSlotsThirtyMin);

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
        public bool Delete(WeekendClass c)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(constring);
            try
            {
                string sql = "DELETE FROM Table_WeekendDetails WHERE WeekendDetailsID=@WeekendDetailsID";
                //Creating SQL Command 
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameters to add value
                cmd.Parameters.AddWithValue("@WeekendDetailsID", c.WeekendDetailsID);
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
