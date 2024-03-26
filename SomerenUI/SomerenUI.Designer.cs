﻿using System.Windows.Forms;
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripDrinksItem = new System.Windows.Forms.ToolStripMenuItem();
            drinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            pnlRoom = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            listViewRooms = new System.Windows.Forms.ListView();
            label6 = new System.Windows.Forms.Label();
            pnlRevenue = new System.Windows.Forms.Panel();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            Purchases = new System.Windows.Forms.Label();
            Profits = new System.Windows.Forms.Label();
            DrinksSold = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            listViewForRevenue = new System.Windows.Forms.ListView();
            label9 = new System.Windows.Forms.Label();
            lblDashboard = new System.Windows.Forms.Label();
            pnlDrink = new System.Windows.Forms.Panel();
            refreshBtn = new System.Windows.Forms.Button();
            EditDrinkButton = new System.Windows.Forms.Button();
            AddDrinkButton = new System.Windows.Forms.Button();
            DeleteDrinkButton = new System.Windows.Forms.Button();
            listViewDrinks = new System.Windows.Forms.ListView();
            label3 = new System.Windows.Forms.Label();
            pnlOrder = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            QuantityOfDrinks = new System.Windows.Forms.NumericUpDown();
            buttonOrder = new System.Windows.Forms.Button();
            listBoxStudentOrders = new System.Windows.Forms.ListBox();
            listBoxDrinksOrders = new System.Windows.Forms.ListBox();
            label7 = new System.Windows.Forms.Label();
            PriceOutput = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            pnlActivity = new System.Windows.Forms.Panel();
            listViewActivities = new System.Windows.Forms.ListView();
            label4 = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            listViewStudents = new System.Windows.Forms.ListView();
            label1 = new System.Windows.Forms.Label();
            pnlLecturer = new System.Windows.Forms.Panel();
            listViewLecturers = new System.Windows.Forms.ListView();
            label2 = new System.Windows.Forms.Label();
            pictureBox7 = new System.Windows.Forms.PictureBox();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlRevenue.SuspendLayout();
            pnlDrink.SuspendLayout();
            pnlOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityOfDrinks).BeginInit();
            pnlActivity.SuspendLayout();
            pnlStudents.SuspendLayout();
            pnlLecturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, toolStripDrinksItem, drinksToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(14, 5, 0, 5);
            menuStrip1.Size = new System.Drawing.Size(2463, 55);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
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
            drinksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { orderToolStripMenuItem, revenueToolStripMenuItem });
            drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            drinksToolStripMenuItem.Size = new System.Drawing.Size(169, 45);
            drinksToolStripMenuItem.Text = "Financials";
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new System.Drawing.Size(297, 54);
            orderToolStripMenuItem.Text = "Order";
            orderToolStripMenuItem.Click += orderToolStripMenuItem_Click;
            // 
            // revenueToolStripMenuItem
            // 
            revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            revenueToolStripMenuItem.Size = new System.Drawing.Size(297, 54);
            revenueToolStripMenuItem.Text = "Revenue";
            revenueToolStripMenuItem.Click += revenueToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(pnlRoom);
            pnlDashboard.Controls.Add(pnlRevenue);
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Controls.Add(pnlDrink);
            pnlDashboard.Controls.Add(pnlOrder);
            pnlDashboard.Controls.Add(pnlActivity);
            pnlDashboard.Controls.Add(pnlStudents);
            pnlDashboard.Controls.Add(pnlLecturer);
            pnlDashboard.Location = new System.Drawing.Point(0, 0);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(2278, 1274);
            pnlDashboard.TabIndex = 1;
            // 
            // pnlRoom
            // 
            pnlRoom.Controls.Add(pictureBox1);
            pnlRoom.Controls.Add(listViewRooms);
            pnlRoom.Controls.Add(label6);
            pnlRoom.Dock = System.Windows.Forms.DockStyle.Top;
            pnlRoom.Location = new System.Drawing.Point(0, 1274);
            pnlRoom.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            pnlRoom.Name = "pnlRoom";
            pnlRoom.Size = new System.Drawing.Size(2278, 1274);
            pnlRoom.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(2096, 193);
            pictureBox1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(235, 275);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.Location = new System.Drawing.Point(56, 205);
            listViewRooms.Margin = new System.Windows.Forms.Padding(5);
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
            label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(216, 81);
            label6.TabIndex = 0;
            label6.Text = "Rooms";
            // 
            // pnlRevenue
            // 
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
            pnlRevenue.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new System.Drawing.Size(2278, 1274);
            pnlRevenue.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(1408, 459);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(249, 41);
            label14.TabIndex = 12;
            label14.Text = "Purchases Made :";
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
            Purchases.Location = new System.Drawing.Point(1663, 459);
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
            DrinksSold.Location = new System.Drawing.Point(1602, 308);
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(599, 308);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(567, 47);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // listViewForRevenue
            // 
            listViewForRevenue.Location = new System.Drawing.Point(433, 547);
            listViewForRevenue.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
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
            label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(259, 81);
            label9.TabIndex = 0;
            label9.Text = "Revenue";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(39, 72);
            lblDashboard.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(523, 41);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
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
            pnlDrink.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            pnlDrink.Name = "pnlDrink";
            pnlDrink.Size = new System.Drawing.Size(2278, 1274);
            pnlDrink.TabIndex = 4;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new System.Drawing.Point(1955, 889);
            refreshBtn.Margin = new System.Windows.Forms.Padding(5);
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
            EditDrinkButton.Margin = new System.Windows.Forms.Padding(5);
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
            AddDrinkButton.Margin = new System.Windows.Forms.Padding(5);
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
            DeleteDrinkButton.Margin = new System.Windows.Forms.Padding(5);
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
            listViewDrinks.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
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
            label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(202, 81);
            label3.TabIndex = 0;
            label3.Text = "Drinks";
            // 
            // pnlOrder
            // 
            pnlOrder.Controls.Add(label5);
            pnlOrder.Controls.Add(QuantityOfDrinks);
            pnlOrder.Controls.Add(buttonOrder);
            pnlOrder.Controls.Add(listBoxStudentOrders);
            pnlOrder.Controls.Add(listBoxDrinksOrders);
            pnlOrder.Controls.Add(label7);
            pnlOrder.Controls.Add(PriceOutput);
            pnlOrder.Controls.Add(label8);
            pnlOrder.Dock = System.Windows.Forms.DockStyle.Top;
            pnlOrder.Location = new System.Drawing.Point(0, 0);
            pnlOrder.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            pnlOrder.Name = "pnlOrder";
            pnlOrder.Size = new System.Drawing.Size(2278, 1274);
            pnlOrder.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(1799, 897);
            label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(105, 41);
            label5.TabIndex = 8;
            label5.Text = "Price : ";
            // 
            // QuantityOfDrinks
            // 
            QuantityOfDrinks.Location = new System.Drawing.Point(1800, 803);
            QuantityOfDrinks.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            QuantityOfDrinks.Name = "QuantityOfDrinks";
            QuantityOfDrinks.Size = new System.Drawing.Size(397, 47);
            QuantityOfDrinks.TabIndex = 3;
            QuantityOfDrinks.ValueChanged += QuantityOfDrinks_ValueChanged;
            // 
            // buttonOrder
            // 
            buttonOrder.Location = new System.Drawing.Point(1800, 998);
            buttonOrder.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
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
            listBoxStudentOrders.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
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
            listBoxDrinksOrders.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
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
            label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(213, 81);
            label7.TabIndex = 0;
            label7.Text = "Orders";
            // 
            // PriceOutput
            // 
            PriceOutput.AutoSize = true;
            PriceOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PriceOutput.Location = new System.Drawing.Point(1907, 898);
            PriceOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
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
            label8.Location = new System.Drawing.Point(1792, 728);
            label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
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
            pnlActivity.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            pnlActivity.Name = "pnlActivity";
            pnlActivity.Size = new System.Drawing.Size(2278, 1274);
            pnlActivity.TabIndex = 3;
            // 
            // listViewActivities
            // 
            listViewActivities.Location = new System.Drawing.Point(56, 205);
            listViewActivities.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
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
            label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
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
            pnlStudents.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(2278, 1274);
            pnlStudents.TabIndex = 2;
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new System.Drawing.Point(56, 205);
            listViewStudents.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
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
            label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
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
            pnlLecturer.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            pnlLecturer.Name = "pnlLecturer";
            pnlLecturer.Size = new System.Drawing.Size(2278, 1274);
            pnlLecturer.TabIndex = 3;
            // 
            // listViewLecturers
            // 
            listViewLecturers.Location = new System.Drawing.Point(56, 205);
            listViewLecturers.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
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
            label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(274, 81);
            label2.TabIndex = 0;
            label2.Text = "Lecturers";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (System.Drawing.Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new System.Drawing.Point(2309, 1168);
            pictureBox7.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new System.Drawing.Size(137, 123);
            pictureBox7.TabIndex = 2;
            pictureBox7.TabStop = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(601, 454);
            dateTimePicker2.MaxDate = DateTime.Today;
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(565, 47);
            dateTimePicker2.TabIndex = 4;
            dateTimePicker2.Value = new System.DateTime(2024, 3, 26, 0, 0, 0, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2463, 1331);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            Controls.Add(pictureBox7);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
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
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            pnlDrink.ResumeLayout(false);
            pnlDrink.PerformLayout();
            pnlOrder.ResumeLayout(false);
            pnlOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityOfDrinks).EndInit();
            pnlActivity.ResumeLayout(false);
            pnlActivity.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            pnlLecturer.ResumeLayout(false);
            pnlLecturer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLecturer;
        private System.Windows.Forms.ListView listViewLecturers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlActivity;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem drinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripDrinksItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ListView listViewForRevenue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Purchases;
        private System.Windows.Forms.Label Profits;
        private System.Windows.Forms.Label DrinksSold;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.NumericUpDown QuantityOfDrinks;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.ListBox listBoxStudentOrders;
        private System.Windows.Forms.ListBox listBoxDrinksOrders;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PriceOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlDrink;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EditDrinkButton;
        private System.Windows.Forms.Button AddDrinkButton;
        private System.Windows.Forms.Button DeleteDrinkButton;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}