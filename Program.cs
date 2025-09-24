using System;
using System.Threading;

public class Countdown
{
    public static void Main(string[] args)
    {

        Console.Write("Hey Enter your Name: ");
        string username = Console.ReadLine();

        for (int i = 5; i >= 0; i--)
        {
            Console.WriteLine(i);

            if (i == 5)
            {
                Thread.Sleep(500);
            }

            else
            {
                Thread.Sleep(1000);
            }
          

        }
        Console.WriteLine($"Welcome {username}");
    }


}