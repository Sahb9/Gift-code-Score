using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_login
{
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        Score score = new Score();
        SinhVien student = new SinhVien();
        string data;
        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            comboBoxSelectCourse.DataSource = course.getAllCourse();
            comboBoxSelectCourse.ValueMember = "id";
            comboBoxSelectCourse.DisplayMember = "label";
            dataGridView1.DataSource = score.getStudentsScore();
        }

        private void buttonShowStudents_Click(object sender, EventArgs e)
        {
            data = "student";
            dataGridView1.DataSource = student.ShowAllSinhVien();
        }

        private void buttonShowScore_Click(object sender, EventArgs e)
        {
            data = "score";
            dataGridView1.DataSource = score.getStudentsScore();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            getDataFromDatagridView();
        }
        public void getDataFromDatagridView()
        {
            if(data == "student")
            {
                textBoxStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else if (data =="score")
            {
                textBoxStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBoxSelectCourse.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value;

            }


        }



        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int studentId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int courseId = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            if (MessageBox.Show("Do you want to delete this score ", "Delete Score", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (score.deleteScore(studentId, courseId))
                {
                    MessageBox.Show("Deleted Successfully", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = score.getStudentsScore();
                }
                else
                {
                    MessageBox.Show("Error", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAvgScore_Click(object sender, EventArgs e)
        {
            AvgScoreByCourseForm agv = new AvgScoreByCourseForm();
            agv.Show();
        }

        private void buttonAddScore_Click_1(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(textBoxStudentID.Text);
                int courseId = Convert.ToInt32(comboBoxSelectCourse.SelectedValue);
                float scorevalue = Convert.ToInt32(textBoxScore.Text);
                string description = textBoxDescription.Text;
                //check  if a score already asigned to the student
                if (!score.studentScoreExists(studentId, courseId))
                {
                    if (score.insertScore(studentId, courseId, scorevalue, description))
                    {
                        MessageBox.Show("Student Score Inserted ", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = score.getStudentsScore();
                    }
                    else
                    {
                        MessageBox.Show("Student Score not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score for this course are already set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
