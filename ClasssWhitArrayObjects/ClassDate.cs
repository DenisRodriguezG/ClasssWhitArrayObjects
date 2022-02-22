using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasssWhitArrayObjects
{
    internal class ClassDate
    {
        private int month;
        private int day;
        private int year;

        public ClassDate()
        {
            day = 17;
            month = 10;
            year = 1999;
        }
        public void Insert()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("       Enter a date        ");
            Console.WriteLine("---------------------------");
            Console.Write("Enter day: ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Enter month: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Enter year: ");
            year = int.Parse(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }
    }
}
