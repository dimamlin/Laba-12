using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_12
{
    class Time
    {
        public string Month;
        public int Year;
        public int Day;


        public Time(string Month, int Year, int Day)
        {
            this.Month = Month;
            this.Year = Year;
            this.Day = Day;
        }

        public static void TestPrint(string t1, int t2, int t3)
        {
            Console.WriteLine("Я родился в" + " " + t1 + " " + "это был" + " " + t3 + " " + "год " + "и " + t2 + " " + "день" + " ");
        }

        public void ForTest1(int x)
        {
            Console.WriteLine("Публичный метод");
            x = this.Year;
            Console.WriteLine("К нам придут инопланетяне в " + x + "году");

        }


    }
}