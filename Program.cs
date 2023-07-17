using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double answ;
            Char oper;

            void sus()
            {
                Console.WriteLine("Type first number");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Type operator");
                oper = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Type second number");
                b = Convert.ToDouble(Console.ReadLine());

                    if (oper == '+')
                    {
                        answ = a + b;
                        Console.Write("Answer is ");
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\n" + answ + "\n");
                        Console.ResetColor();
                    }
                    else if (oper == '-')
                    {
                        answ = a - b;
                        Console.Write("Answer is ");
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\n" + answ + "\n");
                        Console.ResetColor();
                    }
                    else if (oper == '*')
                    {
                        answ = a * b;
                        Console.Write("Answer is ");
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\n" + answ + "\n");
                        Console.ResetColor();
                    }
                    else if (oper == '/')
                    {
                        answ = a / b;
                        Console.Write("Answer is ");
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\n" + answ + "\n");
                        Console.ResetColor();
                    }
                    sus();  
            }
            sus();
           
        }    
    }
}
