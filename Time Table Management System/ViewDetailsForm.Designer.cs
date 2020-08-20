namespace Time_Table_Management_System
{
    partial class ViewDetailsForm
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
            this.btnViewDetailsWeekday = new System.Windows.Forms.Button();
            this.btnViewDetailsWeekend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxViewNoOfWorkingDays = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxViewWorkingDays = new System.Windows.Forms.GroupBox();
            this.checkBoxViewThursday = new System.Windows.Forms.CheckBox();
            this.checkBoxViewFriday = new System.Windows.Forms.CheckBox();
            this.checkBoxViewWednesday = new System.Windows.Forms.CheckBox();
            this.checkBoxViewTuesday = new System.Windows.Forms.CheckBox();
            this.checkBoxViewMonday = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxViewWorkingTimeHours = new System.Windows.Forms.ComboBox();
            this.comboBoxViewWorkingTimeMinutes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxViewTimeSlot = new System.Windows.Forms.GroupBox();
            this.radioButtonViewThirtyMinutes = new System.Windows.Forms.RadioButton();
            this.radioButtonViewOneHour = new System.Windows.Forms.RadioButton();
            this.WeekdayDetailsDelete = new System.Windows.Forms.Button();
            this.btnDeleteWeekend = new System.Windows.Forms.Button();
            this.checkBoxViewSaturday = new System.Windows.Forms.CheckBox();
            this.checkBoxViewSunday = new System.Windows.Forms.CheckBox();
            this.groupBoxViewWorkingDays.SuspendLayout();
            this.groupBoxViewTimeSlot.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(255, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "View Details";
            // 
            // btnViewDetailsWeekday
            // 
            this.btnViewDetailsWeekday.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewDetailsWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetailsWeekday.ForeColor = System.Drawing.SystemColors.Control;
            this.btnViewDetailsWeekday.Location = new System.Drawing.Point(149, 113);
            this.btnViewDetailsWeekday.Name = "btnViewDetailsWeekday";
            this.btnViewDetailsWeekday.Size = new System.Drawing.Size(105, 39);
            this.btnViewDetailsWeekday.TabIndex = 3;
            this.btnViewDetailsWeekday.Text = "Weekday";
            this.btnViewDetailsWeekday.UseVisualStyleBackColor = false;
            this.btnViewDetailsWeekday.Click += new System.EventHandler(this.btnViewDetailsWeekday_Click);
            // 
            // btnViewDetailsWeekend
            // 
            this.btnViewDetailsWeekend.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewDetailsWeekend.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetailsWeekend.ForeColor = System.Drawing.SystemColors.Control;
            this.btnViewDetailsWeekend.Location = new System.Drawing.Point(375, 113);
            this.btnViewDetailsWeekend.Name = "btnViewDetailsWeekend";
            this.btnViewDetailsWeekend.Size = new System.Drawing.Size(104, 39);
            this.btnViewDetailsWeekend.TabIndex = 4;
            this.btnViewDetailsWeekend.Text = "Weekend";
            this.btnViewDetailsWeekend.UseVisualStyleBackColor = false;
            this.btnViewDetailsWeekend.Click += new System.EventHandler(this.btnViewDetailsWeekend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "No Of Working Days";
            // 
            // comboBoxViewNoOfWorkingDays
            // 
            this.comboBoxViewNoOfWorkingDays.FormattingEnabled = true;
            this.comboBoxViewNoOfWorkingDays.Items.AddRange(new object[] {
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
            this.comboBoxViewNoOfWorkingDays.Location = new System.Drawing.Point(299, 189);
            this.comboBoxViewNoOfWorkingDays.Name = "comboBoxViewNoOfWorkingDays";
            this.comboBoxViewNoOfWorkingDays.Size = new System.Drawing.Size(146, 24);
            this.comboBoxViewNoOfWorkingDays.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Working Days";
            // 
            // groupBoxViewWorkingDays
            // 
            this.groupBoxViewWorkingDays.Controls.Add(this.checkBoxViewSunday);
            this.groupBoxViewWorkingDays.Controls.Add(this.checkBoxViewSaturday);
            this.groupBoxViewWorkingDays.Controls.Add(this.checkBoxViewThursday);
            this.groupBoxViewWorkingDays.Controls.Add(this.checkBoxViewFriday);
            this.groupBoxViewWorkingDays.Controls.Add(this.checkBoxViewWednesday);
            this.groupBoxViewWorkingDays.Controls.Add(this.checkBoxViewTuesday);
            this.groupBoxViewWorkingDays.Controls.Add(this.checkBoxViewMonday);
            this.groupBoxViewWorkingDays.Location = new System.Drawing.Point(299, 246);
            this.groupBoxViewWorkingDays.Name = "groupBoxViewWorkingDays";
            this.groupBoxViewWorkingDays.Size = new System.Drawing.Size(354, 142);
            this.groupBoxViewWorkingDays.TabIndex = 8;
            this.groupBoxViewWorkingDays.TabStop = false;
            this.groupBoxViewWorkingDays.Text = "Working Days";
            // 
            // checkBoxViewThursday
            // 
            this.checkBoxViewThursday.AutoSize = true;
            this.checkBoxViewThursday.Location = new System.Drawing.Point(7, 74);
            this.checkBoxViewThursday.Name = "checkBoxViewThursday";
            this.checkBoxViewThursday.Size = new System.Drawing.Size(90, 21);
            this.checkBoxViewThursday.TabIndex = 4;
            this.checkBoxViewThursday.Text = "Thursday";
            this.checkBoxViewThursday.UseVisualStyleBackColor = true;
            // 
            // checkBoxViewFriday
            // 
            this.checkBoxViewFriday.AutoSize = true;
            this.checkBoxViewFriday.Location = new System.Drawing.Point(126, 74);
            this.checkBoxViewFriday.Name = "checkBoxViewFriday";
            this.checkBoxViewFriday.Size = new System.Drawing.Size(69, 21);
            this.checkBoxViewFriday.TabIndex = 3;
            this.checkBoxViewFriday.Text = "Friday";
            this.checkBoxViewFriday.UseVisualStyleBackColor = true;
            // 
            // checkBoxViewWednesday
            // 
            this.checkBoxViewWednesday.AutoSize = true;
            this.checkBoxViewWednesday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxViewWednesday.Location = new System.Drawing.Point(250, 32);
            this.checkBoxViewWednesday.Name = "checkBoxViewWednesday";
            this.checkBoxViewWednesday.Size = new System.Drawing.Size(105, 21);
            this.checkBoxViewWednesday.TabIndex = 2;
            this.checkBoxViewWednesday.Text = "Wednesday";
            this.checkBoxViewWednesday.UseVisualStyleBackColor = true;
            // 
            // checkBoxViewTuesday
            // 
            this.checkBoxViewTuesday.AutoSize = true;
            this.checkBoxViewTuesday.Location = new System.Drawing.Point(126, 32);
            this.checkBoxViewTuesday.Name = "checkBoxViewTuesday";
            this.checkBoxViewTuesday.Size = new System.Drawing.Size(85, 21);
            this.checkBoxViewTuesday.TabIndex = 1;
            this.checkBoxViewTuesday.Text = "Tuesday";
            this.checkBoxViewTuesday.UseVisualStyleBackColor = true;
            // 
            // checkBoxViewMonday
            // 
            this.checkBoxViewMonday.AutoSize = true;
            this.checkBoxViewMonday.Location = new System.Drawing.Point(7, 32);
            this.checkBoxViewMonday.Name = "checkBoxViewMonday";
            this.checkBoxViewMonday.Size = new System.Drawing.Size(80, 21);
            this.checkBoxViewMonday.TabIndex = 0;
            this.checkBoxViewMonday.Text = "Monday";
            this.checkBoxViewMonday.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Working Time Per Days";
            // 
            // comboBoxViewWorkingTimeHours
            // 
            this.comboBoxViewWorkingTimeHours.FormattingEnabled = true;
            this.comboBoxViewWorkingTimeHours.Items.AddRange(new object[] {
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
            this.comboBoxViewWorkingTimeHours.Location = new System.Drawing.Point(299, 413);
            this.comboBoxViewWorkingTimeHours.Name = "comboBoxViewWorkingTimeHours";
            this.comboBoxViewWorkingTimeHours.Size = new System.Drawing.Size(121, 24);
            this.comboBoxViewWorkingTimeHours.TabIndex = 10;
            // 
            // comboBoxViewWorkingTimeMinutes
            // 
            this.comboBoxViewWorkingTimeMinutes.FormattingEnabled = true;
            this.comboBoxViewWorkingTimeMinutes.Items.AddRange(new object[] {
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
            this.comboBoxViewWorkingTimeMinutes.Location = new System.Drawing.Point(474, 413);
            this.comboBoxViewWorkingTimeMinutes.Name = "comboBoxViewWorkingTimeMinutes";
            this.comboBoxViewWorkingTimeMinutes.Size = new System.Drawing.Size(121, 24);
            this.comboBoxViewWorkingTimeMinutes.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "H";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(601, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "M";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Time Slot";
            // 
            // groupBoxViewTimeSlot
            // 
            this.groupBoxViewTimeSlot.Controls.Add(this.radioButtonViewThirtyMinutes);
            this.groupBoxViewTimeSlot.Controls.Add(this.radioButtonViewOneHour);
            this.groupBoxViewTimeSlot.Location = new System.Drawing.Point(299, 489);
            this.groupBoxViewTimeSlot.Name = "groupBoxViewTimeSlot";
            this.groupBoxViewTimeSlot.Size = new System.Drawing.Size(195, 131);
            this.groupBoxViewTimeSlot.TabIndex = 15;
            this.groupBoxViewTimeSlot.TabStop = false;
            this.groupBoxViewTimeSlot.Text = "Time Slot";
            // 
            // radioButtonViewThirtyMinutes
            // 
            this.radioButtonViewThirtyMinutes.AutoSize = true;
            this.radioButtonViewThirtyMinutes.Location = new System.Drawing.Point(7, 88);
            this.radioButtonViewThirtyMinutes.Name = "radioButtonViewThirtyMinutes";
            this.radioButtonViewThirtyMinutes.Size = new System.Drawing.Size(118, 21);
            this.radioButtonViewThirtyMinutes.TabIndex = 1;
            this.radioButtonViewThirtyMinutes.TabStop = true;
            this.radioButtonViewThirtyMinutes.Text = "Thirty Minutes";
            this.radioButtonViewThirtyMinutes.UseVisualStyleBackColor = true;
            // 
            // radioButtonViewOneHour
            // 
            this.radioButtonViewOneHour.AutoSize = true;
            this.radioButtonViewOneHour.Location = new System.Drawing.Point(7, 47);
            this.radioButtonViewOneHour.Name = "radioButtonViewOneHour";
            this.radioButtonViewOneHour.Size = new System.Drawing.Size(91, 21);
            this.radioButtonViewOneHour.TabIndex = 0;
            this.radioButtonViewOneHour.TabStop = true;
            this.radioButtonViewOneHour.Text = "One Hour";
            this.radioButtonViewOneHour.UseVisualStyleBackColor = true;
            // 
            // WeekdayDetailsDelete
            // 
            this.WeekdayDetailsDelete.BackColor = System.Drawing.Color.Red;
            this.WeekdayDetailsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekdayDetailsDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.WeekdayDetailsDelete.Location = new System.Drawing.Point(306, 634);
            this.WeekdayDetailsDelete.Name = "WeekdayDetailsDelete";
            this.WeekdayDetailsDelete.Size = new System.Drawing.Size(156, 43);
            this.WeekdayDetailsDelete.TabIndex = 14;
            this.WeekdayDetailsDelete.Text = "Delete WeekDay";
            this.WeekdayDetailsDelete.UseVisualStyleBackColor = false;
            this.WeekdayDetailsDelete.Click += new System.EventHandler(this.WeekdayDetailsDelete_Click);
            // 
            // btnDeleteWeekend
            // 
            this.btnDeleteWeekend.BackColor = System.Drawing.Color.Red;
            this.btnDeleteWeekend.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteWeekend.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteWeekend.Location = new System.Drawing.Point(474, 634);
            this.btnDeleteWeekend.Name = "btnDeleteWeekend";
            this.btnDeleteWeekend.Size = new System.Drawing.Size(156, 43);
            this.btnDeleteWeekend.TabIndex = 16;
            this.btnDeleteWeekend.Text = "Delete Weekend";
            this.btnDeleteWeekend.UseVisualStyleBackColor = false;
            this.btnDeleteWeekend.Click += new System.EventHandler(this.btnDeleteWeekend_Click);
            // 
            // checkBoxViewSaturday
            // 
            this.checkBoxViewSaturday.AutoSize = true;
            this.checkBoxViewSaturday.Location = new System.Drawing.Point(250, 74);
            this.checkBoxViewSaturday.Name = "checkBoxViewSaturday";
            this.checkBoxViewSaturday.Size = new System.Drawing.Size(87, 21);
            this.checkBoxViewSaturday.TabIndex = 5;
            this.checkBoxViewSaturday.Text = "Saturday";
            this.checkBoxViewSaturday.UseVisualStyleBackColor = true;
            // 
            // checkBoxViewSunday
            // 
            this.checkBoxViewSunday.AutoSize = true;
            this.checkBoxViewSunday.Location = new System.Drawing.Point(7, 113);
            this.checkBoxViewSunday.Name = "checkBoxViewSunday";
            this.checkBoxViewSunday.Size = new System.Drawing.Size(78, 21);
            this.checkBoxViewSunday.TabIndex = 6;
            this.checkBoxViewSunday.Text = "Sunday";
            this.checkBoxViewSunday.UseVisualStyleBackColor = true;
            // 
            // ViewDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 689);
            this.Controls.Add(this.btnDeleteWeekend);
            this.Controls.Add(this.WeekdayDetailsDelete);
            this.Controls.Add(this.groupBoxViewTimeSlot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxViewWorkingTimeMinutes);
            this.Controls.Add(this.comboBoxViewWorkingTimeHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxViewWorkingDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxViewNoOfWorkingDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewDetailsWeekend);
            this.Controls.Add(this.btnViewDetailsWeekday);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewDetailsForm";
            this.Text = "ViewDetailsForm";
            this.groupBoxViewWorkingDays.ResumeLayout(false);
            this.groupBoxViewWorkingDays.PerformLayout();
            this.groupBoxViewTimeSlot.ResumeLayout(false);
            this.groupBoxViewTimeSlot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewDetailsWeekday;
        private System.Windows.Forms.Button btnViewDetailsWeekend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxViewNoOfWorkingDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxViewWorkingDays;
        private System.Windows.Forms.CheckBox checkBoxViewThursday;
        private System.Windows.Forms.CheckBox checkBoxViewFriday;
        private System.Windows.Forms.CheckBox checkBoxViewWednesday;
        private System.Windows.Forms.CheckBox checkBoxViewTuesday;
        private System.Windows.Forms.CheckBox checkBoxViewMonday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxViewWorkingTimeHours;
        private System.Windows.Forms.ComboBox comboBoxViewWorkingTimeMinutes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxViewTimeSlot;
        private System.Windows.Forms.RadioButton radioButtonViewThirtyMinutes;
        private System.Windows.Forms.RadioButton radioButtonViewOneHour;
        private System.Windows.Forms.Button WeekdayDetailsDelete;
        private System.Windows.Forms.Button btnDeleteWeekend;
        private System.Windows.Forms.CheckBox checkBoxViewSunday;
        private System.Windows.Forms.CheckBox checkBoxViewSaturday;
    }
}