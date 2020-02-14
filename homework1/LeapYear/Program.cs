using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentYear = 0;
            int bcYear = 0;
            CultureInfo culture;
            DateTime result;
            culture = CultureInfo.CreateSpecificCulture("zh-TW");
            culture.DateTimeFormat.Calendar = new TaiwanCalendar();

            Console.Write("請輸入民國年份:");
            currentYear = int.Parse(Console.ReadLine());

            bcYear = DateTime.ParseExact(currentYear.ToString() ,"yyy" ,culture).Year;
            Console.WriteLine($"民國{currentYear}(西元:{bcYear}): {(isLeapYear(bcYear) ? "潤年" : "不是潤年")}");
            Console.ReadKey();
            //string sampleDate = "2012-2-29";
            //DateTime dt = DateTime.Parse(sampleDate);
            //CultureInfo culture = new CultureInfo("zh-TW");
            //culture.DateTimeFormat.Calendar = new TaiwanCalendar();
            //Console.WriteLine(dt.ToString("yyy/MM/dd" ,culture));
            //Console.ReadKey();
        }
        static bool isLeapYear(int currentYear)
        {
            return (currentYear % 4 == 0 && currentYear % 100 != 0) ||
                    currentYear % 400 == 0;
        }
    }
}
