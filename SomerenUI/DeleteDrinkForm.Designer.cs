﻿namespace SomerenUI
{
    partial class DeleteDrinkForm
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
            comboBoxDrinks = new System.Windows.Forms.ComboBox();
            buttonDeleteDrink = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // comboBoxDrinks
            // 
            comboBoxDrinks.FormattingEnabled = true;
            comboBoxDrinks.Location = new System.Drawing.Point(49, 65);
            comboBoxDrinks.Name = "comboBoxDrinks";
            comboBoxDrinks.Size = new System.Drawing.Size(390, 32);
            comboBoxDrinks.TabIndex = 0;
            // 
            // buttonDeleteDrink
            // 
            buttonDeleteDrink.Location = new System.Drawing.Point(107, 139);
            buttonDeleteDrink.Name = "buttonDeleteDrink";
            buttonDeleteDrink.Size = new System.Drawing.Size(270, 59);
            buttonDeleteDrink.TabIndex = 1;
            buttonDeleteDrink.Text = "Delete";
            buttonDeleteDrink.UseVisualStyleBackColor = true;
            buttonDeleteDrink.Click += buttonDeleteDrink_Click;
            // 
            // DeleteDrinkForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(491, 252);
            Controls.Add(buttonDeleteDrink);
            Controls.Add(comboBoxDrinks);
            Name = "DeleteDrinkForm";
            Text = "DeleteDrinkForm";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDrinks;
        private System.Windows.Forms.Button buttonDeleteDrink;
    }
}