using System;

class Program
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int num1 = 5;
        int num2 = 10;

        Console.WriteLine("Before swap: num1 = " + num1 + ", num2 = " + num2);

        Swap(ref num1, ref num2);

        Console.WriteLine("After swap: num1 = " + num1 + ", num2 = " + num2);
    }
}
