using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Classes;

namespace Time_Table_Management_System
{
    public partial class SubjectDetailsForm : Form
    {
        public SubjectDetailsForm()
        {
            InitializeComponent();
        }
        SubjectClass c = new SubjectClass();

        private void SubjectDetailsForm_Load(object sender, EventArgs e)
        {
            //load data on data gridview
            DataTable dt = c.Select();
            dataGridViewSubjectDetails.DataSource = dt;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            //get values from input fields
            c.SubjectOfferedYear = int.Parse(comboBoxOfferedYear.Text);
            c.SubjectOfferedSemester = int.Parse(comboBoxOfferedSemester.Text);
            c.SubjectName = textBoxSubjectName.Text;
            c.SubjectCode = textBoxSubjectCode.Text;
            c.LectureHours = int.Parse(textBoxLectureHours.Text);
            c.TutorialHours = int.Parse(textBoxTutorialHours.Text);
            c.LabHours = int.Parse(textBoxLabHours.Text);
            c.EvaluationHours = int.Parse(textBoxEvaluationHours.Text);

            //Insert data into database using method in class
            bool success = c.Insert(c);

            if (success == true)
            {
                MessageBox.Show("New Subject Inserted");
                //load data on data gridview
                DataTable dt = c.Select();
                dataGridViewSubjectDetails.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Faild to Insert Room");
            }
        }

        private void dataGridViewSubjectDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data
            int rowIndex = e.RowIndex;
            textBoxSubjectID.Text = dataGridViewSubjectDetails.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxOfferedYear.Text = dataGridViewSubjectDetails.Rows[rowIndex].Cells[1].Value.ToString();
            comboBoxOfferedSemester.Text = dataGridViewSubjectDetails.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxSubjectName.Text = dataGridViewSubjectDetails.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxSubjectCode.Text = dataGridViewSubjectDetails.Rows[rowIndex].Cells[4].Value.ToString();
            textBoxLectureHours.Text = dataGridViewSubjectDetails.Rows[rowIndex].Cells[5].Value.ToString();
            textBoxTutorialHours.Text = dataGridViewSubjectDetails.Rows[rowIndex].Cells[6].Value.ToString();
            textBoxLabHours.Text = dataGridViewSubjectDetails.Rows[rowIndex].Cells[7].Value.ToString();
            textBoxEvaluationHours.Text = dataGridViewSubjectDetails.Rows[rowIndex].Cells[8].Value.ToString();
        }

        private void btnUpdateSubject_Click(object sender, EventArgs e)
        {
            //get values from input fields
            c.SubjectID = Convert.ToInt32(textBoxSubjectID.Text);
            c.SubjectOfferedYear = int.Parse(comboBoxOfferedYear.Text);
            c.SubjectOfferedSemester = int.Parse(comboBoxOfferedSemester.Text);
            c.SubjectName = textBoxSubjectName.Text;
            c.SubjectCode = textBoxSubjectCode.Text;
            c.LectureHours = int.Parse(textBoxLectureHours.Text);
            c.TutorialHours = int.Parse(textBoxTutorialHours.Text);
            c.LabHours = int.Parse(textBoxLabHours.Text);
            c.EvaluationHours = int.Parse(textBoxEvaluationHours.Text);

            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Subject Details Updated Successfully");
                //load data on data gridview
                DataTable dt = c.Select();
                dataGridViewSubjectDetails.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Faild to Update Subject Details");
            }
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            c.SubjectID = Convert.ToInt32(textBoxSubjectID.Text);
            if (MessageBox.Show("Do You Want to Delete Item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool success = c.Delete(c);

                if (success == true)
                {
                    MessageBox.Show("Subject Details Deleted Successfully");
                    //load data on data gridview
                    DataTable dt = c.Select();
                    dataGridViewSubjectDetails.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Faild to Delete Subject Details");
                }
            }
            else
            {
                MessageBox.Show("Item Not Deleted", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
