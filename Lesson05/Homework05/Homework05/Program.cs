using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Homework05
{
    class Program
    {
        // Выполнила Гринева Татьяна

        //Метод проверки на соответствие логина требованиям без регулярных выражений
        static bool CheckLogin(string login)
        {
            int length = login.Length;
            if (length >= 2 && length <= 10)
            {
                bool check = true;
                char letter = login[0];
                if (Char.IsDigit(letter))
                    return false;
                for (int i = 1; i < length; i++)
                {
                    letter = login[i];
                    if (!(Char.IsDigit(letter) || IsLatinLetter(letter)))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    return true;
            }
            return false;
        }

        //Метод проверки на соответствие логина требованиям через регулярные выражения
     
        static bool CheckLoginReg(string login)
        {
            char letter = login[0];
            if (Char.IsDigit(letter))
                return false;
            if (!Regex.IsMatch(login, @"^[a-zA-Z0-9]+${2,10}"))
                return false;
            return true;
        }

        
        private static bool IsLatinLetter(char letter)
        {
            int num = letter;
            if ((num >= 65 && num <= 90) || (num >= 97 && num <= 122))
                return true;
            else
                return false;
        }

        static void Task1()
        {

            int MaxCount = 3;
            Console.WriteLine("Программа проверки правильности ввода логина");
            string login;
            int count = 0;
            do
            {
                Console.WriteLine("\nВведите логин");
                login = Console.ReadLine();
                if (CheckLogin(login) && CheckLoginReg(login))
                {
                    Console.WriteLine("Введен правильный логин");
                    break;
                }
                count++;
                Console.WriteLine("Неверный ввод. \nДолжны быть соблюдены следующие условия:"
                        + "\nлогин должен быть не менее 2 и не более 10 символов;"
                        + "\nможно использовать только буквы латинского алфавита или цифры;"
                        + "\nцифра не может быть первой. \nУ вас осталось " + (MaxCount - count) + " попыт" + ((MaxCount - count) == 1 ? "ка" : "ки"));
            }
            while (count <= MaxCount);

            Console.ReadKey();
        }
        static void Task2()
        {
            Console.WriteLine("Программа демонстрации возможностей статического класса Message.");

            
            Console.WriteLine("\nИмеется следующий текст: \n"+Message.text);
            Console.WriteLine("\nВыведем слова текста, которые содержат не более 5 букв:");
            Message.GetWordsByLength(5);

            Console.WriteLine();
            Console.Write("\nУдалим из текста слова, заканчивающиеся на 'я': ");
            Message.DeleteWordByEndChar('я');

            Console.WriteLine();
            Console.WriteLine("\nСамое длинное слово в тексте: " + Message.FindMaxLengthWord());


            Console.WriteLine("\nСформированная строка StringBuilder из самых длинных слов сообщения: \n" + Message.GetLongWordsString());

            Console.WriteLine("\nПроизведём частотный анализ текста: ");
            string[] arr = {"модель", "новая", "степени", "опыт", "проект"};
            Message.FrequencyAnalysis(arr, Message.text);

            Console.ReadKey();
        }
        
        static int Menu()
        {
            Console.WriteLine("1 - Программа проверки правильности логина");
            Console.WriteLine("2 - Демонстрация работы класса Messsage");
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

                default:
                    Console.WriteLine("Неверная цифра");
                    break;
            }
        }
    }
}
