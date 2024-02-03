namespace CS161_Lab4.Problems
{
    public partial class Workshop : Form
    {
        public Workshop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            decimal registerFee = 0;
            decimal lodgingFee = 0;
            decimal days = 0;

            if(workShopListBox.SelectedItem == "Handling Stress")
            {
                registerFee = 1000m;
                days = 3m;
            }

            if(workShopListBox.SelectedItem == "Time Management")
            {
                registerFee = 800m;
                days = 3m;
            }

            if(workShopListBox.SelectedItem == "Supervision Skills")
            {
                registerFee = 1500m;
                days = 3m;
            }

            if(workShopListBox.SelectedItem == "Negotation")
            {
                registerFee = 1300m;
                days = 5m;
            }

            if (workShopListBox.SelectedItem == "How to Interview")
            {
                registerFee = 500m;
                days = 1m;
            }

            if(locationListBox.SelectedItem == "Austin")
            { lodgingFee = 150m; }

            if(locationListBox.SelectedItem == "Chicago")
            { lodgingFee = 225m; }

            if (locationListBox.SelectedItem == "Dallas")
            { lodgingFee = 175m; }

            if (locationListBox.SelectedItem == "Orlando")
            { lodgingFee = 300m; }

            if(locationListBox.SelectedItem == "Phoenix")
            { lodgingFee = 175m; }
            
            if(locationListBox.SelectedItem == "Raleigh")
            { lodgingFee = 150m; }

        }
    }
}
