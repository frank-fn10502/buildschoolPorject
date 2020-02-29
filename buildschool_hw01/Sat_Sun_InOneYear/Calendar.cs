using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat_Sun_InOneYear
{
    public enum YearType
    {
        ROCYEAR = 0,
        BCYEAR  = 1
    }
    class Calendar
    {
        private CultureInfo culture_TW;
        private int[] DayNum;
        public DateTime CurrentYear { get; set; }

        public Calendar(int year ,YearType type)
        {
            init();

            if (type == YearType.ROCYEAR)
            {
                CurrentYear = DateTime.ParseExact(year.ToString() ,"yyy" ,culture_TW);
            }
            else if (type == YearType.BCYEAR)
            {
                CurrentYear = new DateTime(year ,1 ,1);
            }
        }
        private void init()
        {
            culture_TW = CultureInfo.CreateSpecificCulture("zh-TW");
            culture_TW.DateTimeFormat.Calendar = new TaiwanCalendar();

            DayNum = new int[7];//星期一 ~ 星期日
        }
        public void calWithLoop()
        {
            DateTime startDay = new DateTime(CurrentYear.Year ,1 ,1);
            DateTime lastDay = new DateTime(CurrentYear.Year ,12 ,31);
            while(startDay <= lastDay)
            {
                DayNum[(int)startDay.DayOfWeek]++;//DayNum = new int[7] //星期日 星期一 星期二 ... 星期六
                startDay = startDay.AddDays(1);
            }
        }
        public void calWithOutLoop()
        {
            DateTime startDay = new DateTime(CurrentYear.Year ,1 ,1);
            DateTime lastDay  = new DateTime(CurrentYear.Year ,12 ,31);
                
            for(int i = 0 ; i < 7 ; i++)
            {
                DayNum[(int)startDay.DayOfWeek] = ((TimeSpan)(lastDay - startDay)).Days / 7 + 1;
                startDay = startDay.AddDays(1);
            }
        }
        public override string ToString()
        {
            int maxLen = 0;
            string tempStr = "";
            string resultStr = "";
            string[] weekStr = { "日" ,"一" ,"二" ,"三" ,"四" ,"五" ,"六"};
            for(int i = 0 ; i < 7 ; i++)
            {
                tempStr = $"星期{weekStr[i]}有{DayNum[i]}天\r\n";
                maxLen = tempStr.Length > maxLen ? tempStr.Length : maxLen;
                resultStr += tempStr;
            }
            tempStr = "";
            for (int i = 0 ; i < maxLen ; i++)
            {
                tempStr += "=";
            }
            resultStr += tempStr + "\r\n";
            return resultStr;
        }
    }
}
