using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumachloh
{
    internal class Program
    {
        static void Zad51(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine("Они равны");
            }
            else if (b < a)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
        static void Zad52(ref int a,ref int b)
        {
            (a, b) = (b, a);
            Console.WriteLine($"{a} {b}");
        }
        static bool Zad53(ref int f)
        {
            int num = 1;
            for (int i = 1; i <= f; i++)
            {
                try
                {
                    checked
                    {
                        num *= i;
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
            f = num;
            return true;
        }
        static void Zad54(int num, int nachal, int fakt)
        {
            num *= nachal;
            if (nachal >= fakt)
            {
                Console.WriteLine($"Фактрориал = {num}");
                return;
            }
            nachal++;
            Zad54(num, nachal, fakt);
        }
        static void Zad512(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }
                
        }
        static void Zad512(int a, int b, int c)
        {
            int Nod = Math.Min(a, Math.Min(b, c));
            for (; Nod > 1; Nod--)
            {
                if (a % Nod == 0 && b % Nod == 0 && c % Nod == 0)
                    break;
            }
            Console.WriteLine("NOD: " + Nod);
        }
        static void Zad522dz(int num, int nachal, int chislo, int fibonach)
        {
            
            if (chislo == fibonach)
            {
                Console.WriteLine(nachal);
                return;
            }
            int sum = num + nachal;
            chislo++;
            Zad522dz(nachal, sum, chislo, fibonach);

        }
            static void Main(string[] args)
        {
            /*Console.WriteLine("тума 5.1");
            Console.WriteLine("Введите а, потом б");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Zad51(a,b);


            Console.WriteLine("тума 5.2");
            Console.WriteLine("Введите а, потом б");
            //Спросить можно ли ввести числа разделить сплитом как-то так(a, b) = int.Parse(Console.ReadLine().Split(' '));
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Zad52(ref a,ref b);


            Console.WriteLine("тума 5.3");
            Console.WriteLine("Введите число");
            int fak = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Zad53(ref fak)}, Факториал = {fak}");

            Console.WriteLine("тума 5.4");
            Console.WriteLine("Введите число");
            int fakt = int.Parse(Console.ReadLine());
            Zad54(1, 1, fakt);


            Console.WriteLine("тума 5.1");
            Console.WriteLine("введите первое число");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("тума 5.1");
            Console.WriteLine("введите первое число");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("введите третье число");
            int j = int.Parse(Console.ReadLine());*/


            Console.WriteLine("введите порядковый номер числа ряда фиббоначи");
            int chislo = int.Parse(Console.ReadLine());
            if (chislo > 48)
            {
                Console.WriteLine("извините программа на такие вычисление не способна");
            }  
            else if (chislo < 0) Console.WriteLine("числа под таким номером не существует");
            else
            {
                Zad522dz(1, 1, 2, chislo);
            }




            /*int y = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            DateTime date1 = new DateTime(y,m,d);
            DateTime date2 = new DateTime(2022, 10, 8);
            Console.WriteLine(date1);
            Console.WriteLine(date2 - date1);*/






            Console.ReadKey();

        }
    }
}
