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

            //Asks user for input of which command they would like to run
            Console.WriteLine("Which function would you like to use? (Choices are: Add, Subtract, Multiply, Divide)");
            command = Console.ReadLine();
            command = command.ToUpper();
            Console.Clear();

            //Runs the command the user chose
            if(command == "ADD" || command == "AD" || command == "PLUS" || command == "+")
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

            else if (command == "SUBTRACT" || command == "SUB" || command == "MINUS" || command == "-")
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

            else if (command == "MULTIPLY" || command == "TIMES" || command == "*")
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

            else if (command == "DIVIDE" || command == "DIVIDE BY" || command == "/")
            {
                Console.WriteLine("DIVIDE");
                Console.WriteLine();
                Console.WriteLine("Input two numbers:");
                Int32.TryParse(Console.ReadLine(), out valueOne);
                Int32.TryParse(Console.ReadLine(), out valueTwo);
                Console.WriteLine();

                double answer = Divide(valueOne, valueTwo);
                Console.WriteLine($"The quotent of {valueTwo} and {valueOne} is {answer}.");
            }

            //If command is not recognized
            else
            {
                Console.WriteLine("Not a valid command.");
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to close.");
            Console.ReadLine();
        }

        //Add helper method
        public static int Add(int valueOne, int valueTwo)
        {
            return valueOne + valueTwo;
        }

        //Subtract helper method
        public static int Subtract(int valueOne, int valueTwo)
        {
            return valueOne - valueTwo;
        }

        //Multiply helper method
        public static int Multiply(int valueOne, int valueTwo)
        {
            return valueOne * valueTwo;
        }

        //Divide helper method
        public static double Divide(double valueOne, double valueTwo)
        {
            return valueTwo / valueOne;
        }
    }
}
