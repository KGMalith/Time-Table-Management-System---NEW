using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Table_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelWDandHsubmenu.Visible = false;
            panelStudentDetailsSubmenu.Visible = false;
            panelLocationsSubmenu.Visible = false;
            panelStatSubmenu.Visible = false;
            panelSessionManagentSubmenu.Visible = false;
            panelRoomManagementSubmenu.Visible = false;
            panelGenerateTimeTableSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelWDandHsubmenu.Visible == true)
                panelWDandHsubmenu.Visible = false;
            if (panelStudentDetailsSubmenu.Visible == true)
                panelStudentDetailsSubmenu.Visible = false;
            if (panelLocationsSubmenu.Visible == true)
                panelLocationsSubmenu.Visible = false;
            if (panelStatSubmenu.Visible == true)
                panelStatSubmenu.Visible = false;
            if (panelSessionManagentSubmenu.Visible == true)
                panelSessionManagentSubmenu.Visible = false;
            if (panelRoomManagementSubmenu.Visible == true)
                panelRoomManagementSubmenu.Visible = false;
            if (panelGenerateTimeTableSubmenu.Visible == true)
                panelGenerateTimeTableSubmenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new AcademicYandSForm());
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Your code..
            hideSubMenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSessionManagentSubmenu);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAllocateNotAvailable_Click(object sender, EventArgs e)
        {
            //Your code..
            hideSubMenu();
        }

        private void btnConsecutiveSession_Click(object sender, EventArgs e)
        {
            //Your code..
            hideSubMenu();
        }

        private void panelStatSubmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new UnavailableRoomsForm());
            hideSubMenu();
        }

        private void btnWDandH_Click(object sender, EventArgs e)
        {
            showSubMenu(panelWDandHsubmenu);
        }

        private void btnLecturers_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new LecturerDetailsForm());
            hideSubMenu();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new SubjectDetailsForm());
            hideSubMenu();
        }

        private void btnWeekdayDetails_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new WeekdayDetailsForm());
            hideSubMenu();
        }

        private void btnWeekendDetails_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new WeekendDetailsForm());
            hideSubMenu();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new ViewDetailsForm());
            hideSubMenu();
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new EditDetailsForm());
            hideSubMenu();
        }

        private void btnProgramme_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new ProgrammeForm());
            hideSubMenu();
        }

        private void btnGroupNumber_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new GroupNumbersForm());
            hideSubMenu();
        }

        private void btnGenerateGroupID_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new GenerateGroupIDForm());
            hideSubMenu();
        }

        private void btnSubGroupNumbers_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new SubGroupNumbersForm());
            hideSubMenu();
        }

        private void btnGenerateSubGroupID_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new GenerateSubGroupIDForm());
            hideSubMenu();
        }

        private void btnBuildings_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new BuildingsForm());
            hideSubMenu();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new RoomsForm());
            hideSubMenu();
        }

        private void btnLecturesStat_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new LecturersStatForm());
            hideSubMenu();
        }

        private void btnStudentsStat_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new StudentsStatForm());
            hideSubMenu();
        }

        private void btnSubjectsStat_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new SubjectsStatForm());
            hideSubMenu();
        }

        private void btnParallelSessions_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new ParallelSessionsForm());
            hideSubMenu();
        }

        private void btnNotOverlappingSessions_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new NotOverlappingSessionsForm());
            hideSubMenu();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new AllocateRoomForTagForm());
            hideSubMenu();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new PreferedRoomsForm());
            hideSubMenu();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new RoomsforLecturesFrom());
            hideSubMenu();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new RoomForGroupOrSubGroupForm());
            hideSubMenu();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new RoomsForSessionsForm());
            hideSubMenu();
        }

        private void btnRoomManagement_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRoomManagementSubmenu);
        }

        private void panelLocationsSubmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelWDandHsubmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStudentDetailsSubmenu);
        }

        private void panelRoomManagementSubmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGenerateTimeTable_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGenerateTimeTableSubmenu);
        }

        private void btnConsecutiveSessions_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new ConsecutiveSessionsRoomManagement());
            hideSubMenu();
        }

        private void btnWeekdayTimeTable_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new WeekdayTimeTableForm());
            hideSubMenu();
        }

        private void btnWeekEndTimeTable_Click(object sender, EventArgs e)
        {
            //Your code..
            openChildForm(new WeekendTimeTableForm());
            hideSubMenu();
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLocationsSubmenu);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStatSubmenu);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
