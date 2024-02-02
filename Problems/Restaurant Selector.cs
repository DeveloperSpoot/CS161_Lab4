namespace CS161_Lab4.Problems
{
    public partial class Restaurant_Selector : Form
    {
        public Restaurant_Selector()
        {
            InitializeComponent();
        }

        private void checkAll()
        {
            bool vege = vegetarianCheckBox.Checked;
            bool vegan = veganCheckBox.Checked;
            bool gluten = glutenCheckBox.Checked;

            restaruantsListBox.Items.Clear();
            restaruantsListBox.Items.Add("Joe's Gourmet Burgers"); // 0
            restaruantsListBox.Items.Add("Main Street Pizza Company"); //1
            restaruantsListBox.Items.Add("Corner Cafe"); //2
            restaruantsListBox.Items.Add("Mama's Fine Italian"); //3
            restaruantsListBox.Items.Add("The Chef's kitchen"); //4

            List<string> list = new List<string>();

            //Vege Check
            if (vege)
            {
                list.Add("Joe's Gourmet Burgers");

            }

            //vegan Check
            if (vegan)
            {
                list.Add("Joe's Gourmet Burgers");
                list.Add("Main Street Pizza Company");
                list.Add("Mama's Fine Italian");
            }

            if (gluten)
            {
                list.Add("Joe's Gourmet Burgers");
                list.Add("Mama's Fine Italian");
            }

            if (list.Exists(item => item == "Joe's Gourmet Burgers"))
            {
                restaruantsListBox.Items.Remove("Joe's Gourmet Burgers");
            }
            if (list.Exists(item => item == "Main Street Pizza Company"))
            {
                restaruantsListBox.Items.Remove("Main Street Pizza Company");
            }
            if (list.Exists(item => item == "Corner Cafe"))
            {
                restaruantsListBox.Items.Remove("Corner Cafe");
            }
            if (list.Exists(item => item == "Mama's Fine Italian"))
            {
                restaruantsListBox.Items.Remove("Mama's Fine Italian");
            }
            if (list.Exists(item => item == ("The Chef's kitchen")))
            {
                restaruantsListBox.Items.Remove("The Chef's kitchen");
            }

        }

        private void vegetarianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkAll();
        }

        private void veganCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkAll();
        }

        private void glutenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkAll();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
