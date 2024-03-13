using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlTeachers.Hide();

            // show students
            pnlStudents.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }
        private void ShowLecturersPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();

            // show students
            pnlTeachers.Show();

            try
            {
                // get and display all students
                List<Teacher> teachers = GetTeachers();
                DisplayTeachers(teachers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }
        private List<Teacher> GetTeachers()
        {
            TeacherService teacherService = new TeacherService();
            List<Teacher> teachers = teacherService.GetTeachers();
            return teachers;
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Items.Clear();


            listViewStudents.View = View.Details; // 设置 ListView 显示方式为详细视图
            listViewStudents.Columns.Add("Name", 120); // 添加姓名列，宽度为 120
            listViewStudents.Columns.Add("Student Number", 200); // 添加学号列，宽度为 100
            listViewStudents.Columns.Add("Telephone Number", 200); // 添加电话号码列，宽度为 150
            listViewStudents.Columns.Add("Room Number", 200); // 添加房间号列，宽度为 80

            // 在显示学生数据时，为每个学生创建 ListViewItem，并将其添加到 ListView 中
            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.FullName);
                li.SubItems.Add(student.Number.ToString()); // 添加学号子项
                li.SubItems.Add(student.TelePhoneNumber); // 添加电话号码子项
                li.SubItems.Add(student.RoomNumber.ToString()); // 添加房间号子项
                li.Tag = student; // 将学生对象关联到 ListViewItem 的 Tag 属性
                listViewStudents.Items.Add(li);
            }

        }
        private void DisplayTeachers(List<Teacher> teachers)
        {
            // clear the listview before filling it
            listViewLecturers.Items.Clear();
            foreach (Teacher teacher in teachers)
            {
                ListViewItem li = new ListViewItem(teacher.FullName);
                li.Tag = teacher;   // link student object to listview item
                listViewLecturers.Items.Add(li);
            }
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturersPanel();
        }

    }
}