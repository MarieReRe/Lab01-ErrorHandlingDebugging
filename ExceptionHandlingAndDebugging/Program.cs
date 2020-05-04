using System;

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
            }
            catch (FormatException formatEx)
            {

                Console.WriteLine("Your input is in the wrong format: {0}", formatEx.Message);
            }
            catch(OverflowException overflowEx)
            {
                Console.WriteLine("There is data overflow: {0}", overflowEx.Message);
            }


        }
    }
}
