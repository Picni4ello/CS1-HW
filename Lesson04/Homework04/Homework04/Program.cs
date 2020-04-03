using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{

    //Выполнила Татьяна Гринева

    class Program
    {
        static int GetNumberOfPairs(int[] array, int length)
        {
            int count = 0;
            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        static void Task1()
        {
            int arrayLength = 20;
            int[] myArray = new int[arrayLength];
            Random rnd = new Random();
            int result;

            Console.WriteLine("Данная программа считает количество пар элементов, в которых хотя бы одно число делится на 3.");
            Console.Write("\nВ следующем массиве [ ");
            for (int i = 0; i < arrayLength; i++)
            {
                myArray[i] = rnd.Next(-10000, 10000);
                Console.Write(myArray[i] + ", ");
            }
            Console.WriteLine("\b\b ]\n");

            result = GetNumberOfPairs(myArray, arrayLength);

            Console.WriteLine($"Количество пар: {result}");

            Console.ReadKey();

        }

        static void Task2()
        {
            MyArray a = new MyArray(10);
            MyArray b = new MyArray(10, 0, 10);
            Console.WriteLine($"Пример массива с увеличением каждого последующего элемента на определенное значение: " + b.ToString());
            Console.WriteLine($"\nПример рандомного массива: "+a.ToString());
            Console.WriteLine($"\nМаксимальное число в массиве: "+ a.Max);
            Console.WriteLine($"\nМинимальное число в массиве: " + a.Min);
            Console.WriteLine($"\nКоличество положительных чисел в массиве: " + a.CountPositiv);
            Console.WriteLine($"\nСумма всех элементов массива: " + a.Sum);
            Console.WriteLine($"\nКоличество максимальных элементов массива: " + a.MaxCount);
            Console.WriteLine("\nЗапись массива в файл data.txt");
            a.WriteToFile("data.txt");
            a.Multi = 2;
            Console.WriteLine($"\nУмножение всех элементов массива на 2: " + a.ToString());
            MyArray c = new MyArray("data.txt");
            Console.WriteLine("\nЧтение массива из файла data.txt: " + c.ToString());
            c.Inverse = -1;
            Console.WriteLine("\nИнверсия всех элементов массива: "+ c.ToString());
            

            Console.ReadKey();
        }
        static void Task3()
        {
            /*MyArray x = new MyArray("loginpass.txt");
            Console.WriteLine(x.ToString());
            int MaxCount = 3;
            Console.WriteLine("Реализовать метод проверки логина и пароля.");
            string login, password;

            int count = 0;
            do
            {
                Console.WriteLine("\nВведите логин");
                login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                password = Console.ReadLine();
                for (int i = 0; i < x.Length; i + 2)
                {
                    if (x[i] == login && x[i++] == password);
                    {
                        Console.WriteLine("Доступ разрешен");
                        break;
                    }
                    count++;
                    Console.WriteLine("Доступ запрещен. У вас осталось " + (MaxCount - count) + " попыт" + ((MaxCount - count) == 1 ? "ка" : "ки"));
                }
            }
            while (count <= MaxCount);

                Console.ReadKey();
            */
            
        }

        static int Menu()
        {
            Console.WriteLine("1 - Задание 1");
            Console.WriteLine("2 - Задание 2");
            //Console.WriteLine("3 - Задание 3");
            int m = int.Parse(Console.ReadLine());
            return m;
        }

        static void Main(string[] args)
        {
            int m = Menu();

            switch (m)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                /*case 3:
                    Task2();
                    break;*/

                default:
                    Console.WriteLine("Неверная цифра");
                    break;
            }
        }
    }
}
