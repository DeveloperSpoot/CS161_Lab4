namespace CS161_Lab4.Problems
{
    partial class Restaurant_Selector
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
            groupBox1 = new GroupBox();
            glutenCheckBox = new CheckBox();
            veganCheckBox = new CheckBox();
            vegetarianCheckBox = new CheckBox();
            groupBox2 = new GroupBox();
            restaruantsListBox = new ListBox();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(glutenCheckBox);
            groupBox1.Controls.Add(veganCheckBox);
            groupBox1.Controls.Add(vegetarianCheckBox);
            groupBox1.Location = new Point(8, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(129, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Restrictions";
            // 
            // glutenCheckBox
            // 
            glutenCheckBox.AutoSize = true;
            glutenCheckBox.Location = new Point(9, 80);
            glutenCheckBox.Name = "glutenCheckBox";
            glutenCheckBox.Size = new Size(88, 19);
            glutenCheckBox.TabIndex = 2;
            glutenCheckBox.Text = "Gluten-Free";
            glutenCheckBox.UseVisualStyleBackColor = true;
            glutenCheckBox.CheckedChanged += glutenCheckBox_CheckedChanged;
            // 
            // veganCheckBox
            // 
            veganCheckBox.AutoSize = true;
            veganCheckBox.Location = new Point(9, 52);
            veganCheckBox.Name = "veganCheckBox";
            veganCheckBox.Size = new Size(58, 19);
            veganCheckBox.TabIndex = 1;
            veganCheckBox.Text = "Vegan";
            veganCheckBox.UseVisualStyleBackColor = true;
            veganCheckBox.CheckedChanged += veganCheckBox_CheckedChanged;
            // 
            // vegetarianCheckBox
            // 
            vegetarianCheckBox.AutoSize = true;
            vegetarianCheckBox.Location = new Point(9, 25);
            vegetarianCheckBox.Name = "vegetarianCheckBox";
            vegetarianCheckBox.Size = new Size(75, 19);
            vegetarianCheckBox.TabIndex = 0;
            vegetarianCheckBox.Text = "Vegetarin";
            vegetarianCheckBox.UseVisualStyleBackColor = true;
            vegetarianCheckBox.CheckedChanged += vegetarianCheckBox_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(restaruantsListBox);
            groupBox2.Location = new Point(153, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(297, 110);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Restaurants";
            // 
            // restaruantsListBox
            // 
            restaruantsListBox.FormattingEnabled = true;
            restaruantsListBox.ItemHeight = 15;
            restaruantsListBox.Items.AddRange(new object[] { "Joe's Gourmet Burgers", "Main Street Pizza Company", "Corner Cafe", "Mama's Fine Italian", "The Chef's kitchen" });
            restaruantsListBox.Location = new Point(7, 19);
            restaruantsListBox.Name = "restaruantsListBox";
            restaruantsListBox.Size = new Size(284, 79);
            restaruantsListBox.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.IndianRed;
            exitButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.ForeColor = SystemColors.Control;
            exitButton.Location = new Point(9, 127);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(441, 28);
            exitButton.TabIndex = 2;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Restaurant_Selector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 164);
            Controls.Add(exitButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Restaurant_Selector";
            Text = "Restaurant_Selector";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox glutenCheckBox;
        private CheckBox veganCheckBox;
        private CheckBox vegetarianCheckBox;
        private GroupBox groupBox2;
        private ListBox restaruantsListBox;
        private Button exitButton;
    }
}