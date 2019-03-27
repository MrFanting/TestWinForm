using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWinForm.Object;

namespace TestWinForm.UI
{
    public partial class ScoreWin : Form
    {
        private IList<Score> scores = null;
        private int flag;
        public ScoreWin()
        {
            flag = 0;
            InitializeComponent();
        }

        private void AddInfo(Score score)
        {
            course_name.Text = score.Con;
            student_id.Text = score.StudentId;
            grade.Text = score.Mark;
            id.Text = score.CourseId;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            scores[flag].Mark = grade.Text.ToString().Trim();
            student_data.DataSource = scores;
            if (flag > 0)
            {
                flag -= 1;
                AddInfo(scores[flag]);
            }
            else
            {
                MessageBox.Show("已经是第一个");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scores[flag].Mark = grade.Text.ToString().Trim();
            student_data.DataSource = scores;
            if (flag <(scores.Count-1))
            {
                flag += 1;
                AddInfo(scores[flag]);
            }
            else
            {
                MessageBox.Show("已经是最后一个");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            scores[flag].Mark = grade.Text.ToString().Trim();
            if (NetworkService.GetTeacherCourseGrades(scores))
            {
                MessageBox.Show("更改成功");
            }
            else
            {
                MessageBox.Show("更改失败");
            }
        }

        private void ScoreWin_Load(object sender, EventArgs e)
        {
            course_data.DataSource = NetworkService.GetTeacherCourses();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Course course = new Course();
            course.Id = this.course_data.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            scores = NetworkService.GetTeacherCourseGrades(course);
            student_data.DataSource = scores;
            if (scores != null)
            {
                AddInfo(scores[flag]);
            }
            else
            {
                MessageBox.Show("没有学生选择这门课");
            }
        }
    }
}
