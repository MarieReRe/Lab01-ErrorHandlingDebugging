using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace ExceptionHandlingAndDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome, let's play a math game!");
                StartSequence();
            }
            catch (Exception ex)
            {
                //write a generic exception and let the user know something went wrong.
                Console.WriteLine("Sorry, something went wrong! Exception{0}", ex.Message);
            }
        }
        public static void StartSequence()
        {
            try
            {
                //prompt to input a number greater than zero
                Console.WriteLine("Enter a number greater than zero please:");
                string userNumberChosen = Console.ReadLine();
                //parse to int
                int arrayLength = Convert.ToInt32(userNumberChosen);

                //set up an empty array for the user to populate
                int[] array = new int[arrayLength];

                //populate the users array with the length chosen by user
                int[] userArray = Populate(array);
            }
            catch (FormatException formatEx)
            {

                Console.WriteLine("Your input is in the wrong format: {0}", formatEx.Message);
            }
            catch (OverflowException overflowEx)
            {
                Console.WriteLine("There is data overflow: {0}", overflowEx.Message);
            }


        }
        public static int[] Populate(int[] arrayLength)
        {

            //we need a for loop to fill the user array
            for (int i = 0; i < arrayLength.Length; i++)
            {
                //ask the user for numbers, ask as many times as the length they have set above
                Console.WriteLine("Please select {0} numbers, hitting enter after you are satisfied with your number choice.", arrayLength.Length);
                string userArrayNumberChosen = Console.ReadLine();
                //parse the number they chose into an int
                int arrayNumber = int.Parse(userArrayNumberChosen);
                arrayLength[i] = arrayNumber;

            }
            //we need to return the array to the user
            for(int j = 0; j < arrayLength.Length; j++)
            {
                Console.WriteLine("You entered {0}", arrayLength[j]);
            }
            return arrayLength;
        }
    }
}
