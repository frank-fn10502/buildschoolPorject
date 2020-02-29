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
                patternList[i].Show(3 * counter++ ,1);
            }

            Console.ReadKey();
        }
        static Dictionary<int ,NumberLED> CreateList()
        {
            Builder builder = new Builder();

            Dictionary<int ,NumberLED> Dict = new Dictionary<int ,NumberLED>();

            Dict[0] = new NumberLED(builder.getBuild().Disable(1 ,1).Done());
            Dict[1] = new NumberLED(builder.getBuild().Disable(0 ,0).Disable(0 ,1)
                                                      .Disable(1 ,0).Disable(1 ,1)
                                                      .Disable(2 ,0).Disable(2 ,1).Done());

            Dict[2] = new NumberLED(builder.getBuild().Disable(1 ,0).Disable(2 ,2).Done());

            Dict[3] = new NumberLED(builder.getBuild().Disable(1 ,0).Disable(2 ,0).Done());

            Dict[4] = new NumberLED(builder.getBuild().Disable(0 ,1).Disable(2 ,0).Disable(2 ,1).Done());

            Dict[5] = new NumberLED(builder.getBuild().Disable(1 ,2).Disable(2 ,0).Done());

            Dict[6] = new NumberLED(builder.getBuild().Disable(1 ,2).Done());

            Dict[7] = new NumberLED(builder.getBuild().Disable(1,0).Disable(1,1).Disable(2,0).Disable(2,1).Done());

            Dict[8] = new NumberLED(builder.getBuild().Done());

            Dict[9] = new NumberLED(builder.getBuild().Disable(2 ,0).Done());

            return Dict;
        }
    }
}
