using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char eche = '+';
            while (eche == '+')
            {
                double a;
                double b;
                double rez;
                char oper;

                Console.WriteLine("Введите число a:");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите желаемую операцию(+,-,*,/):");
                oper = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Введите число b:");
                b = Convert.ToDouble(Console.ReadLine());

                if (oper == '+')
                {
                    rez = a + b;
                    Console.WriteLine("Cумма " + a + " и " + b + " равна " + rez + ".");
                }

                else if (oper == '-')
                {
                    rez = a - b;
                    Console.WriteLine("Разность " + a + " и " + b + " равна " + rez + ".");
                }

                else if (oper == '*')
                {
                    rez = a * b;
                    Console.WriteLine("Умножение " + a + " на " + b + " равно " + rez + ".");
                }

                else if (oper == '/')
                {
                    rez = a / b;
                    Console.WriteLine("Деление " + a + " на " + b + " равно " + rez + ".");
                }
                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (+,other)");
                eche = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
