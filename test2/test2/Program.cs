using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string Path = Console.ReadLine(); //указываем ссылку на текстовый файл с координатами четырехуголника

            StreamReader sr = new StreamReader(Path);

            List<string> LineList = new List<string>();// неупорядоченный список

            string line; // объявляем строку
            while ((line = sr.ReadLine()) != null) LineList.Add(line); //парсим каждую строку, добавляем в список
            sr.Close();
            sr = new StreamReader(Console.ReadLine());
            string point_line;
            List<string> PointsLineList = new List<string>();
            while ((point_line = sr.ReadLine()) != null) PointsLineList.Add(point_line);
            sr.Close();
            Methods methods = new Methods();
            List<Point> QuadCoords = new List<Point>();
            foreach(var e in LineList)
            {
                QuadCoords.Add(methods.NewPoint(e));
            }
            
            List<Point> points = new List<Point>();
            foreach(var e in PointsLineList)
            {
                points.Add(methods.NewPoint(e));
            }
            foreach (var e in points)
            {
                Console.WriteLine(methods.Answer(QuadCoords, e));
            }
            Console.ReadKey();
            
        }
    }
}
