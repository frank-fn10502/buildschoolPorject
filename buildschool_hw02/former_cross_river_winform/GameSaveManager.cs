using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmer_cross_river_winform
{
    class GameSaveEntity
    {
        public Label myLabel { get; set; }
        public GameSave gameSave { get; set; }
        public GameStatus status { get; set; }
    }
    class GameSave
    {
        public List<string> MsourceSide { get; set; }
        public List<string> MtargetSide { get; set; }
        public List<string> Mside1 { get; set; }
        public List<string> Mside2 { get; set; }
        public bool IsSide1 { get; set; }

        public GameSave(List<string> side1, List<string> side2 ,bool isSide1)
        {
            Mside1 = new List<string>(side1);
            Mside2 = new List<string>(side2);
            IsSide1 = isSide1;

            MsourceSide = IsSide1 ? Mside1 : Mside2;
            MtargetSide = IsSide1 ? Mside2 : Mside1;
        }
    }
    class GameSaveManager
    {
        private Stack<GameSave> _gameSaves;

        public GameSaveManager()
        {
            _gameSaves = new Stack<GameSave>();
        }
        private Label createLabel(int count ,string dec)
        {
            Label newLabel = new Label();
            newLabel.Size = new System.Drawing.Size(366, 24);
            newLabel.Location = new System.Drawing.Point(0, count * newLabel.Size.Height);
            newLabel.Name = $"label_{count}";
            newLabel.BorderStyle = BorderStyle.FixedSingle;
            newLabel.Text = dec;
            newLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            return newLabel;
        }

        public int save(GameSave gameSave)
        {
            _gameSaves.Push(gameSave);
            return _gameSaves.Count;
        }
        public GameSave restore()
        {
            try
            {
                return _gameSaves.Pop();
            }
            catch (InvalidOperationException e)
            {
                return null;
            }
        }
    }
}
