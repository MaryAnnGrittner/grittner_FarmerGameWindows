using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

/* Assignment No:   3A
 * Programmer   :   Mary Ann Grittner
 * Purpose      :   Graphical user interface class
 */

namespace grittner_FarmerGameWindows
{

    public partial class FarmerGameUI : Form
    {
        public FarmerGame theGame;

        private string itemToMove;

        #region Pictures' Location
        private Point _farmerLocationLeft = new Point(86, 263);
        private Point _farmerLocationRight = new Point(273, 267);

        private Point _chickenLocationLeft = new Point(13, 242);
        private Point _chickenLocationRight = new Point(555, 242);

        private Point _grainLocationLeft = new Point(70, 275);
        private Point _grainLocationRight = new Point(503, 277);

        private Point _foxLocationLeft = new Point(125, 242);
        private Point _foxLocationRight = new Point(451, 242);
        #endregion

        //Constructor Method
        public FarmerGameUI()
        {
            theGame = new FarmerGame();
            InitializeComponent();
            Play(); 
        }

        //Other Methods
        public void Play()//controller method
        {
            theGame = new FarmerGame();
             
            DisplayWelcome();
            DisplayInitialGameState();  
            MessagePrompt("Do you want to continue this game?", "Click RESET to start again or EXIT to end this game."); 
        }

        
        public void DisplayInitialGameState() //displays initial position of the picture boxes
        {
            picFarmer.Location = _farmerLocationLeft;
            picChicken.Location = _chickenLocationLeft;
            picGrain.Location = _grainLocationLeft;
            picFox.Location = _foxLocationLeft;
        }

        #region Buttons' Event-Handling Methods

        private void btnNone_Click(object sender, EventArgs e) //None button function
        {
            itemToMove = "";
            if (picFarmer.Location == _farmerLocationLeft)
            {
                theGame.Move(itemToMove);
                picFarmer.Location = _farmerLocationRight;
            }
            else
            {
                theGame.Move(itemToMove);
                picFarmer.Location = _farmerLocationLeft;
            } 
            DisplayStatus();
        }

        private void btnChicken_Click(object sender, EventArgs e) //Chicken button function
        {
            itemToMove = "CHICKEN";

            if (picFarmer.Location == _farmerLocationRight && picChicken.Location == _chickenLocationRight)
            {
                theGame.Move(itemToMove);
                MessagePrompt("Good moved", "Keep it up!");
                picChicken.Location = _chickenLocationLeft;
                picFarmer.Location = _farmerLocationLeft;  
            }
            else if (picChicken.Location == _chickenLocationLeft & picFarmer.Location == _farmerLocationLeft)
            { 
                theGame.Move(itemToMove);
                MessagePrompt("Good moved", "Keep it up!");
                picChicken.Location = _chickenLocationRight;
                picFarmer.Location = _farmerLocationRight; 
            }
            else
            {
                MessagePrompt("Item cannot be moved", "The farmer is on the other side of the river.");
            }
            DisplayStatus();
        }

        private void btnGrain_Click(object sender, EventArgs e) //Grain button function
        {
            itemToMove = "GRAIN";

            if (picFarmer.Location == _farmerLocationRight && picGrain.Location == _grainLocationRight)
            {
                theGame.Move(itemToMove);
                MessagePrompt("Good moved", "Keep it up!");
                picGrain.Location = _grainLocationLeft;
                picFarmer.Location = _farmerLocationLeft;
                
            }
            else if (picGrain.Location == _grainLocationLeft && picFarmer.Location == _farmerLocationLeft)
            {
                theGame.Move(itemToMove);
                MessagePrompt("Good moved", "Keep it up!");
                picGrain.Location = _grainLocationRight;
                picFarmer.Location = _farmerLocationRight; 
            }
            else
            {
                MessagePrompt("Item cannot be moved", "The farmer is on the other side of the river.");  
            }
            DisplayStatus();
        }

        private void btnFox_Click(object sender, EventArgs e) //Fox button function
        {
            itemToMove = "FOX";

            if (picFarmer.Location == _farmerLocationRight && picFox.Location == _foxLocationRight)
            {
                theGame.Move(itemToMove);
                MessagePrompt("Good moved", "Keep it up!");
                picFox.Location = _foxLocationLeft;
                picFarmer.Location = _farmerLocationLeft;
                
            }
            else if (picFox.Location == _foxLocationLeft && picFarmer.Location == _farmerLocationLeft)
            {
                theGame.Move(itemToMove);
                MessagePrompt("Good moved", "Keep it up!");
                picFox.Location = _foxLocationRight;
                picFarmer.Location = _farmerLocationRight; 
            }
            else
            {
                MessagePrompt("Item cannot be moved", "The farmer is on the other side of the river.");
            }
            DisplayStatus();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DialogResult response;

            response = MessageBox.Show("Do you want to Quit?", "Button One", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (response == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for playing!");
                Close();
            }
        }

        #endregion

        #region Textboxes Methods
        public void MessagePrompt(string title, string prompt) //displays messages or prompts at the txtPromptBox textbox only
        {
            string message =
                $" {title} {Environment.NewLine} {Environment.NewLine}" +
                $" {prompt} {Environment.NewLine}";
            txtPromptBox.Text = message; 
        }

        public void DisplayWelcome() //displays instructions at the txtInstructions textbox only
        {
            string message =
                $"WELCOME TO FARMER'S GAME! {Environment.NewLine} {Environment.NewLine}" +
                $"Help the farmer get across the river with his animals and grain (the farmer will automatically move). {Environment.NewLine}" +
                $"His boat is old and leaky, so he can only take one across with him at a time. {Environment.NewLine} {Environment.NewLine}" +
                $"1. You will win, if you get the Chicken, Fox, and Grain accross the river. {Environment.NewLine}" +
                $"2. Choose an item to move one at time. Chicken, Fox, Grain, or Nothing. {Environment.NewLine}" +
                $"3. You will lose, if the chicken eats the grain or if the fox eats the chicken. ";
            txtInstructions.Text = message; 
        } 

        public void DisplayStatus() //displays if user wins or loses at the txtPromptBox textbox and MessagePrompt Box
        {
            if (theGame.AnimalAteFood() == true)
            {
                MessagePrompt("You lose!", "Animal ate his food.");
                MessageBox.Show("You lost the game! Animal ate his food.");
                Play();

            }
            if (theGame.DetermineWin() == true)
            {
                MessagePrompt("You win!", "You successfully helped the farmer.");
                MessageBox.Show("You won the game! You successfully helped the farmer.");
                Play();
            }
        }
        #endregion

        private void FarmerGameUI_Load(object sender, EventArgs e)
        {

        }
    }
}
