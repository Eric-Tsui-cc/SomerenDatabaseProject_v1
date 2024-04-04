using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
namespace SomerenUI
{
    public partial class SuperviseForm : Form
    {
        private LecturerService lecturerService;
        private SuperviseService SuperviseService;
        public SuperviseForm()
        {
            InitializeComponent();
            lecturerService = new LecturerService();
            SuperviseService = new SuperviseService();
            ShowActivityPanel();
        }
        private void ShowActivityPanel()
        {
            try
            {
                // Get activities from the service
                List<Activity> activities = GetActivities();

                // Display activities in the ListView
                DisplayActivity(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }
        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetActivities();
            return activities;
        }
        private void DisplayActivity(List<Activity> activities)
        {

            listViewActivities.Items.Clear();
            listViewActivities.Columns.Clear();
            listViewActivities.View = View.Details;

            listViewActivities.Columns.Add("Name", 200);
            listViewActivities.Columns.Add("Date", 150);
            listViewActivities.Columns.Add("Time", 100);

            foreach (Activity activity in activities)
            {
                ListViewItem item = new ListViewItem(activity.Name);

                item.SubItems.Add(activity.Date.ToShortDateString());
                item.SubItems.Add(activity.Time.ToString());

                item.Tag = activity;

                listViewActivities.Items.Add(item);
            }
        }

        private void listViewActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewActivities.SelectedItems.Count > 0)
            {
                Activity activity;
                List<Lecturer> lecturers;
                List<Lecturer> allLecturers = lecturerService.GetLecturers();


                ListViewItem selectedItem = listViewActivities.SelectedItems[0];

                string selectedValue = selectedItem.Text;
                activity = SuperviseService.GetByName(selectedValue);
                lecturers = SuperviseService.GetLecturersIdByActivity(activity);
                List<Lecturer> newLecturers = new List<Lecturer>(allLecturers);
                foreach (Lecturer lecturer in lecturers)
                {
                    newLecturers.RemoveAll(l => l.Number == lecturer.Number);
                }
                DisplayTeacherout(newLecturers);
                DisplayTeacherin(lecturers);
            }
        }

        private void DisplayTeacherin(List<Lecturer> lecturers)
        {

            listViewTeacherin.Items.Clear();
            listViewTeacherin.Columns.Clear();
            listViewTeacherin.View = View.Details;

            listViewTeacherin.Columns.Add("LecturerId", 100);
            listViewTeacherin.Columns.Add("Name", 150);


            foreach (Lecturer lecturer in lecturers)
            {
                ListViewItem item = new ListViewItem(lecturer.Number.ToString());

                item.SubItems.Add(SuperviseService.GetLecturerByid(lecturer.Number).FullName);

                item.Tag = lecturer;

                listViewTeacherin.Items.Add(item);
            }
        }
        private void DisplayTeacherout(List<Lecturer> lecturers)
        {
            listViewTeacherout.Items.Clear();
            listViewTeacherout.Columns.Clear();

            listViewTeacherout.View = View.Details;

            listViewTeacherout.Columns.Add("LecturerId", 100);
            listViewTeacherout.Columns.Add("Name", 150);


            foreach (Lecturer lecturer in lecturers)
            {
                ListViewItem item = new ListViewItem(lecturer.Number.ToString());

                item.SubItems.Add(lecturer.FullName);

                item.Tag = lecturer;

                listViewTeacherout.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listViewActivities.SelectedItems[0];

            string activityName = selectedItem.Text;
            Activity ToDeleteactivity = SuperviseService.GetByName(activityName);

            ListViewItem selectedItem1 = listViewTeacherin.SelectedItems[0];

            string teacherId = selectedItem1.Text;
            Lecturer ToDeletelecturer = SuperviseService.GetLecturerByid(int.Parse(teacherId));

            if (ToDeletelecturer != null && ToDeleteactivity != null)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to remove supervisor {ToDeletelecturer.FullName} (from activity: {ToDeleteactivity.Name})?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SuperviseService.DeleteSupervisor(ToDeletelecturer, ToDeleteactivity);

                    MessageBox.Show("Supervisor deleted successfully!");
                    Refresh();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listViewActivities.SelectedItems[0];

            string activityName = selectedItem.Text;
            Activity activity = SuperviseService.GetByName(activityName);

            ListViewItem selectedItem1 = listViewTeacherout.SelectedItems[0];

            string teacherId = selectedItem1.Text;
            Lecturer lecturer = SuperviseService.GetLecturerByid(int.Parse(teacherId));
            SuperviseService.AddSupervisor(lecturer, activity);
            MessageBox.Show("Supervisor added!");
            Refresh();
        }
        private void Refresh()
        {
            if (listViewActivities.SelectedItems.Count > 0)
            {
                Activity activity;
                List<Lecturer> lecturers;
                List<Lecturer> allLecturers = lecturerService.GetLecturers();


                ListViewItem selectedItem = listViewActivities.SelectedItems[0];

                string selectedValue = selectedItem.Text;
                activity = SuperviseService.GetByName(selectedValue);
                lecturers = SuperviseService.GetLecturersIdByActivity(activity);
                List<Lecturer> newLecturers = new List<Lecturer>(allLecturers);
                foreach (Lecturer lecturer in lecturers)
                {
                    newLecturers.RemoveAll(l => l.Number == lecturer.Number);
                }
                DisplayTeacherout(newLecturers);
                DisplayTeacherin(lecturers);
            }
        }
    }
}
