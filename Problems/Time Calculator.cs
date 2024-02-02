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
            try
            {
                decimal seconds = decimal.Parse(secondsTextBox.Text);

                if(seconds >= 60 && seconds < 3600)
                {
                    decimal outputNumber = seconds;

                    outputLabel.Text = $"{outputNumber.ToString("f2")} Seconds.";

                    return;
                }

                if (seconds >= 3600 && seconds < 86400)
                {
                    decimal outputNumber = seconds / 3600m;

                    outputLabel.Text = $"{outputNumber.ToString("f2")} Minutes.";
                    return;
                }

                if (seconds >= 86400)
                {
                    decimal outputNumber = seconds / 86400;

                    outputLabel.Text = $"{outputNumber.ToString("f2")} Hours.";
                    return;
                }

                MessageBox.Show("Please tner a value greater than or equal to 60 seconds.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
