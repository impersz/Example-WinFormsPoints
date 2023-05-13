using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleProject
{
    public partial class InGameForm : Form
    {
        private string _gameName;
        private DateTime _startDate;

        public InGameForm(string gameName, DateTime startDate)
        {
            InitializeComponent();
            _startDate = startDate;
            labelStartDate.Text = _startDate.ToString();

            _gameName = gameName;
            labelGameName.Text = _gameName;

            labelTotalPoints.Text = "0";
            textBoxPointsToGive.Text = "1";
        }

        private void buttonAddPoints_Click(object sender, EventArgs e)
        {
            var pointsToGive = Convert.ToInt32(textBoxPointsToGive.Text);

            var currentPoints = Convert.ToInt32(labelTotalPoints.Text);

            labelTotalPoints.Text = (currentPoints + pointsToGive).ToString();
        }

        private void buttonRemovePoints_Click(object sender, EventArgs e)
        {
            var pointsToTake = Convert.ToInt32(textBoxPointsToGive.Text);

            var currentPoints = Convert.ToInt32(labelTotalPoints.Text);

            labelTotalPoints.Text = (currentPoints - pointsToTake).ToString();
        }

        private void buttonEndGame_Click(object sender, EventArgs e)
        {
            //get all the information for the game
            //ideally it would be in a Game object
            //in this example its limited to just few properties

            //All Game Data we have in this example:
            //_gameName
            var gameEndDate = DateTime.Now;
            var gameDuration = gameEndDate - _startDate;
            //we now have only one player so will just take his points
            var gameWinnerPlayer = textBoxPlayerName.Text;
            var gameWinnerPoints = Convert.ToInt32(labelTotalPoints.Text);

            var firstLineToSaveInTheFileAsHeader = "GameName | StartDate | EndDate | Duration | Winner | Points";
            var lineToSaveToTheFile = $"{_gameName} | {_startDate} | {gameEndDate} | {gameDuration} | {gameWinnerPlayer} | {gameWinnerPoints}";

            //we will use that to show it on the screen in a new form populating different labels/textboxes
            // . . .

            //we will save the game result in a txt file
            // . . .
            //https://www.c-sharpcorner.com/article/c-sharp-write-to-file/

            //the above would be good enough, but still, for information for further development :
            // for the game history, in a new form, we can have a listBox controll/component (from Toolbox menu on the left)
            //when reading from the file we can just read the lines and put them in the listbox
            //if we want to get the individual properties one by one, we can read a line and then split at | 
            //string ss = "a,b,c,d";
            //ss.Split(',');
            //will result in an array of strings -> array[0] will be "a", array[1] will be "b"
            //https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-7.0
        }

    }
}
