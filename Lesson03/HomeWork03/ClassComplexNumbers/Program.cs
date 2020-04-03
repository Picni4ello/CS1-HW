using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassComplexNumbers
{

    //Выполнила Татьяна Гринева

    class Program
    { 
    struct Complex
    {
        public double im;
        public double re;
        // в C# в структурах могут храниться также действия над данными
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        // Пример произведения двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        //Вычитание двух комплексных чисел
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;

        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    static void Task1()
    {

        Complex complex1;
        complex1.re = 1;
        complex1.im = 1;
        Complex complex2;
        complex2.re = 2;
        complex2.im = 2;
        Complex result = complex1.Plus(complex2);
        Console.WriteLine(result.ToString());
        result = complex1.Multi(complex2);
        Console.WriteLine(result.ToString());
        result = complex1.Minus(complex2);
        Console.WriteLine(result.ToString());



        CComplex CComplex2;
        CComplex2 = new CComplex(1, 1);
        CComplex CComplex3 = new CComplex(2, 2);
        CComplex3.Im = 3;
        CComplex result1;
        result1 = CComplex2.Plus(CComplex3);
        Console.WriteLine(result1.ToString());
        result1 = CComplex2.Multi(CComplex3);
        Console.WriteLine(result1.ToString());
        result1 = CComplex2.Minus(CComplex3);
        Console.WriteLine(result1.ToString());

            Console.ReadKey();

    }
    static void Task2()
    {
        int num, count = 0, sum = 0;
        bool flag;

        do
        {
                do
                {
                    Console.WriteLine("Введите число");
                    flag = int.TryParse(Console.ReadLine(), out num);
                    if (flag == false) Console.WriteLine("Неверный ввод числа");
                }
                while (!flag); //(flag == false);
                //return num;
                
                if (num % 2 != 0 && num > 0)
                        {
                    count++;
                    sum += num;
                }

        }
        while (num != 0);

        Console.WriteLine("Сумма положительных нечетных чисел = " + sum);
        Console.ReadKey();


    }
        
        static int Menu()
        {
            Console.WriteLine("1 - Задание 1");
            Console.WriteLine("2 - Задание 2");
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
