using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string userInput = string.Empty;
            Console.WriteLine($"Please enter a 1 to 4 digit number below :) ");
            userInput = Console.ReadLine();
            int userNum = Int32.Parse(userInput);

            if (userNum >= 0 && userNum <= 9999)
            {

                Console.WriteLine("In words: " + numConverter.numToWordsConverter.convertNumtoWord(userNum));
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 9999.");
            
            }
        }
    }
}
