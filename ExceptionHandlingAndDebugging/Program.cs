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
            finally
            {
                Console.WriteLine("Congrats you're done, I don't like math either");
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

                int sum = GetSum(array);

                int product = GetProduct(array, sum);

                decimal quotient = GetQuotient(product);



                //return array to the user
                Console.WriteLine("The sum is {0}", sum);
                Console.WriteLine("The product is {0}", product);
                Console.WriteLine("The quotient is {0}", quotient);
                Console.WriteLine("Thanks for playing, I guess!");



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
                Console.WriteLine($"Please select ({i + 1} of {arrayLength.Length})");
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
        public static int GetSum(int[] array)
        {
            //declare an int variable named sum
            int sum = 0;
            //iterate through and populate the variable
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            //throw a sum if user input is less than 20
            if(sum < 20)
            {
                Console.WriteLine("Your sum of {0} is too low, please enter numbers that sum greater than 20!", sum);
            }

            return sum;
        }
        public static int GetProduct(int[] array, int sum)
        {
            //set product to zero
            int product = 0;
            // set user input limit of arrayLength
            int userLimit = array.Length;
            try
            {
                Console.WriteLine("Please choose a number between 1 and {0}", userLimit);
                string userChoice = Console.ReadLine();
                int chosenNumber = int.Parse(userChoice);

                product = sum * chosenNumber;
            }
            catch (Exception IndexOutOfRange)
            {
                Console.WriteLine("Index is out of range {0}", IndexOutOfRange.Message);
                throw;
            }
            return product;
        }
        public static decimal GetQuotient(int product)
        {
            //set the dividend
            int dividend = 0;
            try
            {
                Console.WriteLine("Please choose a number to divide your product by {0}", product);
                string userDivider = Console.ReadLine();
                dividend = Convert.ToInt32(userDivider);
            }
            catch (DivideByZeroException ex)
            {
                if(dividend == 0)
                {
                    Console.WriteLine("Why are you trying to divide by zero: {0}", ex.Message);
                }
              
            }
            decimal quotient = product / dividend;
            return quotient;

        }
    }
}
