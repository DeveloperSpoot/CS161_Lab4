using CS161_Lab4.Problems;

namespace CS161_Lab4
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void softwareSalesButton_Click(object sender, EventArgs e)
        {
            Software_Sales form = new Software_Sales();
            form.Show();
        }
        private void dollarGameButton_Click(object sender, EventArgs e)
        {
            Dollar_Game form = new Dollar_Game();
            form.Show();
        }

        private void timeConverterButton_Click(object sender, EventArgs e)
        {
            Time_Calculator form = new Time_Calculator();
            form.Show();
        }


        private void restaruantSelectorButton_Click(object sender, EventArgs e)
        {

        }

        private void workshopSelectorButton_Click(object sender, EventArgs e)
        {

        }
    }
}
