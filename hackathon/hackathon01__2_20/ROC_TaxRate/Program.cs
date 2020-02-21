using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROC_TaxRate
{
    class TaxRate
    {
        public decimal Start { get; set; }
        public decimal End { get; set; }
        public decimal rate { get; set; }

        public bool isThis(decimal money)
        {
            return money >= Start && money <= End;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxRate> taxRateList = new List<TaxRate>()
            {
                new TaxRate(){Start=0 ,End=540_000 ,rate=0.05m},
                new TaxRate(){Start=540_001 ,End=1_210_000 ,rate=0.12m},
                new TaxRate(){Start=1_210_001 ,End=2_420_000 ,rate=0.20m},
                new TaxRate(){Start=2_420_001 ,End=4_530_000 ,rate=0.30m},
                new TaxRate(){Start=4_530_001 ,End=10_310_000 ,rate=0.40m},
                new TaxRate(){Start=10_310_001 ,End=decimal.MaxValue ,rate=0.50m},
            };

            //Console.Write("請輸入金額: ");
            //decimal money = int.Parse(Console.ReadLine());
            //decimal result = 0;
            string str = "";
            while (true)
            {
                str = Console.ReadLine().Replace(" " ,"").Replace(" -> " ,"-").Replace("," ,"").Split('-')[0];

                decimal money = int.Parse(str);
                decimal result = 0;

                int level = 0;
                for (int i = taxRateList.Count - 1 ; i >= 0 ; i--)
                {
                    if (taxRateList[i].isThis(money))
                    {
                        decimal temp = i != 0 ? money - taxRateList[i - 1].End : money;
                        result += temp * taxRateList[i].rate;
                        //Console.WriteLine($"\t{temp * taxRateList[i].rate}");

                        money -= temp;
                    }
                }
                Console.WriteLine($"\tresult: {result:C}\n");
            }
            Console.ReadKey();
        }
    }
}
