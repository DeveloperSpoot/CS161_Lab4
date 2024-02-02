namespace CS161_Lab4.Problems
{
    public partial class Software_Sales : Form
    {
        public Software_Sales()
        {
            InitializeComponent();
        }

        private void packagesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (packagesTextBox.Text == "") { return; }

                double numberOfPackages = double.Parse(packagesTextBox.Text);
                double totalCostB4Discount = numberOfPackages * 99;

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

                displayLabel.Text = "No Discount.";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid inout given, please only input numbers.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
