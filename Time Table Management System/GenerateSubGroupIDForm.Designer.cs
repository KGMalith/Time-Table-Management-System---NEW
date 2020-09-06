namespace Time_Table_Management_System
{
    partial class GenerateSubGroupIDForm
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
            this.dataGridViewSubGroupID = new System.Windows.Forms.DataGridView();
            this.textBoxSubGroupID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGroupID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSubGroupNumber = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteSubGroupID = new System.Windows.Forms.Button();
            this.btnAddSubGroupID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubGroupID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(194, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Generate SubGroup ID";
            // 
            // dataGridViewSubGroupID
            // 
            this.dataGridViewSubGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSubGroupID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSubGroupID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubGroupID.Location = new System.Drawing.Point(12, 353);
            this.dataGridViewSubGroupID.Name = "dataGridViewSubGroupID";
            this.dataGridViewSubGroupID.RowHeadersWidth = 51;
            this.dataGridViewSubGroupID.RowTemplate.Height = 24;
            this.dataGridViewSubGroupID.Size = new System.Drawing.Size(642, 298);
            this.dataGridViewSubGroupID.TabIndex = 31;
            this.dataGridViewSubGroupID.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSubGroupID_RowHeaderMouseClick);
            // 
            // textBoxSubGroupID
            // 
            this.textBoxSubGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSubGroupID.Location = new System.Drawing.Point(44, 128);
            this.textBoxSubGroupID.Name = "textBoxSubGroupID";
            this.textBoxSubGroupID.ReadOnly = true;
            this.textBoxSubGroupID.Size = new System.Drawing.Size(362, 22);
            this.textBoxSubGroupID.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "ID";
            // 
            // comboBoxGroupID
            // 
            this.comboBoxGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGroupID.FormattingEnabled = true;
            this.comboBoxGroupID.Location = new System.Drawing.Point(44, 192);
            this.comboBoxGroupID.Name = "comboBoxGroupID";
            this.comboBoxGroupID.Size = new System.Drawing.Size(362, 24);
            this.comboBoxGroupID.TabIndex = 41;
            this.comboBoxGroupID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Group ID";
            // 
            // comboBoxSubGroupNumber
            // 
            this.comboBoxSubGroupNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSubGroupNumber.FormattingEnabled = true;
            this.comboBoxSubGroupNumber.Location = new System.Drawing.Point(44, 260);
            this.comboBoxSubGroupNumber.Name = "comboBoxSubGroupNumber";
            this.comboBoxSubGroupNumber.Size = new System.Drawing.Size(362, 24);
            this.comboBoxSubGroupNumber.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Sub Group Number";
            // 
            // btnDeleteSubGroupID
            // 
            this.btnDeleteSubGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSubGroupID.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteSubGroupID.Location = new System.Drawing.Point(535, 227);
            this.btnDeleteSubGroupID.Name = "btnDeleteSubGroupID";
            this.btnDeleteSubGroupID.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteSubGroupID.TabIndex = 49;
            this.btnDeleteSubGroupID.Text = "Delete";
            this.btnDeleteSubGroupID.UseVisualStyleBackColor = false;
            this.btnDeleteSubGroupID.Click += new System.EventHandler(this.btnDeleteSubGroupID_Click);
            // 
            // btnAddSubGroupID
            // 
            this.btnAddSubGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSubGroupID.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddSubGroupID.Location = new System.Drawing.Point(535, 159);
            this.btnAddSubGroupID.Name = "btnAddSubGroupID";
            this.btnAddSubGroupID.Size = new System.Drawing.Size(75, 30);
            this.btnAddSubGroupID.TabIndex = 47;
            this.btnAddSubGroupID.Text = "Add";
            this.btnAddSubGroupID.UseVisualStyleBackColor = false;
            this.btnAddSubGroupID.Click += new System.EventHandler(this.btnAddSubGroupID_Click);
            // 
            // GenerateSubGroupIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 689);
            this.Controls.Add(this.btnDeleteSubGroupID);
            this.Controls.Add(this.btnAddSubGroupID);
            this.Controls.Add(this.comboBoxSubGroupNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxGroupID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSubGroupID);
            this.Controls.Add(this.dataGridViewSubGroupID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerateSubGroupIDForm";
            this.Text = "GenerateSubGroupIDForm";
            this.Load += new System.EventHandler(this.GenerateSubGroupIDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubGroupID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSubGroupID;
        private System.Windows.Forms.TextBox textBoxSubGroupID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGroupID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSubGroupNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteSubGroupID;
        private System.Windows.Forms.Button btnAddSubGroupID;
    }
}