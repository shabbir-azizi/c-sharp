
namepace hello
{
    o references
    class Program
    {
       o references
        static void main ( straing[]args)
        {
            console.WriteLine("Hellow world");
            console.readline();
        }

    }
}

using System;
using System.Threading;

class DigitalClock
{
    static void Main()
    {
        while (true)
        {
            Console.Clear(); // Clear the console to update the clock display
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss")); // Display current time
            Thread.Sleep(1000); // Wait for 1 second before updating
        }
    }
}
