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
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();
        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentsScore();

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //remove the selected score
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
    }
}
