using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassComplexNumbers
{
    class CComplex
    {
        // Поля приватные.
        private double im;
        // По умолчанию элементы приватные, поэтому private можно не писать.
        double re;
        // Конструктор без параметров.
        public CComplex()
        {
            im = 0;
            re = 0;
        }
        // Конструктор, в котором задаем поля.
        // Специально создадим параметр re, совпадающий с именем поля в классе.
        public CComplex(double _im, double re)
        {
            // Здесь имена не совпадают, и компилятор легко понимает, что чем является.
            im = _im;
            // Чтобы показать, что к полю нашего класса присваивается параметр,
            // используется ключевое слово this 
            // Поле параметр
            this.re = re;
        }
        public CComplex Plus(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = im + x2.im;
            x3.re = re + x2.re;
            return x3;
        }
        public CComplex Minus(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }
        public CComplex Multi(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = re*x2.im + im*x2.re;
            x3.re = re*x2.re -im*x2.im;
            return x3;
        }

        // Свойства - это механизм доступа к данным класса.
        public double Im
        {
            get { return im; }
            set
            {
                // Для примера ограничимся только положительными числами.
                if (value >= 0) im = value;
            }
        }
        // Специальный метод, который возвращает строковое представление данных.
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

}
