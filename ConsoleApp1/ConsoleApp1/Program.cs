using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueOne;
            int valueTwo;
            string command;
            //string upperCommand;

            Console.WriteLine("Which function would you like to use? (Choices are: Add, Subtract, Multiply, Divide)");
            command = Console.ReadLine();
            command = command.ToUpper();
            Console.Clear();

            Console.WriteLine(command);
            Console.WriteLine();
            Console.WriteLine("Input two numbers:");
            Int32.TryParse(Console.ReadLine(), out valueOne);
            Int32.TryParse(Console.ReadLine(), out valueTwo);

            if(command == "ADD" || command == "AD" || command == "PLUS")
            {
                Add(valueOne, valueTwo);
            }

            if (command == "SUBTRACT" || command == "SUB" || command == "MINUS")
            {
                Subtract(valueOne, valueTwo);
            }

            if (command == "MULTIPLY" || command == "TIMES")
            {
                Multiply(valueOne, valueTwo);
            }

            if (command == "DIVIDE" || command == "DIVIDE BY")
            {
                Divide(valueOne, valueTwo);
            }

        }

        public static int Add(int valueOne, int valueTwo)
        {

        }
    }
}
