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
    public partial class UpdateTeacherForm : Form
    {
        LecturerService lecturerService;
        public UpdateTeacherForm()
        {
            InitializeComponent();
            lecturerService = new LecturerService();
            RefreshTeachers();
        }
        void RefreshTeachers()
        {
            comboBox1.Items.Clear();
            comboBox1.ResetText();
            List<Lecturer> lecturers = lecturerService.GetLecturers();
            foreach (Lecturer lecturer in lecturers)
            {
                comboBox1.Items.Add(lecturer.Number);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object selectedItem = comboBox1.SelectedItem;

            if (selectedItem != null)
            {
                int studentNumber;
                if (int.TryParse(selectedItem.ToString(), out studentNumber))
                {
                    Lecturer updatelecturer = new Lecturer(
                        studentNumber,
                        textBox1.Text,
                        textBox2.Text,
                        textBox3.Text,
                        int.Parse(textBox4.Text),
                        textBox5.Text
                    );

                    lecturerService.UpdateLecturer(updatelecturer);
                    MessageBox.Show("Teacher updated!");
                    RefreshTeachers();
                }
                else
                {
                    MessageBox.Show("Invalid Teacher number selected!");
                }
            }
            else
            {
                MessageBox.Show("No Teacher selected!");
            }

            comboBox1.SelectedItem = selectedItem;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int number = (int)comboBox1.SelectedItem;
            Lecturer lecturer = lecturerService.GetByLecturerID(number);
            textBox1.Text = lecturer.FirstName;
            textBox2.Text = lecturer.LastName;
            textBox3.Text = lecturer.PhoneNumber;
            textBox4.Text = lecturer.Age.ToString();
            textBox5.Text = lecturer.RoomNumber;
        }
    }
}
