
using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            pnlDrink.Hide();

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
            pnlDrink.Visible = false;

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
            pnlDrink.Visible = false;

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
            pnlDrink.Visible = false;

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
            pnlDrink.Visible = false;

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
        private void ShowDrinkPanel()
        {
            // Hide the dashboard label
            lblDashboard.Hide();

            // Hide other panels
            pnlStudents.Visible = false;
            pnlActivity.Visible = false;
            pnlLecturer.Visible = false;
            pnlRoom.Visible = false;

            try
            {
                // Show the drinks panel
                pnlDrink.Visible = true;

                // Get drinks from the service
                List<Drink> drinks = GetDrinks();

                // Display drinks in the ListView or any other control you're using
                DisplayDrinks(drinks);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drinks: " + e.Message);
            }
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
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
        // Get drinks from the service
        private List<Drink> GetDrinks()
        {
            DrinkService drinkService = new DrinkService();
            List<Drink> drinks = drinkService.GetDrinks();
            return drinks;
        }
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////
        /// </summary>
        // Display students in the ListView
        private void DisplayStudents(List<Student> students)
        {
            ClearListViewStudent();

            listViewStudents.View = View.Details;
            AddListViewColumnsStudent();

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
            ClearListViewLectuer();

            listViewLecturers.View = View.Details;

            AddListViewColumnsLectuer();

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
            ClearListViewRoom();

            listViewRooms.View = View.Details;
            AddListViewColumnsRoom();

            foreach (Room room in rooms)
            {
                ListViewItem li = new ListViewItem(room.RoomNumber.ToString());
                li.SubItems.Add(room.Building.ToString());
                li.SubItems.Add(room.RoomType);
                li.SubItems.Add(room.FloorNumber.ToString());
                li.Tag = room;
                listViewRooms.Items.Add(li);
            }
        }

        // Display activities in the ListView
        private void DisplayActivity(List<Activity> activities)
        {
            ClearListViewActivity();

            listViewActivities.View = View.Details;

            AddListViewColumnsActivity();

            foreach (Activity activity in activities)
            {
                ListViewItem item = new ListViewItem(activity.Name);

                item.SubItems.Add(activity.Date.ToShortDateString());
                item.SubItems.Add(activity.Time.ToString());

                item.Tag = activity;

                listViewActivities.Items.Add(item);
            }
        }

        private void DisplayDrinks(List<Drink> drinks)
        {
            ClearListViewDrink();
            listViewDrinks.View = View.Details;

            AddListViewColumnsDrink();

            // Set the view to Details

            ImageList imageList = CreateImageList();

            // Iterate through each drink and add them to the ListView
            foreach (Drink drink in drinks)
            {
                // Create a new ListViewItem with the drink's name
                ListViewItem item = new ListViewItem(drink.name);

                // Add sub-items for other properties of the drink
                item.SubItems.Add(drink.type);
                item.SubItems.Add(drink.stock.ToString());
                //get stock status
                string status = GetStockStatus(drink);

                item.SubItems.Add(status);
                item.SubItems.Add(drink.id.ToString());
                SetImageIndex(item, drink);

                // Set the Tag property of the ListViewItem to the drink object itself
                item.Tag = drink;

                // Add the ListViewItem to the ListView
                listViewDrinks.Items.Add(item);
            }

            // Assign the ImageList to the ListView after adding all items
            listViewDrinks.SmallImageList = imageList;
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

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

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show drink panel
            ShowDrinkPanel();
        }
        private void DeleteDrinkButton_Click_1(object sender, EventArgs e)
        {
            DeleteDrinkForm deleteDrinkForm = new DeleteDrinkForm();
            deleteDrinkForm.ShowDialog();
        }
        private void EditDrinkButton_Click(object sender, EventArgs e)
        {
            UpdateDrinkForm updateDrinkForm = new UpdateDrinkForm();
            updateDrinkForm.ShowDialog();
        }


        /// /////////////////////////////////////////////////////////////////

        private void ClearListViewDrink()
        {
            listViewDrinks.Items.Clear();
            listViewDrinks.Columns.Clear();
        }
        private void ClearListViewActivity()
        {
            listViewActivities.Items.Clear();
            listViewActivities.Columns.Clear();
        }

        private void ClearListViewLectuer()
        {
            listViewLecturers.Items.Clear();
            listViewLecturers.Columns.Clear();
        }

        private void ClearListViewRoom()
        {
            listViewRooms.Items.Clear();
            listViewRooms.Columns.Clear();
        }

        private void ClearListViewStudent()
        {
            listViewStudents.Items.Clear();
            listViewStudents.Columns.Clear();
        }

        private void AddListViewColumnsDrink()
        {
            listViewDrinks.Columns.Add("Name", 200);
            listViewDrinks.Columns.Add("Type", 150);
            listViewDrinks.Columns.Add("Stock", 200);
            listViewDrinks.Columns.Add("Stock Status", 200);
            listViewDrinks.Columns.Add("Drink Id", 200);

        }
        private void AddListViewColumnsActivity()
        {
            listViewActivities.Columns.Add("Name", 200);
            listViewActivities.Columns.Add("Date", 150);
            listViewActivities.Columns.Add("Time", 100);
        }
        private void AddListViewColumnsRoom()
        {
            listViewRooms.Columns.Add("Room Number", 120);
            listViewRooms.Columns.Add("Building", 200);
            listViewRooms.Columns.Add("Room Type", 200);
            listViewRooms.Columns.Add("Floor Number", 200);
        }
        private void AddListViewColumnsStudent()
        {
            listViewStudents.Columns.Add("Name", 200);
            listViewStudents.Columns.Add("Student Number", 200);
            listViewStudents.Columns.Add("Telephone Number", 200);
            listViewStudents.Columns.Add("Room Number", 200);
            listViewStudents.Columns.Add("Class", 150);
        }
        private void AddListViewColumnsLectuer()
        {
            listViewLecturers.Columns.Add("Full Name", 200);
            listViewLecturers.Columns.Add("Telephone Number", 200);
            listViewLecturers.Columns.Add("Age", 200);
            listViewLecturers.Columns.Add("Room Number", 150);
        }
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////
        /// method for drink panel
        private ImageList CreateImageList()
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(32, 32);
            imageList.Images.Add("Icon1", new Bitmap("..//..//..//icons/icon1.ico"));
            imageList.Images.Add("Icon2", new Bitmap("..//..//..//icons/icon2.ico"));
            return imageList;
        }
        private string GetStockStatus(Drink drink)
        {
            if (drink.stock == 0)
            {
                return "stock empty";
            }
            else if (drink.stock > 0 && drink.stock < 10)
            {
                return "stock nearly depleted";
            }
            else
            {
                return "stock sufficient";
            }
        }
        private void SetImageIndex(ListViewItem item, Drink drink)
        {
            int imageIndex = -1; // Default to Icon1
            if (drink.stock == 0)
            {
                imageIndex = 1;
            }
            else if (drink.stock > 0 && drink.stock < 10)
            {
                imageIndex = 0;
            }

            // Assign the image index to the ListViewItem

            item.ImageIndex = imageIndex;
        }

    }
}