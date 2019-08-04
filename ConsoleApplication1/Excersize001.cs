using System;

namespace ConsoleApplication1
{
    class Program
    {
        // This is the start of your program
        // This is the entry point to your program
        // This is the main method

        static void topOfASCII() // Prints the top of the ASCII STOP sign
        {
            Console.WriteLine(" _____  ");
            Console.WriteLine(" /     \\ ");
            Console.WriteLine("/       \\");
        }

        static void bottomOfASCII() // Prints the bottom of the ASCII STOP sign
        {
            Console.WriteLine("\\       /");
            Console.WriteLine(" \\_____/ ");
        }

        static void plusASCII()
        {
            Console.WriteLine("+-------+"); // Prints the + and - characters for the very bottom of the ASCII stop sign
        }

        static void stopASCII()
        {
            Console.WriteLine("|  STOP |"); // Prings the STOP and sides of the ASCII STOP sign
        }

        static void Main(string[] args) // Main method that requires 3 inputs to get all of the ASCII art, 1 sign at a time
        { // body
            Console.ReadKey();
            topOfASCII();
            bottomOfASCII();
            Console.ReadKey();

            topOfASCII();
            bottomOfASCII();
            plusASCII();
            Console.ReadKey();

            topOfASCII();
            stopASCII();
            bottomOfASCII();
            plusASCII();
            Console.ReadKey();
        }
    }
}
