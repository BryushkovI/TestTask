using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Formulas formulas = new Formulas();
            string Path = Console.ReadLine(); //указываем ссылку на текстовый файл

            StreamReader sr = new StreamReader(Path);

            List<int> list = new List<int>();// неупорядоченный список

            string line; // объявляем строку
            while ((line = sr.ReadLine()) != null) list.Add(Convert.ToInt32(line)); //парсим каждую строку, добавляем в список

            Console.WriteLine(string.Format("{0:f2}", formulas.Percentile(list, 0.9)));

            Console.ReadKey();

            /*
             * 90 перценталь
             * медиана
             * максимальное значение
             * минимальное значение
             * среднее значение
            */
        }
    }
}
