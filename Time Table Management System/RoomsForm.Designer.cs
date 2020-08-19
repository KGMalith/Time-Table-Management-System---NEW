namespace Time_Table_Management_System
{
    partial class RoomsForm
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
            this.textBoxRoomID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.dataGridViewRoomDetails = new System.Windows.Forms.DataGridView();
            this.comboBoxBuildingName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rooms Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Room ID";
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Location = new System.Drawing.Point(17, 138);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.ReadOnly = true;
            this.textBoxRoomID.Size = new System.Drawing.Size(362, 22);
            this.textBoxRoomID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "BuildingName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Room Name";
            // 
            // textBoxRoomName
            // 
            this.textBoxRoomName.Location = new System.Drawing.Point(17, 267);
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(362, 22);
            this.textBoxRoomName.TabIndex = 11;
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteRoom.Location = new System.Drawing.Point(259, 321);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteRoom.TabIndex = 29;
            this.btnDeleteRoom.Text = "Delete";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.BackColor = System.Drawing.Color.Khaki;
            this.btnUpdateRoom.Location = new System.Drawing.Point(161, 321);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateRoom.TabIndex = 28;
            this.btnUpdateRoom.Text = "Update";
            this.btnUpdateRoom.UseVisualStyleBackColor = false;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddRoom.Location = new System.Drawing.Point(64, 321);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(75, 30);
            this.btnAddRoom.TabIndex = 27;
            this.btnAddRoom.Text = "Add";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // dataGridViewRoomDetails
            // 
            this.dataGridViewRoomDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoomDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoomDetails.Location = new System.Drawing.Point(12, 375);
            this.dataGridViewRoomDetails.Name = "dataGridViewRoomDetails";
            this.dataGridViewRoomDetails.RowHeadersWidth = 51;
            this.dataGridViewRoomDetails.RowTemplate.Height = 24;
            this.dataGridViewRoomDetails.Size = new System.Drawing.Size(642, 279);
            this.dataGridViewRoomDetails.TabIndex = 30;
            this.dataGridViewRoomDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRoomDetails_RowHeaderMouseClick);
            // 
            // comboBoxBuildingName
            // 
            this.comboBoxBuildingName.FormattingEnabled = true;
            this.comboBoxBuildingName.Location = new System.Drawing.Point(17, 200);
            this.comboBoxBuildingName.Name = "comboBoxBuildingName";
            this.comboBoxBuildingName.Size = new System.Drawing.Size(362, 24);
            this.comboBoxBuildingName.TabIndex = 31;
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 689);
            this.Controls.Add(this.comboBoxBuildingName);
            this.Controls.Add(this.dataGridViewRoomDetails);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnUpdateRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.textBoxRoomName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRoomID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomsForm";
            this.Text = "RoomsForm";
            this.Load += new System.EventHandler(this.RoomsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRoomID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRoomName;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.DataGridView dataGridViewRoomDetails;
        private System.Windows.Forms.ComboBox comboBoxBuildingName;
    }
}