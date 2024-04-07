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
    public partial class DeleteTeacherForm : Form
    {
        LecturerService lecturerService;
        public DeleteTeacherForm()
        {
            InitializeComponent();
            lecturerService = new LecturerService();
            RefreshTeachers();
        }
        void RefreshTeachers()
        {
            comboBoxTeachers.Items.Clear();
            comboBoxTeachers.ResetText();
            List<Lecturer> lecturers = lecturerService.GetLecturers();
            foreach (Lecturer lecturer in lecturers)
            {
                comboBoxTeachers.Items.Add(lecturer.Number);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedTeacherNumber = (int)comboBoxTeachers.SelectedItem;
            Lecturer teacherToDelete = lecturerService.GetByLecturerID(selectedTeacherNumber);

            if (teacherToDelete != null)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete Lecteurer {teacherToDelete.FirstName} (Student Number: {teacherToDelete.Number})?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    lecturerService.DeleteStudent(teacherToDelete);

                    RefreshTeachers();

                    MessageBox.Show("Lecteurer deleted successfully!");
                }
            }
        }
    }
}
