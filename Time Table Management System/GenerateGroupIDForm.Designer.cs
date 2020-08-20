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
            this.dataGridViewRoomDetails = new System.Windows.Forms.DataGridView();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRoomID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomDetails)).BeginInit();
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
            // dataGridViewRoomDetails
            // 
            this.dataGridViewRoomDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoomDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoomDetails.Location = new System.Drawing.Point(12, 297);
            this.dataGridViewRoomDetails.Name = "dataGridViewRoomDetails";
            this.dataGridViewRoomDetails.RowHeadersWidth = 51;
            this.dataGridViewRoomDetails.RowTemplate.Height = 24;
            this.dataGridViewRoomDetails.Size = new System.Drawing.Size(642, 303);
            this.dataGridViewRoomDetails.TabIndex = 31;
            this.dataGridViewRoomDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoomDetails_CellContentClick);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteRoom.Location = new System.Drawing.Point(186, 196);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteRoom.TabIndex = 37;
            this.btnDeleteRoom.Text = "Delete";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "ID";
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Location = new System.Drawing.Point(46, 152);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.ReadOnly = true;
            this.textBoxRoomID.Size = new System.Drawing.Size(362, 22);
            this.textBoxRoomID.TabIndex = 35;
            // 
            // GenerateGroupIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 689);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRoomID);
            this.Controls.Add(this.dataGridViewRoomDetails);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerateGroupIDForm";
            this.Text = "GenerateGroupIDForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRoomDetails;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRoomID;
    }
}