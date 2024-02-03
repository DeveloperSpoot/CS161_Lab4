namespace CS161_Lab4.Problems
{
    partial class Workshop
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
            workShopListBox = new ListBox();
            groupBox2 = new GroupBox();
            locationListBox = new ListBox();
            button1 = new Button();
            button2 = new Button();
            groupBox3 = new GroupBox();
            registerationLabel = new Label();
            groupBox4 = new GroupBox();
            lodgingLabel = new Label();
            groupBox5 = new GroupBox();
            totalLabel = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(workShopListBox);
            groupBox1.Location = new Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 160);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Workshops";
            // 
            // workShopListBox
            // 
            workShopListBox.FormattingEnabled = true;
            workShopListBox.ItemHeight = 15;
            workShopListBox.Items.AddRange(new object[] { "Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview" });
            workShopListBox.Location = new Point(8, 25);
            workShopListBox.Name = "workShopListBox";
            workShopListBox.Size = new Size(247, 124);
            workShopListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(locationListBox);
            groupBox2.Location = new Point(288, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 160);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Locations";
            // 
            // locationListBox
            // 
            locationListBox.FormattingEnabled = true;
            locationListBox.ItemHeight = 15;
            locationListBox.Items.AddRange(new object[] { "Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh" });
            locationListBox.Location = new Point(8, 25);
            locationListBox.Name = "locationListBox";
            locationListBox.Size = new Size(247, 124);
            locationListBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(18, 178);
            button1.Name = "button1";
            button1.Size = new Size(247, 23);
            button1.TabIndex = 2;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Location = new Point(296, 178);
            button2.Name = "button2";
            button2.Size = new Size(247, 23);
            button2.TabIndex = 3;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(registerationLabel);
            groupBox3.Location = new Point(565, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 57);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Registration Fee";
            // 
            // registerationLabel
            // 
            registerationLabel.BackColor = SystemColors.ControlLight;
            registerationLabel.Location = new Point(10, 23);
            registerationLabel.Name = "registerationLabel";
            registerationLabel.Size = new Size(180, 23);
            registerationLabel.TabIndex = 0;
            registerationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lodgingLabel);
            groupBox4.Location = new Point(565, 78);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 57);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Lodging Fee";
            // 
            // lodgingLabel
            // 
            lodgingLabel.BackColor = SystemColors.ControlLight;
            lodgingLabel.Location = new Point(10, 23);
            lodgingLabel.Name = "lodgingLabel";
            lodgingLabel.Size = new Size(180, 23);
            lodgingLabel.TabIndex = 0;
            lodgingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(totalLabel);
            groupBox5.Location = new Point(565, 144);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(200, 57);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Total";
            // 
            // totalLabel
            // 
            totalLabel.BackColor = SystemColors.ControlLight;
            totalLabel.Location = new Point(10, 23);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(180, 23);
            totalLabel.TabIndex = 0;
            totalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Workshop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 214);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Workshop";
            Text = "Workshop";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox workShopListBox;
        private GroupBox groupBox2;
        private ListBox locationListBox;
        private Button button1;
        private Button button2;
        private GroupBox groupBox3;
        private Label registerationLabel;
        private GroupBox groupBox4;
        private Label lodgingLabel;
        private GroupBox groupBox5;
        private Label totalLabel;
    }
}