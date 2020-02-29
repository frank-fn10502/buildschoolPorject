using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace braised_dishes_winform
{
    class Street_Vendor
    {
        private int _remainder;
        public List<Food> FoodList { get; set; }

        private int GetNumber(int money)
        {
            int result = _remainder / money;
            _remainder %= money;

            return result;
        }
        public int TotalCost()
        {
            int cost = 0;
            foreach(Food f in FoodList)
            {
                cost += f.TotalCost;
            }
            return cost;
        }
        public override string ToString()
        {
            string str = "";
            foreach(Food f in FoodList)
            {
                if(f.TotalCost != 0)
                    str += f.ToString() + "\n";
            }
            str += $"\n\t總計:{TotalCost()}";
            return str;
        }
        public string Check()
        {
            _remainder = TotalCost();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["1000元"] = GetNumber(1000);
            dict["500元"] = GetNumber(500); 
            dict["100元"] = GetNumber(100);
            dict["50元"] = GetNumber(50);
            dict["10元"] = GetNumber(10);
            dict["5元"] = GetNumber(5);
            dict["1元"] = _remainder;

            List<KeyValuePair<string, int>> results = dict.ToList();
            string str = $"總計{TotalCost()}，應收:\n";
            foreach (KeyValuePair<string, int> d in results)
            {
                if (d.Value != 0)
                {
                    int n = int.Parse(d.Key.Remove(d.Key.LastIndexOf("元")));
                    str += $"{d.Key}: {d.Value}{(n > 50 ? "張" : "個")}\n";
                }
            }
            return str;
        }
    }
}
