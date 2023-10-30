using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        
        Console.WriteLine($"The sum is: {sum}");

        //Compute the average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average number is: {average}");

        //Find the max number

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
                // if number is greater than max then that is the new max!!
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}