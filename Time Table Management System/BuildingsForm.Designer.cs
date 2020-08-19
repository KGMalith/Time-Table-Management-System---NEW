namespace Time_Table_Management_System
{
    partial class BuildingsForm
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
            this.textBoxBuildingID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBuildingName = new System.Windows.Forms.TextBox();
            this.btnDeleteBuilding = new System.Windows.Forms.Button();
            this.btnUpdateBuilding = new System.Windows.Forms.Button();
            this.btnAddBuilding = new System.Windows.Forms.Button();
            this.dataGridViewBuilding = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuilding)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Building Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Building ID";
            // 
            // textBoxBuildingID
            // 
            this.textBoxBuildingID.Location = new System.Drawing.Point(17, 136);
            this.textBoxBuildingID.Name = "textBoxBuildingID";
            this.textBoxBuildingID.ReadOnly = true;
            this.textBoxBuildingID.Size = new System.Drawing.Size(362, 22);
            this.textBoxBuildingID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Building Name";
            // 
            // textBoxBuildingName
            // 
            this.textBoxBuildingName.Location = new System.Drawing.Point(18, 213);
            this.textBoxBuildingName.Name = "textBoxBuildingName";
            this.textBoxBuildingName.Size = new System.Drawing.Size(362, 22);
            this.textBoxBuildingName.TabIndex = 8;
            // 
            // btnDeleteBuilding
            // 
            this.btnDeleteBuilding.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteBuilding.Location = new System.Drawing.Point(254, 261);
            this.btnDeleteBuilding.Name = "btnDeleteBuilding";
            this.btnDeleteBuilding.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteBuilding.TabIndex = 26;
            this.btnDeleteBuilding.Text = "Delete";
            this.btnDeleteBuilding.UseVisualStyleBackColor = false;
            this.btnDeleteBuilding.Click += new System.EventHandler(this.btnDeleteBuilding_Click);
            // 
            // btnUpdateBuilding
            // 
            this.btnUpdateBuilding.BackColor = System.Drawing.Color.Khaki;
            this.btnUpdateBuilding.Location = new System.Drawing.Point(156, 261);
            this.btnUpdateBuilding.Name = "btnUpdateBuilding";
            this.btnUpdateBuilding.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateBuilding.TabIndex = 25;
            this.btnUpdateBuilding.Text = "Update";
            this.btnUpdateBuilding.UseVisualStyleBackColor = false;
            this.btnUpdateBuilding.Click += new System.EventHandler(this.btnUpdateBuilding_Click);
            // 
            // btnAddBuilding
            // 
            this.btnAddBuilding.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddBuilding.Location = new System.Drawing.Point(59, 261);
            this.btnAddBuilding.Name = "btnAddBuilding";
            this.btnAddBuilding.Size = new System.Drawing.Size(75, 30);
            this.btnAddBuilding.TabIndex = 24;
            this.btnAddBuilding.Text = "Add";
            this.btnAddBuilding.UseVisualStyleBackColor = false;
            this.btnAddBuilding.Click += new System.EventHandler(this.btnAddBuilding_Click);
            // 
            // dataGridViewBuilding
            // 
            this.dataGridViewBuilding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuilding.Location = new System.Drawing.Point(12, 332);
            this.dataGridViewBuilding.Name = "dataGridViewBuilding";
            this.dataGridViewBuilding.RowHeadersWidth = 51;
            this.dataGridViewBuilding.RowTemplate.Height = 24;
            this.dataGridViewBuilding.Size = new System.Drawing.Size(642, 321);
            this.dataGridViewBuilding.TabIndex = 27;
            this.dataGridViewBuilding.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBuilding_CellContentClick);
            this.dataGridViewBuilding.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBuilding_RowHeaderMouseClick);
            // 
            // BuildingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 689);
            this.Controls.Add(this.dataGridViewBuilding);
            this.Controls.Add(this.btnDeleteBuilding);
            this.Controls.Add(this.btnUpdateBuilding);
            this.Controls.Add(this.btnAddBuilding);
            this.Controls.Add(this.textBoxBuildingName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBuildingID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuildingsForm";
            this.Text = "BuildingsForm";
            this.Load += new System.EventHandler(this.BuildingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuilding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBuildingID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBuildingName;
        private System.Windows.Forms.Button btnDeleteBuilding;
        private System.Windows.Forms.Button btnUpdateBuilding;
        private System.Windows.Forms.Button btnAddBuilding;
        private System.Windows.Forms.DataGridView dataGridViewBuilding;
    }
}