using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegates
{
    
 
        public delegate int ArithmeticOperation(int a, int b);

        class Program
        {
            static int Add(int a, int b)
            {
                return a + b;
            }

            static int Subtract(int a, int b)
            {
                return a - b;
            }

            static int Multiply(int a, int b)
            {
                return a * b;
            }

            static int Divide(int a, int b)
            {
                if (b != 0)
                    return a / b;
                else
                {
                    Console.WriteLine("Cannot divide by zero!");
                    return 0;
                }
            }

            static void Main(string[] args)
            {
                ArithmeticOperation addOperation = new ArithmeticOperation(Add);
                ArithmeticOperation subtractOperation = new ArithmeticOperation(Subtract);
                ArithmeticOperation multiplyOperation = new ArithmeticOperation(Multiply);
                ArithmeticOperation divideOperation = new ArithmeticOperation(Divide);

                Console.WriteLine("Enter two integers:");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Choose an arithmetic operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");

                int choice = int.Parse(Console.ReadLine());

                int result = 0;
                switch (choice)
                {
                    case 1:
                        result = addOperation(num1, num2);
                        break;
                    case 2:
                        result = subtractOperation(num1, num2);
                        break;
                    case 3:
                        result = multiplyOperation(num1, num2);
                        break;
                    case 4:
                        result = divideOperation(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                Console.WriteLine($"Result: {result}");

                Console.ReadKey();
            }
        }
    }

