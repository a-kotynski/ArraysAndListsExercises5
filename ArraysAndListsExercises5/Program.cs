using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-tutorial-for-beginners/learn/lecture/2910726#content
/* 5 - Write a program that asks the user to supply a list of 
 * comma separated numbers (e.g 5, 1, 9, 2, 10). 
 * If the list is empty or includes less than 5 numbers, 
 * display "Invalid List" and ask the user to re-try; 
 * otherwise, display the 3 smallest numbers in the list.*/



//no idea what happened below *shrug*
namespace ArraysAndListsExercises5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of numbers separated by comas: ");
            //var input = Console.ReadLine();
            var input = "5,4,7,4,2";
            // why the list isn't created here? - program first checks if
            // the input is empty or includes less than 5 numbers
            // 
            
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("The list cannot be empty or null, type again.");
            }
            else
            {
                var numbers = GetListFromValuesSeparatedWithComas(input);
                numbers.Sort();
                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid list - cannot be empty or null. Please retry");
                }
                else
                {
                    var smallestThreeNumbers = new List<int>();
                    for (int i = 0; i < 3; i++)
                    {
                        smallestThreeNumbers.Add(numbers[i]);
                    }
                    smallestThreeNumbers.ForEach(Console.WriteLine);
                }
            }
        }
        static IEnumerable<int> GetListFromValuesSeparatedWithComas(string input)
        {
            return input?.Split(',').Select(number => Convert.ToInt32(number.Trim())).ToList();
        }
    }
}