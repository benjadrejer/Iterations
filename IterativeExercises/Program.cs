using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterativeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Count the amount of numbers between 1 and 100 divisible by 3 with no remainder
            //int amount = 0;
            //for (var i = 1; i <= 100; i++)
            //{
            //    if(i % 3 == 0)
            //    {
            //        amount++;
            //    }
            //}
            //Console.WriteLine(amount);
            //Console.ReadKey();

            //Loop until user types "ok". Ask user to enter a number. Calculate the sum and display each loop.
            //int sum = 0;
            //string input = null;
            //while(input != "ok")
            //{
            //    Console.WriteLine("Please enter a number or \"ok\" to quit");
            //    input = Console.ReadLine();
            //    if (input == "ok")
            //        break;
            //    sum += Convert.ToInt32(input);
            //    Console.WriteLine(sum);
            //}

            //Ask for a number and compute the factorial, provide output.
            //int number;
            //int start;
            //int sum = 0;
            //Console.WriteLine("Please enter a number");
            //number = Convert.ToInt32(Console.ReadLine());
            //sum = number;
            //start = number;
            //while (number > 1)
            //{
            //    sum = sum * (number - 1);
            //    number--;
            //}
            //Console.WriteLine(String.Format("Factorial of {0} = {1}", start, sum));
            //Console.ReadKey();

            //Choose a random number between 1 and 10.
            //Provide user 4 tries to guess the number.
            //If the user guesses correctly, output "you won" and terminate.
            //Else, output "you lost".
            //var random = new Random();
            //int RandomNumber = random.Next(1, 10);
            //int guess = 0;

            //for(var i = 1; i<5; i++)
            //{
            //    Console.WriteLine("Guess a random number between 1 and 10");
            //    guess = Convert.ToInt32(Console.ReadLine());
            //    if(guess == RandomNumber)
            //    {
            //        Console.WriteLine("You won! The number was: " + RandomNumber);
            //        Console.ReadKey();
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong, try again");
            //    }
            //}

            //if(guess != RandomNumber)
            //{
            //    Console.WriteLine("You lost. The number was: " + RandomNumber);
            //    Console.ReadLine();
            //}

            //Ask the user for a series of number separated by a comma.
            //Find the maximum number and output.
            string input;
            string[] numbers;
            int max = 0;

            Console.WriteLine("Please enter a series of numbers separated by commas");
            input = Console.ReadLine();

            numbers = input.Split(',');
            max = Convert.ToInt32(numbers[0]);

            foreach(var str in numbers)
            {
                int number = Convert.ToInt32(str);
                if(max < number)
                {
                    max = number;
                }
            }
            Console.WriteLine("Max is: " + max);
            Console.ReadKey();

        }
    }
}
