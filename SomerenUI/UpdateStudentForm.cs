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
    public partial class UpdateStudentForm : Form
    {
        public UpdateStudentForm()
        {
            InitializeComponent();
            studentService = new StudentService();
            RefreshStudents();
        }
        StudentService studentService;
        void RefreshStudents()
        {

            comboBoxStudents.Items.Clear();
            List<Student> students = studentService.GetStudents();
            foreach (Student student in students)
            {
                comboBoxStudents.Items.Add(student.Number);
            }
        }

        private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            int number = (int)comboBoxStudents.SelectedItem;
            Student student = studentService.GetByStudentNumber(number);
            textBoxFirstName.Text = student.FirstName;
            textBoxLastName.Text = student.LastName;
            textBoxPhoneNumber.Text = student.TelePhoneNumber;
            textBoxClass.Text = student.Class;
            textBoxRoomNumber.Text = student.RoomNumber;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            object selectedItem = comboBoxStudents.SelectedItem;

            if (selectedItem != null)
            {
                int studentNumber;
                if (int.TryParse(selectedItem.ToString(), out studentNumber))
                {
                    Student updateStudent = new Student(
                        studentNumber,
                        textBoxFirstName.Text,
                        textBoxLastName.Text,
                        textBoxPhoneNumber.Text,
                        textBoxClass.Text,
                        textBoxRoomNumber.Text
                    );

                    studentService.UpdateStudent(updateStudent);
                    MessageBox.Show("Student updated!");
                    RefreshStudents();
                }
                else
                {
                    MessageBox.Show("Invalid student number selected!");
                }
            }
            else
            {
                MessageBox.Show("No student selected!");
            }

            comboBoxStudents.SelectedItem = selectedItem;
        }

    }
}
