namespace Time_Table_Management_System
{
    partial class ProgrammeForm
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
            this.dataGridViewProgrammes = new System.Windows.Forms.DataGridView();
            this.textBoxProgrammeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteProgramme = new System.Windows.Forms.Button();
            this.btnUpdateProgramme = new System.Windows.Forms.Button();
            this.btnAddProgramme = new System.Windows.Forms.Button();
            this.textBoxProgrammeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgrammes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProgrammes
            // 
            this.dataGridViewProgrammes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProgrammes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProgrammes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProgrammes.Location = new System.Drawing.Point(23, 294);
            this.dataGridViewProgrammes.Name = "dataGridViewProgrammes";
            this.dataGridViewProgrammes.RowHeadersWidth = 51;
            this.dataGridViewProgrammes.RowTemplate.Height = 24;
            this.dataGridViewProgrammes.Size = new System.Drawing.Size(625, 356);
            this.dataGridViewProgrammes.TabIndex = 43;
            this.dataGridViewProgrammes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProgrammes_RowHeaderMouseClick);
            // 
            // textBoxProgrammeID
            // 
            this.textBoxProgrammeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProgrammeID.Location = new System.Drawing.Point(23, 119);
            this.textBoxProgrammeID.Name = "textBoxProgrammeID";
            this.textBoxProgrammeID.ReadOnly = true;
            this.textBoxProgrammeID.Size = new System.Drawing.Size(365, 22);
            this.textBoxProgrammeID.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "ID";
            // 
            // btnDeleteProgramme
            // 
            this.btnDeleteProgramme.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteProgramme.Location = new System.Drawing.Point(313, 227);
            this.btnDeleteProgramme.Name = "btnDeleteProgramme";
            this.btnDeleteProgramme.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteProgramme.TabIndex = 40;
            this.btnDeleteProgramme.Text = "Delete";
            this.btnDeleteProgramme.UseVisualStyleBackColor = false;
            this.btnDeleteProgramme.Click += new System.EventHandler(this.btnDeleteProgramme_Click);
            // 
            // btnUpdateProgramme
            // 
            this.btnUpdateProgramme.BackColor = System.Drawing.Color.Khaki;
            this.btnUpdateProgramme.Location = new System.Drawing.Point(215, 227);
            this.btnUpdateProgramme.Name = "btnUpdateProgramme";
            this.btnUpdateProgramme.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateProgramme.TabIndex = 39;
            this.btnUpdateProgramme.Text = "Update";
            this.btnUpdateProgramme.UseVisualStyleBackColor = false;
            this.btnUpdateProgramme.Click += new System.EventHandler(this.btnUpdateProgramme_Click);
            // 
            // btnAddProgramme
            // 
            this.btnAddProgramme.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddProgramme.Location = new System.Drawing.Point(118, 227);
            this.btnAddProgramme.Name = "btnAddProgramme";
            this.btnAddProgramme.Size = new System.Drawing.Size(75, 30);
            this.btnAddProgramme.TabIndex = 38;
            this.btnAddProgramme.Text = "Add";
            this.btnAddProgramme.UseVisualStyleBackColor = false;
            this.btnAddProgramme.Click += new System.EventHandler(this.btnAddProgramme_Click);
            // 
            // textBoxProgrammeName
            // 
            this.textBoxProgrammeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProgrammeName.Location = new System.Drawing.Point(23, 173);
            this.textBoxProgrammeName.Name = "textBoxProgrammeName";
            this.textBoxProgrammeName.Size = new System.Drawing.Size(365, 22);
            this.textBoxProgrammeName.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Programme Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Programme Details";
            // 
            // ProgrammeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 689);
            this.Controls.Add(this.dataGridViewProgrammes);
            this.Controls.Add(this.textBoxProgrammeID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteProgramme);
            this.Controls.Add(this.btnUpdateProgramme);
            this.Controls.Add(this.btnAddProgramme);
            this.Controls.Add(this.textBoxProgrammeName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgrammeForm";
            this.Text = "ProgrammeForm";
            this.Load += new System.EventHandler(this.ProgrammeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgrammes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProgrammes;
        private System.Windows.Forms.TextBox textBoxProgrammeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteProgramme;
        private System.Windows.Forms.Button btnUpdateProgramme;
        private System.Windows.Forms.Button btnAddProgramme;
        private System.Windows.Forms.TextBox textBoxProgrammeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}