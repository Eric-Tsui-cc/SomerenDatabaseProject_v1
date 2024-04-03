namespace SomerenUI
{
    partial class AddStudentForm
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
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            textBoxNumber = new System.Windows.Forms.TextBox();
            textBoxFristName = new System.Windows.Forms.TextBox();
            textBoxLastName = new System.Windows.Forms.TextBox();
            textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            textBoxClass = new System.Windows.Forms.TextBox();
            textBoxRoomNumber = new System.Windows.Forms.TextBox();
            buttonAddStudent = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(45, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(155, 24);
            label1.TabIndex = 0;
            label1.Text = "Student Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(45, 108);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 24);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(45, 174);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(101, 24);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(45, 236);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(173, 24);
            label4.TabIndex = 3;
            label4.Text = "Telephone number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(45, 287);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 24);
            label5.TabIndex = 4;
            label5.Text = "Class";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(45, 339);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(138, 24);
            label6.TabIndex = 5;
            label6.Text = "Room Number";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new System.Drawing.Point(243, 33);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new System.Drawing.Size(150, 30);
            textBoxNumber.TabIndex = 6;
            // 
            // textBoxFristName
            // 
            textBoxFristName.Location = new System.Drawing.Point(243, 102);
            textBoxFristName.Name = "textBoxFristName";
            textBoxFristName.Size = new System.Drawing.Size(150, 30);
            textBoxFristName.TabIndex = 7;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new System.Drawing.Point(243, 168);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new System.Drawing.Size(150, 30);
            textBoxLastName.TabIndex = 8;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new System.Drawing.Point(243, 230);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new System.Drawing.Size(150, 30);
            textBoxPhoneNumber.TabIndex = 9;
            // 
            // textBoxClass
            // 
            textBoxClass.Location = new System.Drawing.Point(243, 281);
            textBoxClass.Name = "textBoxClass";
            textBoxClass.Size = new System.Drawing.Size(150, 30);
            textBoxClass.TabIndex = 10;
            // 
            // textBoxRoomNumber
            // 
            textBoxRoomNumber.Location = new System.Drawing.Point(243, 333);
            textBoxRoomNumber.Name = "textBoxRoomNumber";
            textBoxRoomNumber.Size = new System.Drawing.Size(150, 30);
            textBoxRoomNumber.TabIndex = 11;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Location = new System.Drawing.Point(134, 387);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new System.Drawing.Size(163, 49);
            buttonAddStudent.TabIndex = 12;
            buttonAddStudent.Text = "Submit";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(423, 448);
            Controls.Add(buttonAddStudent);
            Controls.Add(textBoxRoomNumber);
            Controls.Add(textBoxClass);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFristName);
            Controls.Add(textBoxNumber);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddStudentForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxFristName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.Button buttonAddStudent;
    }
}