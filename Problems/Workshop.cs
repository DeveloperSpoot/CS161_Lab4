namespace CS161_Lab4.Problems
{
    public partial class Workshop : Form
    {
        public Workshop()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //Delcaring vairables to hold fees amounts and number of days required;
            decimal registerFee = 0;
            decimal lodgingFee = 0;
            decimal days = 0;

            //Checking which workshop was selected and assigning the corresponding fees.

            switch (workShopListBox.SelectedItem)
            {
                case "Handling Stress":
                    registerFee = 1000m;
                    days = 3m;
                    break;

                case "Time Management":
                    registerFee = 800m;
                    days = 3m;
                    break;

                case "Supervision Skills":
                    registerFee = 1500m;
                    days = 3m;
                    break;

                case "Negotation":
                    registerFee = 1300m;
                    days = 5m;
                    break;

                case "How to Interview":
                    registerFee = 1300m;
                    days = 5m;
                    break;
            }

            //Checking which location was selected and assigning the corresponding fees.

            switch (locationListBox.SelectedItem)
            {
                case "Austin": lodgingFee = 150m; break;

                case "Chicago": lodgingFee = 225m; break;

                case "Dallas": lodgingFee = 175m; break;

                case "Orlando": lodgingFee = 300m; break;

                case "Phoenix": lodgingFee = 175m; break;

                case "Raleigh": lodgingFee = 150m; break;

            }


            //Calculating the total lodging fee base don the number of days and fee with the corresponding location.
            lodgingFee = lodgingFee * days;

            //Calculating total, if that wasn't obvious.
            decimal total = lodgingFee + registerFee;


            //Updating display labels;
            registerationLabel.Text = registerFee.ToString("c");
            lodgingLabel.Text = lodgingFee.ToString("C");
            totalLabel.Text = total.ToString("C");

        }

        //Exit method for our exit button, imgaine that.
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
