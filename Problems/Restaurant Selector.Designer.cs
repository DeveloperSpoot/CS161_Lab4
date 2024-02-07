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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.glutenCheckBox = new System.Windows.Forms.CheckBox();
            this.veganCheckBox = new System.Windows.Forms.CheckBox();
            this.vegetarianCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.restaruantsListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.glutenCheckBox);
            this.groupBox1.Controls.Add(this.veganCheckBox);
            this.groupBox1.Controls.Add(this.vegetarianCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(147, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restrictions";
            // 
            // glutenCheckBox
            // 
            this.glutenCheckBox.AutoSize = true;
            this.glutenCheckBox.Location = new System.Drawing.Point(10, 101);
            this.glutenCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.glutenCheckBox.Name = "glutenCheckBox";
            this.glutenCheckBox.Size = new System.Drawing.Size(101, 23);
            this.glutenCheckBox.TabIndex = 2;
            this.glutenCheckBox.Text = "Gluten-Free";
            this.glutenCheckBox.UseVisualStyleBackColor = true;
            this.glutenCheckBox.CheckedChanged += new System.EventHandler(this.retrieveCompatiableResturants);
            this.glutenCheckBox.CheckStateChanged += new System.EventHandler(this.retrieveCompatiableResturants);
            // 
            // veganCheckBox
            // 
            this.veganCheckBox.AutoSize = true;
            this.veganCheckBox.Location = new System.Drawing.Point(10, 66);
            this.veganCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.veganCheckBox.Name = "veganCheckBox";
            this.veganCheckBox.Size = new System.Drawing.Size(66, 23);
            this.veganCheckBox.TabIndex = 1;
            this.veganCheckBox.Text = "Vegan";
            this.veganCheckBox.UseVisualStyleBackColor = true;
            this.veganCheckBox.CheckedChanged += new System.EventHandler(this.retrieveCompatiableResturants);
            this.veganCheckBox.CheckStateChanged += new System.EventHandler(this.retrieveCompatiableResturants);
            // 
            // vegetarianCheckBox
            // 
            this.vegetarianCheckBox.AutoSize = true;
            this.vegetarianCheckBox.Location = new System.Drawing.Point(10, 32);
            this.vegetarianCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vegetarianCheckBox.Name = "vegetarianCheckBox";
            this.vegetarianCheckBox.Size = new System.Drawing.Size(86, 23);
            this.vegetarianCheckBox.TabIndex = 0;
            this.vegetarianCheckBox.Text = "Vegetarin";
            this.vegetarianCheckBox.UseVisualStyleBackColor = true;
            this.vegetarianCheckBox.CheckedChanged += new System.EventHandler(this.retrieveCompatiableResturants);
            this.vegetarianCheckBox.CheckStateChanged += new System.EventHandler(this.retrieveCompatiableResturants);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.restaruantsListBox);
            this.groupBox2.Location = new System.Drawing.Point(175, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(339, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restaurants";
            // 
            // restaruantsListBox
            // 
            this.restaruantsListBox.FormattingEnabled = true;
            this.restaruantsListBox.ItemHeight = 19;
            this.restaruantsListBox.Items.AddRange(new object[] {
            "Joe\'s Gourmet Burgers",
            "Main Street Pizza Company",
            "Corner Cafe",
            "Mama\'s Fine Italian",
            "The Chef\'s kitchen"});
            this.restaruantsListBox.Location = new System.Drawing.Point(8, 24);
            this.restaruantsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.restaruantsListBox.Name = "restaruantsListBox";
            this.restaruantsListBox.Size = new System.Drawing.Size(324, 99);
            this.restaruantsListBox.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.IndianRed;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(10, 161);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(504, 35);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Restaurant_Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 208);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Restaurant_Selector";
            this.Text = "Restaurant_Selector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

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