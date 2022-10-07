using System;
using System.Collections.Generic;
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
        static void Main(string[] args)
        {
            Console.WriteLine("тума 5.1");
            Console.WriteLine("Введите а, потом б");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            //Zad51(a,b);


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


            


            Console.ReadKey();

        }
    }
}
