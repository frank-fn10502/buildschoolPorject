using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace parking_lot_winform
{
    delegate bool Function(int min);

    class CostRegulation
    {
        private int _unit;
        private int _remaindUnit;
        private int _remain;
        private int _cost;
        private Dictionary<string, Function> _dict1;
        private Dictionary<string, string> _dict2;

        public int Cost { get { return _cost; } }

        public CostRegulation()
        {
            _dict1 = new Dictionary<string, Function>();
            _dict2 = new Dictionary<string, string>();
            _dict1["超過4小時以上每半小時60元"] = new Function(this.R3);
            _dict1["超過2小時但未滿4小時，每半小時40元"] = new Function(this.R2);
            _dict1["2小時內，每半小時30元"] = new Function(this.R1);
            
            

            _dict2["備註"] = "未滿半小時部份不計算";
        }
        public void R0(int min)
        {
            _cost = 0;
            _remaindUnit = _unit = min / 30;
            _remain = min % 30;
        }
        public bool R1(int min)
        {
            var period = _remaindUnit;
            var cost = 30 * period;
            _cost += cost;
            return cost != 0;
        }
        public bool R2(int min)
        {
            var period = GetPeriodHalfHours(4);
            var cost = 40 * period;
            _cost += cost;
            return cost != 0;
        }
        public bool R3(int min)
        {
            var period = GetPeriodHalfHours(8);
            var cost = 60 * period;
            _cost += cost;
            return cost != 0;
        }
        private int GetPeriodHalfHours(int period)
        {
            int result = _remaindUnit - period;
            if (result < 0) result = 0;
            _remaindUnit -= result;
            return result;
        }
        public string Cal(TimeSpan ts)
        {
            int min = (int)ts.TotalMinutes;
            R0(min);

            string str = $"符合規則:\n";

            foreach (var d in _dict1)
            {
                if(d.Value(min))
                {
                    str += $"\t{d.Key}\n";   
                }
            }
            str += $"\n需繳{_cost}元，總計時間為{ts}\n" +
                   $"經過{_unit}個30分鐘，剩餘{_remain}分鐘(不列入計算)\n";
            return str;
        }
        public override string ToString()
        {
            int no = 0;
            string str = "";
            foreach(var s in _dict1.Keys.ToList())
            {
                str += $"{++no}. {s}\n";
            }

            no = 0;
            str += "\n備註\n";
            foreach (var s in _dict2.Values.ToList())
            {
                str += $"{++no}. {s}\n";
            }

            return str;
        }
    }
    class PrkingLot
    {
        private bool _isStartCal;
        private CostRegulation _cost;
        private DateTime _startTime;
        private DateTime _endTime;

        public CostRegulation Cost
        {
            get { return _cost; }
        }
        public DateTime StartTime
        {
            get { return _startTime; }
        }
        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        public PrkingLot()
        {
            Init();
        }
        private void Init()
        {
            _isStartCal = false;
            DateTime dt = DateTime.Now;
            TimeSpan ts = dt - dt.Date;
            _startTime = dt.Date.AddSeconds((int)ts.TotalSeconds);
            _endTime = _startTime;
            _cost = new CostRegulation();
        }
        private void Clock()
        {
            while (true)
            {
                if (_isStartCal)
                {
                    _startTime = _startTime.AddSeconds(1);
                    _endTime = _startTime;
                }
                else
                {
                    _endTime = _endTime.AddSeconds(1);
                }
                Thread.Sleep(1000);
            }
        }

        public void StartCal()
        {
            _isStartCal = true;
        }
        /// <summary>
        /// 以分鐘為單位加速
        /// </summary>
        /// <param name="n">分鐘數</param>
        public void SpeedUp(int n)
        {
            _endTime = _endTime.AddMinutes(n);
        }
    }
}
