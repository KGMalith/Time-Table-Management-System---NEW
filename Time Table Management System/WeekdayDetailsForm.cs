using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Classes;

namespace Time_Table_Management_System
{
    public partial class WeekdayDetailsForm : Form
    {
        public WeekdayDetailsForm()
        {
            InitializeComponent();
        }
        WeekDayDetailsClass c = new WeekDayDetailsClass();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void WeekdayDetailsAdd_Click(object sender, EventArgs e)
        {
            //get values from input fields
            c.NumberOfWorkingDays = int.Parse(comboBoxNoOfWorkingDays.Text);
            c.IsMondayWorking = checkBoxMonday.Checked;
            c.IsTuesdayWorking = checkBoxTuesday.Checked;
            c.IsWednesdayWorking = checkBoxWednesday.Checked;
            c.IsThursdayWorking = checkBoxThursday.Checked;
            c.IsFridayWorking = checkBoxFriday.Checked;
            c.WorkingTimePerDayHours = int.Parse(comboBoxWorkingTimeHours.Text);
            c.WorkingTimePerDayMinutes = int.Parse(comboBoxWorkingTimeMinutes.Text);
            if (radioButtonOneHour.Checked)
            {
                c.TimeSlotsOneHour = radioButtonOneHour.Checked;
            }
            else if (radioButtonThirtyMinutes.Checked)
            {
                c.TimeSlotsThirtyMin = radioButtonThirtyMinutes.Checked;
            }

            //Insert data into database using method in class
            bool success = c.Insert(c);

            if (success == true)
            {
                MessageBox.Show("New Programme Inserted");
            }
            else
            {
                MessageBox.Show("Faild to Insert Programme");
            }
        }
    }
}
