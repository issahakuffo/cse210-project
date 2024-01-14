using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;
        
        do
        {
            Console.Write("Enter number and enter 0 to quite: ");
            string response = Console.ReadLine();
            number = int.Parse(response);

            if (number != 0)    
            {
                numbers.Add(number);
            }   
        } while (number != 0);

        int sum = 0 ;
        foreach(int figure in numbers)
        {
            sum += figure;
        }
        Console.WriteLine($"The sum is {sum}");


        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        
        int max = numbers[0];

        foreach (int figure in numbers)
        {
            if (figure > max)
            {
                max = figure;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
       
}
       
