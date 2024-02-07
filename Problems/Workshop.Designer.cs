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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.workShopListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.registerationLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lodgingLabel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.workShopListBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(299, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Workshops";
            // 
            // workShopListBox
            // 
            this.workShopListBox.FormattingEnabled = true;
            this.workShopListBox.ItemHeight = 19;
            this.workShopListBox.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.workShopListBox.Location = new System.Drawing.Point(9, 32);
            this.workShopListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.workShopListBox.Name = "workShopListBox";
            this.workShopListBox.Size = new System.Drawing.Size(282, 156);
            this.workShopListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.locationListBox);
            this.groupBox2.Location = new System.Drawing.Point(329, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(299, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Locations";
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.ItemHeight = 19;
            this.locationListBox.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.locationListBox.Location = new System.Drawing.Point(9, 32);
            this.locationListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(282, 156);
            this.locationListBox.TabIndex = 0;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(21, 225);
            this.registerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(282, 29);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RosyBrown;
            this.exitButton.Location = new System.Drawing.Point(338, 225);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(282, 29);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.registerationLabel);
            this.groupBox3.Location = new System.Drawing.Point(646, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(229, 72);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registration Fee";
            // 
            // registerationLabel
            // 
            this.registerationLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.registerationLabel.Location = new System.Drawing.Point(11, 29);
            this.registerationLabel.Name = "registerationLabel";
            this.registerationLabel.Size = new System.Drawing.Size(206, 29);
            this.registerationLabel.TabIndex = 0;
            this.registerationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lodgingLabel);
            this.groupBox4.Location = new System.Drawing.Point(646, 99);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(229, 72);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lodging Fee";
            // 
            // lodgingLabel
            // 
            this.lodgingLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lodgingLabel.Location = new System.Drawing.Point(11, 29);
            this.lodgingLabel.Name = "lodgingLabel";
            this.lodgingLabel.Size = new System.Drawing.Size(206, 29);
            this.lodgingLabel.TabIndex = 0;
            this.lodgingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.totalLabel);
            this.groupBox5.Location = new System.Drawing.Point(646, 182);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(229, 72);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total";
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalLabel.Location = new System.Drawing.Point(11, 29);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(206, 29);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Workshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 271);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Workshop";
            this.Text = "Workshop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ListBox workShopListBox;
        private GroupBox groupBox2;
        private ListBox locationListBox;
        private Button registerButton;
        private Button exitButton;
        private GroupBox groupBox3;
        private Label registerationLabel;
        private GroupBox groupBox4;
        private Label lodgingLabel;
        private GroupBox groupBox5;
        private Label totalLabel;
    }
}