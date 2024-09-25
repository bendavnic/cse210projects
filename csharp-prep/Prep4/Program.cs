using System;

class Program
{
    static void Main(string[] args)
    {
        //get list of numbers
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int input = -1;
        while (input != 0)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        //get sum of list
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }
        Console.WriteLine($"The sum is: {sum}");
        
        //get average of list
        int average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //get largest number in list
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");
    }
}