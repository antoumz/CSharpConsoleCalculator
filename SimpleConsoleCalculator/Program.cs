using System;

namespace SimpleConsoleCalculator
{

    class MainProgram
    {
        static void Main(string[] args)
        {
            double num1, num2;
            int opcion = 0; 
            do
            {
                Console.Write("Enter the first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("------------------------");
                Console.WriteLine("Select an Operation:");
                Console.WriteLine("1. To Add");
                Console.WriteLine("2. To Substract");
                Console.WriteLine("3. To Multiply");
                Console.WriteLine("4. To Divide");
                Console.WriteLine("5. Exit");
                Console.WriteLine("------------------------");

                Console.Write("Enter your choice: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ToAdd(num1, num2);
                        Console.WriteLine();
                        break;
                    case 2:
                        ToSubstract(num1, num2);
                        Console.WriteLine();
                        break;
                    case 3:
                        ToMultiply(num1, num2);
                        Console.WriteLine();
                        break;
                    case 4:
                        ToDivide(num1, num2);
                        Console.WriteLine();
                        break;
                    case 5:
                        break;
                }
            } while (opcion !=5);
        }
       

        public static void ToAdd(double num1, double num2)
        {
            double answer = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {answer}");
            Console.ReadKey();
        }

        public static void ToSubstract(double num1, double num2)
        {
            double answer = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {answer}");
            Console.ReadKey();
        }
        public static void ToMultiply(double num1, double num2)
        {
            double answer = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {answer}");
            Console.ReadKey();
        }
        public static void ToDivide(double num1, double num2)
        {
            double answer = num1 / num2;
            if (num2 != 0)
            {
                Console.WriteLine($"{num1} / {num2} = {answer}");
            }
            else
            {
                Console.WriteLine("Math Error!");
            }
            Console.ReadKey();
        }

    }
}