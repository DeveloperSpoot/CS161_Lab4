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
            try
            {

                decimal pennies = decimal.Parse(penniesTextBox.Text) * 0.01m; ;
                decimal nickels = decimal.Parse(nickelsTextBox.Text) * 0.05m;
                decimal dimes = decimal.Parse(dimsTextBox.Text) * 0.10m;
                decimal quarters = decimal.Parse(quartersTextBox.Text) * 0.25m;

                decimal total = (pennies + nickels + dimes + quarters);
                if (total == 1.00m)
                {
                    MessageBox.Show("Congrats! You made $1.00");
                }
                else
                {
                    MessageBox.Show("You did not make $1.00. Try again.");
                }


            }catch(Exception ex)
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
