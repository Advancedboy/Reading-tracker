using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reading_tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            Console.WriteLine(DateTime.Now);

            DateTime date1 = new DateTime(2022, 7, 9, 19, 19, 19); // год - месяц - день - час - минута - секунда
            var dateuntil = date1.Subtract(DateTime.Now);
            Console.WriteLine((int)dateuntil.TotalDays);
            Console.WriteLine();
            Console.WriteLine(date1);
            Console.ReadLine();
        }
    }
}
