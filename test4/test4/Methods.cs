using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    public class Methods
    {
        public Visiter newVisiter(string line)
        {
            DateTime Enter = DateTime.Parse(line.Split(' ')[0]);
            DateTime Leave = DateTime.Parse(line.Split(' ')[1].Trim('\\', 'n'));
            return new Visiter()
            {
                EnterTime = Enter,
                LeaveTime = Leave
            };
        }
    }
}
