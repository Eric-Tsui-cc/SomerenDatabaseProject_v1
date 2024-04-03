using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class DeleteStudentForm : Form

    {
        StudentService studentService;
        public DeleteStudentForm()
        {
            InitializeComponent();
            studentService = new StudentService();
            RefreshStudents();
        }
        void RefreshStudents()
        {
            comboBoxStudents.Items.Clear();
            comboBoxStudents.ResetText();
            List<Student> students = studentService.GetStudents();
            foreach (Student student in students)
            {
                comboBoxStudents.Items.Add(student.Number);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedStudentNumber = (int)comboBoxStudents.SelectedItem;

            Student studentToDelete = studentService.GetByStudentNumber(selectedStudentNumber);

            if (studentToDelete != null)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete student {studentToDelete.FirstName} (Student Number: {studentToDelete.Number})?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    studentService.DeleteStudent(studentToDelete);

                    RefreshStudents();

                    MessageBox.Show("Student deleted successfully!");
                }
            }
        }

    }
}
