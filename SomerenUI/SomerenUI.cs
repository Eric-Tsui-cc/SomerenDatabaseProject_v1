
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

        // Show the dashboard panel
        private void ShowDashboardPanel()
        {
            // Hide all other panels
            pnlStudents.Hide();
            pnlActivity.Hide();
            pnlRoom.Hide();
            pnlLecturer.Hide();

            // Show dashboard
            pnlDashboard.Show();
            lblDashboard.Show();
        }

        // Show the students panel
        private void ShowStudentsPanel()
        {
            // Hide the dashboard label
            lblDashboard.Hide();

            // Hide other panels
            pnlLecturer.Visible = false;
            pnlActivity.Visible = false;
            pnlRoom.Visible = false;

            try
            {
                // Show the students panel
                pnlStudents.Visible = true;

                // Get students from the service
                List<Student> students = GetStudents();

                // Display students in the ListView
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        // Show the lecturers panel
        private void ShowLectueresPanel()
        {
            // Hide the dashboard label
            lblDashboard.Hide();

            // Hide other panels
            pnlStudents.Visible = false;
            pnlActivity.Visible = false;
            pnlRoom.Visible = false;

            try
            {
                // Show the lecturers panel
                pnlLecturer.Visible = true;

                // Get lecturers from the service
                List<Lecturer> teachers = GetLecturers();

                // Display lecturers in the ListView
                DisplayLecturers(teachers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the teachers: " + e.Message);
            }
        }

        // Show the room panel
        private void ShowRoomPanel()
        {
            // Hide the dashboard label
            lblDashboard.Hide();

            // Hide other panels
            pnlStudents.Visible = false;
            pnlActivity.Visible = false;
            pnlLecturer.Visible = false;

            try
            {
                // Show the room panel
                pnlRoom.Visible = true;

                // Get rooms from the service
                List<Room> rooms = GetRooms();

                // Display rooms in the ListView
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }

        // Show the activity panel
        private void ShowActivityPanel()
        {
            // Hide the dashboard label
            lblDashboard.Hide();

            // Hide the room panel
            pnlRoom.Visible = false;

            // Hide other panels
            pnlStudents.Visible = false;
            pnlLecturer.Visible = false;

            try
            {
                // Show the activity panel
                pnlActivity.Visible = true;

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

        // Get students from the service
        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        // Get lecturers from the service
        private List<Lecturer> GetLecturers()
        {
            LecturerService teacherService = new LecturerService();
            List<Lecturer> teachers = teacherService.GetLecturers();
            return teachers;
        }

        // Get rooms from the service
        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }

        // Get activities from the service
        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetActivities();
            return activities;
        }

        // Display students in the ListView
        private void DisplayStudents(List<Student> students)
        {
            // Clear the listview before filling it
            listViewStudents.Items.Clear();
            listViewStudents.Columns.Clear(); // Clear columns as well

            listViewStudents.View = View.Details;
            listViewStudents.Columns.Add("Name", 120);
            listViewStudents.Columns.Add("Student Number", 200);
            listViewStudents.Columns.Add("Telephone Number", 200);
            listViewStudents.Columns.Add("Room Number", 200);
            listViewStudents.Columns.Add("Class", 150);

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.FullName);
                li.SubItems.Add(student.Number.ToString());
                li.SubItems.Add(student.TelePhoneNumber);
                li.SubItems.Add(student.RoomNumber.ToString());
                li.SubItems.Add(student.Class.ToString());
                li.Tag = student;
                listViewStudents.Items.Add(li);
            }
        }

        // Display lecturers in the ListView
        private void DisplayLecturers(List<Lecturer> lecturers)
        {
            listViewLecturers.Items.Clear();
            listViewLecturers.Columns.Clear();

            listViewLecturers.View = View.Details;

            listViewLecturers.Columns.Add("Full Name", 200);
            listViewLecturers.Columns.Add("ID", 120);
            listViewLecturers.Columns.Add("Telephone Number", 200);
            listViewLecturers.Columns.Add("Age", 200);
            listViewLecturers.Columns.Add("Room Number", 150);

            foreach (Lecturer lecturer in lecturers)
            {
                ListViewItem li = new ListViewItem(lecturer.FullName);
                li.SubItems.Add(lecturer.PhoneNumber);
                li.SubItems.Add(lecturer.Age.ToString());
                li.SubItems.Add(lecturer.RoomNmber.ToString());
                li.Tag = lecturer;
                listViewLecturers.Items.Add(li);
            }
        }

        // Display rooms in the ListView
        private void DisplayRooms(List<Room> rooms)
        {
            // Clear the listview before filling it
            listViewRooms.Items.Clear();
            listViewRooms.Columns.Clear(); // Clear columns as well

            listViewRooms.View = View.Details;
            listViewRooms.Columns.Add("Room Number", 120);
            listViewRooms.Columns.Add("Building Number", 200);
            listViewRooms.Columns.Add("Room Type", 200);
            listViewRooms.Columns.Add("Floor Number", 200);

            foreach (Room room in rooms)
            {
                ListViewItem li = new ListViewItem(room.RoomNumber.ToString());
                li.SubItems.Add(room.BuildingNumber.ToString());
                li.SubItems.Add(room.RoomType);
                li.SubItems.Add(room.FloorNumber.ToString());
                li.Tag = room;
                listViewRooms.Items.Add(li);
            }
        }

        // Display activities in the ListView
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

// Event handler for dashboard menu item click
        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            // Show the dashboard panel
            ShowDashboardPanel();
        }

        // Event handler for exit menu item click
        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        // Event handler for students menu item click
        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the students panel
            ShowStudentsPanel();
        }

        // Event handler for lecturers menu item click
        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the lecturers panel
            ShowLectueresPanel();
        }

        // Event handler when the form is loaded
        private void SomerenUI_Load(object sender, EventArgs e)
        {
            // Show the dashboard panel by default when the form is loaded
            ShowDashboardPanel();
        }

        // Event handler for rooms menu item click
        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the rooms panel
            ShowRoomPanel();
        }

        // Event handler for activities menu item click
        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the activities panel
            ShowActivityPanel();
        }

    }
}