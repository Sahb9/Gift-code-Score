using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_login
{
    public partial class PrintScoreForm : Form
    {
        public PrintScoreForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        Score score = new Score();
        SinhVien student = new SinhVien();
        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            //student data
            SqlCommand command = new SqlCommand("SELECT id,fname,lname FROM DB_Student ");
            dataGridViewStudentList.DataSource = student.getAllSinhVien(command);
            //score data
            dataGridViewScore.DataSource = score.getStudentsScore();

            //course data
            listBoxCourses.DataSource = course.getAllCourse();
            listBoxCourses.ValueMember = "id";
            listBoxCourses.DisplayMember = "label";


        }

        private void listBoxCourses_Click(object sender, EventArgs e)
        {
            dataGridViewScore.DataSource = score.getCourseScore(int.Parse(listBoxCourses.SelectedValue.ToString()));
        }

        private void dataGridViewStudentList_Click(object sender, EventArgs e)
        {

            dataGridViewScore.DataSource = score.getStudentScore(int.Parse(dataGridViewStudentList.CurrentRow.Cells[0].Value.ToString()));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dataGridViewScore.DataSource = score.getStudentsScore();
        }
    }
}
