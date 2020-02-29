using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberToLED
{
    class LED
    {
        protected static readonly List<List<string>> Pattern = new List<List<string>>()
        {
            new List<string>(){" " ,"_" ," "},
            new List<string>(){"|" ,"_" ,"|"},
            new List<string>(){"|" ,"_" ,"|"}
        };
    }
    class NumberLED :LED
    {
        public List<List<int>> SwitchList { get; set; }

        public NumberLED(List<List<int>> switchList)
        {
            SwitchList = switchList;
        }
        public void Show(int left ,int ybase = 0)
        {
            for(int i = 0 ; i < Pattern.Count ; i++)
            {
                Console.SetCursorPosition(left ,i + ybase);
                for (int j = 0 ; j < Pattern[i].Count ; j++)
                {
                    if(SwitchList[i][j] == 1)
                    {
                        Console.Write(Pattern[i][j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
    }
    class Builder
    {
        private static List<List<int>> _switchList;

        public Builder getBuild()
        {
            _switchList = new List<List<int>>()
            {
                new List<int>(){1 ,1 ,1},
                new List<int>(){1 ,1 ,1},
                new List<int>(){1 ,1 ,1}
            };
            return this;
        }
        public Builder Disable(int row ,int col)
        {
            _switchList[row][col] = 0;

            return this;
        }
        public List<List<int>> Done()
        {
            return _switchList;
        }
    }
}
