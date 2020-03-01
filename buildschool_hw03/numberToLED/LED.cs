using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberToLED
{
    class NumberLED
    {
        public List<List<string>> Pattern { get; set; }

        public NumberLED()
        {
        }
        public void Show(int left ,int ybase = 0)
        {
            for(int i = 0 ; i < Pattern.Count ; i++)
            {
                Console.SetCursorPosition(left ,i + ybase);
                for (int j = 0 ; j < Pattern[i].Count ; j++)
                {
                    Console.Write(Pattern[i][j]);
                }
            }
        }
    }
    class Builder
    {
        private NumberLED _numberLED;

        public Builder()
        {
            _numberLED = new NumberLED();

            _numberLED.Pattern = new List<List<string>>()
            {
                new List<string>(){" " ,"_" ," "},
                new List<string>(){"|" ,"_" ,"|"},
                new List<string>(){"|" ,"_" ,"|"}
            };
        }
        public Builder Disable(int row ,int col)
        {
            _numberLED.Pattern[row][col] = " ";

            return this;
        }
        public NumberLED Build()
        {
            return _numberLED;
        }
    }
}
