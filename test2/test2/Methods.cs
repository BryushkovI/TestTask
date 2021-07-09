using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public class Methods
    {
        public Point NewPoint(string line)
        {
            double x = double.Parse(line.Split(' ')[0]);
            double y = double.Parse(line.Split(' ')[1].Trim('\\', 'n'));
            return new Point() { X = x, Y = y };
        }
    }
}