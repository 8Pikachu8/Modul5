using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Modul5
{
    internal class StudyingMethods
    {

        public void CreateUser()
        {
            (string? name, string?[] Dishes) User;
            Console.Write("Введите имя ");
            User.name = Console.ReadLine();

            User.Dishes = new string[5];
            Console.WriteLine("Введите 5 любимых блюд ");
            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.Write("Блюдо номер {0}: ", i);
                User.Dishes[i] = Console.ReadLine();
            }

            Console.WriteLine("Ваше имя {0} ", User.name);
            Console.WriteLine("Ваши любимые блюда:");
            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.Write("Блюдо номер {0}: ", i);
                Console.WriteLine(User.Dishes[i]);
            }
        }

        internal static string ShowColor(string username, int userage)
        {
            Console.WriteLine("{0}, {1} лет \nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }

        internal static void Anketa()
        {

            (string name, int age) anketa;

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            string?[] favColors = new string?[3];

            for (int i = 0; i < favColors.Length; i++)
            {
                favColors[i] = ShowColor(anketa.name, anketa.age);
            }

            Console.ReadKey();

        }

        static void ShowColors(string[] favcolors)
        {
            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }

        internal static int[] GetArrayFromConsole(ref int lenght)
        {
            lenght = 6;
            var result = new int[lenght];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        internal static void SortArray(in int[] arr, out int[] sorteddesc, out int[] sortedasc)
        {
            
            sorteddesc = SortArrayDesc(arr);

            sortedasc = SortArrayAsc(arr);
        }

        internal static int[] SortArrayDesc(int[] arr2)
        {
            int[] arr = (int[])arr2.Clone();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int q = i + 1; q < arr.Length; q++)
                {
                    if (arr[i] < arr[q])
                    {
                        int temp = arr[q];
                        arr[q] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            return arr;
        }

        internal static int[] SortArrayAsc(int[] arr2)
        {
            int[] arr = (int[])arr2.Clone();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int q = i + 1; q < arr.Length; q++)
                {
                    if (arr[i] > arr[q])
                    {
                        int temp = arr[q];
                        arr[q] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            return arr;
        }

        internal static void ShowArray(int[] arr, bool sort)
        {
            if(sort) 
               SortArray(arr, out int[] sorteddesc, out int[] sortedasc);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        internal static void Echo(string saidworld, int deep)
        {
            string modif = saidworld;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }

            Console.WriteLine("..."+modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }

        internal static int PowerUp(int N, byte pow)
        {
            if(pow == 0)
            {
                return 1;
            }
            else
            {
                return N * PowerUp(N, (byte)(pow - 1));
            }
        }
    }
}
