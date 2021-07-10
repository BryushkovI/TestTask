using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public class Methods
    {
        /// <summary>
        /// Создание новой точки
        /// </summary>
        /// <param name="line">Строка содержащая координаты новой точки</param>
        /// <returns></returns>
        public Point NewPoint(string line)
        {
            double x = double.Parse(line.Split(' ')[0]);
            double y = double.Parse(line.Split(' ')[1].Trim('\\', 'n'));
            return new Point() { X = x, Y = y };
        }
        /// <summary>
        /// Расчет площади четырехуголника
        /// </summary>
        /// <param name="QuadCoord">Список координат четырехуголника</param>
        /// <returns></returns>
        public double QuadArea(List<Point> QuadCoord)
        {
            return 0.5 * Math.Abs((QuadCoord[0].X * QuadCoord[1].Y - QuadCoord[1].X * QuadCoord[0].Y) +
                                  (QuadCoord[1].X * QuadCoord[2].Y - QuadCoord[2].X * QuadCoord[1].Y) +
                                  (QuadCoord[2].X * QuadCoord[3].Y - QuadCoord[3].X * QuadCoord[2].Y) +
                                  (QuadCoord[3].X * QuadCoord[0].Y - QuadCoord[0].X * QuadCoord[3].Y));
        }

        public double SumTriangArea(List<Point> QuadCoord, Point point)
        {
            double SumArea = 0;
            for(int i = 1; i < 4; i++)
            {
                SumArea += Math.Abs((QuadCoord[i-1].X - point.X) * (QuadCoord[i].Y - point.Y) - (QuadCoord[i].X - point.X) * QuadCoord[i-1].Y - point.Y);
            }
            return SumArea;
        }
        public int Answer(List<Point> QuadCoord, Point point)
        {
            double SquareArea = Math.Round(QuadArea(QuadCoord),2);
            double TrianglesAreas = Math.Round(SumTriangArea(QuadCoord, point), 2);
            foreach(var e in QuadCoord)
            {
                if (point.X == e.X && point.Y == e.Y) return 0;
            }
            if (Math.Round(QuadArea(QuadCoord),2) == Math.Round(SumTriangArea(QuadCoord, point),2)) return 2;
            else if(QuadArea(QuadCoord) > SumTriangArea(QuadCoord, point)) return 3;
            else  return 1;
        }
    }
}