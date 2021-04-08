using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork8
{
    class Calculator
    {
        public void GetNumbers()
        {
            Console.WriteLine("Enter number 1");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Please enter correct data");
                return;
            };

            Console.WriteLine("Select operation * / - +");
            string symbol = Console.ReadLine();
            if (symbol != "*" && symbol != "/" && symbol != "-" && symbol != "+")
            {
                Console.WriteLine("Please enter correct data");
                return;
            }

            Console.WriteLine("Enter number 2");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Please enter correct data");
                return;
            };

            double result = 0;

            if (symbol == "*")
            {
                result = Multiplication(num1, num2);
                Console.WriteLine($"Result = {result}");
            }
            else if (symbol == "/")
            {
                result = Division(num1, num2);
                Console.WriteLine($"Result = {result}");
            }
            else if (symbol == "-")
            {
                result = Minus(num1, num2);
                Console.WriteLine($"Result = {result}");
            }
            else if (symbol == "+")
            {
                result = Plus(num1, num2);
                Console.WriteLine($"Result = {result}");
            }
            else
            {
                Console.WriteLine("Please enter correct data");
            }
            Console.WriteLine();
        }
        public double Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        public double Division(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
        public double Minus(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        public double Plus(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
    }
    
}
