using System.Windows.Forms;
using System;

namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            lecturersToolStripMenuItem = new ToolStripMenuItem();
            activitiesToolStripMenuItem = new ToolStripMenuItem();
            roomsToolStripMenuItem = new ToolStripMenuItem();
            toolStripDrinksItem = new ToolStripMenuItem();
            drinksToolStripMenuItem = new ToolStripMenuItem();
            pnlDashboard = new Panel();
            pnlRoom = new Panel();
            pictureBox1 = new PictureBox();
            listViewRooms = new ListView();
            label6 = new Label();
            pnlOrder = new Panel();
            button6 = new Button();
            button5 = new Button();
            label5 = new Label();
            QuantityOfDrinks = new NumericUpDown();
            buttonOrder = new Button();
            listBoxStudentOrders = new ListBox();
            listBoxDrinksOrders = new ListBox();
            label7 = new Label();
            PriceOutput = new Label();
            label8 = new Label();
            pnlActivity = new Panel();
            listViewActivities = new ListView();
            label4 = new Label();
            pnlStudents = new Panel();
            listViewStudents = new ListView();
            label1 = new Label();
            pnlLecturer = new Panel();
            listViewLecturers = new ListView();
            label2 = new Label();
            lblDashboard = new Label();
            pnlVat = new Panel();
            button7 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            yearOnlySelect = new Label();
            dateTimePicker3 = new DateTimePicker();
            label15 = new Label();
            pnlRevenue = new Panel();
            button8 = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            Purchases = new Label();
            Profits = new Label();
            DrinksSold = new Label();
            label11 = new Label();
            label10 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            listViewForRevenue = new ListView();
            label9 = new Label();
            pnlDrink = new Panel();
            refreshBtn = new Button();
            EditDrinkButton = new Button();
            AddDrinkButton = new Button();
            DeleteDrinkButton = new Button();
            listViewDrinks = new ListView();
            label3 = new Label();
            pictureBox7 = new PictureBox();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityOfDrinks).BeginInit();
            pnlActivity.SuspendLayout();
            pnlStudents.SuspendLayout();
            pnlLecturer.SuspendLayout();
            pnlVat.SuspendLayout();
            pnlRevenue.SuspendLayout();
            pnlDrink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, toolStripDrinksItem, drinksToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(14, 5, 0, 5);
            menuStrip1.Size = new System.Drawing.Size(2463, 55);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(192, 45);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(329, 54);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(329, 54);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(158, 45);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(162, 45);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(159, 45);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(134, 45);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // toolStripDrinksItem
            // 
            toolStripDrinksItem.Name = "toolStripDrinksItem";
            toolStripDrinksItem.Size = new System.Drawing.Size(125, 45);
            toolStripDrinksItem.Text = "Drinks";
            toolStripDrinksItem.Click += toolStripDrinks_Click;
            // 
            // drinksToolStripMenuItem
            // 
            drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            drinksToolStripMenuItem.Size = new System.Drawing.Size(132, 45);
            drinksToolStripMenuItem.Text = "Orders";
            drinksToolStripMenuItem.Click += drinksToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(pnlRoom);
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Controls.Add(pnlVat);
            pnlDashboard.Controls.Add(pnlRevenue);
            pnlDashboard.Controls.Add(pnlDrink);
            pnlDashboard.Controls.Add(pnlOrder);
            pnlDashboard.Controls.Add(pnlActivity);
            pnlDashboard.Controls.Add(pnlStudents);
            pnlDashboard.Controls.Add(pnlLecturer);
            pnlDashboard.Location = new System.Drawing.Point(0, 0);
            pnlDashboard.Margin = new Padding(8, 9, 8, 9);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(2278, 1274);
            pnlDashboard.TabIndex = 1;
            // 
            // pnlRoom
            // 
            pnlRoom.Controls.Add(pictureBox1);
            pnlRoom.Controls.Add(listViewRooms);
            pnlRoom.Controls.Add(label6);
            pnlRoom.Dock = DockStyle.Top;
            pnlRoom.Location = new System.Drawing.Point(0, 1274);
            pnlRoom.Margin = new Padding(8, 9, 8, 9);
            pnlRoom.Name = "pnlRoom";
            pnlRoom.Size = new System.Drawing.Size(2278, 1274);
            pnlRoom.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(2096, 193);
            pictureBox1.Margin = new Padding(8, 9, 8, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(235, 275);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.Location = new System.Drawing.Point(56, 205);
            listViewRooms.Margin = new Padding(5);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(1854, 833);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(56, 94);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(216, 81);
            label6.TabIndex = 0;
            label6.Text = "Rooms";
            // 
            // pnlOrder
            // 
            pnlOrder.Controls.Add(button6);
            pnlOrder.Controls.Add(button5);
            pnlOrder.Controls.Add(label5);
            pnlOrder.Controls.Add(QuantityOfDrinks);
            pnlOrder.Controls.Add(buttonOrder);
            pnlOrder.Controls.Add(listBoxStudentOrders);
            pnlOrder.Controls.Add(listBoxDrinksOrders);
            pnlOrder.Controls.Add(label7);
            pnlOrder.Controls.Add(PriceOutput);
            pnlOrder.Controls.Add(label8);
            pnlOrder.Dock = DockStyle.Top;
            pnlOrder.Location = new System.Drawing.Point(0, 0);
            pnlOrder.Margin = new Padding(8, 9, 8, 9);
            pnlOrder.Name = "pnlOrder";
            pnlOrder.Size = new System.Drawing.Size(2278, 1274);
            pnlOrder.TabIndex = 17;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(1860, 998);
            button6.Margin = new Padding(6, 7, 6, 7);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(405, 154);
            button6.TabIndex = 10;
            button6.Text = "Vat Report";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(1853, 740);
            button5.Margin = new Padding(6, 7, 6, 7);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(405, 154);
            button5.TabIndex = 9;
            button5.Text = "Revenue report";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(1852, 374);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(105, 41);
            label5.TabIndex = 8;
            label5.Text = "Price : ";
            // 
            // QuantityOfDrinks
            // 
            QuantityOfDrinks.Location = new System.Drawing.Point(1853, 280);
            QuantityOfDrinks.Margin = new Padding(6, 7, 6, 7);
            QuantityOfDrinks.Name = "QuantityOfDrinks";
            QuantityOfDrinks.Size = new System.Drawing.Size(397, 47);
            QuantityOfDrinks.TabIndex = 3;
            QuantityOfDrinks.ValueChanged += QuantityOfDrinks_ValueChanged;
            // 
            // buttonOrder
            // 
            buttonOrder.Location = new System.Drawing.Point(1853, 475);
            buttonOrder.Margin = new Padding(6, 7, 6, 7);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new System.Drawing.Size(405, 154);
            buttonOrder.TabIndex = 3;
            buttonOrder.Text = "Place Order";
            buttonOrder.UseVisualStyleBackColor = true;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // listBoxStudentOrders
            // 
            listBoxStudentOrders.FormattingEnabled = true;
            listBoxStudentOrders.ItemHeight = 41;
            listBoxStudentOrders.Location = new System.Drawing.Point(56, 205);
            listBoxStudentOrders.Margin = new Padding(6, 7, 6, 7);
            listBoxStudentOrders.Name = "listBoxStudentOrders";
            listBoxStudentOrders.Size = new System.Drawing.Size(593, 947);
            listBoxStudentOrders.TabIndex = 3;
            listBoxStudentOrders.SelectedIndexChanged += listBoxStudentOrders_SelectedIndexChanged;
            // 
            // listBoxDrinksOrders
            // 
            listBoxDrinksOrders.FormattingEnabled = true;
            listBoxDrinksOrders.ItemHeight = 41;
            listBoxDrinksOrders.Location = new System.Drawing.Point(797, 205);
            listBoxDrinksOrders.Margin = new Padding(6, 7, 6, 7);
            listBoxDrinksOrders.Name = "listBoxDrinksOrders";
            listBoxDrinksOrders.Size = new System.Drawing.Size(944, 947);
            listBoxDrinksOrders.TabIndex = 4;
            listBoxDrinksOrders.SelectedIndexChanged += listBoxDrinksOrders_SelectedIndexChanged_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(56, 94);
            label7.Margin = new Padding(8, 0, 8, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(213, 81);
            label7.TabIndex = 0;
            label7.Text = "Orders";
            // 
            // PriceOutput
            // 
            PriceOutput.AutoSize = true;
            PriceOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PriceOutput.Location = new System.Drawing.Point(1960, 375);
            PriceOutput.Margin = new Padding(6, 0, 6, 0);
            PriceOutput.Name = "PriceOutput";
            PriceOutput.Size = new System.Drawing.Size(67, 47);
            PriceOutput.TabIndex = 7;
            PriceOutput.Text = "0.00";
            PriceOutput.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(1845, 205);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(420, 41);
            label8.TabIndex = 6;
            label8.Text = "Choose the number of drinks :";
            // 
            // pnlActivity
            // 
            pnlActivity.Controls.Add(listViewActivities);
            pnlActivity.Controls.Add(label4);
            pnlActivity.Location = new System.Drawing.Point(0, 0);
            pnlActivity.Margin = new Padding(8, 9, 8, 9);
            pnlActivity.Name = "pnlActivity";
            pnlActivity.Size = new System.Drawing.Size(2278, 1274);
            pnlActivity.TabIndex = 3;
            // 
            // listViewActivities
            // 
            listViewActivities.Location = new System.Drawing.Point(56, 205);
            listViewActivities.Margin = new Padding(8, 9, 8, 9);
            listViewActivities.Name = "listViewActivities";
            listViewActivities.Size = new System.Drawing.Size(1854, 833);
            listViewActivities.TabIndex = 1;
            listViewActivities.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(56, 94);
            label4.Margin = new Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(272, 81);
            label4.TabIndex = 0;
            label4.Text = "Activities";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(0, 0);
            pnlStudents.Margin = new Padding(8, 9, 8, 9);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(2278, 1274);
            pnlStudents.TabIndex = 2;
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new System.Drawing.Point(56, 205);
            listViewStudents.Margin = new Padding(8, 9, 8, 9);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(1854, 833);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(56, 94);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(264, 81);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlLecturer
            // 
            pnlLecturer.Controls.Add(listViewLecturers);
            pnlLecturer.Controls.Add(label2);
            pnlLecturer.Location = new System.Drawing.Point(0, 0);
            pnlLecturer.Margin = new Padding(8, 9, 8, 9);
            pnlLecturer.Name = "pnlLecturer";
            pnlLecturer.Size = new System.Drawing.Size(2278, 1274);
            pnlLecturer.TabIndex = 3;
            // 
            // listViewLecturers
            // 
            listViewLecturers.Location = new System.Drawing.Point(56, 205);
            listViewLecturers.Margin = new Padding(8, 9, 8, 9);
            listViewLecturers.Name = "listViewLecturers";
            listViewLecturers.Size = new System.Drawing.Size(1854, 833);
            listViewLecturers.TabIndex = 1;
            listViewLecturers.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(56, 94);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(274, 81);
            label2.TabIndex = 0;
            label2.Text = "Lecturers";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(39, 72);
            lblDashboard.Margin = new Padding(8, 0, 8, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(523, 41);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlVat
            // 
            pnlVat.Controls.Add(button7);
            pnlVat.Controls.Add(button4);
            pnlVat.Controls.Add(button3);
            pnlVat.Controls.Add(button2);
            pnlVat.Controls.Add(button1);
            pnlVat.Controls.Add(label25);
            pnlVat.Controls.Add(label24);
            pnlVat.Controls.Add(label23);
            pnlVat.Controls.Add(label22);
            pnlVat.Controls.Add(label21);
            pnlVat.Controls.Add(label20);
            pnlVat.Controls.Add(label19);
            pnlVat.Controls.Add(label18);
            pnlVat.Controls.Add(label17);
            pnlVat.Controls.Add(label16);
            pnlVat.Controls.Add(yearOnlySelect);
            pnlVat.Controls.Add(dateTimePicker3);
            pnlVat.Controls.Add(label15);
            pnlVat.Location = new System.Drawing.Point(8, 8);
            pnlVat.Margin = new Padding(8, 9, 8, 9);
            pnlVat.Name = "pnlVat";
            pnlVat.Size = new System.Drawing.Size(2278, 1274);
            pnlVat.TabIndex = 3;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(2045, 120);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(206, 53);
            button7.TabIndex = 21;
            button7.Text = "Go Back";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(692, 539);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(206, 53);
            button4.TabIndex = 20;
            button4.Text = "Quarter 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(692, 451);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(206, 53);
            button3.TabIndex = 19;
            button3.Text = "Quarter 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(425, 539);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(206, 53);
            button2.TabIndex = 18;
            button2.Text = "Quarter 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(425, 451);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(206, 53);
            button1.TabIndex = 17;
            button1.Text = "Quarter 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label25
            // 
            label25.AutoEllipsis = true;
            label25.AutoSize = true;
            label25.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label25.Location = new System.Drawing.Point(863, 822);
            label25.Margin = new Padding(8, 0, 8, 0);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(230, 50);
            label25.TabIndex = 16;
            label25.Text = "dd/mm/yyyy";
            // 
            // label24
            // 
            label24.AutoEllipsis = true;
            label24.AutoSize = true;
            label24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label24.Location = new System.Drawing.Point(863, 692);
            label24.Margin = new Padding(8, 0, 8, 0);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(230, 50);
            label24.TabIndex = 15;
            label24.Text = "dd/mm/yyyy";
            // 
            // label23
            // 
            label23.AutoEllipsis = true;
            label23.AutoSize = true;
            label23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label23.Location = new System.Drawing.Point(1894, 822);
            label23.Margin = new Padding(8, 0, 8, 0);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(90, 50);
            label23.TabIndex = 14;
            label23.Text = "0.00";
            label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.AutoEllipsis = true;
            label22.AutoSize = true;
            label22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label22.Location = new System.Drawing.Point(1894, 638);
            label22.Margin = new Padding(8, 0, 8, 0);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(90, 50);
            label22.TabIndex = 13;
            label22.Text = "0.00";
            label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.AutoEllipsis = true;
            label21.AutoSize = true;
            label21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label21.Location = new System.Drawing.Point(1894, 458);
            label21.Margin = new Padding(8, 0, 8, 0);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(90, 50);
            label21.TabIndex = 12;
            label21.Text = "0.00";
            label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.AutoEllipsis = true;
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label20.Location = new System.Drawing.Point(1556, 822);
            label20.Margin = new Padding(8, 0, 8, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(188, 50);
            label20.TabIndex = 11;
            label20.Text = "Total vat  :";
            // 
            // label19
            // 
            label19.AutoEllipsis = true;
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label19.Location = new System.Drawing.Point(1556, 638);
            label19.Margin = new Padding(8, 0, 8, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(315, 50);
            label19.TabIndex = 10;
            label19.Text = "Total vat for 21% :";
            // 
            // label18
            // 
            label18.AutoEllipsis = true;
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label18.Location = new System.Drawing.Point(1556, 458);
            label18.Margin = new Padding(8, 0, 8, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(295, 50);
            label18.TabIndex = 9;
            label18.Text = "Total vat for 9% :";
            // 
            // label17
            // 
            label17.AutoEllipsis = true;
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label17.Location = new System.Drawing.Point(404, 822);
            label17.Margin = new Padding(8, 0, 8, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(428, 50);
            label17.TabIndex = 8;
            label17.Text = "End Day of the Quarter : ";
            // 
            // label16
            // 
            label16.AutoEllipsis = true;
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label16.Location = new System.Drawing.Point(404, 692);
            label16.Margin = new Padding(8, 0, 8, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(443, 50);
            label16.TabIndex = 7;
            label16.Text = "Start Day of the Quarter : ";
            // 
            // yearOnlySelect
            // 
            yearOnlySelect.AutoEllipsis = true;
            yearOnlySelect.AutoSize = true;
            yearOnlySelect.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            yearOnlySelect.Location = new System.Drawing.Point(404, 375);
            yearOnlySelect.Margin = new Padding(8, 0, 8, 0);
            yearOnlySelect.Name = "yearOnlySelect";
            yearOnlySelect.Size = new System.Drawing.Size(216, 50);
            yearOnlySelect.TabIndex = 6;
            yearOnlySelect.Text = "Select year :";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "yyyy";
            dateTimePicker3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.ImeMode = ImeMode.NoControl;
            dateTimePicker3.Location = new System.Drawing.Point(693, 375);
            dateTimePicker3.MaxDate = new DateTime(2024, 3, 27, 0, 0, 0, 0);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.RightToLeft = RightToLeft.Yes;
            dateTimePicker3.Size = new System.Drawing.Size(205, 52);
            dateTimePicker3.TabIndex = 5;
            dateTimePicker3.Value = new DateTime(2024, 3, 27, 0, 0, 0, 0);
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label15.Location = new System.Drawing.Point(56, 94);
            label15.Margin = new Padding(8, 0, 8, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(119, 81);
            label15.TabIndex = 0;
            label15.Text = "Vat";
            // 
            // pnlRevenue
            // 
            pnlRevenue.Controls.Add(button8);
            pnlRevenue.Controls.Add(label14);
            pnlRevenue.Controls.Add(label13);
            pnlRevenue.Controls.Add(label12);
            pnlRevenue.Controls.Add(Purchases);
            pnlRevenue.Controls.Add(Profits);
            pnlRevenue.Controls.Add(DrinksSold);
            pnlRevenue.Controls.Add(label11);
            pnlRevenue.Controls.Add(label10);
            pnlRevenue.Controls.Add(dateTimePicker2);
            pnlRevenue.Controls.Add(dateTimePicker1);
            pnlRevenue.Controls.Add(listViewForRevenue);
            pnlRevenue.Controls.Add(label9);
            pnlRevenue.Location = new System.Drawing.Point(0, 0);
            pnlRevenue.Margin = new Padding(8, 9, 8, 9);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new System.Drawing.Size(2278, 1274);
            pnlRevenue.TabIndex = 17;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(2006, 130);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(206, 53);
            button8.TabIndex = 22;
            button8.Text = "Go Back";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(1408, 454);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(183, 41);
            label14.TabIndex = 12;
            label14.Text = "Customers : ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(1408, 383);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(209, 41);
            label13.TabIndex = 11;
            label13.Text = "Profits Made : ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(1408, 308);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(188, 41);
            label12.TabIndex = 10;
            label12.Text = "Drinks sold : ";
            // 
            // Purchases
            // 
            Purchases.AutoSize = true;
            Purchases.Location = new System.Drawing.Point(1617, 459);
            Purchases.Name = "Purchases";
            Purchases.Size = new System.Drawing.Size(0, 41);
            Purchases.TabIndex = 9;
            // 
            // Profits
            // 
            Profits.AutoSize = true;
            Profits.Location = new System.Drawing.Point(1617, 383);
            Profits.Name = "Profits";
            Profits.Size = new System.Drawing.Size(0, 41);
            Profits.TabIndex = 8;
            // 
            // DrinksSold
            // 
            DrinksSold.AutoSize = true;
            DrinksSold.Location = new System.Drawing.Point(1617, 308);
            DrinksSold.Name = "DrinksSold";
            DrinksSold.Size = new System.Drawing.Size(0, 41);
            DrinksSold.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(601, 383);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(64, 41);
            label11.TabIndex = 6;
            label11.Text = "To :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(599, 255);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(102, 41);
            label10.TabIndex = 5;
            label10.Text = "From :";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(601, 454);
            dateTimePicker2.MaxDate = new DateTime(2024, 3, 27, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(565, 47);
            dateTimePicker2.TabIndex = 4;
            dateTimePicker2.Value = new DateTime(2024, 3, 27, 0, 0, 0, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Location = new System.Drawing.Point(599, 308);
            dateTimePicker1.MaxDate = new DateTime(2024, 3, 27, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(567, 47);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.Value = new DateTime(2024, 3, 1, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // listViewForRevenue
            // 
            listViewForRevenue.Location = new System.Drawing.Point(433, 547);
            listViewForRevenue.Margin = new Padding(8, 9, 8, 9);
            listViewForRevenue.Name = "listViewForRevenue";
            listViewForRevenue.Size = new System.Drawing.Size(1517, 605);
            listViewForRevenue.TabIndex = 1;
            listViewForRevenue.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(56, 94);
            label9.Margin = new Padding(8, 0, 8, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(259, 81);
            label9.TabIndex = 0;
            label9.Text = "Revenue";
            // 
            // pnlDrink
            // 
            pnlDrink.Controls.Add(refreshBtn);
            pnlDrink.Controls.Add(EditDrinkButton);
            pnlDrink.Controls.Add(AddDrinkButton);
            pnlDrink.Controls.Add(DeleteDrinkButton);
            pnlDrink.Controls.Add(listViewDrinks);
            pnlDrink.Controls.Add(label3);
            pnlDrink.Location = new System.Drawing.Point(0, 0);
            pnlDrink.Margin = new Padding(8, 9, 8, 9);
            pnlDrink.Name = "pnlDrink";
            pnlDrink.Size = new System.Drawing.Size(2278, 1274);
            pnlDrink.TabIndex = 4;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new System.Drawing.Point(1955, 889);
            refreshBtn.Margin = new Padding(5);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new System.Drawing.Size(257, 149);
            refreshBtn.TabIndex = 6;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // EditDrinkButton
            // 
            EditDrinkButton.Location = new System.Drawing.Point(1955, 700);
            EditDrinkButton.Margin = new Padding(5);
            EditDrinkButton.Name = "EditDrinkButton";
            EditDrinkButton.Size = new System.Drawing.Size(257, 149);
            EditDrinkButton.TabIndex = 5;
            EditDrinkButton.Text = "Edit Drink";
            EditDrinkButton.UseVisualStyleBackColor = true;
            EditDrinkButton.Click += EditDrinkButton_Click_1;
            // 
            // AddDrinkButton
            // 
            AddDrinkButton.Location = new System.Drawing.Point(1955, 519);
            AddDrinkButton.Margin = new Padding(5);
            AddDrinkButton.Name = "AddDrinkButton";
            AddDrinkButton.Size = new System.Drawing.Size(257, 142);
            AddDrinkButton.TabIndex = 4;
            AddDrinkButton.Text = "Add Drink";
            AddDrinkButton.UseVisualStyleBackColor = true;
            AddDrinkButton.Click += AddDrinkButton_Click_1;
            // 
            // DeleteDrinkButton
            // 
            DeleteDrinkButton.Location = new System.Drawing.Point(1955, 332);
            DeleteDrinkButton.Margin = new Padding(5);
            DeleteDrinkButton.Name = "DeleteDrinkButton";
            DeleteDrinkButton.Size = new System.Drawing.Size(257, 149);
            DeleteDrinkButton.TabIndex = 3;
            DeleteDrinkButton.Text = "Delete Drink";
            DeleteDrinkButton.UseVisualStyleBackColor = true;
            DeleteDrinkButton.Click += DeleteDrinkButton_Click;
            // 
            // listViewDrinks
            // 
            listViewDrinks.Location = new System.Drawing.Point(56, 205);
            listViewDrinks.Margin = new Padding(8, 9, 8, 9);
            listViewDrinks.Name = "listViewDrinks";
            listViewDrinks.Size = new System.Drawing.Size(1854, 833);
            listViewDrinks.TabIndex = 1;
            listViewDrinks.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(56, 94);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(202, 81);
            label3.TabIndex = 0;
            label3.Text = "Drinks";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (System.Drawing.Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new System.Drawing.Point(2309, 1168);
            pictureBox7.Margin = new Padding(8, 9, 8, 9);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new System.Drawing.Size(137, 123);
            pictureBox7.TabIndex = 2;
            pictureBox7.TabStop = false;
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2463, 1331);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            Controls.Add(pictureBox7);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(8, 9, 8, 9);
            Name = "SomerenUI";
            Text = "SomerenApp";
            Load += SomerenUI_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlRoom.ResumeLayout(false);
            pnlRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlOrder.ResumeLayout(false);
            pnlOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityOfDrinks).EndInit();
            pnlActivity.ResumeLayout(false);
            pnlActivity.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            pnlLecturer.ResumeLayout(false);
            pnlLecturer.PerformLayout();
            pnlVat.ResumeLayout(false);
            pnlVat.PerformLayout();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            pnlDrink.ResumeLayout(false);
            pnlDrink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem lecturersToolStripMenuItem;
        private ToolStripMenuItem activitiesToolStripMenuItem;
        private ToolStripMenuItem roomsToolStripMenuItem;
        private Panel pnlDashboard;
        private Label lblDashboard;
        private Panel pnlStudents;
        private ListView listViewStudents;
        private Label label1;
        private Panel pnlLecturer;
        private ListView listViewLecturers;
        private Label label2;
        private Panel pnlRoom;
        private Label label6;
        private Panel pnlActivity;
        private ListView listViewActivities;
        private Label label4;
        private ToolStripMenuItem drinksToolStripMenuItem;
        private ToolStripMenuItem toolStripDrinksItem;
        private PictureBox pictureBox1;
        private ListView listViewRooms;
        private Panel pnlRevenue;
        private PictureBox pictureBox7;
        private ListView listViewForRevenue;
        private Label label9;
        private Label Purchases;
        private Label Profits;
        private Label DrinksSold;
        private Label label11;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private Label label13;
        private Label label12;
        private Panel pnlOrder;
        private NumericUpDown QuantityOfDrinks;
        private Button buttonOrder;
        private ListBox listBoxStudentOrders;
        private ListBox listBoxDrinksOrders;
        private Label label7;
        private Label PriceOutput;
        private Label label8;
        private Panel pnlDrink;
        private ListView listViewDrinks;
        private Label label3;
        private Button EditDrinkButton;
        private Button AddDrinkButton;
        private Button DeleteDrinkButton;
        private Button refreshBtn;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Panel pnlVat;
        private Label label15;
        private DateTimePicker dateTimePicker3;
        private Label yearOnlySelect;
        private Label label17;
        private Label label16;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label24;
        private Label label25;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label14;
        private Button button6;
        private Button button5;
        private Button button7;
        private Button button8;
    }
}