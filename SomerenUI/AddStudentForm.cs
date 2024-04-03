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
    public partial class AddStudentForm : Form
    {
        StudentService studentService;
        public AddStudentForm()
        {
            InitializeComponent();
            studentService = new StudentService();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            int studentNumber = int.Parse(textBoxNumber.Text);
            string firstName = textBoxFristName.Text;
            string lastName = textBoxLastName.Text;
            string telephoneNumber = textBoxPhoneNumber.Text;
            string studentClass = textBoxClass.Text;
            string roomNumber = textBoxRoomNumber.Text;

            Student student = new Student(studentNumber, firstName, lastName, telephoneNumber, studentClass, roomNumber);


            ;
            studentService.AddStudent(student);

            textBoxNumber.Text = "";
            textBoxFristName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxClass.Text = "";
            textBoxRoomNumber.Text = "";

            MessageBox.Show("Student added successfully!");
        }
    }
}
