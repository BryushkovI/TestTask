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
            string Path = Console.ReadLine();

            StreamReader sr = new StreamReader(Path);

            List<int> list = new List<int>();
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                list.Add(Convert.ToInt32(line));
            }

            foreach (var e in list) Console.WriteLine(e);

            Console.ReadKey();

            /*
             * упорядочить числа
             * 90 перценталь
             * медиана
             * максимальное значение
             * минимальное значение
             * среднее значение
            */
        }
    }
}
