namespace SomerenUI
{
    partial class UpdateTeacherForm
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
            System.Windows.Forms.Label label1;
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(54, 59);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 24);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(54, 117);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 24);
            label2.TabIndex = 1;
            label2.Text = "firstName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(54, 175);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 24);
            label3.TabIndex = 2;
            label3.Text = "last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(54, 243);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 24);
            label4.TabIndex = 3;
            label4.Text = "phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(54, 307);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(42, 24);
            label5.TabIndex = 4;
            label5.Text = "age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(54, 373);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(129, 24);
            label6.TabIndex = 5;
            label6.Text = "room number";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(173, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(151, 32);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(173, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(150, 30);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(173, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(150, 30);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(174, 243);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(150, 30);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(174, 307);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(150, 30);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(173, 373);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(150, 30);
            textBox5.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(109, 448);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(164, 60);
            button1.TabIndex = 12;
            button1.Text = "submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UpdateTeacherForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(402, 549);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateTeacherForm";
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
    }
}