namespace CS161_Lab4
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            softwareSalesButton = new Button();
            timeConverterButton = new Button();
            dollarGameButton = new Button();
            restaruantSelectorButton = new Button();
            workshopSelectorButton = new Button();
            SuspendLayout();
            // 
            // softwareSalesButton
            // 
            softwareSalesButton.Location = new Point(12, 12);
            softwareSalesButton.Name = "softwareSalesButton";
            softwareSalesButton.Size = new Size(190, 23);
            softwareSalesButton.TabIndex = 0;
            softwareSalesButton.Text = "Software Sales";
            softwareSalesButton.UseVisualStyleBackColor = true;
            softwareSalesButton.Click += softwareSalesButton_Click;
            // 
            // timeConverterButton
            // 
            timeConverterButton.Location = new Point(12, 96);
            timeConverterButton.Name = "timeConverterButton";
            timeConverterButton.Size = new Size(190, 23);
            timeConverterButton.TabIndex = 1;
            timeConverterButton.Text = "Time Calculator";
            timeConverterButton.UseVisualStyleBackColor = true;
            timeConverterButton.Click += timeConverterButton_Click;
            // 
            // dollarGameButton
            // 
            dollarGameButton.Location = new Point(12, 54);
            dollarGameButton.Name = "dollarGameButton";
            dollarGameButton.Size = new Size(190, 23);
            dollarGameButton.TabIndex = 2;
            dollarGameButton.Text = "Dollar Game";
            dollarGameButton.UseVisualStyleBackColor = true;
            dollarGameButton.Click += dollarGameButton_Click;
            // 
            // restaruantSelectorButton
            // 
            restaruantSelectorButton.Location = new Point(12, 138);
            restaruantSelectorButton.Name = "restaruantSelectorButton";
            restaruantSelectorButton.Size = new Size(190, 23);
            restaruantSelectorButton.TabIndex = 3;
            restaruantSelectorButton.Text = "Restaurant Selector";
            restaruantSelectorButton.UseVisualStyleBackColor = true;
            restaruantSelectorButton.Click += restaruantSelectorButton_Click;
            // 
            // workshopSelectorButton
            // 
            workshopSelectorButton.Location = new Point(12, 180);
            workshopSelectorButton.Name = "workshopSelectorButton";
            workshopSelectorButton.Size = new Size(190, 23);
            workshopSelectorButton.TabIndex = 4;
            workshopSelectorButton.Text = "Workshop Selector";
            workshopSelectorButton.UseVisualStyleBackColor = true;
            workshopSelectorButton.Click += workshopSelectorButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 215);
            Controls.Add(workshopSelectorButton);
            Controls.Add(restaruantSelectorButton);
            Controls.Add(dollarGameButton);
            Controls.Add(timeConverterButton);
            Controls.Add(softwareSalesButton);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button softwareSalesButton;
        private Button timeConverterButton;
        private Button dollarGameButton;
        private Button restaruantSelectorButton;
        private Button workshopSelectorButton;
    }
}
