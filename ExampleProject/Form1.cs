namespace ExampleProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //set the actual values we want to see.
            //The ones in the Designer view are currently set as the names of the controls, just so its easier while developing
            textBoxGameName.Text = "";
            buttonCreateGame.Text = "Create Game";
        }

        private void buttonCreateGame_Click(object sender, EventArgs e)
        {
            var gameName = textBoxGameName.Text;
            var startDate = DateTime.Now;

            //ideally we would like to provide a whole Game object here, with StartDate, max points, winner id and others
            //for this example we will just provide GameName and StartDate
            var nextForm = new InGameForm(gameName, startDate);
            nextForm.Show();
            this.Hide();
        }
    }
}