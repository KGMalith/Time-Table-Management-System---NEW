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
    public partial class EditDetailsForm : Form
    {
        public EditDetailsForm()
        {
            InitializeComponent();
        }
        WeekDayDetailsClass wd = new WeekDayDetailsClass();
        WeekendClass we = new WeekendClass();
        private void btnEditDetailsWeekday_Click(object sender, EventArgs e)
        {
            //load data 
            //Databse Connection
            string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conn = new SqlConnection(constring);
            checkBoxEditMonday.Checked = false;
            checkBoxEditTuesday.Checked = false;
            checkBoxEditWednesday.Checked = false;
            checkBoxEditThursday.Checked = false;
            checkBoxEditFriday.Checked = false;
            checkBoxEditSaturday.Checked = false;
            checkBoxEditSunday.Checked = false;
            radioButtonEditOneHour.Checked = false;
            radioButtonEditThirtyMinutes.Checked = false;
            conn.Open();

            string sql2 = "SELECT * FROM Table_WeekDayDetails WHERE WeekdayDetailsID = 8";
            SqlCommand scmd = new SqlCommand(sql2, conn);
            SqlDataReader dataR = scmd.ExecuteReader();
            if (dataR.Read())
            {
                textBoxID.Text = dataR["WeekdayDetailsID"].ToString();
                comboBoxEditNoOfWorkingDays.Text = dataR["NumberOfWorkingDays"].ToString();
                string checking1 = dataR["IsMondayWorking"].ToString();
                string checking2 = dataR["IsTuesdayWorking"].ToString();
                string checking3 = dataR["IsWednesdayWorking"].ToString();
                string checking4 = dataR["IsThursdayWorking"].ToString();
                string checking5 = dataR["IsFridayWorking"].ToString();
                comboBoxEditWorkingTimeHours.Text = dataR["WorkingTimePerDayHours"].ToString();
                comboBoxEditWorkingTimeMinutes.Text = dataR["WorkingTimePerDayMinutes"].ToString();
                string checking6 = dataR["TimeSlotsOneHour"].ToString();
                string checking7 = dataR["TimeSlotsThirtyMin"].ToString();
                if (checking1 == "True")
                {
                    checkBoxEditMonday.Checked = true;
                }
                if (checking2 == "True")
                {
                    checkBoxEditTuesday.Checked = true;
                }
                if (checking3 == "True")
                {
                    checkBoxEditWednesday.Checked = true;
                }
                if (checking4 == "True")
                {
                    checkBoxEditThursday.Checked = true;
                }
                if (checking5 == "True")
                {
                    checkBoxEditFriday.Checked = true;
                }
                if (checking6 == "True")
                {
                    radioButtonEditOneHour.Checked = true;
                }
                if (checking7 == "True")
                {
                    radioButtonEditThirtyMinutes.Checked = true;
                }
            }
          


            conn.Close();
        }

        private void btnEditDetailsWeekend_Click(object sender, EventArgs e)
        {
            //load data 
            //Databse Connection
            string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conn = new SqlConnection(constring);
            checkBoxEditMonday.Checked = false;
            checkBoxEditTuesday.Checked = false;
            checkBoxEditWednesday.Checked = false;
            checkBoxEditThursday.Checked = false;
            checkBoxEditFriday.Checked = false;
            checkBoxEditSaturday.Checked = false;
            checkBoxEditSunday.Checked = false;
            radioButtonEditOneHour.Checked = false;
            radioButtonEditThirtyMinutes.Checked = false;
            conn.Open();

            string sql2 = "SELECT * FROM Table_WeekendDetails WHERE WeekendDetailsID = 5";
            SqlCommand scmd = new SqlCommand(sql2, conn);
            SqlDataReader dataR = scmd.ExecuteReader();
            if (dataR.Read())
            {
                textBoxID.Text = dataR["WeekendDetailsID"].ToString();
                comboBoxEditNoOfWorkingDays.Text = dataR["NumberOfWorkingDays"].ToString();
                string checking1 = dataR["IsSaturdayWorking"].ToString();
                string checking2 = dataR["IsSundayWorking"].ToString();
                comboBoxEditWorkingTimeHours.Text = dataR["WorkingTimePerDayHours"].ToString();
                comboBoxEditWorkingTimeMinutes.Text = dataR["WorkingTimePerDayMinutes"].ToString();
                string checking3 = dataR["TimeSlotsOneHour"].ToString();
                string checking4 = dataR["TimeSlotsThirtyMin"].ToString();
                if (checking1 == "True")
                {
                    checkBoxEditSaturday.Checked = true;
                }
                if (checking2 == "True")
                {
                    checkBoxEditSunday.Checked = true;
                }
                if (checking3 == "True")
                {
                    radioButtonEditOneHour.Checked = true;
                }
                if (checking4 == "True")
                {
                    radioButtonEditThirtyMinutes.Checked = true;
                }
            }



            conn.Close();
        }

        private void btnUpdateProgrammeWeekday_Click(object sender, EventArgs e)
        {
            //get values from input fields
            wd.WeekdayDetailsID = int.Parse(textBoxID.Text);
            wd.NumberOfWorkingDays = int.Parse(comboBoxEditNoOfWorkingDays.Text);
            wd.IsMondayWorking = checkBoxEditMonday.Checked;
            wd.IsTuesdayWorking = checkBoxEditTuesday.Checked;
            wd.IsWednesdayWorking = checkBoxEditWednesday.Checked;
            wd.IsThursdayWorking = checkBoxEditThursday.Checked;
            wd.IsFridayWorking = checkBoxEditFriday.Checked;
            wd.WorkingTimePerDayHours = int.Parse(comboBoxEditWorkingTimeHours.Text);
            wd.WorkingTimePerDayMinutes = int.Parse(comboBoxEditWorkingTimeMinutes.Text);
            if (radioButtonEditOneHour.Checked)
            {
                wd.TimeSlotsOneHour = radioButtonEditOneHour.Checked;
            }
            else if (radioButtonEditThirtyMinutes.Checked)
            {
                wd.TimeSlotsThirtyMin = radioButtonEditThirtyMinutes.Checked;
            }

            //Insert data into database using method in class
            bool success = wd.Update(wd);

            if (success == true)
            {
                MessageBox.Show("Weekday Details Updated");
            }
            else
            {
                MessageBox.Show("Faild to Update Weekday Details");
            }
        }

        private void btnUpdateProgrammeWeekend_Click(object sender, EventArgs e)
        {
            //get values from input fields
            we.WeekendDetailsID = int.Parse(textBoxID.Text);
            we.NumberOfWorkingDays = int.Parse(comboBoxEditNoOfWorkingDays.Text);
            we.IsSaturdayWorking = checkBoxEditSaturday.Checked;
            we.IsSundayWorking = checkBoxEditSunday.Checked;
            we.WorkingTimePerDayHours = int.Parse(comboBoxEditWorkingTimeHours.Text);
            we.WorkingTimePerDayMinutes = int.Parse(comboBoxEditWorkingTimeMinutes.Text);
            if (radioButtonEditOneHour.Checked)
            {
                we.TimeSlotsOneHour = radioButtonEditOneHour.Checked;
            }
            else if (radioButtonEditThirtyMinutes.Checked)
            {
                we.TimeSlotsThirtyMin = radioButtonEditThirtyMinutes.Checked;
            }

            //Insert data into database using method in class
            bool success = we.Update(we);

            if (success == true)
            {
                MessageBox.Show("Weekend Details Updated Successfully");
            }
            else
            {
                MessageBox.Show("Faild to Update Weekend Details");
            }
        }
    }
}
