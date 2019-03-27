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
    public partial class TeacherCourse : Form
    {
        IList<Course> courses;
        public TeacherCourse()
        {
            InitializeComponent();
        }

        private void TeacherCourse_Load(object sender, EventArgs e)
        {
            courses= NetworkService.GetTeacherCourses();
            coures_data.DataSource = courses;
        }

        private void room_query_Click(object sender, EventArgs e)
        {
            room_data.DataSource = NetworkService.GetRoomIdle();
        }

        private void room_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            room_id.Text = this.room_data.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
        }

        private void coures_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = this.coures_data.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            con.Text = this.coures_data.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            credit.Text = this.coures_data.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            course_time.Text = this.coures_data.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            program_id.Text = this.coures_data.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
            room_id.Text = this.coures_data.Rows[e.RowIndex].Cells[7].Value.ToString().Trim();
        }

        private void query_Click(object sender, EventArgs e)
        {
            List<Course> coursesQuery = new List<Course>();
            int flag = 0;
            foreach(Course course in courses)
            {
                if (course_time.Text.Trim() != "")
                {
                    if (course_time.Text.Trim() == course.CourseTime) { flag += 1; }
                }
                else { flag += 1; }
                if (credit.Text.Trim() != "")
                {
                    if (credit.Text.Trim() == course.Credit) { flag += 1; }
                }
                else { flag += 1; }
                if (flag == 2) { coursesQuery.Add(course); }
                flag = 0;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.Id = id.Text.Trim();
            course.Con = con.Text.Trim();
            course.Credit = credit.Text.Trim();
            course.ProgramId = program_id.Text.Trim();
            course.CourseTime = course_time.Text.Trim();
            course.RoomId = room_id.Text.Trim();
            if (NetworkService.TeacherAddCourse(course))
            {
                MessageBox.Show("添加成功");
                courses = NetworkService.GetTeacherCourses();
                coures_data.DataSource = courses;
            }
            else { MessageBox.Show("添加失败"); }
        }

        private void update_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.CourseTime = course_time.Text.Trim();
            course.RoomId = room_id.Text.Trim();
            if (NetworkService.TeacherUpdateCourse(course))
            {
                MessageBox.Show("更改成功");
                courses = NetworkService.GetTeacherCourses();
                coures_data.DataSource = courses;
            }
            else { MessageBox.Show("更改失败"); }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.Id = id.Text.Trim();
            if (NetworkService.TeacherDeleteCourse(course))
            {
                MessageBox.Show("删除成功");
                courses = NetworkService.GetTeacherCourses();
                coures_data.DataSource = courses;
            }
            else { MessageBox.Show("删除失败"); }
        }
    }
}
