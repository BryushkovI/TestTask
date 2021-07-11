using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.ReadLine());
            Methods methods = new Methods();
            List<Visiter> visiters = new List<Visiter>();
            string line; // объявляем строку
            while ((line = sr.ReadLine()) != null)
            {
                visiters.Add(methods.newVisiter(line)); // парсим посетителей из каждой строки
            }
            sr.Close();
            Dictionary<DateTime, int> dayDict = new Dictionary<DateTime, int>();
            for (DateTime i = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 8, 00, 00);
                          i <= new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 20, 00, 00);
                          i = i.AddMinutes(1))
                dayDict.Add(i, 0);
            foreach(Visiter e in visiters)
            {
                for(DateTime i = e.EnterTime; i < e.LeaveTime; i = i.AddMinutes(1))
                {
                    dayDict[i]++;
                }
            }
            int MaxVisiters = dayDict.Values.Max();
            List<DateTime> AnswerList = new List<DateTime>();
            for(int i = 1; i < dayDict.Count(); i++)
            {
                if(dayDict.ElementAt(i).Value == MaxVisiters || dayDict.ElementAt(i-1).Value == MaxVisiters)
                {
                    if (dayDict.ElementAt(i).Value != dayDict.ElementAt(i - 1).Value)
                        AnswerList.Add(dayDict.ElementAt(i).Key);
                    else continue;
                }
            }
            for(int i = 0;i < AnswerList.Count; i += 2)
            {
                Console.WriteLine($"{AnswerList[i]:t} {AnswerList[i+1]:t}\n");
            }
            Console.ReadKey();
        }
    }
}
