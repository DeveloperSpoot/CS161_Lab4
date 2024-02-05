namespace CS161_Lab4.Problems
{
    partial class Software_Sales
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
            label1 = new Label();
            packagesTextBox = new TextBox();
            groupBox1 = new GroupBox();
            displayLabel = new Label();
            exitButton = new Button();
            groupBox = new GroupBox();
            totalLabel = new Label();
            groupBox1.SuspendLayout();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(206, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter number of packages purchased:";
            // 
            // packagesTextBox
            // 
            packagesTextBox.Location = new Point(224, 9);
            packagesTextBox.Name = "packagesTextBox";
            packagesTextBox.Size = new Size(100, 23);
            packagesTextBox.TabIndex = 1;
            packagesTextBox.TextChanged += packagesTextBox_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(displayLabel);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 60);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Discount To Be Given";
            // 
            // displayLabel
            // 
            displayLabel.BackColor = SystemColors.ControlLight;
            displayLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayLabel.Location = new Point(16, 21);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(281, 25);
            displayLabel.TabIndex = 0;
            displayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(12, 181);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(312, 33);
            exitButton.TabIndex = 3;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(totalLabel);
            groupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox.Location = new Point(13, 107);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(312, 60);
            groupBox.TabIndex = 3;
            groupBox.TabStop = false;
            groupBox.Text = "Total";
            // 
            // totalLabel
            // 
            totalLabel.BackColor = SystemColors.ControlLight;
            totalLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(16, 21);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(281, 25);
            totalLabel.TabIndex = 0;
            totalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Software_Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 226);
            Controls.Add(groupBox);
            Controls.Add(exitButton);
            Controls.Add(groupBox1);
            Controls.Add(packagesTextBox);
            Controls.Add(label1);
            Name = "Software_Sales";
            Text = "Software_Sales";
            groupBox1.ResumeLayout(false);
            groupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox packagesTextBox;
        private GroupBox groupBox1;
        private Label displayLabel;
        private Button exitButton;
        private GroupBox groupBox;
        private Label totalLabel;
    }
}