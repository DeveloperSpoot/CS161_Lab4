namespace CS161_Lab4.Problems
{
    public partial class Software_Sales : Form
    {
        public Software_Sales()
        {
            InitializeComponent();
        }

        //Attemping to calculate as the client inputs their numbers, rather than requiring them to click a button.
        private void packagesTextBox_TextChanged(object sender, EventArgs e)
        {

            //Making sure the client only inputs numbers into the texboxes.
            try
            {
                //Making sure we don't attempt to run the code if textboxes are cleared.
                if (packagesTextBox.Text == "") { return; }

                double numberOfPackages = double.Parse(packagesTextBox.Text);
                double totalCostB4Discount = numberOfPackages * 99;


                //Checking to see if the packages brought meet the following requirements for discounts and assigning them the appropriate discount.
                if (numberOfPackages >= 10 && numberOfPackages <= 19)
                {
                    displayLabel.Text =(totalCostB4Discount * 0.20).ToString("c");
                    totalLabel.Text = (totalCostB4Discount - (totalCostB4Discount*.20)).ToString("c");
                    return;
                }


                if (numberOfPackages >= 20 && numberOfPackages <= 49)
                {
                    displayLabel.Text = (totalCostB4Discount * 0.30).ToString("c");
                    totalLabel.Text = (totalCostB4Discount - (totalCostB4Discount * .30)).ToString("c");
                    return;

                }

                if (numberOfPackages >= 50 && numberOfPackages <= 99)
                {
                    displayLabel.Text = (totalCostB4Discount * 0.40).ToString("c");
                    totalLabel.Text = (totalCostB4Discount - (totalCostB4Discount * .40)).ToString("c");
                    return;
                }

                if (numberOfPackages >= 100)
                {
                    displayLabel.Text = (totalCostB4Discount * 0.50).ToString("c");
                    totalLabel.Text = (totalCostB4Discount - (totalCostB4Discount * .50)).ToString("c");
                    return;
                }

                //If the clint brought less than 10 packages, no discount is given.

                displayLabel.Text = "No Discount.";

            }
            catch (Exception ex) //Catching if the clients inputs an invalid argument in the texbox.
            {
                MessageBox.Show("Invalid inout given, please only input numbers.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
