namespace SomerenUI
{
    partial class UpdateStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            comboBoxStudents = new System.Windows.Forms.ComboBox();
            textBoxFirstName = new System.Windows.Forms.TextBox();
            textBoxLastName = new System.Windows.Forms.TextBox();
            textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            textBoxClass = new System.Windows.Forms.TextBox();
            textBoxRoomNumber = new System.Windows.Forms.TextBox();
            buttonUpdate = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(47, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(155, 24);
            label1.TabIndex = 0;
            label1.Text = "Student Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(47, 89);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(104, 24);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(50, 148);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(101, 24);
            label4.TabIndex = 3;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(50, 205);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(141, 24);
            label5.TabIndex = 4;
            label5.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(50, 266);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(53, 24);
            label6.TabIndex = 5;
            label6.Text = "Class";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(47, 327);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(138, 24);
            label7.TabIndex = 6;
            label7.Text = "Room Number";
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.Location = new System.Drawing.Point(266, 20);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new System.Drawing.Size(150, 32);
            comboBoxStudents.TabIndex = 7;
            comboBoxStudents.SelectedIndexChanged += comboBoxStudents_SelectedIndexChanged;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new System.Drawing.Point(266, 83);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new System.Drawing.Size(150, 30);
            textBoxFirstName.TabIndex = 9;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new System.Drawing.Point(266, 148);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new System.Drawing.Size(150, 30);
            textBoxLastName.TabIndex = 10;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new System.Drawing.Point(266, 205);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new System.Drawing.Size(150, 30);
            textBoxPhoneNumber.TabIndex = 11;
            // 
            // textBoxClass
            // 
            textBoxClass.Location = new System.Drawing.Point(266, 260);
            textBoxClass.Name = "textBoxClass";
            textBoxClass.Size = new System.Drawing.Size(150, 30);
            textBoxClass.TabIndex = 12;
            // 
            // textBoxRoomNumber
            // 
            textBoxRoomNumber.Location = new System.Drawing.Point(266, 321);
            textBoxRoomNumber.Name = "textBoxRoomNumber";
            textBoxRoomNumber.Size = new System.Drawing.Size(150, 30);
            textBoxRoomNumber.TabIndex = 13;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new System.Drawing.Point(165, 388);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(149, 65);
            buttonUpdate.TabIndex = 14;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // UpdateStudentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(479, 484);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxRoomNumber);
            Controls.Add(textBoxClass);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(comboBoxStudents);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "UpdateStudentForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.Button buttonUpdate;
    }
}