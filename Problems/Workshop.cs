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
            //NOTE: This could have also been with a switch case, which may have looked better.

            if (workShopListBox.SelectedItem == "Handling Stress")
            {
                registerFee = 1000m;
                days = 3m;
            }

            if (workShopListBox.SelectedItem == "Time Management")
            {
                registerFee = 800m;
                days = 3m;
            }

            if (workShopListBox.SelectedItem == "Supervision Skills")
            {
                registerFee = 1500m;
                days = 3m;
            }

            if (workShopListBox.SelectedItem == "Negotation")
            {
                registerFee = 1300m;
                days = 5m;
            }

            if (workShopListBox.SelectedItem == "How to Interview")
            {
                registerFee = 500m;
                days = 1m;
            }

            //Checking which location was selected and assigning the corresponding fees.
            //NOTE: This could have also been with a switch case, which may have looked better.

            if (locationListBox.SelectedItem == "Austin")
            { lodgingFee = 150m; }

            if (locationListBox.SelectedItem == "Chicago")
            { lodgingFee = 225m; }

            if (locationListBox.SelectedItem == "Dallas")
            { lodgingFee = 175m; }

            if (locationListBox.SelectedItem == "Orlando")
            { lodgingFee = 300m; }

            if (locationListBox.SelectedItem == "Phoenix")
            { lodgingFee = 175m; }

            if (locationListBox.SelectedItem == "Raleigh")
            { lodgingFee = 150m; }


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
