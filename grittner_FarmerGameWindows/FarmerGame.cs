using System;
using System.Collections.Generic; 
using System.Drawing;
using System.Linq;


/* Assignment No:   3A
 * Programmer   :   Mary Ann Grittner
 * Purpose      :   Data store for  Farmer, Chicken, Fox and Grain Game
 */

namespace grittner_FarmerGameWindows
{
    public class FarmerGame
    {
        public enum Direction
        {
            LEFT,
            RIGHT
        }

        //Data Members
        Direction farmer;
        private List<string> leftBank = new List<string>();
        private List<string> rightBank = new List<string>();

        //Properties
        public Direction Farmer //read-only property
        {
            get { return farmer; }
        }
        
        public List<string> LeftBank
        {
            get { return leftBank; }
        }
        public List<string> RightBank
        {
            get { return rightBank; }
        }

        //Constructor Method
        public FarmerGame()
        {
            //Initial state of the game
            farmer = Direction.LEFT;
            leftBank.Add("CHICKEN");
            leftBank.Add("GRAIN");
            leftBank.Add("FOX");
        }
         
        //Other Methods
        public void Move(string item)
        {  
            if (farmer == Direction.LEFT)
            {
                bool success = leftBank.Remove(item);
                if (success == true)
                {
                   rightBank.Add(item); 
                }
                farmer = Direction.RIGHT;
            }
            else
            {
                bool success = rightBank.Remove(item);
                if (success == true)
                {
                    leftBank.Add(item); 
                }
                farmer = Direction.LEFT;
            } 
        }

        public bool AnimalAteFood()
        {
            bool result = false;
            if (farmer == Direction.LEFT)
            {
                if (rightBank.Contains("CHICKEN") && rightBank.Contains("GRAIN") && leftBank.Contains("FOX"))
                {
                    result = true;
                }
                if (rightBank.Contains("CHICKEN") && rightBank.Contains("FOX") && leftBank.Contains("GRAIN"))
                {
                    result = true;
                }
            }
            if (farmer == Direction.RIGHT)
            {
                if (leftBank.Contains("CHICKEN") && leftBank.Contains("GRAIN") && rightBank.Contains("FOX"))
                {
                    result = true;
                }
                if (leftBank.Contains("CHICKEN") && leftBank.Contains("FOX") && rightBank.Contains("GRAIN"))
                {
                    result = true;
                }
            }
            return result;
        }
        public bool DetermineWin()
        {
            bool result = false;
            if (rightBank.Contains("CHICKEN") && rightBank.Contains("FOX") && rightBank.Contains("GRAIN"))
            {
                result = true;
            }
            return result;
        }

    }
}
