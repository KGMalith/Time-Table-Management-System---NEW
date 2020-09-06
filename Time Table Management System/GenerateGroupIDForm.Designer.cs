namespace Time_Table_Management_System
{
    partial class GenerateGroupIDForm
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
            this.dataGridViewGroupID = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGroupID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxYearandSemester = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProgramme = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxGroupNumber = new System.Windows.Forms.ComboBox();
            this.btnDeleteGroupID = new System.Windows.Forms.Button();
            this.btnAddGroupID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(204, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Generate Group ID";
            // 
            // dataGridViewGroupID
            // 
            this.dataGridViewGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGroupID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroupID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroupID.Location = new System.Drawing.Point(12, 399);
            this.dataGridViewGroupID.Name = "dataGridViewGroupID";
            this.dataGridViewGroupID.RowHeadersWidth = 51;
            this.dataGridViewGroupID.RowTemplate.Height = 24;
            this.dataGridViewGroupID.Size = new System.Drawing.Size(642, 259);
            this.dataGridViewGroupID.TabIndex = 31;
            this.dataGridViewGroupID.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoomDetails_CellContentClick);
            this.dataGridViewGroupID.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewGroupID_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "ID";
            // 
            // textBoxGroupID
            // 
            this.textBoxGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGroupID.Location = new System.Drawing.Point(46, 105);
            this.textBoxGroupID.Name = "textBoxGroupID";
            this.textBoxGroupID.ReadOnly = true;
            this.textBoxGroupID.Size = new System.Drawing.Size(334, 22);
            this.textBoxGroupID.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Year And Semester";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxYearandSemester
            // 
            this.comboBoxYearandSemester.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxYearandSemester.FormattingEnabled = true;
            this.comboBoxYearandSemester.Location = new System.Drawing.Point(46, 170);
            this.comboBoxYearandSemester.Name = "comboBoxYearandSemester";
            this.comboBoxYearandSemester.Size = new System.Drawing.Size(334, 24);
            this.comboBoxYearandSemester.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Programme";
            // 
            // comboBoxProgramme
            // 
            this.comboBoxProgramme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProgramme.FormattingEnabled = true;
            this.comboBoxProgramme.Location = new System.Drawing.Point(46, 236);
            this.comboBoxProgramme.Name = "comboBoxProgramme";
            this.comboBoxProgramme.Size = new System.Drawing.Size(334, 24);
            this.comboBoxProgramme.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Group Number";
            // 
            // comboBoxGroupNumber
            // 
            this.comboBoxGroupNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGroupNumber.FormattingEnabled = true;
            this.comboBoxGroupNumber.Location = new System.Drawing.Point(46, 304);
            this.comboBoxGroupNumber.Name = "comboBoxGroupNumber";
            this.comboBoxGroupNumber.Size = new System.Drawing.Size(334, 24);
            this.comboBoxGroupNumber.TabIndex = 43;
            // 
            // btnDeleteGroupID
            // 
            this.btnDeleteGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteGroupID.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteGroupID.Location = new System.Drawing.Point(531, 240);
            this.btnDeleteGroupID.Name = "btnDeleteGroupID";
            this.btnDeleteGroupID.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteGroupID.TabIndex = 46;
            this.btnDeleteGroupID.Text = "Delete";
            this.btnDeleteGroupID.UseVisualStyleBackColor = false;
            this.btnDeleteGroupID.Click += new System.EventHandler(this.btnDeleteecturer_Click);
            // 
            // btnAddGroupID
            // 
            this.btnAddGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGroupID.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddGroupID.Location = new System.Drawing.Point(531, 164);
            this.btnAddGroupID.Name = "btnAddGroupID";
            this.btnAddGroupID.Size = new System.Drawing.Size(75, 30);
            this.btnAddGroupID.TabIndex = 44;
            this.btnAddGroupID.Text = "Add";
            this.btnAddGroupID.UseVisualStyleBackColor = false;
            this.btnAddGroupID.Click += new System.EventHandler(this.btnAddLecturer_Click);
            // 
            // GenerateGroupIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 689);
            this.Controls.Add(this.btnDeleteGroupID);
            this.Controls.Add(this.btnAddGroupID);
            this.Controls.Add(this.comboBoxGroupNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxProgramme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxYearandSemester);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxGroupID);
            this.Controls.Add(this.dataGridViewGroupID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerateGroupIDForm";
            this.Text = "GenerateGroupIDForm";
            this.Load += new System.EventHandler(this.GenerateGroupIDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewGroupID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGroupID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxYearandSemester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProgramme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxGroupNumber;
        private System.Windows.Forms.Button btnDeleteGroupID;
        private System.Windows.Forms.Button btnAddGroupID;
    }
}