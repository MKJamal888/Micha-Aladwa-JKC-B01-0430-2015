using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int n = rand.Next(-100, 100); // Generates a random number between -100 and 100

        int lastDigit = Math.Abs(n) % 10; // Get the last digit of n

        Console.WriteLine("The last digit of the number " + n + " is " + lastDigit + ".");
    }
}
