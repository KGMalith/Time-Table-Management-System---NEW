namespace Time_Table_Management_System
{
    partial class LecturerDetailsForm
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
            this.textBoxLecturerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCenter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxLBuilding = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.textBoxRank = new System.Windows.Forms.TextBox();
            this.dataGridViewLecturerDetails = new System.Windows.Forms.DataGridView();
            this.btnAddLecturer = new System.Windows.Forms.Button();
            this.btnUpdateLecturer = new System.Windows.Forms.Button();
            this.btnDeleteecturer = new System.Windows.Forms.Button();
            this.textBoxLecturerID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lecturer Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxLecturerName
            // 
            this.textBoxLecturerName.Location = new System.Drawing.Point(17, 188);
            this.textBoxLecturerName.Name = "textBoxLecturerName";
            this.textBoxLecturerName.Size = new System.Drawing.Size(163, 22);
            this.textBoxLecturerName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Employee ID";
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Location = new System.Drawing.Point(17, 240);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(163, 22);
            this.textBoxEmployeeID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Faculty";
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Items.AddRange(new object[] {
            "Computing",
            "Business School",
            "Humanities & Sciences",
            "Architecture",
            "Hospitality & Culinary"});
            this.comboBoxFaculty.Location = new System.Drawing.Point(17, 294);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(163, 24);
            this.comboBoxFaculty.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Department";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Items.AddRange(new object[] {
            "IT",
            "SE",
            "DS",
            "IM",
            "IS"});
            this.comboBoxDepartment.Location = new System.Drawing.Point(17, 350);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(163, 24);
            this.comboBoxDepartment.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Center";
            // 
            // comboBoxCenter
            // 
            this.comboBoxCenter.FormattingEnabled = true;
            this.comboBoxCenter.Items.AddRange(new object[] {
            "Malabe",
            "Kollupitiya",
            "Matara",
            "Kandy",
            "Kurunegala",
            "Jaffna"});
            this.comboBoxCenter.Location = new System.Drawing.Point(17, 407);
            this.comboBoxCenter.Name = "comboBoxCenter";
            this.comboBoxCenter.Size = new System.Drawing.Size(163, 24);
            this.comboBoxCenter.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Building";
            // 
            // comboBoxLBuilding
            // 
            this.comboBoxLBuilding.FormattingEnabled = true;
            this.comboBoxLBuilding.Location = new System.Drawing.Point(17, 464);
            this.comboBoxLBuilding.Name = "comboBoxLBuilding";
            this.comboBoxLBuilding.Size = new System.Drawing.Size(163, 24);
            this.comboBoxLBuilding.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 503);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Level";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 562);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Rank";
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxLevel.Location = new System.Drawing.Point(17, 523);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(163, 24);
            this.comboBoxLevel.TabIndex = 18;
            // 
            // textBoxRank
            // 
            this.textBoxRank.Location = new System.Drawing.Point(17, 582);
            this.textBoxRank.Name = "textBoxRank";
            this.textBoxRank.Size = new System.Drawing.Size(163, 22);
            this.textBoxRank.TabIndex = 19;
            // 
            // dataGridViewLecturerDetails
            // 
            this.dataGridViewLecturerDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewLecturerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLecturerDetails.Location = new System.Drawing.Point(210, 169);
            this.dataGridViewLecturerDetails.Name = "dataGridViewLecturerDetails";
            this.dataGridViewLecturerDetails.RowHeadersWidth = 51;
            this.dataGridViewLecturerDetails.RowTemplate.Height = 24;
            this.dataGridViewLecturerDetails.Size = new System.Drawing.Size(444, 356);
            this.dataGridViewLecturerDetails.TabIndex = 20;
            this.dataGridViewLecturerDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewLecturerDetails_RowHeaderMouseClick);
            // 
            // btnAddLecturer
            // 
            this.btnAddLecturer.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddLecturer.Location = new System.Drawing.Point(284, 564);
            this.btnAddLecturer.Name = "btnAddLecturer";
            this.btnAddLecturer.Size = new System.Drawing.Size(75, 30);
            this.btnAddLecturer.TabIndex = 21;
            this.btnAddLecturer.Text = "Add";
            this.btnAddLecturer.UseVisualStyleBackColor = false;
            this.btnAddLecturer.Click += new System.EventHandler(this.btnAddLecturer_Click);
            // 
            // btnUpdateLecturer
            // 
            this.btnUpdateLecturer.BackColor = System.Drawing.Color.Khaki;
            this.btnUpdateLecturer.Location = new System.Drawing.Point(381, 564);
            this.btnUpdateLecturer.Name = "btnUpdateLecturer";
            this.btnUpdateLecturer.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateLecturer.TabIndex = 22;
            this.btnUpdateLecturer.Text = "Update";
            this.btnUpdateLecturer.UseVisualStyleBackColor = false;
            this.btnUpdateLecturer.Click += new System.EventHandler(this.btnUpdateLecturer_Click);
            // 
            // btnDeleteecturer
            // 
            this.btnDeleteecturer.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteecturer.Location = new System.Drawing.Point(479, 564);
            this.btnDeleteecturer.Name = "btnDeleteecturer";
            this.btnDeleteecturer.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteecturer.TabIndex = 23;
            this.btnDeleteecturer.Text = "Delete";
            this.btnDeleteecturer.UseVisualStyleBackColor = false;
            this.btnDeleteecturer.Click += new System.EventHandler(this.btnDeleteecturer_Click);
            // 
            // textBoxLecturerID
            // 
            this.textBoxLecturerID.Location = new System.Drawing.Point(17, 134);
            this.textBoxLecturerID.Name = "textBoxLecturerID";
            this.textBoxLecturerID.ReadOnly = true;
            this.textBoxLecturerID.Size = new System.Drawing.Size(163, 22);
            this.textBoxLecturerID.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "ID";
            // 
            // LecturerDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 689);
            this.Controls.Add(this.textBoxLecturerID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDeleteecturer);
            this.Controls.Add(this.btnUpdateLecturer);
            this.Controls.Add(this.btnAddLecturer);
            this.Controls.Add(this.dataGridViewLecturerDetails);
            this.Controls.Add(this.textBoxRank);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxLBuilding);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxCenter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxFaculty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEmployeeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLecturerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LecturerDetailsForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.LecturerDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturerDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLecturerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCenter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxLBuilding;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.TextBox textBoxRank;
        private System.Windows.Forms.DataGridView dataGridViewLecturerDetails;
        private System.Windows.Forms.Button btnAddLecturer;
        private System.Windows.Forms.Button btnUpdateLecturer;
        private System.Windows.Forms.Button btnDeleteecturer;
        private System.Windows.Forms.TextBox textBoxLecturerID;
        private System.Windows.Forms.Label label10;
    }
}