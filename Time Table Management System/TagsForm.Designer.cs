namespace Time_Table_Management_System
{
    partial class TagsForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTagName = new System.Windows.Forms.TextBox();
            this.btnDeleteTag = new System.Windows.Forms.Button();
            this.btnUpdateTag = new System.Windows.Forms.Button();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.textBoxTagID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTagDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTagDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tags Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tag Name";
            // 
            // textBoxTagName
            // 
            this.textBoxTagName.Location = new System.Drawing.Point(17, 171);
            this.textBoxTagName.Name = "textBoxTagName";
            this.textBoxTagName.Size = new System.Drawing.Size(365, 22);
            this.textBoxTagName.TabIndex = 15;
            // 
            // btnDeleteTag
            // 
            this.btnDeleteTag.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteTag.Location = new System.Drawing.Point(229, 213);
            this.btnDeleteTag.Name = "btnDeleteTag";
            this.btnDeleteTag.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteTag.TabIndex = 31;
            this.btnDeleteTag.Text = "Delete";
            this.btnDeleteTag.UseVisualStyleBackColor = false;
            this.btnDeleteTag.Click += new System.EventHandler(this.btnDeleteTag_Click);
            // 
            // btnUpdateTag
            // 
            this.btnUpdateTag.BackColor = System.Drawing.Color.Khaki;
            this.btnUpdateTag.Location = new System.Drawing.Point(131, 213);
            this.btnUpdateTag.Name = "btnUpdateTag";
            this.btnUpdateTag.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateTag.TabIndex = 30;
            this.btnUpdateTag.Text = "Update";
            this.btnUpdateTag.UseVisualStyleBackColor = false;
            this.btnUpdateTag.Click += new System.EventHandler(this.btnUpdateTag_Click);
            // 
            // btnAddTag
            // 
            this.btnAddTag.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddTag.Location = new System.Drawing.Point(34, 213);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(75, 30);
            this.btnAddTag.TabIndex = 29;
            this.btnAddTag.Text = "Add";
            this.btnAddTag.UseVisualStyleBackColor = false;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // textBoxTagID
            // 
            this.textBoxTagID.Location = new System.Drawing.Point(17, 117);
            this.textBoxTagID.Name = "textBoxTagID";
            this.textBoxTagID.ReadOnly = true;
            this.textBoxTagID.Size = new System.Drawing.Size(365, 22);
            this.textBoxTagID.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tag ID";
            // 
            // dataGridViewTagDetails
            // 
            this.dataGridViewTagDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTagDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTagDetails.Location = new System.Drawing.Point(17, 269);
            this.dataGridViewTagDetails.Name = "dataGridViewTagDetails";
            this.dataGridViewTagDetails.RowHeadersWidth = 51;
            this.dataGridViewTagDetails.RowTemplate.Height = 24;
            this.dataGridViewTagDetails.Size = new System.Drawing.Size(625, 356);
            this.dataGridViewTagDetails.TabIndex = 34;
            this.dataGridViewTagDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTagDetails_RowHeaderMouseClick);
            // 
            // TagsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 689);
            this.Controls.Add(this.dataGridViewTagDetails);
            this.Controls.Add(this.textBoxTagID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteTag);
            this.Controls.Add(this.btnUpdateTag);
            this.Controls.Add(this.btnAddTag);
            this.Controls.Add(this.textBoxTagName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TagsForm";
            this.Text = "TagsForm";
            this.Load += new System.EventHandler(this.TagsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTagDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTagName;
        private System.Windows.Forms.Button btnDeleteTag;
        private System.Windows.Forms.Button btnUpdateTag;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.TextBox textBoxTagID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewTagDetails;
    }
}