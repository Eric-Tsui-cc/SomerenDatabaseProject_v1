namespace SomerenUI
{
    partial class SuperviseForm
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
            listViewActivities = new System.Windows.Forms.ListView();
            listViewTeacherin = new System.Windows.Forms.ListView();
            listViewTeacherout = new System.Windows.Forms.ListView();
            buttonRemoveSupervisor = new System.Windows.Forms.Button();
            buttonAddSupervisor = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(79, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 24);
            label1.TabIndex = 0;
            label1.Text = "Activities";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(79, 309);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(281, 24);
            label2.TabIndex = 1;
            label2.Text = "Teachers in supervise (select ID)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(432, 309);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(294, 24);
            label3.TabIndex = 2;
            label3.Text = "Teachers out supervise (select ID)";
            // 
            // listViewActivities
            // 
            listViewActivities.Location = new System.Drawing.Point(79, 102);
            listViewActivities.Name = "listViewActivities";
            listViewActivities.Size = new System.Drawing.Size(478, 182);
            listViewActivities.TabIndex = 3;
            listViewActivities.UseCompatibleStateImageBehavior = false;
            listViewActivities.SelectedIndexChanged += listViewActivities_SelectedIndexChanged;
            // 
            // listViewTeacherin
            // 
            listViewTeacherin.Location = new System.Drawing.Point(79, 353);
            listViewTeacherin.Name = "listViewTeacherin";
            listViewTeacherin.Size = new System.Drawing.Size(299, 134);
            listViewTeacherin.TabIndex = 4;
            listViewTeacherin.UseCompatibleStateImageBehavior = false;
            // 
            // listViewTeacherout
            // 
            listViewTeacherout.Location = new System.Drawing.Point(432, 353);
            listViewTeacherout.Name = "listViewTeacherout";
            listViewTeacherout.Size = new System.Drawing.Size(299, 134);
            listViewTeacherout.TabIndex = 5;
            listViewTeacherout.UseCompatibleStateImageBehavior = false;
            // 
            // buttonRemoveSupervisor
            // 
            buttonRemoveSupervisor.Location = new System.Drawing.Point(143, 507);
            buttonRemoveSupervisor.Name = "buttonRemoveSupervisor";
            buttonRemoveSupervisor.Size = new System.Drawing.Size(170, 51);
            buttonRemoveSupervisor.TabIndex = 6;
            buttonRemoveSupervisor.Text = "Remove";
            buttonRemoveSupervisor.UseVisualStyleBackColor = true;
            buttonRemoveSupervisor.Click += button1_Click;
            // 
            // buttonAddSupervisor
            // 
            buttonAddSupervisor.Location = new System.Drawing.Point(498, 507);
            buttonAddSupervisor.Name = "buttonAddSupervisor";
            buttonAddSupervisor.Size = new System.Drawing.Size(170, 51);
            buttonAddSupervisor.TabIndex = 7;
            buttonAddSupervisor.Text = "Add";
            buttonAddSupervisor.UseVisualStyleBackColor = true;
            buttonAddSupervisor.Click += button2_Click;
            // 
            // SuperviseForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 583);
            Controls.Add(buttonAddSupervisor);
            Controls.Add(buttonRemoveSupervisor);
            Controls.Add(listViewTeacherout);
            Controls.Add(listViewTeacherin);
            Controls.Add(listViewActivities);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SuperviseForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.ListView listViewTeacherin;
        private System.Windows.Forms.ListView listViewTeacherout;
        private System.Windows.Forms.Button buttonRemoveSupervisor;
        private System.Windows.Forms.Button buttonAddSupervisor;
    }
}