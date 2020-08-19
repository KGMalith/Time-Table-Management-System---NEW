namespace Time_Table_Management_System
{
    partial class ViewDetailsWeekend
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
            this.btnViewDetailsWeekend = new System.Windows.Forms.Button();
            this.btnViewDetailsWeekday = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxViewNoOfWorkingDaysWeekend = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxViewWorkingDaysWeekend = new System.Windows.Forms.GroupBox();
            this.checkBoxViewSunday = new System.Windows.Forms.CheckBox();
            this.checkBoxViewSaturday = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxViewWorkingTimeHoursWeekend = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxViewWorkingTimeMinutesWeekend = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxViewTimeSlotWeekend = new System.Windows.Forms.GroupBox();
            this.radioButtonViewThirtyMinutesWeekend = new System.Windows.Forms.RadioButton();
            this.radioButtonViewOneHourWeekend = new System.Windows.Forms.RadioButton();
            this.WeekendDetailsDelete = new System.Windows.Forms.Button();
            this.groupBoxViewWorkingDaysWeekend.SuspendLayout();
            this.groupBoxViewTimeSlotWeekend.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(255, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "View Details";
            // 
            // btnViewDetailsWeekend
            // 
            this.btnViewDetailsWeekend.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewDetailsWeekend.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetailsWeekend.ForeColor = System.Drawing.SystemColors.Control;
            this.btnViewDetailsWeekend.Location = new System.Drawing.Point(377, 92);
            this.btnViewDetailsWeekend.Name = "btnViewDetailsWeekend";
            this.btnViewDetailsWeekend.Size = new System.Drawing.Size(104, 39);
            this.btnViewDetailsWeekend.TabIndex = 6;
            this.btnViewDetailsWeekend.Text = "Weekend";
            this.btnViewDetailsWeekend.UseVisualStyleBackColor = false;
            this.btnViewDetailsWeekend.Click += new System.EventHandler(this.btnViewDetailsWeekend_Click);
            // 
            // btnViewDetailsWeekday
            // 
            this.btnViewDetailsWeekday.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewDetailsWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetailsWeekday.ForeColor = System.Drawing.SystemColors.Control;
            this.btnViewDetailsWeekday.Location = new System.Drawing.Point(151, 92);
            this.btnViewDetailsWeekday.Name = "btnViewDetailsWeekday";
            this.btnViewDetailsWeekday.Size = new System.Drawing.Size(105, 39);
            this.btnViewDetailsWeekday.TabIndex = 5;
            this.btnViewDetailsWeekday.Text = "Weekday";
            this.btnViewDetailsWeekday.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "No Of Working Days";
            // 
            // comboBoxViewNoOfWorkingDaysWeekend
            // 
            this.comboBoxViewNoOfWorkingDaysWeekend.FormattingEnabled = true;
            this.comboBoxViewNoOfWorkingDaysWeekend.Items.AddRange(new object[] {
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
            this.comboBoxViewNoOfWorkingDaysWeekend.Location = new System.Drawing.Point(297, 179);
            this.comboBoxViewNoOfWorkingDaysWeekend.Name = "comboBoxViewNoOfWorkingDaysWeekend";
            this.comboBoxViewNoOfWorkingDaysWeekend.Size = new System.Drawing.Size(146, 24);
            this.comboBoxViewNoOfWorkingDaysWeekend.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Working Days";
            // 
            // groupBoxViewWorkingDaysWeekend
            // 
            this.groupBoxViewWorkingDaysWeekend.Controls.Add(this.checkBoxViewSunday);
            this.groupBoxViewWorkingDaysWeekend.Controls.Add(this.checkBoxViewSaturday);
            this.groupBoxViewWorkingDaysWeekend.Location = new System.Drawing.Point(297, 242);
            this.groupBoxViewWorkingDaysWeekend.Name = "groupBoxViewWorkingDaysWeekend";
            this.groupBoxViewWorkingDaysWeekend.Size = new System.Drawing.Size(218, 105);
            this.groupBoxViewWorkingDaysWeekend.TabIndex = 10;
            this.groupBoxViewWorkingDaysWeekend.TabStop = false;
            this.groupBoxViewWorkingDaysWeekend.Text = "Working Days";
            // 
            // checkBoxViewSunday
            // 
            this.checkBoxViewSunday.AutoSize = true;
            this.checkBoxViewSunday.Location = new System.Drawing.Point(126, 32);
            this.checkBoxViewSunday.Name = "checkBoxViewSunday";
            this.checkBoxViewSunday.Size = new System.Drawing.Size(78, 21);
            this.checkBoxViewSunday.TabIndex = 1;
            this.checkBoxViewSunday.Text = "Sunday";
            this.checkBoxViewSunday.UseVisualStyleBackColor = true;
            // 
            // checkBoxViewSaturday
            // 
            this.checkBoxViewSaturday.AutoSize = true;
            this.checkBoxViewSaturday.Location = new System.Drawing.Point(7, 32);
            this.checkBoxViewSaturday.Name = "checkBoxViewSaturday";
            this.checkBoxViewSaturday.Size = new System.Drawing.Size(87, 21);
            this.checkBoxViewSaturday.TabIndex = 0;
            this.checkBoxViewSaturday.Text = "Saturday";
            this.checkBoxViewSaturday.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Working Time Per Days";
            // 
            // comboBoxViewWorkingTimeHoursWeekend
            // 
            this.comboBoxViewWorkingTimeHoursWeekend.FormattingEnabled = true;
            this.comboBoxViewWorkingTimeHoursWeekend.Items.AddRange(new object[] {
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
            this.comboBoxViewWorkingTimeHoursWeekend.Location = new System.Drawing.Point(297, 380);
            this.comboBoxViewWorkingTimeHoursWeekend.Name = "comboBoxViewWorkingTimeHoursWeekend";
            this.comboBoxViewWorkingTimeHoursWeekend.Size = new System.Drawing.Size(121, 24);
            this.comboBoxViewWorkingTimeHoursWeekend.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "H";
            // 
            // comboBoxViewWorkingTimeMinutesWeekend
            // 
            this.comboBoxViewWorkingTimeMinutesWeekend.FormattingEnabled = true;
            this.comboBoxViewWorkingTimeMinutesWeekend.Items.AddRange(new object[] {
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
            this.comboBoxViewWorkingTimeMinutesWeekend.Location = new System.Drawing.Point(485, 380);
            this.comboBoxViewWorkingTimeMinutesWeekend.Name = "comboBoxViewWorkingTimeMinutesWeekend";
            this.comboBoxViewWorkingTimeMinutesWeekend.Size = new System.Drawing.Size(121, 24);
            this.comboBoxViewWorkingTimeMinutesWeekend.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(612, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "M";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Time Slot";
            // 
            // groupBoxViewTimeSlotWeekend
            // 
            this.groupBoxViewTimeSlotWeekend.Controls.Add(this.radioButtonViewThirtyMinutesWeekend);
            this.groupBoxViewTimeSlotWeekend.Controls.Add(this.radioButtonViewOneHourWeekend);
            this.groupBoxViewTimeSlotWeekend.Location = new System.Drawing.Point(297, 466);
            this.groupBoxViewTimeSlotWeekend.Name = "groupBoxViewTimeSlotWeekend";
            this.groupBoxViewTimeSlotWeekend.Size = new System.Drawing.Size(195, 131);
            this.groupBoxViewTimeSlotWeekend.TabIndex = 16;
            this.groupBoxViewTimeSlotWeekend.TabStop = false;
            this.groupBoxViewTimeSlotWeekend.Text = "Time Slot";
            // 
            // radioButtonViewThirtyMinutesWeekend
            // 
            this.radioButtonViewThirtyMinutesWeekend.AutoSize = true;
            this.radioButtonViewThirtyMinutesWeekend.Location = new System.Drawing.Point(7, 88);
            this.radioButtonViewThirtyMinutesWeekend.Name = "radioButtonViewThirtyMinutesWeekend";
            this.radioButtonViewThirtyMinutesWeekend.Size = new System.Drawing.Size(118, 21);
            this.radioButtonViewThirtyMinutesWeekend.TabIndex = 1;
            this.radioButtonViewThirtyMinutesWeekend.TabStop = true;
            this.radioButtonViewThirtyMinutesWeekend.Text = "Thirty Minutes";
            this.radioButtonViewThirtyMinutesWeekend.UseVisualStyleBackColor = true;
            // 
            // radioButtonViewOneHourWeekend
            // 
            this.radioButtonViewOneHourWeekend.AutoSize = true;
            this.radioButtonViewOneHourWeekend.Location = new System.Drawing.Point(7, 47);
            this.radioButtonViewOneHourWeekend.Name = "radioButtonViewOneHourWeekend";
            this.radioButtonViewOneHourWeekend.Size = new System.Drawing.Size(91, 21);
            this.radioButtonViewOneHourWeekend.TabIndex = 0;
            this.radioButtonViewOneHourWeekend.TabStop = true;
            this.radioButtonViewOneHourWeekend.Text = "One Hour";
            this.radioButtonViewOneHourWeekend.UseVisualStyleBackColor = true;
            // 
            // WeekendDetailsDelete
            // 
            this.WeekendDetailsDelete.BackColor = System.Drawing.Color.Red;
            this.WeekendDetailsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekendDetailsDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.WeekendDetailsDelete.Location = new System.Drawing.Point(541, 630);
            this.WeekendDetailsDelete.Name = "WeekendDetailsDelete";
            this.WeekendDetailsDelete.Size = new System.Drawing.Size(80, 30);
            this.WeekendDetailsDelete.TabIndex = 17;
            this.WeekendDetailsDelete.Text = "Delete";
            this.WeekendDetailsDelete.UseVisualStyleBackColor = false;
            // 
            // ViewDetailsWeekend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 689);
            this.Controls.Add(this.WeekendDetailsDelete);
            this.Controls.Add(this.groupBoxViewTimeSlotWeekend);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxViewWorkingTimeMinutesWeekend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxViewWorkingTimeHoursWeekend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxViewWorkingDaysWeekend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxViewNoOfWorkingDaysWeekend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewDetailsWeekend);
            this.Controls.Add(this.btnViewDetailsWeekday);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewDetailsWeekend";
            this.Text = "ViewDetailsWeekend";
            this.groupBoxViewWorkingDaysWeekend.ResumeLayout(false);
            this.groupBoxViewWorkingDaysWeekend.PerformLayout();
            this.groupBoxViewTimeSlotWeekend.ResumeLayout(false);
            this.groupBoxViewTimeSlotWeekend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewDetailsWeekend;
        private System.Windows.Forms.Button btnViewDetailsWeekday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxViewNoOfWorkingDaysWeekend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxViewWorkingDaysWeekend;
        private System.Windows.Forms.CheckBox checkBoxViewSunday;
        private System.Windows.Forms.CheckBox checkBoxViewSaturday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxViewWorkingTimeHoursWeekend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxViewWorkingTimeMinutesWeekend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxViewTimeSlotWeekend;
        private System.Windows.Forms.RadioButton radioButtonViewThirtyMinutesWeekend;
        private System.Windows.Forms.RadioButton radioButtonViewOneHourWeekend;
        private System.Windows.Forms.Button WeekendDetailsDelete;
    }
}