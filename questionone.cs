using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int n = rand.Next(-100, 100); // Generates a random number between -100 and 100

        if (n > 0)
        {
            Console.WriteLine("The number " + n + " is positive.");
        }
        else if (n < 0)
        {
            Console.WriteLine("The number " + n + " is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}
