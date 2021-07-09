using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class Formulas
    {
        public double Percentile(List<int> list,double percentile)
        {
            int N = list.Count;
            double n = (N - 1) * percentile + 1;
            int k = (int)n;
            double d = n - k;
            return list[k - 1] + d * (list[k] - list[k - 1]);
        }
    }
}
