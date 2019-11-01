using System;

namespace TestApp
{
    class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int NumberInMemory { get; set; }
            
        public Calculator()
        {
            this.FirstNumber = 0;
            this.SecondNumber = 0;
            this.NumberInMemory = 0;
        }

        public override string ToString()
        {
            return string.Format("Firstumber: {0}\n"
                + "SecondNumber: {1}\n"
                + "NumberInMemory: {2}",
                FirstNumber, SecondNumber, NumberInMemory);
        }

        public int SumNumbers()
        {
            return FirstNumber + SecondNumber;
        }

        public int MultiplyNumbers()
        {
            return FirstNumber * SecondNumber;
        }

        public int SumInBetween()
        {
            int sumInBetween = 0;

            for (int i = FirstNumber; i < SecondNumber; i++)
            {
                sumInBetween += i;
            }

            return sumInBetween;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int option = 0;

            while (option != -1)
            {
                Console.WriteLine("1. Add two numbers\n"
                    + "2. Multiplay two numbers\n"
                    + "3. Sum the numbers between two numbers\n"
                    + "4. Add number to memory\n"
                    + "5. Clear memory\n"
                    + "6. Print calculator contents\n"
                    + "7. Quit\n");

                Console.Write("Option: ");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.Write("Enter first number: ");
                        calc.FirstNumber = int.Parse(Console.ReadLine());

                        Console.Write("Enter second number: ");
                        calc.SecondNumber = int.Parse(Console.ReadLine());

                        Console.WriteLine("{0} + {1} = {2}",
                            calc.FirstNumber, calc.SecondNumber, calc.SumNumbers());
                        break;
                    case 2:
                        Console.Write("Enter first number: ");
                        calc.FirstNumber = int.Parse(Console.ReadLine());

                        Console.Write("Enter second number: ");
                        calc.SecondNumber = int.Parse(Console.ReadLine());

                        Console.WriteLine("{0} * {1} = {2}",
                            calc.FirstNumber, calc.SecondNumber, calc.MultiplyNumbers());
                        break;
                    case 3:
                        Console.Write("Enter first number: ");
                        calc.FirstNumber = int.Parse(Console.ReadLine());

                        Console.Write("Enter second number: ");
                        calc.SecondNumber = int.Parse(Console.ReadLine());

                        Console.WriteLine("{0} > {1} = {2}",
                            calc.FirstNumber, calc.SecondNumber, calc.SumInBetween());
                        break;
                    case 4:
                        Console.Write("Add number to memory: ");
                        calc.NumberInMemory = int.Parse(Console.ReadLine());

                        Console.WriteLine("Number added to memory");
                        break;
                    case 5:
                        calc.NumberInMemory = 0;
                        Console.WriteLine("Number in memory cleared");
                        break;
                    case 6:
                        Console.WriteLine(calc.ToString());
                        break;
                    case 7:
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Press any key...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
