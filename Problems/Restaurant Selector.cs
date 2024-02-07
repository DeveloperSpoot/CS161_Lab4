namespace CS161_Lab4.Problems
{
    public partial class Restaurant_Selector : Form
    {
        public Restaurant_Selector()
        {
            InitializeComponent();
        }

        //Create a list to contain all resutrants that don't meet the clients needs;
        private List<string> dontShowList = new List<string>();

        //Our "Main" method that gets triggered when a client adds a restrictions by updating the radio buttons;
        private void retrieveCompatiableResturants(object sender, EventArgs e)
        {
            clearSelections();
            updateRestrictions();
            updateResturantsList();
        }

        //Resetting the output list and clearing the don't show list;
        private void clearSelections()
        {
            dontShowList.Clear();
            restaruantsListBox.Items.Clear();
            restaruantsListBox.Items.Add("Joe's Gourmet Burgers"); // 0
            restaruantsListBox.Items.Add("Main Street Pizza Company"); //1
            restaruantsListBox.Items.Add("Corner Cafe"); //2
            restaruantsListBox.Items.Add("Mama's Fine Italian"); //3
            restaruantsListBox.Items.Add("The Chef's kitchen"); //4
        }

        //Adding resturants to the don't show list based on selected restrictions;
        private void updateRestrictions()
        {
            bool vege = vegetarianCheckBox.Checked;
            bool vegan = veganCheckBox.Checked;
            bool gluten = glutenCheckBox.Checked;

            //Checking each radio button and adding resturants to a list (containg resutrants to be removed/not shown) if they don't support the restrictions.
            if (vege)
            {
                dontShowList.Add("Joe's Gourmet Burgers");

            }

            if (vegan)
            {
                dontShowList.Add("Joe's Gourmet Burgers");
                dontShowList.Add("Main Street Pizza Company");
                dontShowList.Add("Mama's Fine Italian");
            }

            if (gluten)
            {
                dontShowList.Add("Joe's Gourmet Burgers");
                dontShowList.Add("Mama's Fine Italian");
            }
        }

        //Updating the output list based on incompitable resutrants (don't show list).
        private void updateResturantsList()
        {
            //Looping through all resutrants in the don't show list and removing them from the output list.
            dontShowList.ForEach(item => {
                if (restaruantsListBox.Items.Contains(item) == true)
                {
                    restaruantsListBox.Items.Remove(item);
                }
            });
        }

        //Close upon exit button clicked;
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
