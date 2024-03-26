namespace SomerenUI
{
    partial class AddDrinkForm
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
            labelName = new System.Windows.Forms.Label();
            labelID = new System.Windows.Forms.Label();
            labelPrice = new System.Windows.Forms.Label();
            labelType = new System.Windows.Forms.Label();
            labelStock = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            textBoxID = new System.Windows.Forms.TextBox();
            textBoxPrice = new System.Windows.Forms.TextBox();
            textBoxStock = new System.Windows.Forms.TextBox();
            comboBoxType = new System.Windows.Forms.ComboBox();
            AddDrinkbutton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new System.Drawing.Point(47, 37);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(62, 24);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new System.Drawing.Point(47, 89);
            labelID.Name = "labelID";
            labelID.Size = new System.Drawing.Size(29, 24);
            labelID.TabIndex = 1;
            labelID.Text = "ID";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new System.Drawing.Point(47, 149);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new System.Drawing.Size(52, 24);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Price";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new System.Drawing.Point(46, 202);
            labelType.Name = "labelType";
            labelType.Size = new System.Drawing.Size(52, 24);
            labelType.TabIndex = 3;
            labelType.Text = "Type";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Location = new System.Drawing.Point(47, 251);
            labelStock.Name = "labelStock";
            labelStock.Size = new System.Drawing.Size(57, 24);
            labelStock.TabIndex = 4;
            labelStock.Text = "Stock";
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(220, 37);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(150, 30);
            textBoxName.TabIndex = 5;
            // 
            // textBoxID
            // 
            textBoxID.Location = new System.Drawing.Point(220, 89);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new System.Drawing.Size(150, 30);
            textBoxID.TabIndex = 6;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new System.Drawing.Point(220, 146);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(150, 30);
            textBoxPrice.TabIndex = 7;
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new System.Drawing.Point(220, 248);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new System.Drawing.Size(150, 30);
            textBoxStock.TabIndex = 8;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new System.Drawing.Point(220, 199);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new System.Drawing.Size(150, 32);
            comboBoxType.TabIndex = 9;
            // 
            // AddDrinkbutton
            // 
            AddDrinkbutton.Location = new System.Drawing.Point(134, 298);
            AddDrinkbutton.Name = "AddDrinkbutton";
            AddDrinkbutton.Size = new System.Drawing.Size(166, 66);
            AddDrinkbutton.TabIndex = 10;
            AddDrinkbutton.Text = "Submit";
            AddDrinkbutton.UseVisualStyleBackColor = true;
            AddDrinkbutton.Click += AddDrinkbutton_Click;
            // 
            // AddDrinkForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(479, 376);
            Controls.Add(AddDrinkbutton);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxStock);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxID);
            Controls.Add(textBoxName);
            Controls.Add(labelStock);
            Controls.Add(labelType);
            Controls.Add(labelPrice);
            Controls.Add(labelID);
            Controls.Add(labelName);
            Name = "AddDrinkForm";
            Text = "AddDrinkForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button AddDrinkbutton;
    }
}