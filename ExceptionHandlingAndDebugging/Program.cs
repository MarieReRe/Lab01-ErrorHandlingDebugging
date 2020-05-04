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

        }
    }
}
