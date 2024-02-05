namespace CS161_Lab4.Problems
{
    public partial class Dollar_Game : Form
    {
        public Dollar_Game()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            //Attempting to calculate the dollars with the provided inputs.
            try
            {

                //Delcaring vairables to hold the amount of each coin entered and mutliplying them by their corresponding values.
                decimal pennies = decimal.Parse(penniesTextBox.Text) * 0.01m; ;
                decimal nickels = decimal.Parse(nickelsTextBox.Text) * 0.05m;
                decimal dimes = decimal.Parse(dimsTextBox.Text) * 0.10m;
                decimal quarters = decimal.Parse(quartersTextBox.Text) * 0.25m;

                
                //Adding the values of all the coins entered.
                decimal total = (pennies + nickels + dimes + quarters);

                //Checking if the total is equal to, above, or below a dollar.
                if (total == 1.00m) 
                {
                    MessageBox.Show("Congrats! You made $1.00");
                }else if (total > 1.00m)
                {
                    MessageBox.Show("You made more than a dollar. Try agian.");
                }else if(total < 1.00m)
                {
                    MessageBox.Show("You made less than a dollar. Try again.");
                }


            }catch(Exception ex) // Catching any invalid inputs.
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
