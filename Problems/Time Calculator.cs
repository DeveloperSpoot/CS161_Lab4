namespace CS161_Lab4.Problems
{
    public partial class Time_Calculator : Form
    {
        public Time_Calculator()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Attempting to convert seconds to minutes, hours or days.
            try
            {
                decimal seconds = decimal.Parse(secondsTextBox.Text); // Converting user input into decimal.
                
                if(seconds < 60) // Checking if the amount enters is less than 60 seconds.
                {
                    outputLabel.Text = $"{seconds} Seconds."; // Output
                    return;
                }

                if(seconds >= 60 && seconds < 3600) // Checking to see if seconds enteres is enough to create mintue(s) but not enough to create hour(s).
                {
                    decimal outputNumber = seconds/60;

                    outputLabel.Text = $"{outputNumber.ToString("f2")} Minutes.";

                    return;
                }

                if (seconds >= 3600 && seconds < 86400) // Checking to see if seconds enteres is enough to create hour(s) but not enough to create day(s).
                {
                    decimal outputNumber = seconds / 3600m;

                    outputLabel.Text = $"{outputNumber.ToString("f2")} Hours.";
                    return;
                }

                if (seconds >= 86400) // Checking to see if seconds enteres is enough to create day(s).
                {
                    decimal outputNumber = seconds / 86400;

                    outputLabel.Text = $"{outputNumber.ToString("f2")} Days.";
                    return;
                }

                MessageBox.Show("Please enter a value greater than or equal to 60 seconds.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Catching any invalid input. And displaying the error the user.
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
