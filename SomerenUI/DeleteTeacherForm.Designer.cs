namespace SomerenUI
{
    partial class DeleteTeacherForm
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
            comboBoxTeachers = new System.Windows.Forms.ComboBox();
            buttonDeleteTeacher = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(67, 92);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 24);
            label1.TabIndex = 0;
            label1.Text = "Lectuer ID";
            // 
            // comboBoxTeachers
            // 
            comboBoxTeachers.FormattingEnabled = true;
            comboBoxTeachers.Location = new System.Drawing.Point(243, 92);
            comboBoxTeachers.Name = "comboBoxTeachers";
            comboBoxTeachers.Size = new System.Drawing.Size(182, 32);
            comboBoxTeachers.TabIndex = 1;
            // 
            // buttonDeleteTeacher
            // 
            buttonDeleteTeacher.Location = new System.Drawing.Point(156, 177);
            buttonDeleteTeacher.Name = "buttonDeleteTeacher";
            buttonDeleteTeacher.Size = new System.Drawing.Size(143, 56);
            buttonDeleteTeacher.TabIndex = 2;
            buttonDeleteTeacher.Text = "Submit";
            buttonDeleteTeacher.UseVisualStyleBackColor = true;
            buttonDeleteTeacher.Click += button1_Click;
            // 
            // DeleteTeacherForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(464, 272);
            Controls.Add(buttonDeleteTeacher);
            Controls.Add(comboBoxTeachers);
            Controls.Add(label1);
            Name = "DeleteTeacherForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTeachers;
        private System.Windows.Forms.Button buttonDeleteTeacher;
    }
}