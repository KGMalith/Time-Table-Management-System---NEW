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
    public partial class WeekendDetailsForm : Form
    {
        public WeekendDetailsForm()
        {
            InitializeComponent();
        }
        WeekendClass c = new WeekendClass();

        private void WeekendDetailsAdd_Click(object sender, EventArgs e)
        {
            //get values from input fields
            c.NumberOfWorkingDays = int.Parse(comboBoxNoOfWorkingDaysWeekend.Text);
            c.IsSaturdayWorking = checkBoxSaturday.Checked;
            c.IsSundayWorking = checkBoxSunday.Checked;
            c.WorkingTimePerDayHours = int.Parse(comboBoxWorkingTimeHoursWeekend.Text);
            c.WorkingTimePerDayMinutes = int.Parse(comboBoxWorkingTimeMinutesWeekend.Text);
            if (radioButtonOneHourWeekend.Checked)
            {
                c.TimeSlotsOneHour = radioButtonOneHourWeekend.Checked;
            }
            else if (radioButtonThirtyMinutesWeekend.Checked)
            {
                c.TimeSlotsThirtyMin = radioButtonThirtyMinutesWeekend.Checked;
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
