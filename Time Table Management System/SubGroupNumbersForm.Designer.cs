namespace Time_Table_Management_System
{
    partial class SubGroupNumbersForm
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
            this.dataGridViewSubGroupNumber = new System.Windows.Forms.DataGridView();
            this.textBoxSubgroupID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteSubGroupNumber = new System.Windows.Forms.Button();
            this.btnUpdateSubgroupNumber = new System.Windows.Forms.Button();
            this.btnAddSubGroupNumber = new System.Windows.Forms.Button();
            this.textBoxSubgroupNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubGroupNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSubGroupNumber
            // 
            this.dataGridViewSubGroupNumber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSubGroupNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubGroupNumber.Location = new System.Drawing.Point(14, 248);
            this.dataGridViewSubGroupNumber.Name = "dataGridViewSubGroupNumber";
            this.dataGridViewSubGroupNumber.RowHeadersWidth = 51;
            this.dataGridViewSubGroupNumber.RowTemplate.Height = 24;
            this.dataGridViewSubGroupNumber.Size = new System.Drawing.Size(625, 356);
            this.dataGridViewSubGroupNumber.TabIndex = 52;
            this.dataGridViewSubGroupNumber.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSubGroupNumber_RowHeaderMouseClick);
            // 
            // textBoxSubgroupID
            // 
            this.textBoxSubgroupID.Location = new System.Drawing.Point(14, 96);
            this.textBoxSubgroupID.Name = "textBoxSubgroupID";
            this.textBoxSubgroupID.ReadOnly = true;
            this.textBoxSubgroupID.Size = new System.Drawing.Size(365, 22);
            this.textBoxSubgroupID.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "ID";
            // 
            // btnDeleteSubGroupNumber
            // 
            this.btnDeleteSubGroupNumber.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteSubGroupNumber.Location = new System.Drawing.Point(226, 192);
            this.btnDeleteSubGroupNumber.Name = "btnDeleteSubGroupNumber";
            this.btnDeleteSubGroupNumber.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteSubGroupNumber.TabIndex = 49;
            this.btnDeleteSubGroupNumber.Text = "Delete";
            this.btnDeleteSubGroupNumber.UseVisualStyleBackColor = false;
            this.btnDeleteSubGroupNumber.Click += new System.EventHandler(this.btnDeleteSubGroupNumber_Click);
            // 
            // btnUpdateSubgroupNumber
            // 
            this.btnUpdateSubgroupNumber.BackColor = System.Drawing.Color.Khaki;
            this.btnUpdateSubgroupNumber.Location = new System.Drawing.Point(128, 192);
            this.btnUpdateSubgroupNumber.Name = "btnUpdateSubgroupNumber";
            this.btnUpdateSubgroupNumber.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateSubgroupNumber.TabIndex = 48;
            this.btnUpdateSubgroupNumber.Text = "Update";
            this.btnUpdateSubgroupNumber.UseVisualStyleBackColor = false;
            this.btnUpdateSubgroupNumber.Click += new System.EventHandler(this.btnUpdateSubgroupNumber_Click);
            // 
            // btnAddSubGroupNumber
            // 
            this.btnAddSubGroupNumber.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddSubGroupNumber.Location = new System.Drawing.Point(31, 192);
            this.btnAddSubGroupNumber.Name = "btnAddSubGroupNumber";
            this.btnAddSubGroupNumber.Size = new System.Drawing.Size(75, 30);
            this.btnAddSubGroupNumber.TabIndex = 47;
            this.btnAddSubGroupNumber.Text = "Add";
            this.btnAddSubGroupNumber.UseVisualStyleBackColor = false;
            this.btnAddSubGroupNumber.Click += new System.EventHandler(this.btnAddSubGroupNumber_Click);
            // 
            // textBoxSubgroupNumber
            // 
            this.textBoxSubgroupNumber.Location = new System.Drawing.Point(14, 150);
            this.textBoxSubgroupNumber.Name = "textBoxSubgroupNumber";
            this.textBoxSubgroupNumber.Size = new System.Drawing.Size(365, 22);
            this.textBoxSubgroupNumber.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "SubGroup Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "SubGroup Number Details";
            // 
            // SubGroupNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 642);
            this.Controls.Add(this.dataGridViewSubGroupNumber);
            this.Controls.Add(this.textBoxSubgroupID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteSubGroupNumber);
            this.Controls.Add(this.btnUpdateSubgroupNumber);
            this.Controls.Add(this.btnAddSubGroupNumber);
            this.Controls.Add(this.textBoxSubgroupNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubGroupNumbersForm";
            this.Text = "SubGroupNumbersForm";
            this.Load += new System.EventHandler(this.SubGroupNumbersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubGroupNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSubGroupNumber;
        private System.Windows.Forms.TextBox textBoxSubgroupID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteSubGroupNumber;
        private System.Windows.Forms.Button btnUpdateSubgroupNumber;
        private System.Windows.Forms.Button btnAddSubGroupNumber;
        private System.Windows.Forms.TextBox textBoxSubgroupNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}