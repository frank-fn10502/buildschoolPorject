using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constellation
{
    class Constellation
    {
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public bool isThis(DateTime date)
        {
            DateTime m_d = new DateTime(2020 ,date.Month ,date.Day);
            return m_d >= StartTime && m_d <= EndTime;
        }
    }
}
