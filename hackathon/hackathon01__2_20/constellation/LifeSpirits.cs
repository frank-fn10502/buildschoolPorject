using System;
using System.Collections.Generic;
using System.IO;

namespace constellation
{
    class LifeSpirtDec
    {
        public Constellation Constellation { get; set; }
        public Dictionary<int ,string> Dec { get; set; }
    }
    class LifeSpirits
    {
        public List<LifeSpirtDec> LifeSpirtDecList { get; private set; }

        public LifeSpirits()
        {
            LifeSpirtDecList = new List<LifeSpirtDec>();
            readConstellation();
        }
        private void readConstellation()
        {
            int year = 2020;
            if (File.Exists("D:\\Documents\\build_school\\Chu2020_Hackathon01\\星座.txt"))
            {
                foreach (var line in File.ReadLines("D:\\Documents\\build_school\\Chu2020_Hackathon01\\星座.txt"))
                {
                    LifeSpirtDec temp = new LifeSpirtDec() { Constellation = new Constellation() ,Dec = new Dictionary<int ,string>() };
                    var str = line.Split(',');
                    temp.Constellation.Name = str[0];
                    for (int i = 1 ; i <= 2 ; i++)
                    {
                        var m_d = str[i].Split('-');
                        int month = int.Parse(m_d[0]);
                        int day = int.Parse(m_d[1]);

                        if (month == 1 && day == 21)
                        {
                            year = 2021;
                        }
                        else year = 2020;

                        if (i == 1) temp.Constellation.StartTime = new DateTime(year ,month ,day);
                        else temp.Constellation.EndTime = new DateTime(year ,month ,day);


                    }

                    this.LifeSpirtDecList.Add(temp);
                }
            }
        }
        private string readLifeSpirts(Constellation constellation ,int no)
        {
            int counter = -1, bias = 2;
            bool startCount = false;
            if (File.Exists("D:\\Documents\\build_school\\Chu2020_Hackathon01\\生命靈數.txt"))
            {
                foreach (var line in File.ReadLines("D:\\Documents\\build_school\\Chu2020_Hackathon01\\生命靈數.txt"))
                {
                    if (line.Contains(constellation.Name))
                    {
                        startCount = true;
                    }
                    if (startCount)
                    {
                        counter++;
                    }
                    if (counter == no * 2) return line;
                }
            }
            return "it's not true";
        }
        private Constellation findConstellation(DateTime date)
        {
            foreach (var item in LifeSpirtDecList)
            {
                if (item.Constellation.isThis(date))
                {
                    return item.Constellation;
                }
            }
            return null;
        }

        public string Cal(DateTime dateTime)
        {
            int total = dateTime.Year + dateTime.Month + dateTime.Day;
            int temp = 0;
            while (total >= 10)
            {
                temp = 0;
                foreach (var item in total.ToString())
                {
                    temp += (int)Char.GetNumericValue(item);
                }
                total = temp;
            }
            var constellation = findConstellation(dateTime);
            return $"你的星座是:{constellation.Name} \n你的生命靈數是:\n{readLifeSpirts(constellation ,total)}";
        }
    }
}
