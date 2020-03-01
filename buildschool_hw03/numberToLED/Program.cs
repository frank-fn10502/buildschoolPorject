using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberToLED
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Dictionary<int ,NumberLED> patternList = CreateList();

            Console.Write("line of number: ");
            var str = Console.ReadLine();
            foreach(var item in str)
            {
                int i = item - '0';
                patternList[i].Show(4 * counter++ ,1);
            }

            Console.ReadKey();
        }
        static Dictionary<int ,NumberLED> CreateList()
        {
            Dictionary<int ,NumberLED> Dict = new Dictionary<int ,NumberLED>();

            Dict[0] = new Builder().Disable(1 ,1).Build();
            Dict[1] = new Builder().Disable(0 ,0).Disable(0 ,1)
                                                      .Disable(1 ,0).Disable(1 ,1)
                                                      .Disable(2 ,0).Disable(2 ,1).Build();

            Dict[2] = new Builder().Disable(1 ,0).Disable(2 ,2).Build();

            Dict[3] = new Builder().Disable(1 ,0).Disable(2 ,0).Build();

            Dict[4] = new Builder().Disable(0 ,1).Disable(2 ,0).Disable(2 ,1).Build();

            Dict[5] = new Builder().Disable(1 ,2).Disable(2 ,0).Build();

            Dict[6] = new Builder().Disable(1 ,2).Build();

            Dict[7] = new Builder().Disable(1,0).Disable(1,1).Disable(2,0).Disable(2,1).Build();

            Dict[8] = new Builder().Build();

            Dict[9] = new Builder().Disable(2 ,0).Build();

            return Dict;
        }
    }
}
