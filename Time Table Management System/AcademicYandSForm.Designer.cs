namespace Time_Table_Management_System
{
    partial class AcademicYandSForm
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
            this.dataGridViewAcademicYearandSem = new System.Windows.Forms.DataGridView();
            this.btnDeleteYearandSemester = new System.Windows.Forms.Button();
            this.btnUpdateYearandSemester = new System.Windows.Forms.Button();
            this.btnAddYearandSemester = new System.Windows.Forms.Button();
            this.textBoxYearandSemesterID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxYearandSemester = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcademicYearandSem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(31, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Academic Year and Semester";
            // 
            // dataGridViewAcademicYearandSem
            // 
            this.dataGridViewAcademicYearandSem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAcademicYearandSem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAcademicYearandSem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAcademicYearandSem.Location = new System.Drawing.Point(12, 309);
            this.dataGridViewAcademicYearandSem.Name = "dataGridViewAcademicYearandSem";
            this.dataGridViewAcademicYearandSem.RowHeadersWidth = 51;
            this.dataGridViewAcademicYearandSem.RowTemplate.Height = 24;
            this.dataGridViewAcademicYearandSem.Size = new System.Drawing.Size(624, 272);
            this.dataGridViewAcademicYearandSem.TabIndex = 4;
            this.dataGridViewAcademicYearandSem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewAcademicYearandSem.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAcademicYearandSem_RowHeaderMouseClick);
            // 
            // btnDeleteYearandSemester
            // 
            this.btnDeleteYearandSemester.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteYearandSemester.Location = new System.Drawing.Point(326, 239);
            this.btnDeleteYearandSemester.Name = "btnDeleteYearandSemester";
            this.btnDeleteYearandSemester.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteYearandSemester.TabIndex = 34;
            this.btnDeleteYearandSemester.Text = "Delete";
            this.btnDeleteYearandSemester.UseVisualStyleBackColor = false;
            this.btnDeleteYearandSemester.Click += new System.EventHandler(this.btnDeleteYearandSemester_Click);
            // 
            // btnUpdateYearandSemester
            // 
            this.btnUpdateYearandSemester.BackColor = System.Drawing.Color.Khaki;
            this.btnUpdateYearandSemester.Location = new System.Drawing.Point(228, 239);
            this.btnUpdateYearandSemester.Name = "btnUpdateYearandSemester";
            this.btnUpdateYearandSemester.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateYearandSemester.TabIndex = 33;
            this.btnUpdateYearandSemester.Text = "Update";
            this.btnUpdateYearandSemester.UseVisualStyleBackColor = false;
            this.btnUpdateYearandSemester.Click += new System.EventHandler(this.btnUpdateYearandSemester_Click);
            // 
            // btnAddYearandSemester
            // 
            this.btnAddYearandSemester.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddYearandSemester.Location = new System.Drawing.Point(131, 239);
            this.btnAddYearandSemester.Name = "btnAddYearandSemester";
            this.btnAddYearandSemester.Size = new System.Drawing.Size(75, 30);
            this.btnAddYearandSemester.TabIndex = 32;
            this.btnAddYearandSemester.Text = "Add";
            this.btnAddYearandSemester.UseVisualStyleBackColor = false;
            this.btnAddYearandSemester.Click += new System.EventHandler(this.btnAddYearandSemester_Click);
            // 
            // textBoxYearandSemesterID
            // 
            this.textBoxYearandSemesterID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxYearandSemesterID.Location = new System.Drawing.Point(36, 139);
            this.textBoxYearandSemesterID.Name = "textBoxYearandSemesterID";
            this.textBoxYearandSemesterID.ReadOnly = true;
            this.textBoxYearandSemesterID.Size = new System.Drawing.Size(365, 22);
            this.textBoxYearandSemesterID.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "ID";
            // 
            // textBoxYearandSemester
            // 
            this.textBoxYearandSemester.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxYearandSemester.Location = new System.Drawing.Point(36, 193);
            this.textBoxYearandSemester.Name = "textBoxYearandSemester";
            this.textBoxYearandSemester.Size = new System.Drawing.Size(365, 22);
            this.textBoxYearandSemester.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Academic Year and Semester";
            // 
            // AcademicYandSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 642);
            this.Controls.Add(this.textBoxYearandSemesterID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxYearandSemester);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteYearandSemester);
            this.Controls.Add(this.btnUpdateYearandSemester);
            this.Controls.Add(this.btnAddYearandSemester);
            this.Controls.Add(this.dataGridViewAcademicYearandSem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcademicYandSForm";
            this.Text = "AcademicYandSForm";
            this.Load += new System.EventHandler(this.AcademicYandSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcademicYearandSem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewAcademicYearandSem;
        private System.Windows.Forms.Button btnDeleteYearandSemester;
        private System.Windows.Forms.Button btnUpdateYearandSemester;
        private System.Windows.Forms.Button btnAddYearandSemester;
        private System.Windows.Forms.TextBox textBoxYearandSemesterID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxYearandSemester;
        private System.Windows.Forms.Label label5;
    }
}