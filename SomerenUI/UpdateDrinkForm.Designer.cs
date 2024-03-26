namespace SomerenUI
{
    partial class UpdateDrinkForm
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
            UpdateButton = new System.Windows.Forms.Button();
            comBoxDrinkName = new System.Windows.Forms.ComboBox();
            textBoxNewName = new System.Windows.Forms.TextBox();
            textBoxStock = new System.Windows.Forms.TextBox();
            comboBoxType = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            textBoxPrice = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(53, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 24);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(53, 86);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(106, 24);
            label2.TabIndex = 1;
            label2.Text = "New Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(53, 139);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 24);
            label3.TabIndex = 2;
            label3.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(53, 193);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 24);
            label4.TabIndex = 3;
            label4.Text = "Stock";
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new System.Drawing.Point(95, 280);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new System.Drawing.Size(148, 61);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // comBoxDrinkName
            // 
            comBoxDrinkName.FormattingEnabled = true;
            comBoxDrinkName.Location = new System.Drawing.Point(210, 31);
            comBoxDrinkName.Name = "comBoxDrinkName";
            comBoxDrinkName.Size = new System.Drawing.Size(135, 32);
            comBoxDrinkName.TabIndex = 5;
            comBoxDrinkName.SelectedIndexChanged += comBoxDrinkID_SelectedIndexChanged;
            // 
            // textBoxNewName
            // 
            textBoxNewName.Location = new System.Drawing.Point(210, 86);
            textBoxNewName.Name = "textBoxNewName";
            textBoxNewName.Size = new System.Drawing.Size(135, 30);
            textBoxNewName.TabIndex = 6;
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new System.Drawing.Point(210, 193);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new System.Drawing.Size(135, 30);
            textBoxStock.TabIndex = 8;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new System.Drawing.Point(210, 139);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new System.Drawing.Size(135, 32);
            comboBoxType.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(53, 239);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 24);
            label5.TabIndex = 10;
            label5.Text = "Price";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new System.Drawing.Point(210, 244);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(135, 30);
            textBoxPrice.TabIndex = 11;
            // 
            // UpdateDrinkForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(379, 366);
            Controls.Add(textBoxPrice);
            Controls.Add(label5);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxStock);
            Controls.Add(textBoxNewName);
            Controls.Add(comBoxDrinkName);
            Controls.Add(UpdateButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateDrinkForm";
            Text = "UpdateDrinkForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ComboBox comBoxDrinkName;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrice;
    }
}