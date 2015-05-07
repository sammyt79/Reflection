// Reflection
// Samuel Tollefson
// POS/409
// April 13, 2015
// Jon Jensen

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string condition = null; // To hold the number of sides.

        private void btnRoll_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear(); // Clear the listbox.

            condition = cboSides.Text; // Set the number of sides.

            // Create an instance.
            DiceFactory factory = new ConcreteDiceFactory();

            int inaRow = 0; // Variable to hold the number of sequential double rolls.

            // Count up to 100 in increments of 1.
            for (int sequence = 1; sequence <= 100; sequence++)
            {
                Dice dice1 = factory.GetDice(); // Set dice.
                Dice dice2 = factory.GetDice(); // Set dice.

                if (dice1.roll == dice2.roll) // Compare the numbers.
                {
                    inaRow = inaRow + 1; // Increment sequential double rolls.

                    // Display the rolls that produced doubles.
                    lstResults.Items.Add("Roll " + sequence + " produced a pair of " + dice1.roll + "s");

                    // This if statement was added because the following else statement displays the sequential doubles 
                    // only after the sequential doubles are finished. If the doubles end on the final roll,
                    // there is no other roll to display the number of doubles rolled.
                    if (inaRow > 1 & sequence == 100)
                    {
                        // Display the number of sequential double rolls.
                        lstResults.Items.Add("Nice, " + inaRow + " in a row");
                    }
                }
                else
                {
                    // Check to see if doubles have been rolled at least twice in a row.
                    if (inaRow > 1)
                    {
                        // Display the number of sequential double rolls.
                        lstResults.Items.Add("Nice, " + inaRow + " in a row");
                    }
                    inaRow = 0; // If doubles are not rolled, reset the variable.
                }
            }
        }

        // Compile and pass the condition string.
        public static string getCondition()
        {
            return "get_roll" + condition;
        }
    }
}
