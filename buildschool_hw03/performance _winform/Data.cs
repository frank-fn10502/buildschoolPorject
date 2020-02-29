using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace performance__winform
{
    class Merchandise
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    class Salesman
    {
        public static List<Merchandise> MerchandiseList;
        public string Name { get; set; }
        public int Total
        {
            get
            {
                return MerchandiseDict.Select(x => MerchandiseList[x.Key].Price * x.Value).Sum();
            }
        }
        public Dictionary<int ,int> MerchandiseDict { get; set; }//indexToMerchandise ,quantity


        public Salesman()
        {
            MerchandiseDict = new Dictionary<int ,int>();
        }
    }

}
