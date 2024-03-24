﻿
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

        //SHOW PANLES METHODS !!!!


        // Show the dashboard panel !!!
        private void ShowDashboardPanel()
        {
            hideAll();

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
        //SHOW THE PANELS

        // Show the lecturers panel
        private void ShowLectueresPanel()
        {
            // Hide the dashboard label
            lblDashboard.Hide();

            // Hide other panels
            hideAll();


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
            hideAll();


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

            hideAll();


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
            hideAll();

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


        /*Order panel*/

        private void ShowOrderPanel()
        {
            // Hide the dashboard label
            lblDashboard.Hide();

            // Hide the room panel
            hideAll();

            try
            {
                // Show the Order panel
                pnlOrder.Visible = true;

                // Get students from the service
                List<Student> students = GetStudents();
                List<Drink> drinks = GetDrinks();


                // Display students & drinks in the ListView
                DisplayStudentsForOrder(students);
                DisplayDrinksOrder(drinks);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }

        }

        // ShowRevenuePane Put it here => 




        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




        //THE GET SERVICES !!!


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
        // Get Orders from the service
        private List<Order> GetOrders()
        {
            OrderService orderService = new OrderService();
            List<Order> orders = orderService.GetOrders();
            return orders;
        }





        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





        //EVENT HANDLERS

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
        private void toolStripDrinks_Click(object sender, EventArgs e)
        {
            ShowDrinkPanel();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Order panel*/

            ShowOrderPanel();

        }
        // put RevenueToolStripMenuItem_Click here => 



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




        //DISPLAY STUFF IN LISTVIEWS AND LISTBOXES METHODS !!!!




        // Display Order students in the ListBox
        private void DisplayStudentsForOrder(List<Student> students)
        {
            listBoxStudentOrders.Items.Clear();

            foreach (Student student in students)
            {
                listBoxStudentOrders.Items.Add(student);
            }
        }
        // Display Order Drinks in the ListBox
        private void DisplayDrinksOrder(List<Drink> drinks)
        {
            // Clear existing items and columns in the ListBox
            listBoxDrinksOrders.Items.Clear();
            foreach (Drink drink in drinks)
            {
                listBoxDrinksOrders.Items.Add(drink);
            }
        }

        // Display students in the ListView
        private void DisplayStudents(List<Student> students)
        {
            // Clear the listview before filling it
            listViewStudents.Items.Clear();
            listViewStudents.Columns.Clear(); // Clear columns as well

            listViewStudents.View = View.Details;
            listViewStudents.Columns.Add("Name", 300);
            listViewStudents.Columns.Add("Student Number", 250);
            listViewStudents.Columns.Add("Telephone Number", 300);
            listViewStudents.Columns.Add("Room Number", 250);
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

            listViewLecturers.Columns.Add("Full Name", 300);
            listViewLecturers.Columns.Add("ID", 220);
            listViewLecturers.Columns.Add("Telephone Number", 300);
            listViewLecturers.Columns.Add("Age", 150);
            listViewLecturers.Columns.Add("Room Number", 250);

            foreach (Lecturer lecturer in lecturers)
            {
                ListViewItem li = new ListViewItem(lecturer.FullName);
                li.SubItems.Add(lecturer.PhoneNumber);
                li.SubItems.Add(lecturer.Age.ToString());
                li.SubItems.Add(lecturer.RoomNumber.ToString());
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
            listViewRooms.Columns.Add("Room Number", 220);
            listViewRooms.Columns.Add("Building Number", 300);
            listViewRooms.Columns.Add("Room Type", 300);
            listViewRooms.Columns.Add("Floor Number", 200);

            foreach (Room room in rooms)
            {
                ListViewItem li = new ListViewItem(room.RoomNumber.ToString());
                li.SubItems.Add(room.Building.ToString());
                li.SubItems.Add(room.RoomType.ToString());
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

            listViewActivities.Columns.Add("Name", 300);
            listViewActivities.Columns.Add("Date", 250);
            listViewActivities.Columns.Add("Time", 150);

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










        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////












        // BUTTONS & SINGLE USE NON REPEATING METHODS

        private void buttonOrder_Click_1(object sender, EventArgs e)
        {
            try
            {
                OrderService orderService = new();

                orderService.FillTheOrder(listBoxStudentOrders.SelectedIndex, listBoxDrinksOrders.SelectedIndex, (Student)listBoxStudentOrders.SelectedItem, (Drink)listBoxDrinksOrders.SelectedItem, (int)QuantityOfDrinks.Value);
                MessageBox.Show("Order is successfully placed!");
                ShowOrderPanel();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowOrderPanel();
        }

        private void listBoxStudentOrders_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DoingMyBestNotToRepeat();

        }

        private void listBoxDrinksOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoingMyBestNotToRepeat();


        }
        private void QuantityOfDrinks_ValueChanged_1(object sender, EventArgs e)
        {
            DoingMyBestNotToRepeat();
        }








        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////






        //REPEATING CODE PREVENTION METHODS

        public void hideAll()
        {
            // Hide all other panels
            pnlStudents.Hide();
            pnlActivity.Hide();
            pnlRoom.Hide();
            pnlLecturer.Hide();
            pnlDrinks.Hide();
            pnlOrder.Hide();
            pnlRevenue.Hide();
        }
        private void DoingMyBestNotToRepeat()
        {
            OrderService orderService = new();
            string finalPrice;

            orderService.DisplayPrice((Drink)listBoxDrinksOrders.SelectedItem, listBoxStudentOrders.SelectedIndex, listBoxDrinksOrders.SelectedIndex, QuantityOfDrinks.Value, out finalPrice);
            PriceOutput.Text = finalPrice;
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        //  WORK IN PROGRESS PART !!! 


        //AFTER YOU FINISH THE REVENUE PART PUT EVERYTHING WHERE IT IS SUPPOSED TO BE

        //Revenue panel

        // Button Revenue in Financials =>
        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRevenuePanel(); //After you press the button this method will be called
        }


        //  when the method is called it displays your revenue panel
        public void ShowRevenuePanel()
        {
            // Hide the dashboard label
            lblDashboard.Hide();
            hideAll(); //hides other panels


            try
            {
                pnlRevenue.Visible = true; //displays yours

            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drinks: " + e.Message);
            }
        }
        // Display activities in the ListView
        private void DisplayRevenueInfo(List<Order> orders)
        {
            listViewForRevenue.Items.Clear();
            listViewForRevenue.Columns.Clear();

            listViewForRevenue.View = View.Details;

            listViewForRevenue.Columns.Add("Drink Name", 300);
            listViewForRevenue.Columns.Add("Price", 200);
            listViewForRevenue.Columns.Add("Amount", 200);

            foreach (Order order in orders)
            {
                ListViewItem item = new ListViewItem(order.Drink.name);

                item.SubItems.Add(order.Drink.price.ToString());
                item.SubItems.Add(order.Amount.ToString());

                listViewForRevenue.Items.Add(item);
            }
        }


        private void ChangeLabels()
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            RevenueReportService revenueReportService = new RevenueReportService();


            DrinksSold.Text = revenueReportService.GenerateReport(startDate, endDate).Sales.ToString();
            Profits.Text = revenueReportService.GenerateReport(startDate, endDate).Turnover.ToString();
            Purchases.Text = revenueReportService.GenerateReport(startDate, endDate).CustomerCount.ToString();
        }


        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RevenueReportService revenueReportService = new();
            try
            {
                if (revenueReportService.CheckDates(dateTimePicker1.Value, dateTimePicker2.Value))
                {
                    List<Order> orders = GetOrders();
                    DisplayRevenueInfo(orders);
                    ChangeLabels();
                }
                else
                {
                    throw new Exception("Select the correct date !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            RevenueReportService revenueReportService = new();
            try
            {
                if (revenueReportService.CheckDates(dateTimePicker1.Value, dateTimePicker2.Value))
                {
                    List<Order> orders = GetOrders();
                    DisplayRevenueInfo(orders);
                    ChangeLabels();
                }
                else
                {
                    throw new Exception("Select the correct date !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


}
