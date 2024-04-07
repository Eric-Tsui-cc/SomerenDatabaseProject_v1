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
    public partial class AddLecturerForm : Form
    {
        LecturerService lecturerService;
        public AddLecturerForm()
        {
            InitializeComponent();
            lecturerService = new LecturerService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int studentNumber = int.Parse(textBox1.Text);
            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            string telephoneNumber = textBox4.Text;
            int Age = int.Parse(textBox5.Text);
            string roomNumber = textBox6.Text;

            Lecturer lecturer = new Lecturer(studentNumber, firstName, lastName, telephoneNumber, Age, roomNumber);


            ;
            lecturerService.AddLecturer(lecturer);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            MessageBox.Show("Lecturer added successfully!");
        }
    }
}
