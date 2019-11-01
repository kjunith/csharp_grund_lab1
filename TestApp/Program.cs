using System;

namespace TestApp
{
    class Calculator
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double NumberInMemory { get; set; }
            
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

        public double SumNumbers()
        {
            return FirstNumber + SecondNumber;
        }

        public double MultiplyNumbers()
        {
            return FirstNumber * SecondNumber;
        }

        public double SumInBetween()
        {
            double sumInBetween = 0;

            for (int i = (int) FirstNumber; i < (int) SecondNumber; i++)
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
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("1. Add two numbers\n"
                    + "2. Multiply two numbers\n"
                    + "3. Sum the numbers between two numbers\n"
                    + "4. Add number to memory\n"
                    + "5. Clear memory\n"
                    + "6. Print calculator contents\n"
                    + "7. Quit\n");

                Console.Write("Option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        EnterNumbers(calc);
                        Console.WriteLine("{0} + {1} = {2}",
                            calc.FirstNumber, calc.SecondNumber, calc.SumNumbers());
                        break;
                    case "2":
                        EnterNumbers(calc);
                        Console.WriteLine("{0} * {1} = {2}",
                            calc.FirstNumber, calc.SecondNumber, calc.MultiplyNumbers());
                        break;
                    case "3":
                        EnterNumbers(calc);
                        Console.WriteLine("{0} > {1} = {2}",
                            calc.FirstNumber, calc.SecondNumber, calc.SumInBetween());
                        break;
                    case "4":
                            try
                            {
                                Console.Write("Add number to memory: ");
                                calc.NumberInMemory = int.Parse(Console.ReadLine());

                                Console.WriteLine("Number added to memory");
                            }
                            catch (FormatException)
                            {
                                break;
                            }
                            break;
                    case "5":
                            calc.NumberInMemory = 0;
                            Console.WriteLine("Number in memory cleared");
                            break;
                    case "6":
                            Console.WriteLine(calc.ToString());
                            break;
                    case "7":
                            isRunning = false;
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

        public static void EnterNumbers(Calculator calc)
        {
            try
            {
                Console.Write("Enter first number: ");
                calc.FirstNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                calc.SecondNumber = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return;
            }
        }
    }
}
