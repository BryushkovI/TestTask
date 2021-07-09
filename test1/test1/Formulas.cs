using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class Formulas
    {
        /// <summary>
        /// расчет перцентиля
        /// </summary>
        /// <param name="list">Упорядоченный список чисел</param>
        /// <param name="percentile">значение перцентиля</param>
        /// <returns></returns>
        public double Percentile(List<int> list,double percentile)
        {
            int N = list.Count;
            double n = (N - 1) * percentile + 1;
            int k = (int)n;
            double d = n - k;
            return list[k - 1] + d * (list[k] - list[k - 1]);
        }
        /// <summary>
        /// Поиск медианы
        /// </summary>
        /// <param name="list">Упорядоченный список значений</param>
        /// <returns></returns>
        public double Mediana(List<int> list)
        {
            if (list.Count % 2 == 0)
            {
                return Convert.ToDouble(list[list.Count() / 2] + list[list.Count()/2-1])/2;
            }
            else
            {
                return list[list.Count() / 2];
            }
        }
    }
}
