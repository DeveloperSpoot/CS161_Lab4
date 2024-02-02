namespace CS161_Lab4.Problems
{
    partial class Dollar_Game
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
            penniesTextBox = new TextBox();
            groupBox2 = new GroupBox();
            nickelsTextBox = new TextBox();
            groupBox3 = new GroupBox();
            dimsTextBox = new TextBox();
            groupBox4 = new GroupBox();
            quartersTextBox = new TextBox();
            checkButton = new Button();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(penniesTextBox);
            groupBox1.Location = new Point(12, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(217, 49);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pennies";
            // 
            // penniesTextBox
            // 
            penniesTextBox.Location = new Point(6, 20);
            penniesTextBox.Name = "penniesTextBox";
            penniesTextBox.Size = new Size(202, 23);
            penniesTextBox.TabIndex = 0;
            penniesTextBox.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nickelsTextBox);
            groupBox2.Location = new Point(12, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(217, 49);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nickels";
            // 
            // nickelsTextBox
            // 
            nickelsTextBox.Location = new Point(6, 20);
            nickelsTextBox.Name = "nickelsTextBox";
            nickelsTextBox.Size = new Size(202, 23);
            nickelsTextBox.TabIndex = 1;
            nickelsTextBox.Text = "0";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dimsTextBox);
            groupBox3.Location = new Point(12, 118);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(217, 49);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dimes";
            // 
            // dimsTextBox
            // 
            dimsTextBox.Location = new Point(6, 20);
            dimsTextBox.Name = "dimsTextBox";
            dimsTextBox.Size = new Size(202, 23);
            dimsTextBox.TabIndex = 1;
            dimsTextBox.Text = "0";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(quartersTextBox);
            groupBox4.Location = new Point(12, 173);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(217, 49);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Quarters";
            // 
            // quartersTextBox
            // 
            quartersTextBox.Location = new Point(6, 20);
            quartersTextBox.Name = "quartersTextBox";
            quartersTextBox.Size = new Size(202, 23);
            quartersTextBox.TabIndex = 1;
            quartersTextBox.Text = "0";
            // 
            // checkButton
            // 
            checkButton.Location = new Point(18, 228);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(202, 23);
            checkButton.TabIndex = 4;
            checkButton.Text = "Check";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(18, 257);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(202, 23);
            exitButton.TabIndex = 5;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Dollar_Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 288);
            Controls.Add(exitButton);
            Controls.Add(checkButton);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Dollar_Game";
            Text = "Dollar_Game";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox penniesTextBox;
        private GroupBox groupBox2;
        private TextBox nickelsTextBox;
        private GroupBox groupBox3;
        private TextBox dimsTextBox;
        private GroupBox groupBox4;
        private TextBox quartersTextBox;
        private Button checkButton;
        private Button exitButton;
    }
}