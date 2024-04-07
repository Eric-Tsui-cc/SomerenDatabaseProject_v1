namespace SomerenUI
{
    partial class AddLecturerForm
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
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(54, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 24);
            label1.TabIndex = 0;
            label1.Text = "Lecturer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(54, 107);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 24);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(54, 160);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(101, 24);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(54, 212);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 24);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(54, 263);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 24);
            label5.TabIndex = 4;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(54, 320);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(138, 24);
            label6.TabIndex = 5;
            label6.Text = "Room Number";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(189, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(150, 30);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(189, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(150, 30);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(189, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(150, 30);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(189, 212);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(150, 30);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(189, 263);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(150, 30);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(189, 317);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(150, 30);
            textBox6.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(95, 387);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(192, 65);
            button1.TabIndex = 12;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddLecturerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(414, 502);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddLecturerForm";
            Text = "AddLecturerForm";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
    }
}