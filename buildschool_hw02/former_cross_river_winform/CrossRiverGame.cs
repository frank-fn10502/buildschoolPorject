using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmer_cross_river_winform
{
    enum GameStatus
    {
        GAMEOVER = 0,
        CONTINUE = 1,
        VICTORY  = 2,
        STOP = 3,
    }
    class CrossRiverGame
    {
        private List<string> _sourceSide;
        private List<string> _targetSide;
        private string moveDec;
        private List<string> _side1;
        private List<string> _side2;


        public string MoveDec
        { 
            get { return moveDec; } 
        }
        public List<string> Side1
        {
            get { return _side1; }
        }
        public List<string> Side2
        {
            get { return _side2; }
        }
        public bool IsSide1 { get; set; }
        public int Counter { get; set; }
        public GameStatus CurrentGameStatus { get; set; }


        public CrossRiverGame()
        {
            _side1 = new List<string>() { "農夫", "狼", "羊", "菜" };
            _side2 = new List<string>();

            _sourceSide = Side1;
            _targetSide = Side2;
            IsSide1 = true;
            Counter = 0;
            CurrentGameStatus = GameStatus.CONTINUE;
        }

        public GameSave save()
        {
            return new GameSave(Side1, Side2, IsSide1);
        }
        public bool restore(GameSave gameSave)
        {
            if (gameSave == null)
            {
                return false;
            }
            _side1 = gameSave.Mside1;
            _side2 = gameSave.Mside2;
            _sourceSide = gameSave.MsourceSide;
            _targetSide = gameSave.MtargetSide;
            IsSide1 = gameSave.IsSide1;

            return true;
        }

        private void CreateDec(List<string> moveItems)
        {
            this.moveDec = $"第{this.Counter ,-2}步: 將<{(moveItems.Count == 1 ? " " : "")}{string.Join("," ,moveItems),4}>從{(IsSide1 ? "左邊" : "右邊")}移動到{(IsSide1 ? "右邊" : "左邊")}\n";
        }
        private void CreateDec()
        {
            this.moveDec = $"第{this.Counter,-2}步: 回到上一步\n";
        }

        /// <summary>
        /// 變更遊戲機本屬性
        /// </summary>
        /// <returns>GameStatus</returns>
        private GameStatus changeGameStatus()
        {
            IsSide1 = !IsSide1;

            List<List<string>> fatalList = new List<List<string>>()
            {
                new List<string>() { "狼", "羊" },
                new List<string>() { "羊", "菜" }
            };
            bool gameover = fatalList[0].All(s => _sourceSide.Contains(s)) || fatalList[1].All(s => _sourceSide.Contains(s));

            GameStatus gs = GameStatus.CONTINUE;
            if (gameover)
            {
                gs = GameStatus.GAMEOVER;
            }
            else if(_side1.Count == 0)
            {
                gs = GameStatus.VICTORY;
            }

            List<string> temp = _sourceSide;
            _sourceSide = _targetSide;
            _targetSide = temp;

            return gs;
        }

        /// <summary>
        /// 農夫過河，回傳遊戲狀態(game over)
        /// </summary>
        /// <returns>GameStatus</returns>
        public GameStatus CrossRiver(string selectItem)
        {
            List<string> selectItemList = new List<string>();
            selectItemList.Add(selectItem);
            if (selectItem != "農夫")
            {
                selectItemList.Add("農夫");
            }
            Counter++;
            CreateDec(selectItemList);

            _sourceSide.RemoveAll(l => selectItemList.Contains(l));
            _targetSide.AddRange(selectItemList);

            return changeGameStatus();
        }

        /// <summary>
        /// 回復上一個狀態
        /// </summary>
        public bool Previous(GameSave gameSave)
        {
            bool isSuccess = restore(gameSave);

            if(isSuccess) Counter++;
            CreateDec();

            return isSuccess;
        }
    }
}
