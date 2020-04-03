using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework02_01
{
    //Выполнила Татьяна Гринева

    class Program
    {
        static int Min(int a, int b, int c)
        {
            int min;
            if (a < b && a < c)
            {
                min = a;
            }
            else if (b < a && b < c)
            {
                min = b;
            }
            else
            {
                min = c;
            }
            return min;
        } 

        static void Task1()
        {
            Console.WriteLine("Вычисление минимального из трех чисел");
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Min(a,b,c));

            Console.ReadKey();
        }


        
        static void Task2()
        {
            Console.WriteLine("Подсчет количества цифр в числе");
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (a != 0)
                {count ++;
            a=a/10;
            }
            Console.WriteLine(count);

            Console.ReadKey();


        }

        static void Task3()
        {
        Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
            int a, count = 0;
            do{
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
                if (a%2 != 0 && a > 0)
                    count ++; 
                }
                while (a != 0);         

            Console.WriteLine("Количество положительных нечетных чисел = " +count);
            Console.ReadKey();
        }

        static void Task4()
            {
            int MaxCount = 3;
            Console.WriteLine("Реализовать метод проверки логина и пароля.\n На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел\n (Логин: root, Password: GeekBrains).\n Используя метод проверки логина и пароля, написать программу:\n пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.\n С помощью цикла do while ограничить ввод пароля тремя попытками");
            string login, password;
            int count = 0;
            do{
            Console.WriteLine("\nВведите логин");
                login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                password = Console.ReadLine();
                if (login == "root" && password == "Geekbrains")
                    {
                    Console.WriteLine("Доступ разрешен");
                break;}
                count++;
                Console.WriteLine("Доступ запрещен. У вас осталось "+(MaxCount-count)+" попыт"+((MaxCount-count)==1 ? "ка": "ки"));
                }
                while (count <=MaxCount);
                     
            Console.ReadKey();
            }           
        
         static void Task5()
            {
            //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

            Console.WriteLine("Введите Ваш рост в сантиметрах?");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сколько Вы весите, в кг?");
            double weight = Convert.ToDouble(Console.ReadLine());
            double IMT = weight / Math.Pow(height / 100, 2);
            if (IMT < 18.5)
                Console.WriteLine($"Ваш индекс массы тела равен {IMT:F2}. Вам нужно обратить внимание на здоровье и набрать хотя бы {(weight-18.5*Math.Pow(height/100, 2))*(-1):F0} кг.");
            else if (IMT > 25)
                Console.WriteLine($"Ваш индекс массы тела равен {IMT:F2}. Вам нужно обратить внимание на здоровье и похудеть хотя бы на {weight-25*Math.Pow(height/100, 2):F0} кг.");
            else
            Console.WriteLine($"Поздравляем! Ваш индекс массы тела равен {IMT:F2}. Вы в прекрасной форме!");
            Console.ReadKey();
            } 

        static int Menu()
        {
            Console.WriteLine("1 - Задание 1");
            Console.WriteLine("2 - Задание 2");
            Console.WriteLine("3 - Задание 3");
            Console.WriteLine("4 - Задание 4");
            Console.WriteLine("5 - Задание 5");
            //Console.WriteLine("6 - Задание 6");
            //Console.WriteLine("7 - Задание 7");
            int m = int.Parse(Console.ReadLine());
            return m;
        }

        static void Main(string[] args)
        {
            int m=Menu();
             
            switch(m)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3: Task3();
                    break;
                case 4: Task4();
                    break;
                case 5: Task5();
                    break;
                //case 6: Task6();
                    //break;
                //case 7: Task7();
                    //break;

                default:
                    Console.WriteLine("Неверная цифра");
                    break;
            }
        }
    }
}
