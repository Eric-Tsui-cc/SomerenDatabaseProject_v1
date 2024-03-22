
using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Reflection.Emit;

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
            pnlDrinks.Hide();
            pnlOrder.Hide();

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
            pnlDrinks.Visible = false;

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
            pnlDrinks.Visible = false;

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
            pnlDrinks.Visible = false;
            pnlOrder.Visible = false;

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
            pnlDrinks.Visible = false;

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
            pnlOrder.Visible = false;

            try
            {
                // Show the drinks panel
                pnlDrinks.Visible = true;

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

        // Display students in the ListView
        private void DisplayStudents(List<Student> students)
        {
            // Clear the listview before filling it
            listViewStudents.Items.Clear();
            listViewStudents.Columns.Clear(); // Clear columns as well

            listViewStudents.View = View.Details;
            listViewStudents.Columns.Add("Name", 200);
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

        private void DisplayDrinks(List<Drink> drinks)
        {
            // Clear existing items and columns in the ListView
            listViewDrinks.Items.Clear();
            listViewDrinks.Columns.Clear();

            // Set the view to Details
            listViewDrinks.View = View.Details;

            // Add columns to the ListView
            listViewDrinks.Columns.Add("Name", 200);
            listViewDrinks.Columns.Add("Price", 150);
            listViewDrinks.Columns.Add("Type", 200);
            listViewDrinks.Columns.Add("Stock Status", 350);


            // Iterate through each drink and add them to the ListView
            foreach (Drink drink in drinks)
            {
                // Create a new ListViewItem with the drink's name
                ListViewItem item = new ListViewItem(drink.name);

                // Add sub-items for other properties of the drink
                item.SubItems.Add(drink.price.ToString());
                item.SubItems.Add(drink.type);
                string status = "";
                if (drink.Stock == 0)
                {
                    status = "stock empty";
                }
                else if (drink.Stock > 0 && drink.Stock < 10)
                {
                    status = "stock nearly depleted";
                }
                else if (drink.Stock >= 10)
                {
                    status = "stock sufficient";
                }

                item.SubItems.Add(status);

                // Set the appropriate image index based on the status
                int imageIndex = -1; // Default to Icon1
                if (status == "stock empty")
                {
                    imageIndex = 1;
                }
                else if (status == "stock nearly depleted")
                {
                    imageIndex = 0;
                }

                // Assign the image index to the ListViewItem
                item.ImageIndex = imageIndex;

                // Set the Tag property of the ListViewItem to the drink object itself
                item.Tag = drink;

                // Add the ListViewItem to the ListViewreg
                listViewDrinks.Items.Add(item);
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

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Order panel*/

            ShowOrderPanel();

        }
        /*Order panel*/

        private void ShowOrderPanel()
        {
            // Hide the dashboard label
            lblDashboard.Hide();

            // Hide the room panel
            pnlRoom.Visible = false;

            // Hide other panels
            pnlStudents.Visible = false;
            pnlLecturer.Visible = false;
            pnlDrinks.Visible = false;

            try
            {
                // Show the Order panel
                pnlOrder.Visible = true;

                // Get students from the service
                List<Student> students = GetStudents();
                List<Drink> drinks = GetDrinks();


                // Display students in the ListView
                DisplayStudentsForOrder(students);
                DisplayDrinksOrder(drinks);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }

        }
        // Display students in the ListView
        private void DisplayStudentsForOrder(List<Student> students)
        {
            listBoxStudentOrders.Items.Clear();

            foreach (Student student in students)
            {
                listBoxStudentOrders.Items.Add(student);
            }
        }

        private void DisplayDrinksOrder(List<Drink> drinks)
        {
            // Clear existing items and columns in the ListView
            listBoxDrinksOrders.Items.Clear();
            foreach (Drink drink in drinks)
            {
                listBoxDrinksOrders.Items.Add(drink);
            }
        }
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            try
            {
                OrderService orderService = new();

                orderService.FillOrder(listBoxStudentOrders.SelectedIndex, listBoxDrinksOrders.SelectedIndex, (Student)listBoxStudentOrders.SelectedItem, (Drink)listBoxDrinksOrders.SelectedItem, (int)QuantityOfDrinks.Value);
                MessageBox.Show("Order is successfully placed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listBoxStudentOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderService orderService = new();

            orderService.DisplayPrice((Drink)listBoxDrinksOrders.SelectedItem, listBoxStudentOrders.SelectedIndex, listBoxDrinksOrders.SelectedIndex, QuantityOfDrinks.Value, out string totalPrice);
            PriceOutput.Text = totalPrice;
        }

        private void listBoxDrinksOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderService orderService = new();

            orderService.DisplayPrice((Drink)listBoxDrinksOrders.SelectedItem, listBoxStudentOrders.SelectedIndex, listBoxDrinksOrders.SelectedIndex, QuantityOfDrinks.Value, out string totalPrice);
            PriceOutput.Text = totalPrice;
        }

        private void QuantityOfDrinks_ValueChanged(object sender, EventArgs e)
        {
            OrderService orderService = new();

            orderService.DisplayPrice((Drink)listBoxDrinksOrders.SelectedItem, listBoxStudentOrders.SelectedIndex, listBoxDrinksOrders.SelectedIndex, QuantityOfDrinks.Value, out string totalPrice);
            PriceOutput.Text = totalPrice;
        }



        private void toolStripDrinks_Click(object sender, EventArgs e)
        {
            ShowDrinkPanel();
        }


    }
}