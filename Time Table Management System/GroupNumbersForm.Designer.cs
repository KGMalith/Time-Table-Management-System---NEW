namespace Time_Table_Management_System
{
    partial class GroupNumbersForm
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
            this.dataGridViewGroupNumber = new System.Windows.Forms.DataGridView();
            this.textBoxGroupNumberID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteGroupNumber = new System.Windows.Forms.Button();
            this.btnUpdateGroupNumber = new System.Windows.Forms.Button();
            this.btnAddGroupNumber = new System.Windows.Forms.Button();
            this.textBoxGroupNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGroupNumber
            // 
            this.dataGridViewGroupNumber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroupNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroupNumber.Location = new System.Drawing.Point(23, 271);
            this.dataGridViewGroupNumber.Name = "dataGridViewGroupNumber";
            this.dataGridViewGroupNumber.RowHeadersWidth = 51;
            this.dataGridViewGroupNumber.RowTemplate.Height = 24;
            this.dataGridViewGroupNumber.Size = new System.Drawing.Size(625, 356);
            this.dataGridViewGroupNumber.TabIndex = 52;
            this.dataGridViewGroupNumber.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewGroupNumber_RowHeaderMouseClick);
            // 
            // textBoxGroupNumberID
            // 
            this.textBoxGroupNumberID.Location = new System.Drawing.Point(23, 119);
            this.textBoxGroupNumberID.Name = "textBoxGroupNumberID";
            this.textBoxGroupNumberID.ReadOnly = true;
            this.textBoxGroupNumberID.Size = new System.Drawing.Size(365, 22);
            this.textBoxGroupNumberID.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "ID";
            // 
            // btnDeleteGroupNumber
            // 
            this.btnDeleteGroupNumber.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteGroupNumber.Location = new System.Drawing.Point(235, 215);
            this.btnDeleteGroupNumber.Name = "btnDeleteGroupNumber";
            this.btnDeleteGroupNumber.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteGroupNumber.TabIndex = 49;
            this.btnDeleteGroupNumber.Text = "Delete";
            this.btnDeleteGroupNumber.UseVisualStyleBackColor = false;
            this.btnDeleteGroupNumber.Click += new System.EventHandler(this.btnDeleteGroupNumber_Click);
            // 
            // btnUpdateGroupNumber
            // 
            this.btnUpdateGroupNumber.BackColor = System.Drawing.Color.Khaki;
            this.btnUpdateGroupNumber.Location = new System.Drawing.Point(137, 215);
            this.btnUpdateGroupNumber.Name = "btnUpdateGroupNumber";
            this.btnUpdateGroupNumber.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateGroupNumber.TabIndex = 48;
            this.btnUpdateGroupNumber.Text = "Update";
            this.btnUpdateGroupNumber.UseVisualStyleBackColor = false;
            this.btnUpdateGroupNumber.Click += new System.EventHandler(this.btnUpdateGroupNumber_Click);
            // 
            // btnAddGroupNumber
            // 
            this.btnAddGroupNumber.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddGroupNumber.Location = new System.Drawing.Point(40, 215);
            this.btnAddGroupNumber.Name = "btnAddGroupNumber";
            this.btnAddGroupNumber.Size = new System.Drawing.Size(75, 30);
            this.btnAddGroupNumber.TabIndex = 47;
            this.btnAddGroupNumber.Text = "Add";
            this.btnAddGroupNumber.UseVisualStyleBackColor = false;
            this.btnAddGroupNumber.Click += new System.EventHandler(this.btnAddGroupNumber_Click);
            // 
            // textBoxGroupNumber
            // 
            this.textBoxGroupNumber.Location = new System.Drawing.Point(23, 173);
            this.textBoxGroupNumber.Name = "textBoxGroupNumber";
            this.textBoxGroupNumber.Size = new System.Drawing.Size(365, 22);
            this.textBoxGroupNumber.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Group Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Group Number Details";
            // 
            // GroupNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 689);
            this.Controls.Add(this.dataGridViewGroupNumber);
            this.Controls.Add(this.textBoxGroupNumberID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteGroupNumber);
            this.Controls.Add(this.btnUpdateGroupNumber);
            this.Controls.Add(this.btnAddGroupNumber);
            this.Controls.Add(this.textBoxGroupNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupNumbersForm";
            this.Text = "GroupNumbersForm";
            this.Load += new System.EventHandler(this.GroupNumbersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGroupNumber;
        private System.Windows.Forms.TextBox textBoxGroupNumberID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteGroupNumber;
        private System.Windows.Forms.Button btnUpdateGroupNumber;
        private System.Windows.Forms.Button btnAddGroupNumber;
        private System.Windows.Forms.TextBox textBoxGroupNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}