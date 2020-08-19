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
    class SubjectClass
    {
        public int SubjectID { get; set; }
        public int SubjectOfferedYear { get; set; }
        public int SubjectOfferedSemester { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public int LectureHours { get; set; }
        public int TutorialHours { get; set; }
        public int LabHours { get; set; }
        public int EvaluationHours { get; set; }

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
                string sql = "SELECT * FROM Table_Subjects";

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
        public bool Insert(SubjectClass c)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;

            //Step1 - Connect database
            SqlConnection conn = new SqlConnection(constring);
            try
            {
                //Step2 - Create SQL query to insert data
                string sql = "INSERT INTO Table_Subjects(SubjectOfferedYear,SubjectOfferedSemester,SubjectName,SubjectCode,LectureHours,TutorialHours,LabHours,EvaluationHours) VALUES(@SubjectOfferedYear,@SubjectOfferedSemester,@SubjectName,@SubjectCode,@LectureHours,@TutorialHours,@LabHours,@EvaluationHours)";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameter to add Data
                cmd.Parameters.AddWithValue("@SubjectOfferedYear", c.SubjectOfferedYear);
                cmd.Parameters.AddWithValue("@SubjectOfferedSemester", c.SubjectOfferedSemester);
                cmd.Parameters.AddWithValue("@SubjectName", c.SubjectName);
                cmd.Parameters.AddWithValue("@SubjectCode", c.SubjectCode);
                cmd.Parameters.AddWithValue("@LectureHours", c.LectureHours);
                cmd.Parameters.AddWithValue("@TutorialHours", c.TutorialHours);
                cmd.Parameters.AddWithValue("@LabHours", c.LabHours);
                cmd.Parameters.AddWithValue("@EvaluationHours", c.EvaluationHours);

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
        public bool Update(SubjectClass c)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                //SQL update in database
                string sql = "UPDATE Table_Subjects SET SubjectOfferedYear=@SubjectOfferedYear,SubjectOfferedSemester=@SubjectOfferedSemester,SubjectName=@SubjectName,SubjectCode=@SubjectCode,LectureHours=@LectureHours,TutorialHours=@TutorialHours,LabHours=@LabHours,EvaluationHours=@EvaluationHours WHERE SubjectID=@SubjectID";

                //Creating SQL Command 
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameters to add value
                cmd.Parameters.AddWithValue("@SubjectID", c.SubjectID);
                cmd.Parameters.AddWithValue("@SubjectOfferedYear", c.SubjectOfferedYear);
                cmd.Parameters.AddWithValue("@SubjectOfferedSemester", c.SubjectOfferedSemester);
                cmd.Parameters.AddWithValue("@SubjectName", c.SubjectName);
                cmd.Parameters.AddWithValue("@SubjectCode", c.SubjectCode);
                cmd.Parameters.AddWithValue("@LectureHours", c.LectureHours);
                cmd.Parameters.AddWithValue("@TutorialHours", c.TutorialHours);
                cmd.Parameters.AddWithValue("@LabHours", c.LabHours);
                cmd.Parameters.AddWithValue("@EvaluationHours", c.EvaluationHours);

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
        public bool Delete(SubjectClass c)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(constring);
            try
            {
                string sql = "DELETE FROM Table_Subjects WHERE SubjectID=@SubjectID";
                //Creating SQL Command 
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameters to add value
                cmd.Parameters.AddWithValue("@SubjectID", c.SubjectID);
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
