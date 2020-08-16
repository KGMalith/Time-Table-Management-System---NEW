namespace Time_Table_Management_System
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelGenerateTimeTableSubmenu = new System.Windows.Forms.Panel();
            this.btnWeekEndTimeTable = new System.Windows.Forms.Button();
            this.btnWeekdayTimeTable = new System.Windows.Forms.Button();
            this.btnGenerateTimeTable = new System.Windows.Forms.Button();
            this.panelRoomManagementSubmenu = new System.Windows.Forms.Panel();
            this.btnUnavailableRooms = new System.Windows.Forms.Button();
            this.btnConsecutiveSessions = new System.Windows.Forms.Button();
            this.btnRoomSesstions = new System.Windows.Forms.Button();
            this.btnRoomsforGroupandSubGroups = new System.Windows.Forms.Button();
            this.btnRoomsforLectures = new System.Windows.Forms.Button();
            this.btnPreferedRoomsTagsandSubject = new System.Windows.Forms.Button();
            this.btnAllocateRoomforTag = new System.Windows.Forms.Button();
            this.btnRoomManagement = new System.Windows.Forms.Button();
            this.panelSessionManagentSubmenu = new System.Windows.Forms.Panel();
            this.btnNotOverlappingSessions = new System.Windows.Forms.Button();
            this.btnParallelSessions = new System.Windows.Forms.Button();
            this.btnConsecutiveSession = new System.Windows.Forms.Button();
            this.btnAllocateNotAvailable = new System.Windows.Forms.Button();
            this.btnSessionManagement = new System.Windows.Forms.Button();
            this.panelStatSubmenu = new System.Windows.Forms.Panel();
            this.btnSubjectsStat = new System.Windows.Forms.Button();
            this.btnStudentsStat = new System.Windows.Forms.Button();
            this.btnLecturesStat = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.panelLocationsSubmenu = new System.Windows.Forms.Panel();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnBuildings = new System.Windows.Forms.Button();
            this.btnLocations = new System.Windows.Forms.Button();
            this.btnTags = new System.Windows.Forms.Button();
            this.panelStudentDetailsSubmenu = new System.Windows.Forms.Panel();
            this.btnGenerateSubGroupID = new System.Windows.Forms.Button();
            this.btnSubGroupNumbers = new System.Windows.Forms.Button();
            this.btnGenerateGroupID = new System.Windows.Forms.Button();
            this.btnGroupNumber = new System.Windows.Forms.Button();
            this.btnProgramme = new System.Windows.Forms.Button();
            this.btnYearandSemester = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnLecturers = new System.Windows.Forms.Button();
            this.panelWDandHsubmenu = new System.Windows.Forms.Panel();
            this.btnEditDetails = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnWeekendDetails = new System.Windows.Forms.Button();
            this.btnWeekdayDetails = new System.Windows.Forms.Button();
            this.btnWDandH = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelGenerateTimeTableSubmenu.SuspendLayout();
            this.panelRoomManagementSubmenu.SuspendLayout();
            this.panelSessionManagentSubmenu.SuspendLayout();
            this.panelStatSubmenu.SuspendLayout();
            this.panelLocationsSubmenu.SuspendLayout();
            this.panelStudentDetailsSubmenu.SuspendLayout();
            this.panelWDandHsubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.panelGenerateTimeTableSubmenu);
            this.panelSideMenu.Controls.Add(this.btnGenerateTimeTable);
            this.panelSideMenu.Controls.Add(this.panelRoomManagementSubmenu);
            this.panelSideMenu.Controls.Add(this.btnRoomManagement);
            this.panelSideMenu.Controls.Add(this.panelSessionManagentSubmenu);
            this.panelSideMenu.Controls.Add(this.btnSessionManagement);
            this.panelSideMenu.Controls.Add(this.panelStatSubmenu);
            this.panelSideMenu.Controls.Add(this.btnStatistics);
            this.panelSideMenu.Controls.Add(this.panelLocationsSubmenu);
            this.panelSideMenu.Controls.Add(this.btnLocations);
            this.panelSideMenu.Controls.Add(this.btnTags);
            this.panelSideMenu.Controls.Add(this.panelStudentDetailsSubmenu);
            this.panelSideMenu.Controls.Add(this.btnStudent);
            this.panelSideMenu.Controls.Add(this.btnSubject);
            this.panelSideMenu.Controls.Add(this.btnLecturers);
            this.panelSideMenu.Controls.Add(this.panelWDandHsubmenu);
            this.panelSideMenu.Controls.Add(this.btnWDandH);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(300, 689);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // panelGenerateTimeTableSubmenu
            // 
            this.panelGenerateTimeTableSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelGenerateTimeTableSubmenu.Controls.Add(this.btnWeekEndTimeTable);
            this.panelGenerateTimeTableSubmenu.Controls.Add(this.btnWeekdayTimeTable);
            this.panelGenerateTimeTableSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGenerateTimeTableSubmenu.Location = new System.Drawing.Point(0, 979);
            this.panelGenerateTimeTableSubmenu.Name = "panelGenerateTimeTableSubmenu";
            this.panelGenerateTimeTableSubmenu.Size = new System.Drawing.Size(279, 55);
            this.panelGenerateTimeTableSubmenu.TabIndex = 18;
            // 
            // btnWeekEndTimeTable
            // 
            this.btnWeekEndTimeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWeekEndTimeTable.FlatAppearance.BorderSize = 0;
            this.btnWeekEndTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekEndTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekEndTimeTable.ForeColor = System.Drawing.Color.LightGray;
            this.btnWeekEndTimeTable.Location = new System.Drawing.Point(0, 25);
            this.btnWeekEndTimeTable.Name = "btnWeekEndTimeTable";
            this.btnWeekEndTimeTable.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnWeekEndTimeTable.Size = new System.Drawing.Size(279, 25);
            this.btnWeekEndTimeTable.TabIndex = 1;
            this.btnWeekEndTimeTable.Text = "Weekend";
            this.btnWeekEndTimeTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeekEndTimeTable.UseVisualStyleBackColor = true;
            this.btnWeekEndTimeTable.Click += new System.EventHandler(this.btnWeekEndTimeTable_Click);
            // 
            // btnWeekdayTimeTable
            // 
            this.btnWeekdayTimeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWeekdayTimeTable.FlatAppearance.BorderSize = 0;
            this.btnWeekdayTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekdayTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekdayTimeTable.ForeColor = System.Drawing.Color.LightGray;
            this.btnWeekdayTimeTable.Location = new System.Drawing.Point(0, 0);
            this.btnWeekdayTimeTable.Name = "btnWeekdayTimeTable";
            this.btnWeekdayTimeTable.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnWeekdayTimeTable.Size = new System.Drawing.Size(279, 25);
            this.btnWeekdayTimeTable.TabIndex = 0;
            this.btnWeekdayTimeTable.Text = "Weekday";
            this.btnWeekdayTimeTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeekdayTimeTable.UseVisualStyleBackColor = true;
            this.btnWeekdayTimeTable.Click += new System.EventHandler(this.btnWeekdayTimeTable_Click);
            // 
            // btnGenerateTimeTable
            // 
            this.btnGenerateTimeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerateTimeTable.FlatAppearance.BorderSize = 0;
            this.btnGenerateTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTimeTable.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGenerateTimeTable.Location = new System.Drawing.Point(0, 949);
            this.btnGenerateTimeTable.Name = "btnGenerateTimeTable";
            this.btnGenerateTimeTable.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGenerateTimeTable.Size = new System.Drawing.Size(279, 30);
            this.btnGenerateTimeTable.TabIndex = 17;
            this.btnGenerateTimeTable.Text = "Generate Time Table";
            this.btnGenerateTimeTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateTimeTable.UseVisualStyleBackColor = true;
            this.btnGenerateTimeTable.Click += new System.EventHandler(this.btnGenerateTimeTable_Click);
            // 
            // panelRoomManagementSubmenu
            // 
            this.panelRoomManagementSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelRoomManagementSubmenu.Controls.Add(this.btnUnavailableRooms);
            this.panelRoomManagementSubmenu.Controls.Add(this.btnConsecutiveSessions);
            this.panelRoomManagementSubmenu.Controls.Add(this.btnRoomSesstions);
            this.panelRoomManagementSubmenu.Controls.Add(this.btnRoomsforGroupandSubGroups);
            this.panelRoomManagementSubmenu.Controls.Add(this.btnRoomsforLectures);
            this.panelRoomManagementSubmenu.Controls.Add(this.btnPreferedRoomsTagsandSubject);
            this.panelRoomManagementSubmenu.Controls.Add(this.btnAllocateRoomforTag);
            this.panelRoomManagementSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRoomManagementSubmenu.Location = new System.Drawing.Point(0, 769);
            this.panelRoomManagementSubmenu.Name = "panelRoomManagementSubmenu";
            this.panelRoomManagementSubmenu.Size = new System.Drawing.Size(279, 180);
            this.panelRoomManagementSubmenu.TabIndex = 16;
            this.panelRoomManagementSubmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRoomManagementSubmenu_Paint);
            // 
            // btnUnavailableRooms
            // 
            this.btnUnavailableRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnavailableRooms.FlatAppearance.BorderSize = 0;
            this.btnUnavailableRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnavailableRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnavailableRooms.ForeColor = System.Drawing.Color.LightGray;
            this.btnUnavailableRooms.Location = new System.Drawing.Point(0, 150);
            this.btnUnavailableRooms.Name = "btnUnavailableRooms";
            this.btnUnavailableRooms.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUnavailableRooms.Size = new System.Drawing.Size(279, 25);
            this.btnUnavailableRooms.TabIndex = 6;
            this.btnUnavailableRooms.Text = "Unavailable Roms";
            this.btnUnavailableRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnavailableRooms.UseVisualStyleBackColor = true;
            this.btnUnavailableRooms.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // btnConsecutiveSessions
            // 
            this.btnConsecutiveSessions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsecutiveSessions.FlatAppearance.BorderSize = 0;
            this.btnConsecutiveSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsecutiveSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsecutiveSessions.ForeColor = System.Drawing.Color.LightGray;
            this.btnConsecutiveSessions.Location = new System.Drawing.Point(0, 125);
            this.btnConsecutiveSessions.Name = "btnConsecutiveSessions";
            this.btnConsecutiveSessions.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConsecutiveSessions.Size = new System.Drawing.Size(279, 25);
            this.btnConsecutiveSessions.TabIndex = 5;
            this.btnConsecutiveSessions.Text = "Consecutive Sessions";
            this.btnConsecutiveSessions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsecutiveSessions.UseVisualStyleBackColor = true;
            this.btnConsecutiveSessions.Click += new System.EventHandler(this.btnConsecutiveSessions_Click);
            // 
            // btnRoomSesstions
            // 
            this.btnRoomSesstions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomSesstions.FlatAppearance.BorderSize = 0;
            this.btnRoomSesstions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomSesstions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomSesstions.ForeColor = System.Drawing.Color.LightGray;
            this.btnRoomSesstions.Location = new System.Drawing.Point(0, 100);
            this.btnRoomSesstions.Name = "btnRoomSesstions";
            this.btnRoomSesstions.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRoomSesstions.Size = new System.Drawing.Size(279, 25);
            this.btnRoomSesstions.TabIndex = 4;
            this.btnRoomSesstions.Text = "Room - Sessions";
            this.btnRoomSesstions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomSesstions.UseVisualStyleBackColor = true;
            this.btnRoomSesstions.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // btnRoomsforGroupandSubGroups
            // 
            this.btnRoomsforGroupandSubGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomsforGroupandSubGroups.FlatAppearance.BorderSize = 0;
            this.btnRoomsforGroupandSubGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomsforGroupandSubGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomsforGroupandSubGroups.ForeColor = System.Drawing.Color.LightGray;
            this.btnRoomsforGroupandSubGroups.Location = new System.Drawing.Point(0, 75);
            this.btnRoomsforGroupandSubGroups.Name = "btnRoomsforGroupandSubGroups";
            this.btnRoomsforGroupandSubGroups.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRoomsforGroupandSubGroups.Size = new System.Drawing.Size(279, 25);
            this.btnRoomsforGroupandSubGroups.TabIndex = 3;
            this.btnRoomsforGroupandSubGroups.Text = "Room - Group/Subgroup";
            this.btnRoomsforGroupandSubGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomsforGroupandSubGroups.UseVisualStyleBackColor = true;
            this.btnRoomsforGroupandSubGroups.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnRoomsforLectures
            // 
            this.btnRoomsforLectures.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomsforLectures.FlatAppearance.BorderSize = 0;
            this.btnRoomsforLectures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomsforLectures.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomsforLectures.ForeColor = System.Drawing.Color.LightGray;
            this.btnRoomsforLectures.Location = new System.Drawing.Point(0, 50);
            this.btnRoomsforLectures.Name = "btnRoomsforLectures";
            this.btnRoomsforLectures.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRoomsforLectures.Size = new System.Drawing.Size(279, 25);
            this.btnRoomsforLectures.TabIndex = 2;
            this.btnRoomsforLectures.Text = "Rooms - Lectures";
            this.btnRoomsforLectures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomsforLectures.UseVisualStyleBackColor = true;
            this.btnRoomsforLectures.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnPreferedRoomsTagsandSubject
            // 
            this.btnPreferedRoomsTagsandSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPreferedRoomsTagsandSubject.FlatAppearance.BorderSize = 0;
            this.btnPreferedRoomsTagsandSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreferedRoomsTagsandSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreferedRoomsTagsandSubject.ForeColor = System.Drawing.Color.LightGray;
            this.btnPreferedRoomsTagsandSubject.Location = new System.Drawing.Point(0, 25);
            this.btnPreferedRoomsTagsandSubject.Name = "btnPreferedRoomsTagsandSubject";
            this.btnPreferedRoomsTagsandSubject.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPreferedRoomsTagsandSubject.Size = new System.Drawing.Size(279, 25);
            this.btnPreferedRoomsTagsandSubject.TabIndex = 1;
            this.btnPreferedRoomsTagsandSubject.Text = "Prefered Rooms - Tags/Subject";
            this.btnPreferedRoomsTagsandSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreferedRoomsTagsandSubject.UseVisualStyleBackColor = true;
            this.btnPreferedRoomsTagsandSubject.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnAllocateRoomforTag
            // 
            this.btnAllocateRoomforTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllocateRoomforTag.FlatAppearance.BorderSize = 0;
            this.btnAllocateRoomforTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllocateRoomforTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllocateRoomforTag.ForeColor = System.Drawing.Color.LightGray;
            this.btnAllocateRoomforTag.Location = new System.Drawing.Point(0, 0);
            this.btnAllocateRoomforTag.Name = "btnAllocateRoomforTag";
            this.btnAllocateRoomforTag.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAllocateRoomforTag.Size = new System.Drawing.Size(279, 25);
            this.btnAllocateRoomforTag.TabIndex = 0;
            this.btnAllocateRoomforTag.Text = "Allocate Room for Tag";
            this.btnAllocateRoomforTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllocateRoomforTag.UseVisualStyleBackColor = true;
            this.btnAllocateRoomforTag.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnRoomManagement
            // 
            this.btnRoomManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomManagement.FlatAppearance.BorderSize = 0;
            this.btnRoomManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRoomManagement.Location = new System.Drawing.Point(0, 739);
            this.btnRoomManagement.Name = "btnRoomManagement";
            this.btnRoomManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRoomManagement.Size = new System.Drawing.Size(279, 30);
            this.btnRoomManagement.TabIndex = 15;
            this.btnRoomManagement.Text = "Room Management";
            this.btnRoomManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomManagement.UseVisualStyleBackColor = true;
            this.btnRoomManagement.Click += new System.EventHandler(this.btnRoomManagement_Click);
            // 
            // panelSessionManagentSubmenu
            // 
            this.panelSessionManagentSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSessionManagentSubmenu.Controls.Add(this.btnNotOverlappingSessions);
            this.panelSessionManagentSubmenu.Controls.Add(this.btnParallelSessions);
            this.panelSessionManagentSubmenu.Controls.Add(this.btnConsecutiveSession);
            this.panelSessionManagentSubmenu.Controls.Add(this.btnAllocateNotAvailable);
            this.panelSessionManagentSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSessionManagentSubmenu.Location = new System.Drawing.Point(0, 634);
            this.panelSessionManagentSubmenu.Name = "panelSessionManagentSubmenu";
            this.panelSessionManagentSubmenu.Size = new System.Drawing.Size(279, 105);
            this.panelSessionManagentSubmenu.TabIndex = 14;
            // 
            // btnNotOverlappingSessions
            // 
            this.btnNotOverlappingSessions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotOverlappingSessions.FlatAppearance.BorderSize = 0;
            this.btnNotOverlappingSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotOverlappingSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotOverlappingSessions.ForeColor = System.Drawing.Color.LightGray;
            this.btnNotOverlappingSessions.Location = new System.Drawing.Point(0, 75);
            this.btnNotOverlappingSessions.Name = "btnNotOverlappingSessions";
            this.btnNotOverlappingSessions.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNotOverlappingSessions.Size = new System.Drawing.Size(279, 25);
            this.btnNotOverlappingSessions.TabIndex = 3;
            this.btnNotOverlappingSessions.Text = "Not Overlapping Sessions";
            this.btnNotOverlappingSessions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotOverlappingSessions.UseVisualStyleBackColor = true;
            this.btnNotOverlappingSessions.Click += new System.EventHandler(this.btnNotOverlappingSessions_Click);
            // 
            // btnParallelSessions
            // 
            this.btnParallelSessions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParallelSessions.FlatAppearance.BorderSize = 0;
            this.btnParallelSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParallelSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParallelSessions.ForeColor = System.Drawing.Color.LightGray;
            this.btnParallelSessions.Location = new System.Drawing.Point(0, 50);
            this.btnParallelSessions.Name = "btnParallelSessions";
            this.btnParallelSessions.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnParallelSessions.Size = new System.Drawing.Size(279, 25);
            this.btnParallelSessions.TabIndex = 2;
            this.btnParallelSessions.Text = "Parallel Sessions";
            this.btnParallelSessions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParallelSessions.UseVisualStyleBackColor = true;
            this.btnParallelSessions.Click += new System.EventHandler(this.btnParallelSessions_Click);
            // 
            // btnConsecutiveSession
            // 
            this.btnConsecutiveSession.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsecutiveSession.FlatAppearance.BorderSize = 0;
            this.btnConsecutiveSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsecutiveSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsecutiveSession.ForeColor = System.Drawing.Color.LightGray;
            this.btnConsecutiveSession.Location = new System.Drawing.Point(0, 25);
            this.btnConsecutiveSession.Name = "btnConsecutiveSession";
            this.btnConsecutiveSession.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConsecutiveSession.Size = new System.Drawing.Size(279, 25);
            this.btnConsecutiveSession.TabIndex = 1;
            this.btnConsecutiveSession.Text = "Consecutive Sessions";
            this.btnConsecutiveSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsecutiveSession.UseVisualStyleBackColor = true;
            this.btnConsecutiveSession.Click += new System.EventHandler(this.btnConsecutiveSession_Click);
            // 
            // btnAllocateNotAvailable
            // 
            this.btnAllocateNotAvailable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllocateNotAvailable.FlatAppearance.BorderSize = 0;
            this.btnAllocateNotAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllocateNotAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllocateNotAvailable.ForeColor = System.Drawing.Color.LightGray;
            this.btnAllocateNotAvailable.Location = new System.Drawing.Point(0, 0);
            this.btnAllocateNotAvailable.Name = "btnAllocateNotAvailable";
            this.btnAllocateNotAvailable.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAllocateNotAvailable.Size = new System.Drawing.Size(279, 25);
            this.btnAllocateNotAvailable.TabIndex = 0;
            this.btnAllocateNotAvailable.Text = "Allocate Not Available";
            this.btnAllocateNotAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllocateNotAvailable.UseVisualStyleBackColor = true;
            this.btnAllocateNotAvailable.Click += new System.EventHandler(this.btnAllocateNotAvailable_Click);
            // 
            // btnSessionManagement
            // 
            this.btnSessionManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSessionManagement.FlatAppearance.BorderSize = 0;
            this.btnSessionManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessionManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSessionManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSessionManagement.Location = new System.Drawing.Point(0, 604);
            this.btnSessionManagement.Name = "btnSessionManagement";
            this.btnSessionManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSessionManagement.Size = new System.Drawing.Size(279, 30);
            this.btnSessionManagement.TabIndex = 13;
            this.btnSessionManagement.Text = "Session Management";
            this.btnSessionManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSessionManagement.UseVisualStyleBackColor = true;
            this.btnSessionManagement.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelStatSubmenu
            // 
            this.panelStatSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelStatSubmenu.Controls.Add(this.btnSubjectsStat);
            this.panelStatSubmenu.Controls.Add(this.btnStudentsStat);
            this.panelStatSubmenu.Controls.Add(this.btnLecturesStat);
            this.panelStatSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatSubmenu.Location = new System.Drawing.Point(0, 524);
            this.panelStatSubmenu.Name = "panelStatSubmenu";
            this.panelStatSubmenu.Size = new System.Drawing.Size(279, 80);
            this.panelStatSubmenu.TabIndex = 12;
            this.panelStatSubmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStatSubmenu_Paint);
            // 
            // btnSubjectsStat
            // 
            this.btnSubjectsStat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubjectsStat.FlatAppearance.BorderSize = 0;
            this.btnSubjectsStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectsStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectsStat.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubjectsStat.Location = new System.Drawing.Point(0, 50);
            this.btnSubjectsStat.Name = "btnSubjectsStat";
            this.btnSubjectsStat.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubjectsStat.Size = new System.Drawing.Size(279, 25);
            this.btnSubjectsStat.TabIndex = 2;
            this.btnSubjectsStat.Text = "Subjects";
            this.btnSubjectsStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubjectsStat.UseVisualStyleBackColor = true;
            this.btnSubjectsStat.Click += new System.EventHandler(this.btnSubjectsStat_Click);
            // 
            // btnStudentsStat
            // 
            this.btnStudentsStat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentsStat.FlatAppearance.BorderSize = 0;
            this.btnStudentsStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentsStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentsStat.ForeColor = System.Drawing.Color.LightGray;
            this.btnStudentsStat.Location = new System.Drawing.Point(0, 25);
            this.btnStudentsStat.Name = "btnStudentsStat";
            this.btnStudentsStat.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnStudentsStat.Size = new System.Drawing.Size(279, 25);
            this.btnStudentsStat.TabIndex = 1;
            this.btnStudentsStat.Text = "Students";
            this.btnStudentsStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentsStat.UseVisualStyleBackColor = true;
            this.btnStudentsStat.Click += new System.EventHandler(this.btnStudentsStat_Click);
            // 
            // btnLecturesStat
            // 
            this.btnLecturesStat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLecturesStat.FlatAppearance.BorderSize = 0;
            this.btnLecturesStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecturesStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecturesStat.ForeColor = System.Drawing.Color.LightGray;
            this.btnLecturesStat.Location = new System.Drawing.Point(0, 0);
            this.btnLecturesStat.Name = "btnLecturesStat";
            this.btnLecturesStat.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLecturesStat.Size = new System.Drawing.Size(279, 25);
            this.btnLecturesStat.TabIndex = 0;
            this.btnLecturesStat.Text = "Lectures";
            this.btnLecturesStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLecturesStat.UseVisualStyleBackColor = true;
            this.btnLecturesStat.Click += new System.EventHandler(this.btnLecturesStat_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStatistics.Location = new System.Drawing.Point(0, 494);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStatistics.Size = new System.Drawing.Size(279, 30);
            this.btnStatistics.TabIndex = 11;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // panelLocationsSubmenu
            // 
            this.panelLocationsSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelLocationsSubmenu.Controls.Add(this.btnRooms);
            this.panelLocationsSubmenu.Controls.Add(this.btnBuildings);
            this.panelLocationsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLocationsSubmenu.Location = new System.Drawing.Point(0, 439);
            this.panelLocationsSubmenu.Name = "panelLocationsSubmenu";
            this.panelLocationsSubmenu.Size = new System.Drawing.Size(279, 55);
            this.panelLocationsSubmenu.TabIndex = 10;
            this.panelLocationsSubmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLocationsSubmenu_Paint);
            // 
            // btnRooms
            // 
            this.btnRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRooms.FlatAppearance.BorderSize = 0;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.ForeColor = System.Drawing.Color.LightGray;
            this.btnRooms.Location = new System.Drawing.Point(0, 25);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRooms.Size = new System.Drawing.Size(279, 25);
            this.btnRooms.TabIndex = 1;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnBuildings
            // 
            this.btnBuildings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuildings.FlatAppearance.BorderSize = 0;
            this.btnBuildings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuildings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildings.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuildings.Location = new System.Drawing.Point(0, 0);
            this.btnBuildings.Name = "btnBuildings";
            this.btnBuildings.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnBuildings.Size = new System.Drawing.Size(279, 25);
            this.btnBuildings.TabIndex = 0;
            this.btnBuildings.Text = "Buildings";
            this.btnBuildings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuildings.UseVisualStyleBackColor = true;
            this.btnBuildings.Click += new System.EventHandler(this.btnBuildings_Click);
            // 
            // btnLocations
            // 
            this.btnLocations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocations.FlatAppearance.BorderSize = 0;
            this.btnLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocations.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLocations.Location = new System.Drawing.Point(0, 409);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLocations.Size = new System.Drawing.Size(279, 30);
            this.btnLocations.TabIndex = 9;
            this.btnLocations.Text = "Locations";
            this.btnLocations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocations.UseVisualStyleBackColor = true;
            this.btnLocations.Click += new System.EventHandler(this.btnLocations_Click);
            // 
            // btnTags
            // 
            this.btnTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTags.FlatAppearance.BorderSize = 0;
            this.btnTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTags.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTags.Location = new System.Drawing.Point(0, 379);
            this.btnTags.Name = "btnTags";
            this.btnTags.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTags.Size = new System.Drawing.Size(279, 30);
            this.btnTags.TabIndex = 8;
            this.btnTags.Text = "Tags";
            this.btnTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTags.UseVisualStyleBackColor = true;
            this.btnTags.Click += new System.EventHandler(this.button7_Click);
            // 
            // panelStudentDetailsSubmenu
            // 
            this.panelStudentDetailsSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelStudentDetailsSubmenu.Controls.Add(this.btnGenerateSubGroupID);
            this.panelStudentDetailsSubmenu.Controls.Add(this.btnSubGroupNumbers);
            this.panelStudentDetailsSubmenu.Controls.Add(this.btnGenerateGroupID);
            this.panelStudentDetailsSubmenu.Controls.Add(this.btnGroupNumber);
            this.panelStudentDetailsSubmenu.Controls.Add(this.btnProgramme);
            this.panelStudentDetailsSubmenu.Controls.Add(this.btnYearandSemester);
            this.panelStudentDetailsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudentDetailsSubmenu.Location = new System.Drawing.Point(0, 226);
            this.panelStudentDetailsSubmenu.Name = "panelStudentDetailsSubmenu";
            this.panelStudentDetailsSubmenu.Size = new System.Drawing.Size(279, 153);
            this.panelStudentDetailsSubmenu.TabIndex = 7;
            // 
            // btnGenerateSubGroupID
            // 
            this.btnGenerateSubGroupID.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerateSubGroupID.FlatAppearance.BorderSize = 0;
            this.btnGenerateSubGroupID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateSubGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSubGroupID.ForeColor = System.Drawing.Color.LightGray;
            this.btnGenerateSubGroupID.Location = new System.Drawing.Point(0, 125);
            this.btnGenerateSubGroupID.Name = "btnGenerateSubGroupID";
            this.btnGenerateSubGroupID.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnGenerateSubGroupID.Size = new System.Drawing.Size(279, 25);
            this.btnGenerateSubGroupID.TabIndex = 5;
            this.btnGenerateSubGroupID.Text = "Generate Sub Group ID";
            this.btnGenerateSubGroupID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateSubGroupID.UseVisualStyleBackColor = true;
            this.btnGenerateSubGroupID.Click += new System.EventHandler(this.btnGenerateSubGroupID_Click);
            // 
            // btnSubGroupNumbers
            // 
            this.btnSubGroupNumbers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubGroupNumbers.FlatAppearance.BorderSize = 0;
            this.btnSubGroupNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubGroupNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubGroupNumbers.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubGroupNumbers.Location = new System.Drawing.Point(0, 100);
            this.btnSubGroupNumbers.Name = "btnSubGroupNumbers";
            this.btnSubGroupNumbers.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubGroupNumbers.Size = new System.Drawing.Size(279, 25);
            this.btnSubGroupNumbers.TabIndex = 4;
            this.btnSubGroupNumbers.Text = "Sub Group Numbers";
            this.btnSubGroupNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubGroupNumbers.UseVisualStyleBackColor = true;
            this.btnSubGroupNumbers.Click += new System.EventHandler(this.btnSubGroupNumbers_Click);
            // 
            // btnGenerateGroupID
            // 
            this.btnGenerateGroupID.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerateGroupID.FlatAppearance.BorderSize = 0;
            this.btnGenerateGroupID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateGroupID.ForeColor = System.Drawing.Color.LightGray;
            this.btnGenerateGroupID.Location = new System.Drawing.Point(0, 75);
            this.btnGenerateGroupID.Name = "btnGenerateGroupID";
            this.btnGenerateGroupID.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnGenerateGroupID.Size = new System.Drawing.Size(279, 25);
            this.btnGenerateGroupID.TabIndex = 3;
            this.btnGenerateGroupID.Text = "Generate Group ID";
            this.btnGenerateGroupID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateGroupID.UseVisualStyleBackColor = true;
            this.btnGenerateGroupID.Click += new System.EventHandler(this.btnGenerateGroupID_Click);
            // 
            // btnGroupNumber
            // 
            this.btnGroupNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGroupNumber.FlatAppearance.BorderSize = 0;
            this.btnGroupNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupNumber.ForeColor = System.Drawing.Color.LightGray;
            this.btnGroupNumber.Location = new System.Drawing.Point(0, 50);
            this.btnGroupNumber.Name = "btnGroupNumber";
            this.btnGroupNumber.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnGroupNumber.Size = new System.Drawing.Size(279, 25);
            this.btnGroupNumber.TabIndex = 2;
            this.btnGroupNumber.Text = "Group Numbers";
            this.btnGroupNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroupNumber.UseVisualStyleBackColor = true;
            this.btnGroupNumber.Click += new System.EventHandler(this.btnGroupNumber_Click);
            // 
            // btnProgramme
            // 
            this.btnProgramme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProgramme.FlatAppearance.BorderSize = 0;
            this.btnProgramme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgramme.ForeColor = System.Drawing.Color.LightGray;
            this.btnProgramme.Location = new System.Drawing.Point(0, 25);
            this.btnProgramme.Name = "btnProgramme";
            this.btnProgramme.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnProgramme.Size = new System.Drawing.Size(279, 25);
            this.btnProgramme.TabIndex = 1;
            this.btnProgramme.Text = "Programme";
            this.btnProgramme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProgramme.UseVisualStyleBackColor = true;
            this.btnProgramme.Click += new System.EventHandler(this.btnProgramme_Click);
            // 
            // btnYearandSemester
            // 
            this.btnYearandSemester.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYearandSemester.FlatAppearance.BorderSize = 0;
            this.btnYearandSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYearandSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearandSemester.ForeColor = System.Drawing.Color.LightGray;
            this.btnYearandSemester.Location = new System.Drawing.Point(0, 0);
            this.btnYearandSemester.Name = "btnYearandSemester";
            this.btnYearandSemester.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnYearandSemester.Size = new System.Drawing.Size(279, 25);
            this.btnYearandSemester.TabIndex = 0;
            this.btnYearandSemester.Text = "Academic Year and Semester";
            this.btnYearandSemester.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYearandSemester.UseVisualStyleBackColor = true;
            this.btnYearandSemester.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStudent.Location = new System.Drawing.Point(0, 196);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(279, 30);
            this.btnStudent.TabIndex = 6;
            this.btnStudent.Text = "Student Details";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubject.FlatAppearance.BorderSize = 0;
            this.btnSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubject.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSubject.Location = new System.Drawing.Point(0, 166);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubject.Size = new System.Drawing.Size(279, 30);
            this.btnSubject.TabIndex = 5;
            this.btnSubject.Text = "Subject Details";
            this.btnSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // btnLecturers
            // 
            this.btnLecturers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLecturers.FlatAppearance.BorderSize = 0;
            this.btnLecturers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecturers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecturers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLecturers.Location = new System.Drawing.Point(0, 136);
            this.btnLecturers.Name = "btnLecturers";
            this.btnLecturers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLecturers.Size = new System.Drawing.Size(279, 30);
            this.btnLecturers.TabIndex = 4;
            this.btnLecturers.Text = "Lecturer Details";
            this.btnLecturers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLecturers.UseVisualStyleBackColor = true;
            this.btnLecturers.Click += new System.EventHandler(this.btnLecturers_Click);
            // 
            // panelWDandHsubmenu
            // 
            this.panelWDandHsubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelWDandHsubmenu.Controls.Add(this.btnEditDetails);
            this.panelWDandHsubmenu.Controls.Add(this.btnViewDetails);
            this.panelWDandHsubmenu.Controls.Add(this.btnWeekendDetails);
            this.panelWDandHsubmenu.Controls.Add(this.btnWeekdayDetails);
            this.panelWDandHsubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWDandHsubmenu.Location = new System.Drawing.Point(0, 30);
            this.panelWDandHsubmenu.Name = "panelWDandHsubmenu";
            this.panelWDandHsubmenu.Size = new System.Drawing.Size(279, 106);
            this.panelWDandHsubmenu.TabIndex = 3;
            this.panelWDandHsubmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWDandHsubmenu_Paint);
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditDetails.FlatAppearance.BorderSize = 0;
            this.btnEditDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDetails.ForeColor = System.Drawing.Color.LightGray;
            this.btnEditDetails.Location = new System.Drawing.Point(0, 75);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEditDetails.Size = new System.Drawing.Size(279, 25);
            this.btnEditDetails.TabIndex = 3;
            this.btnEditDetails.Text = "Edit Details";
            this.btnEditDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDetails.UseVisualStyleBackColor = true;
            this.btnEditDetails.Click += new System.EventHandler(this.btnEditDetails_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.ForeColor = System.Drawing.Color.LightGray;
            this.btnViewDetails.Location = new System.Drawing.Point(0, 50);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnViewDetails.Size = new System.Drawing.Size(279, 25);
            this.btnViewDetails.TabIndex = 2;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnWeekendDetails
            // 
            this.btnWeekendDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWeekendDetails.FlatAppearance.BorderSize = 0;
            this.btnWeekendDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekendDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekendDetails.ForeColor = System.Drawing.Color.LightGray;
            this.btnWeekendDetails.Location = new System.Drawing.Point(0, 25);
            this.btnWeekendDetails.Name = "btnWeekendDetails";
            this.btnWeekendDetails.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnWeekendDetails.Size = new System.Drawing.Size(279, 25);
            this.btnWeekendDetails.TabIndex = 1;
            this.btnWeekendDetails.Text = "Weekend Details";
            this.btnWeekendDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeekendDetails.UseVisualStyleBackColor = true;
            this.btnWeekendDetails.Click += new System.EventHandler(this.btnWeekendDetails_Click);
            // 
            // btnWeekdayDetails
            // 
            this.btnWeekdayDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWeekdayDetails.FlatAppearance.BorderSize = 0;
            this.btnWeekdayDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekdayDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekdayDetails.ForeColor = System.Drawing.Color.LightGray;
            this.btnWeekdayDetails.Location = new System.Drawing.Point(0, 0);
            this.btnWeekdayDetails.Name = "btnWeekdayDetails";
            this.btnWeekdayDetails.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnWeekdayDetails.Size = new System.Drawing.Size(279, 25);
            this.btnWeekdayDetails.TabIndex = 0;
            this.btnWeekdayDetails.Text = "Weekday Details";
            this.btnWeekdayDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeekdayDetails.UseVisualStyleBackColor = true;
            this.btnWeekdayDetails.Click += new System.EventHandler(this.btnWeekdayDetails_Click);
            // 
            // btnWDandH
            // 
            this.btnWDandH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWDandH.FlatAppearance.BorderSize = 0;
            this.btnWDandH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWDandH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWDandH.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnWDandH.Location = new System.Drawing.Point(0, 0);
            this.btnWDandH.Name = "btnWDandH";
            this.btnWDandH.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnWDandH.Size = new System.Drawing.Size(279, 30);
            this.btnWDandH.TabIndex = 2;
            this.btnWDandH.Text = "Working Days and Hours";
            this.btnWDandH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWDandH.UseVisualStyleBackColor = true;
            this.btnWDandH.Click += new System.EventHandler(this.btnWDandH_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(300, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(666, 689);
            this.panelChildForm.TabIndex = 1;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 689);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelGenerateTimeTableSubmenu.ResumeLayout(false);
            this.panelRoomManagementSubmenu.ResumeLayout(false);
            this.panelSessionManagentSubmenu.ResumeLayout(false);
            this.panelStatSubmenu.ResumeLayout(false);
            this.panelLocationsSubmenu.ResumeLayout(false);
            this.panelStudentDetailsSubmenu.ResumeLayout(false);
            this.panelWDandHsubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelStudentDetailsSubmenu;
        private System.Windows.Forms.Button btnGenerateSubGroupID;
        private System.Windows.Forms.Button btnSubGroupNumbers;
        private System.Windows.Forms.Button btnGenerateGroupID;
        private System.Windows.Forms.Button btnGroupNumber;
        private System.Windows.Forms.Button btnProgramme;
        private System.Windows.Forms.Button btnYearandSemester;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnLecturers;
        private System.Windows.Forms.Panel panelWDandHsubmenu;
        private System.Windows.Forms.Button btnEditDetails;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnWeekendDetails;
        private System.Windows.Forms.Button btnWeekdayDetails;
        private System.Windows.Forms.Button btnWDandH;
        private System.Windows.Forms.Button btnTags;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Panel panelLocationsSubmenu;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnBuildings;
        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panelStatSubmenu;
        private System.Windows.Forms.Button btnSubjectsStat;
        private System.Windows.Forms.Button btnStudentsStat;
        private System.Windows.Forms.Button btnLecturesStat;
        private System.Windows.Forms.Button btnSessionManagement;
        private System.Windows.Forms.Panel panelSessionManagentSubmenu;
        private System.Windows.Forms.Button btnNotOverlappingSessions;
        private System.Windows.Forms.Button btnParallelSessions;
        private System.Windows.Forms.Button btnConsecutiveSession;
        private System.Windows.Forms.Button btnAllocateNotAvailable;
        private System.Windows.Forms.Button btnRoomManagement;
        private System.Windows.Forms.Button btnUnavailableRooms;
        private System.Windows.Forms.Button btnConsecutiveSessions;
        private System.Windows.Forms.Button btnRoomSesstions;
        private System.Windows.Forms.Button btnRoomsforGroupandSubGroups;
        private System.Windows.Forms.Button btnRoomsforLectures;
        private System.Windows.Forms.Button btnPreferedRoomsTagsandSubject;
        private System.Windows.Forms.Button btnAllocateRoomforTag;
        private System.Windows.Forms.Button btnGenerateTimeTable;
        private System.Windows.Forms.Panel panelGenerateTimeTableSubmenu;
        private System.Windows.Forms.Button btnWeekEndTimeTable;
        private System.Windows.Forms.Button btnWeekdayTimeTable;
        private System.Windows.Forms.Panel panelRoomManagementSubmenu;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

