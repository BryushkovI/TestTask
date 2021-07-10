using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            StreamReader sr;
            double MaxVisitres = 0;
            int NumMaxInterval = 0;
            for(int i = 0; i < 4; i++)
            {
                sr = new StreamReader($"Cash{i + 1}.txt");
                string line;
                List<double> Intervals = new List<double>();
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim('\\','n');
                    Intervals.Add(double.Parse(line));
                    if (MaxVisitres < double.Parse(line))
                    {
                        MaxVisitres = double.Parse(line);
                        NumMaxInterval = Intervals.Count();
                    }
                }
                sr.Close();
            }
            Console.WriteLine(NumMaxInterval + "\n");
            Console.ReadLine();
        }
    }
}
