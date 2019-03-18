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

            Console.WriteLine("Which function would you like to use? (Choices are: Add, Subtract, Multiply, Divide)");
            command = Console.ReadLine();
            command = command.ToUpper();
            Console.Clear();

            if(command == "ADD" || command == "AD" || command == "PLUS")
            {
                Console.WriteLine("ADD");
                Console.WriteLine();
                Console.WriteLine("Input two numbers:");
                Int32.TryParse(Console.ReadLine(), out valueOne);
                Int32.TryParse(Console.ReadLine(), out valueTwo);
                Console.WriteLine();

                int answer = Add(valueOne, valueTwo);
                Console.WriteLine($"The sum of {valueOne} and {valueTwo} is {answer}.");
            }

            if (command == "SUBTRACT" || command == "SUB" || command == "MINUS")
            {
                Console.WriteLine("SUBTRACT");
                Console.WriteLine();
                Console.WriteLine("Input two numbers:");
                Int32.TryParse(Console.ReadLine(), out valueOne);
                Int32.TryParse(Console.ReadLine(), out valueTwo);
                Console.WriteLine();

                int answer = Subtract(valueOne, valueTwo);
                Console.WriteLine($"The difference of {valueOne} and {valueTwo} is {answer}.");
            }

            if (command == "MULTIPLY" || command == "TIMES")
            {
                Console.WriteLine("MULTIPLY");
                Console.WriteLine();
                Console.WriteLine("Input two numbers:");
                Int32.TryParse(Console.ReadLine(), out valueOne);
                Int32.TryParse(Console.ReadLine(), out valueTwo);
                Console.WriteLine();

                int answer = Multiply(valueOne, valueTwo);
                Console.WriteLine($"The product of {valueOne} and {valueTwo} is {answer}.");
            }

            //if (command == "DIVIDE" || command == "DIVIDE BY")
            //{
            //    Divide(valueOne, valueTwo);
            //}

            Console.WriteLine();
            Console.WriteLine("Press enter to close");
            Console.ReadLine();

        }

        public static int Add(int valueOne, int valueTwo)
        {
            return valueOne + valueTwo;
        }

        public static int Subtract(int valueOne, int valueTwo)
        {
            return valueOne - valueTwo;
        }

        public static int Multiply(int valueOne, int valueTwo)
        {
            return valueOne * valueTwo;
        }


    }
}
