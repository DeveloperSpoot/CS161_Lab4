namespace CS161_Lab4.Problems
{
    partial class Time_Calculator
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
            secondsTextBox = new TextBox();
            groupBox1 = new GroupBox();
            outputLabel = new Label();
            calculateButton = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Number of Seconds:";
            // 
            // secondsTextBox
            // 
            secondsTextBox.Location = new Point(164, 11);
            secondsTextBox.Name = "secondsTextBox";
            secondsTextBox.Size = new Size(100, 23);
            secondsTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(outputLabel);
            groupBox1.Location = new Point(18, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 52);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Output";
            // 
            // outputLabel
            // 
            outputLabel.BackColor = SystemColors.ControlLight;
            outputLabel.Location = new Point(6, 19);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(224, 23);
            outputLabel.TabIndex = 0;
            outputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(24, 97);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(224, 23);
            calculateButton.TabIndex = 3;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Location = new Point(24, 136);
            button2.Name = "button2";
            button2.Size = new Size(224, 23);
            button2.TabIndex = 4;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Time_Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 172);
            Controls.Add(button2);
            Controls.Add(calculateButton);
            Controls.Add(groupBox1);
            Controls.Add(secondsTextBox);
            Controls.Add(label1);
            Name = "Time_Calculator";
            Text = "Time_Calculator";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox secondsTextBox;
        private GroupBox groupBox1;
        private Label outputLabel;
        private Button calculateButton;
        private Button button2;
    }
}