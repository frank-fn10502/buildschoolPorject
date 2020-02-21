using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gassNumber
{
    class Game
    {
        private Random random;
        public int MaxLength { get; private set; }
        public string Real { get; private set; }
        public bool Victory { get; private set; }

        public Game(int maxLength = 4)
        {
            MaxLength = maxLength;
            random = new Random();
        }

        public void StartGame()
        {
            Victory = false;
            Real = "";

            List<int> nList = new List<int>();
            for (int i = 0 ; i < 10 ; i++) nList.Add(i);

            for (int i = 0 ; i < MaxLength ; i++)
            {
                int index = random.Next(nList.Count);

                Real += nList[index];
                nList.RemoveAt(index);
            }
        }
        public string checkAnswer(string answer)
        {
            int A = 0, B = 0;
            for (int i = 0 ; i < MaxLength ; i++)
            {
                for (int j = 0 ; j < MaxLength ; j++)
                {
                    if (i == j)
                    {
                        A = Real[i] == answer[j] ? A + 1 : A;
                    }
                    else
                    {
                        B = Real[i] == answer[j] ? B + 1 : B;
                    }
                }
            }
            Victory = A == 4;

            return $"{answer}: {A}A{B}B";
        }
    }
}
