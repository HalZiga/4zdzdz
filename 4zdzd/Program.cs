using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4zdzd
{
    enum Uroven
    {
        добрый = 1,
        норм = 2,
        злой = 3,
        воплащение_человеческой_злости_накопившейся_за_тысячелетия_существования_нашей_цивилизации = 4,
    }
    struct Ded
    {
        public string name;
        public Uroven lvl;
        public string[] frasi;
        public short sinki;
        public Ded(string Name,Uroven Lvl, string[] Frasi, short Siniki)//ffffffffffffffffffffffffffffзачем это нужно
        {
            this.name = Name;//Зачем это нужно, почему работает без вис, зачем зис, почему он а не я 
            this.lvl = Lvl;
            this.frasi = Frasi;
            this.sinki = Siniki;
        }

    }
    internal class Program
    {
        static short Zad6(Ded ded, params string[] array)//зачем писать деддед 
        {
            foreach (string i in ded.frasi)
            {
                if (array.Contains(i))
                {
                    ded.sinki += 1;
                }
            }
            return ded.sinki;
        }
        static int zadanie(params int[] aray)
        {
            int Sum = 0;
            for (int i = 0; i < aray.Length; i++)
            {
                Sum += aray[i];

            }
            return Sum;
        }
        static void zadanie1(ref int menat, params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                menat *= array[i];
            }
        }
        static void zadanie2(out double sred, params int[] array)
        {
            sred = array.Sum() / array.Length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите коэффиценты a,b,c");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double diskr = Math.Pow(b, 2) - 4 * a * c;
            if (diskr > 0)
            {
                double x1 = (b * (-1) + Math.Sqrt(diskr)) / 2 * a;
                double x2 = (b * (-1) - Math.Sqrt(diskr)) / 2 * a;
                Console.WriteLine("Корни: {0}; {1}", x1, x2);
            }
            else if (diskr == 0)
            {
                double x1 = (b * (-1)) / 2 * a;
                Console.WriteLine("Коренб: " + x1);
            }
            else
            {
                Console.WriteLine("нет вещественных корней");
            }


            Console.WriteLine("Задагие 2");
            Random rand = new Random();
            int[] myArray = new int[20];
            for ( int i = 0; i < 20; i++)
            {
                myArray[i] = rand.Next(0,100);
            }
            Console.WriteLine(string.Join(" ", myArray));
            Console.WriteLine("Выберете числa");
            int index1 = Array.IndexOf(myArray, int.Parse(Console.ReadLine()));
            int index2 = Array.IndexOf(myArray, int.Parse(Console.ReadLine()));
            (myArray[index1], myArray[index2]) = (myArray[index2], myArray[index1]);
            Console.WriteLine(string.Join(" ", myArray));


            Console.WriteLine("Задание 3");
            Console.WriteLine("Сколько чисел будем сортировать?");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа для сортировки:");
            int[] myArra = new int[N];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArra[i] = Convert.ToInt32(Console.ReadLine());//asdfghj
            }
            for (int i = 0; i < myArra.Length; i++)
            {
                for (int j = i + 1; j < myArra.Length; j++)
                {
                    if (myArra[i] > myArra[j])
                    {
                        (myArra[i], myArra[j]) = (myArra[j], myArra[i]);
                    }
                }
            }


            Console.WriteLine("Задание 4");
            int[] Ugaga = { 12, 5};
            Console.WriteLine(zadanie(Ugaga));
            int umnoz = 1;
            zadanie1(ref umnoz, Ugaga);
            Console.WriteLine($"Произведение элементов массива = {umnoz}");
            double sre = 0;
            zadanie2(out sre, Ugaga);//Спросить почему, почему когда я указываю просто zadanie2(Ugaga), VC просит инициализировать out
            Console.WriteLine($"Среднее арифметическое = {sre}");//Почему хотя всё double он выводит int овую воьмёрку
            
            

            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите 1 для начала работы или 0 если не хотите начинать");
            int vkl = int.Parse(Console.ReadLine());
            if (vkl == 1)//Я проверяю хочет ли он чтобы программа работала
            {
                while (vkl == 1)//Чтобы вводить числа до того как не решат закрыть
                {
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Введите число");
                    string chislo = Console.ReadLine().ToLower();
                    if (chislo == "exit" || chislo == "закрыть")
                    {
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        try
                        {
                            string zghj = chislo;
                            int peremen = Convert.ToInt32(zghj);
                            switch (chislo)
                            {
                                case "0":
                                    Console.WriteLine("###" + "\n" + "# #" + "\n" + "# #" + "\n" + "# #" + "\n" + "###");
                                    break;
                                case "1":
                                    Console.WriteLine(" # " + "\n" + " # " + "\n" + " # " + "\n" + " # " + "\n" + "###");
                                    break;
                                case "2":
                                    Console.WriteLine("###" + "\n" + "  #" + "\n" + "  #" + "\n" + "###" + "\n" + "#" + "\n" + "#" + "\n" + "###");
                                    break;
                                case "3":
                                    Console.WriteLine("## " + "\n" + "  #" + "\n" + " # " + "\n" + "  #" + "\n" + "## ");
                                    break;
                                case "4":
                                    Console.WriteLine("# #" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "###");
                                    break;
                                case "5":
                                    Console.WriteLine("###" + "\n" + "#  " + "\n" + "###" + "\n" + "  #" + "\n" + "## ");
                                    break;
                                case "6":
                                    Console.WriteLine(" ##" + "\n" + "#  " + "\n" + "###" + "\n" + "# #" + "\n" + "###");
                                    break;
                                case "7":
                                    Console.WriteLine("###" + "\n" + "  #" + "\n" + "  #" + "\n" + " # " + "\n" + " # ");
                                    break;
                                case "8":
                                    Console.WriteLine("###" + "\n" + "# #" + "\n" + " # " + "\n" + "# #" + "\n" + "###");
                                    break;
                                case "9":
                                    Console.WriteLine("###" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "###");
                                    break;
                        
                                default:
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    Console.WriteLine("Ошибка!!!");
                                    System.Threading.Thread.Sleep(3000);
                                    Console.ResetColor();
                                    Console.Clear();
                                    break;
                            }
                        }
                        catch (NullReferenceException e)
                        {
                            Console.WriteLine(e.Message);
                            Environment.Exit(0);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                            Environment.Exit(0);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Что-то не так");
                            Environment.Exit(0);
                        }
                    }
                }
            }
            else
            {
                System.Environment.Exit(0);
            }


            Console.WriteLine("Задание 7");

            int[] inputArray = { 9, 12, 9, 2, 17, 1, 6 };

            int[] sortedArray = QuickSort(inputArray, 0, inputArray.Length - 1);

            Console.WriteLine($"Sorted array: {string.Join(", ", sortedArray)}");

            Console.ReadLine();


            string[] d1 = { "проституки!", "гады" };
            Ded ded1 = new Ded("Толян Сидоровичыч", (Uroven)1, d1, 0);
            string[] d2 = { "проститутки!", "развратники", "гандон" };
            Ded ded2 = new Ded("Азат Залялетдинов", (Uroven)2, d2, 0);
            string[] d3 = { "проституки!", "гады", "сын бляди!", "уроды", "черти позорные" };
            Ded ded3 = new Ded("Дмитрий Тумач", (Uroven)3, d3, 0);
            string[] d4 = { "проституки!", "хорошая работа олег", "сын бляди!", "уроды", "СЫНОК ТЫ ГРЁБАНЫЙ" };
            Ded ded4 = new Ded("Илья Романов", (Uroven)1, d4, 0);
            string[] d5 = { "проституки!", "любовь моя недосягаема" };
            Ded ded5 = new Ded("Степан Борисов", (Uroven)4, d5, 0);
            string[] slova = { "проституки!", "гады", "отлично", "водка", "пиво", "самогон", "михалыч", "сын бляди!", "уроды", "черти позорные", "СЫНОК ТЫ ГРЁБАНЫЙ" };

            Console.WriteLine("количество синяков от бабки: " + Zad6(ded1, slova));
            Console.WriteLine("количество синяков от бабки: " + Zad6(ded2, slova));
            Console.WriteLine("количество синяков от бабки: " + Zad6(ded3, slova));
            Console.WriteLine("количество синяков от бабки: " + Zad6(ded4, slova));
            Console.WriteLine("количество синяков от бабки: " + Zad6(ded5, slova));

            Console.ReadKey();
        }
        private static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            QuickSort(array, minIndex, pivotIndex - 1);

            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        private static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;

            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);

            return pivot;
        }

        private static void Swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;

            leftItem = rightItem;

            rightItem = temp;
        }
    }
}
