namespace Time_Table_Management_System
{
    partial class SubjectDetailsForm
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
            this.textBoxSubjectID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOfferedYear = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOfferedSemester = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSubjectName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSubjectCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLectureHours = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTutorialHours = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxLabHours = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEvaluationHours = new System.Windows.Forms.TextBox();
            this.dataGridViewSubjectDetails = new System.Windows.Forms.DataGridView();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.btnUpdateSubject = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjectDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subject Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject ID";
            // 
            // textBoxSubjectID
            // 
            this.textBoxSubjectID.Location = new System.Drawing.Point(17, 137);
            this.textBoxSubjectID.Name = "textBoxSubjectID";
            this.textBoxSubjectID.ReadOnly = true;
            this.textBoxSubjectID.Size = new System.Drawing.Size(163, 22);
            this.textBoxSubjectID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Offered Year";
            // 
            // comboBoxOfferedYear
            // 
            this.comboBoxOfferedYear.FormattingEnabled = true;
            this.comboBoxOfferedYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxOfferedYear.Location = new System.Drawing.Point(17, 194);
            this.comboBoxOfferedYear.Name = "comboBoxOfferedYear";
            this.comboBoxOfferedYear.Size = new System.Drawing.Size(163, 24);
            this.comboBoxOfferedYear.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Offered Semester";
            // 
            // comboBoxOfferedSemester
            // 
            this.comboBoxOfferedSemester.FormattingEnabled = true;
            this.comboBoxOfferedSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxOfferedSemester.Location = new System.Drawing.Point(17, 254);
            this.comboBoxOfferedSemester.Name = "comboBoxOfferedSemester";
            this.comboBoxOfferedSemester.Size = new System.Drawing.Size(163, 24);
            this.comboBoxOfferedSemester.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Subject Name";
            // 
            // textBoxSubjectName
            // 
            this.textBoxSubjectName.Location = new System.Drawing.Point(17, 314);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.Size = new System.Drawing.Size(163, 22);
            this.textBoxSubjectName.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Subject Code";
            // 
            // textBoxSubjectCode
            // 
            this.textBoxSubjectCode.Location = new System.Drawing.Point(17, 370);
            this.textBoxSubjectCode.Name = "textBoxSubjectCode";
            this.textBoxSubjectCode.Size = new System.Drawing.Size(163, 22);
            this.textBoxSubjectCode.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "No Of Lecture Hours";
            // 
            // textBoxLectureHours
            // 
            this.textBoxLectureHours.Location = new System.Drawing.Point(17, 427);
            this.textBoxLectureHours.Name = "textBoxLectureHours";
            this.textBoxLectureHours.Size = new System.Drawing.Size(163, 22);
            this.textBoxLectureHours.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "No Of Tutorial Hours";
            // 
            // textBoxTutorialHours
            // 
            this.textBoxTutorialHours.Location = new System.Drawing.Point(17, 485);
            this.textBoxTutorialHours.Name = "textBoxTutorialHours";
            this.textBoxTutorialHours.Size = new System.Drawing.Size(163, 22);
            this.textBoxTutorialHours.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 527);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "No Of Lab Hours";
            // 
            // textBoxLabHours
            // 
            this.textBoxLabHours.Location = new System.Drawing.Point(17, 547);
            this.textBoxLabHours.Name = "textBoxLabHours";
            this.textBoxLabHours.Size = new System.Drawing.Size(163, 22);
            this.textBoxLabHours.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 589);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "No Of Evaluation Hours";
            // 
            // textBoxEvaluationHours
            // 
            this.textBoxEvaluationHours.Location = new System.Drawing.Point(17, 609);
            this.textBoxEvaluationHours.Name = "textBoxEvaluationHours";
            this.textBoxEvaluationHours.Size = new System.Drawing.Size(163, 22);
            this.textBoxEvaluationHours.TabIndex = 24;
            // 
            // dataGridViewSubjectDetails
            // 
            this.dataGridViewSubjectDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubjectDetails.Location = new System.Drawing.Point(198, 174);
            this.dataGridViewSubjectDetails.Name = "dataGridViewSubjectDetails";
            this.dataGridViewSubjectDetails.RowHeadersWidth = 51;
            this.dataGridViewSubjectDetails.RowTemplate.Height = 24;
            this.dataGridViewSubjectDetails.Size = new System.Drawing.Size(456, 356);
            this.dataGridViewSubjectDetails.TabIndex = 25;
            this.dataGridViewSubjectDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSubjectDetails_RowHeaderMouseClick);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteSubject.Location = new System.Drawing.Point(489, 560);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteSubject.TabIndex = 28;
            this.btnDeleteSubject.Text = "Delete";
            this.btnDeleteSubject.UseVisualStyleBackColor = false;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // btnUpdateSubject
            // 
            this.btnUpdateSubject.BackColor = System.Drawing.Color.Khaki;
            this.btnUpdateSubject.Location = new System.Drawing.Point(391, 560);
            this.btnUpdateSubject.Name = "btnUpdateSubject";
            this.btnUpdateSubject.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateSubject.TabIndex = 27;
            this.btnUpdateSubject.Text = "Update";
            this.btnUpdateSubject.UseVisualStyleBackColor = false;
            this.btnUpdateSubject.Click += new System.EventHandler(this.btnUpdateSubject_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddSubject.Location = new System.Drawing.Point(294, 560);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(75, 30);
            this.btnAddSubject.TabIndex = 26;
            this.btnAddSubject.Text = "Add";
            this.btnAddSubject.UseVisualStyleBackColor = false;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // SubjectDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 689);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnUpdateSubject);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.dataGridViewSubjectDetails);
            this.Controls.Add(this.textBoxEvaluationHours);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxLabHours);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxTutorialHours);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxLectureHours);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSubjectCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSubjectName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxOfferedSemester);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxOfferedYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSubjectID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubjectDetailsForm";
            this.Text = "SubjectDetailsForm";
            this.Load += new System.EventHandler(this.SubjectDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjectDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSubjectID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOfferedYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxOfferedSemester;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSubjectName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSubjectCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLectureHours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTutorialHours;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxLabHours;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEvaluationHours;
        private System.Windows.Forms.DataGridView dataGridViewSubjectDetails;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.Button btnUpdateSubject;
        private System.Windows.Forms.Button btnAddSubject;
    }
}