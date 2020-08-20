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
    public partial class ViewDetailsForm : Form
    {
        public ViewDetailsForm()
        {
            InitializeComponent();
        }
        WeekDayDetailsClass wd = new WeekDayDetailsClass();
        WeekendClass we = new WeekendClass();
        private void btnViewDetailsWeekend_Click(object sender, EventArgs e)
        {
            //load data 
            //Databse Connection
            string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conn = new SqlConnection(constring);
            checkBoxViewMonday.Checked = false;
            checkBoxViewTuesday.Checked = false;
            checkBoxViewWednesday.Checked = false;
            checkBoxViewThursday.Checked = false;
            checkBoxViewFriday.Checked = false;
            radioButtonViewOneHour.Checked = false;
            radioButtonViewThirtyMinutes.Checked = false;
            conn.Open();

            string sql2 = "SELECT * FROM Table_WeekendDetails WHERE WeekendDetailsID = 1";
            SqlCommand scmd = new SqlCommand(sql2, conn);
            SqlDataReader dataR = scmd.ExecuteReader();
            if (dataR.Read())
            {

                comboBoxViewNoOfWorkingDays.Text = dataR["NumberOfWorkingDays"].ToString();
                string checking1 = dataR["IsSaturdayWorking"].ToString();
                string checking2 = dataR["IsSundayWorking"].ToString();
                comboBoxViewWorkingTimeHours.Text = dataR["WorkingTimePerDayHours"].ToString();
                comboBoxViewWorkingTimeMinutes.Text = dataR["WorkingTimePerDayMinutes"].ToString();
                string checking3 = dataR["TimeSlotsOneHour"].ToString();
                string checking4 = dataR["TimeSlotsThirtyMin"].ToString();
                if (checking1 == "True")
                {
                    checkBoxViewSaturday.Checked = true;
                }
                if (checking2 == "True")
                {
                    checkBoxViewSunday.Checked = true;
                }
                if (checking3 == "True")
                {
                    radioButtonViewOneHour.Checked = true;
                }
                if (checking4 == "True")
                {
                    radioButtonViewThirtyMinutes.Checked = true;
                }
            }
            


            conn.Close();
        }

        private void btnViewDetailsWeekday_Click(object sender, EventArgs e)
        {
           
            //load data 
            //Databse Connection
            string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conn = new SqlConnection(constring);
            checkBoxViewMonday.Checked = false;
            checkBoxViewTuesday.Checked = false;
            checkBoxViewWednesday.Checked = false;
            checkBoxViewThursday.Checked = false;
            checkBoxViewFriday.Checked = false;
            radioButtonViewOneHour.Checked = false;
            radioButtonViewThirtyMinutes.Checked = false;
            conn.Open();
            //string sql = "SELECT WeekdayDetailsID FROM Table_WeekDayDetails ORDER BY WeekdayDetailsID asc";
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    int v = int.Parse(dr["WeekdayDetailsID"].ToString());

                string sql2 = "SELECT * FROM Table_WeekDayDetails WHERE WeekdayDetailsID = 3";
                SqlCommand scmd = new SqlCommand(sql2, conn);
                SqlDataReader dataR = scmd.ExecuteReader();
                if (dataR.Read())
                {

                    comboBoxViewNoOfWorkingDays.Text = dataR["NumberOfWorkingDays"].ToString();
                    string checking1 = dataR["IsMondayWorking"].ToString();
                    string checking2 = dataR["IsTuesdayWorking"].ToString();
                    string checking3 = dataR["IsWednesdayWorking"].ToString();
                    string checking4 = dataR["IsThursdayWorking"].ToString();
                    string checking5 = dataR["IsFridayWorking"].ToString();
                    comboBoxViewWorkingTimeHours.Text = dataR["WorkingTimePerDayHours"].ToString();
                    comboBoxViewWorkingTimeMinutes.Text = dataR["WorkingTimePerDayMinutes"].ToString();
                    string checking6 = dataR["TimeSlotsOneHour"].ToString();
                    string checking7 = dataR["TimeSlotsThirtyMin"].ToString();
                    if (checking1 == "True")
                    {
                        checkBoxViewMonday.Checked = true;
                    }
                    if (checking2 == "True")
                    {
                        checkBoxViewTuesday.Checked = true;
                    }
                    if (checking3 == "True")
                    {
                        checkBoxViewWednesday.Checked = true;
                    }
                    if (checking4 == "True")
                    {
                        checkBoxViewThursday.Checked = true;
                    }
                    if (checking5 == "True")
                    {
                        checkBoxViewFriday.Checked = true;
                    }
                    if (checking6 == "True")
                    {
                        radioButtonViewOneHour.Checked = true;
                    }
                    if (checking7 == "True")
                    {
                        radioButtonViewThirtyMinutes.Checked = true;
                    }
                }
            //}

            
            conn.Close();
        }

        private void WeekdayDetailsDelete_Click(object sender, EventArgs e)
        {
            string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string sql = "SELECT WeekdayDetailsID FROM Table_WeekDayDetails ORDER BY WeekdayDetailsID asc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int a = int.Parse(dr["WeekdayDetailsID"].ToString());

                wd.WeekdayDetailsID = a;
                if (MessageBox.Show("Do You Want to Delete Item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool success = wd.Delete(wd);

                    if (success == true)
                    {
                        MessageBox.Show("Weekday Details Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Faild to Delete Weekday Details");
                    }
                }
                else
                {
                    MessageBox.Show("Item Not Deleted", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

                
            
        }

        private void btnDeleteWeekend_Click(object sender, EventArgs e)
        {
            string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string sql = "SELECT WeekendDetailsID FROM Table_WeekendDetails ORDER BY WeekendDetailsID asc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int a = int.Parse(dr["WeekendDetailsID"].ToString());

                we.WeekendDetailsID = a;
                if (MessageBox.Show("Do You Want to Delete Item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool success = we.Delete(we);

                    if (success == true)
                    {
                        MessageBox.Show("Lecturer Details Deleted Successfully");
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
    }
}
