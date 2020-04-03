using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{
    class MyArray
    {

        int[] a;
        

        /*public MyArray(int n, int el)
        {
                a = new int[n];
                for (int i = 0; i < n; i++)
                    a[i] = el;
        }*/
            // Создание массива и заполнение его случайными числами от min до max
        public MyArray(int n)
        {
                a = new int[n];
                Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(-10000, 10001);
        }
        public MyArray(int n, int firstEL, int step)
        {
            a = new int[n];
            a[0] = firstEL;
            for (int i = 1; i < n; i++)
                a[i] = a[i - 1] + step;
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                    sum += a[i];
                return sum;
            }
        }

        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }

        public int MaxCount
        {
            get
            {
                int max = Max;
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] == max) count++;
                return count;
            }
        }

        public int Length
        {
            get;
            
        }
        public int Inverse
        {
            set
            {
                for (int i = 0; i < a.Length; i++)
                    a[i] = a[i] * -1;
               
            }
        }


        public int Multi
        {
            set
            {
                for (int i = 0; i < a.Length; i++)
                    a[i] = a[i] * value;
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
        public MyArray(string filename)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filename);
                int n = int.Parse(sr.ReadLine());
                List<string> list = new List<string>();
                for (int i = 0; i < n; i++)
                    list.Add(sr.ReadLine());
                a = new int[n];
                for (int i = 0; i < n; i++)
                    a[i] = int.Parse(list[i]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr?.Close();
            }
        }



        public void WriteToFile(string filename)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(filename);
                sw.WriteLine(a.Length.ToString());
                foreach (int element in a)
                    sw.WriteLine(element);

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                if (sw != null) sw.Close();
                //sw?.Close();
            }
        }
    }
    
}
