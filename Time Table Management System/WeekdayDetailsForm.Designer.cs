namespace Time_Table_Management_System
{
    partial class WeekdayDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxNoOfWorkingDays = new System.Windows.Forms.ComboBox();
            this.groupBoxWorkingDays = new System.Windows.Forms.GroupBox();
            this.checkBoxMonday = new System.Windows.Forms.CheckBox();
            this.checkBoxTuesday = new System.Windows.Forms.CheckBox();
            this.checkBoxWednesday = new System.Windows.Forms.CheckBox();
            this.checkBoxFriday = new System.Windows.Forms.CheckBox();
            this.checkBoxThursday = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxWorkingTimeHours = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxWorkingTimeMinutes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxTimeSlot = new System.Windows.Forms.GroupBox();
            this.radioButtonOneHour = new System.Windows.Forms.RadioButton();
            this.radioButtonThirtyMinutes = new System.Windows.Forms.RadioButton();
            this.WeekdayDetailsAdd = new System.Windows.Forms.Button();
            this.groupBoxWorkingDays.SuspendLayout();
            this.groupBoxTimeSlot.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(199, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Weekday Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "No Of Working Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Working Days";
            // 
            // comboBoxNoOfWorkingDays
            // 
            this.comboBoxNoOfWorkingDays.FormattingEnabled = true;
            this.comboBoxNoOfWorkingDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxNoOfWorkingDays.Location = new System.Drawing.Point(273, 143);
            this.comboBoxNoOfWorkingDays.Name = "comboBoxNoOfWorkingDays";
            this.comboBoxNoOfWorkingDays.Size = new System.Drawing.Size(146, 24);
            this.comboBoxNoOfWorkingDays.TabIndex = 3;
            // 
            // groupBoxWorkingDays
            // 
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxThursday);
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxFriday);
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxWednesday);
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxTuesday);
            this.groupBoxWorkingDays.Controls.Add(this.checkBoxMonday);
            this.groupBoxWorkingDays.Location = new System.Drawing.Point(273, 218);
            this.groupBoxWorkingDays.Name = "groupBoxWorkingDays";
            this.groupBoxWorkingDays.Size = new System.Drawing.Size(354, 118);
            this.groupBoxWorkingDays.TabIndex = 4;
            this.groupBoxWorkingDays.TabStop = false;
            this.groupBoxWorkingDays.Text = "Working Days";
            // 
            // checkBoxMonday
            // 
            this.checkBoxMonday.AutoSize = true;
            this.checkBoxMonday.Location = new System.Drawing.Point(7, 32);
            this.checkBoxMonday.Name = "checkBoxMonday";
            this.checkBoxMonday.Size = new System.Drawing.Size(80, 21);
            this.checkBoxMonday.TabIndex = 0;
            this.checkBoxMonday.Text = "Monday";
            this.checkBoxMonday.UseVisualStyleBackColor = true;
            // 
            // checkBoxTuesday
            // 
            this.checkBoxTuesday.AutoSize = true;
            this.checkBoxTuesday.Location = new System.Drawing.Point(126, 32);
            this.checkBoxTuesday.Name = "checkBoxTuesday";
            this.checkBoxTuesday.Size = new System.Drawing.Size(85, 21);
            this.checkBoxTuesday.TabIndex = 1;
            this.checkBoxTuesday.Text = "Tuesday";
            this.checkBoxTuesday.UseVisualStyleBackColor = true;
            this.checkBoxTuesday.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxWednesday
            // 
            this.checkBoxWednesday.AutoSize = true;
            this.checkBoxWednesday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxWednesday.Location = new System.Drawing.Point(250, 32);
            this.checkBoxWednesday.Name = "checkBoxWednesday";
            this.checkBoxWednesday.Size = new System.Drawing.Size(105, 21);
            this.checkBoxWednesday.TabIndex = 2;
            this.checkBoxWednesday.Text = "Wednesday";
            this.checkBoxWednesday.UseVisualStyleBackColor = true;
            // 
            // checkBoxFriday
            // 
            this.checkBoxFriday.AutoSize = true;
            this.checkBoxFriday.Location = new System.Drawing.Point(126, 74);
            this.checkBoxFriday.Name = "checkBoxFriday";
            this.checkBoxFriday.Size = new System.Drawing.Size(69, 21);
            this.checkBoxFriday.TabIndex = 3;
            this.checkBoxFriday.Text = "Friday";
            this.checkBoxFriday.UseVisualStyleBackColor = true;
            // 
            // checkBoxThursday
            // 
            this.checkBoxThursday.AutoSize = true;
            this.checkBoxThursday.Location = new System.Drawing.Point(7, 74);
            this.checkBoxThursday.Name = "checkBoxThursday";
            this.checkBoxThursday.Size = new System.Drawing.Size(90, 21);
            this.checkBoxThursday.TabIndex = 4;
            this.checkBoxThursday.Text = "Thursday";
            this.checkBoxThursday.UseVisualStyleBackColor = true;
            this.checkBoxThursday.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Working Time Per Days";
            // 
            // comboBoxWorkingTimeHours
            // 
            this.comboBoxWorkingTimeHours.FormattingEnabled = true;
            this.comboBoxWorkingTimeHours.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxWorkingTimeHours.Location = new System.Drawing.Point(273, 361);
            this.comboBoxWorkingTimeHours.Name = "comboBoxWorkingTimeHours";
            this.comboBoxWorkingTimeHours.Size = new System.Drawing.Size(121, 24);
            this.comboBoxWorkingTimeHours.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "H";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBoxWorkingTimeMinutes
            // 
            this.comboBoxWorkingTimeMinutes.FormattingEnabled = true;
            this.comboBoxWorkingTimeMinutes.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.comboBoxWorkingTimeMinutes.Location = new System.Drawing.Point(440, 361);
            this.comboBoxWorkingTimeMinutes.Name = "comboBoxWorkingTimeMinutes";
            this.comboBoxWorkingTimeMinutes.Size = new System.Drawing.Size(121, 24);
            this.comboBoxWorkingTimeMinutes.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(569, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "M";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Time Slot";
            // 
            // groupBoxTimeSlot
            // 
            this.groupBoxTimeSlot.Controls.Add(this.radioButtonThirtyMinutes);
            this.groupBoxTimeSlot.Controls.Add(this.radioButtonOneHour);
            this.groupBoxTimeSlot.Location = new System.Drawing.Point(273, 439);
            this.groupBoxTimeSlot.Name = "groupBoxTimeSlot";
            this.groupBoxTimeSlot.Size = new System.Drawing.Size(195, 131);
            this.groupBoxTimeSlot.TabIndex = 11;
            this.groupBoxTimeSlot.TabStop = false;
            this.groupBoxTimeSlot.Text = "Time Slot";
            // 
            // radioButtonOneHour
            // 
            this.radioButtonOneHour.AutoSize = true;
            this.radioButtonOneHour.Location = new System.Drawing.Point(7, 47);
            this.radioButtonOneHour.Name = "radioButtonOneHour";
            this.radioButtonOneHour.Size = new System.Drawing.Size(91, 21);
            this.radioButtonOneHour.TabIndex = 0;
            this.radioButtonOneHour.TabStop = true;
            this.radioButtonOneHour.Text = "One Hour";
            this.radioButtonOneHour.UseVisualStyleBackColor = true;
            // 
            // radioButtonThirtyMinutes
            // 
            this.radioButtonThirtyMinutes.AutoSize = true;
            this.radioButtonThirtyMinutes.Location = new System.Drawing.Point(7, 88);
            this.radioButtonThirtyMinutes.Name = "radioButtonThirtyMinutes";
            this.radioButtonThirtyMinutes.Size = new System.Drawing.Size(118, 21);
            this.radioButtonThirtyMinutes.TabIndex = 1;
            this.radioButtonThirtyMinutes.TabStop = true;
            this.radioButtonThirtyMinutes.Text = "Thirty Minutes";
            this.radioButtonThirtyMinutes.UseVisualStyleBackColor = true;
            // 
            // WeekdayDetailsAdd
            // 
            this.WeekdayDetailsAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.WeekdayDetailsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekdayDetailsAdd.Location = new System.Drawing.Point(514, 627);
            this.WeekdayDetailsAdd.Name = "WeekdayDetailsAdd";
            this.WeekdayDetailsAdd.Size = new System.Drawing.Size(80, 30);
            this.WeekdayDetailsAdd.TabIndex = 12;
            this.WeekdayDetailsAdd.Text = "Add";
            this.WeekdayDetailsAdd.UseVisualStyleBackColor = false;
            this.WeekdayDetailsAdd.Click += new System.EventHandler(this.WeekdayDetailsAdd_Click);
            // 
            // WeekdayDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 689);
            this.Controls.Add(this.WeekdayDetailsAdd);
            this.Controls.Add(this.groupBoxTimeSlot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxWorkingTimeMinutes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxWorkingTimeHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxWorkingDays);
            this.Controls.Add(this.comboBoxNoOfWorkingDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeekdayDetailsForm";
            this.Text = "Form2";
            this.groupBoxWorkingDays.ResumeLayout(false);
            this.groupBoxWorkingDays.PerformLayout();
            this.groupBoxTimeSlot.ResumeLayout(false);
            this.groupBoxTimeSlot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxNoOfWorkingDays;
        private System.Windows.Forms.GroupBox groupBoxWorkingDays;
        private System.Windows.Forms.CheckBox checkBoxThursday;
        private System.Windows.Forms.CheckBox checkBoxFriday;
        private System.Windows.Forms.CheckBox checkBoxWednesday;
        private System.Windows.Forms.CheckBox checkBoxTuesday;
        private System.Windows.Forms.CheckBox checkBoxMonday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxWorkingTimeHours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxWorkingTimeMinutes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxTimeSlot;
        private System.Windows.Forms.RadioButton radioButtonThirtyMinutes;
        private System.Windows.Forms.RadioButton radioButtonOneHour;
        private System.Windows.Forms.Button WeekdayDetailsAdd;
    }
}