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
    public partial class AddScoreForm : Form
    {
        Score score = new Score();
        Course course = new Course();
        SinhVien student = new SinhVien();
        public AddScoreForm()
        {
            InitializeComponent();
        }
        
        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            comboBoxSelectCourse.DataSource = course.getAllCourse();
            comboBoxSelectCourse.ValueMember = "id";
            comboBoxSelectCourse.DisplayMember = "label";
            //comboBoxSelectCourse.SelectedItem = null;

            //populate the datagridview with students data(id,first,name,last name)
            SqlCommand command = new SqlCommand("SELECT ID,fname,lname FROM DB_Student");
            dataGridView1.DataSource = student.getAllSinhVien(command);
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(textBoxStudentID.Text);
                int courseId = Convert.ToInt32(comboBoxSelectCourse.SelectedValue);
                float scorevalue = Convert.ToInt32(textBoxScore.Text);
                string description = textBoxDescription.Text;
                //check  if a score already asigned to the student
                if(!score.studentScoreExists(studentId,courseId))
                {
                    if (score.insertScore(studentId, courseId, scorevalue, description))
                    {
                        MessageBox.Show("Student Score Inserted ", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
