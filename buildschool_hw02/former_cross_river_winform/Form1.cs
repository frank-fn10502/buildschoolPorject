using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmer_cross_river_winform
{


    public partial class Form1 : Form
    {
        private GameSave _curentGameSave;
        private string _curent_step_title;

        private List<GameSaveEntity> _gameSaveEntities;
        private GameSaveManager _gameSaveManager;
        private CrossRiverGame _game;
        public Form1()
        {
            InitializeComponent();

            SetListBox();
            Start();
        }
        private void SetListBox()
        {
            side1.SelectionMode = SelectionMode.One;
            side2.SelectionMode = SelectionMode.One;
        }
        private void ChangeData()
        {
            side1.DataSource = null;
            side2.DataSource = null;
            side1.DataSource = _game.Side1;
            side2.DataSource = _game.Side2;
        }
        private void createDisplayRecord(int count, string dec, GameSave gameSave, GameStatus status)
        {
            Label myLable = new Label();
            myLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            myLable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            myLable.Name = $"display_label_{count - 1}";
            myLable.Size = new System.Drawing.Size(366, 24);
            myLable.Location = new System.Drawing.Point(0, (count - 1) * myLable.Size.Height);
            myLable.Text = dec;
            myLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            myLable.Click += record_click;
            myLable.MouseEnter += mouse_hover;
            myLable.MouseLeave += mouse_leave;

            this.historical_record_panel.Controls.Add(myLable);
            _gameSaveEntities.Add(new GameSaveEntity() { myLabel = myLable, gameSave = gameSave, status = status });
        }

        private void record_click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            int no = int.Parse(l.Name.Split('_')[2]);

            _curent_step_title = step_title.Text;
            _curentGameSave = _game.save();

            var gameSave = _gameSaveEntities[no].gameSave;
            _game.restore(gameSave);
            ChangeGameStatus(GameStatus.STOP);

            step_title.Text = $"第{no + 1}步";
            _game.CurrentGameStatus = (no == _game.Counter - 1) ? GameStatus.CONTINUE : GameStatus.STOP;
            if (_game.CurrentGameStatus == GameStatus.STOP)
            {
                side1.Enabled = false;
                side2.Enabled = false;

                step_title.Text += $"(回憶中)";
            }

            var status = _gameSaveEntities[no].status;
            if (status != GameStatus.CONTINUE)
            {
                step_title.Text += $"({Enum.GetName(typeof(GameStatus), status)})";
            }

            l.BackColor = System.Drawing.Color.LightBlue;
        }
        private void mouse_hover(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.BackColor = Color.LightYellow;
        }
        private void mouse_leave(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.BackColor = System.Drawing.Color.Transparent;
        }

        private void ChangeGameStatus(GameStatus gameStatus = GameStatus.CONTINUE)
        {
            side1.Enabled = _game.IsSide1;
            side2.Enabled = !_game.IsSide1;
            ChangeData();

            if (gameStatus != GameStatus.STOP)
            {
                createDisplayRecord(_game.Counter, _game.MoveDec, _game.save(), gameStatus);

                step_title.Text = $"第{_game.Counter}步";
                if (gameStatus != GameStatus.CONTINUE)
                {
                    step_title.Text += $"({Enum.GetName(typeof(GameStatus), gameStatus)})";
                }

                if (gameStatus == GameStatus.GAMEOVER)
                {
                    MessageBox.Show("遊戲結束!!!", "GAME OVER");

                    var result = MessageBox.Show("回上一步!!!", "GAME OVER", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        Start();
                    }
                    else if (result == DialogResult.Yes)
                    {
                        _game.Previous(_gameSaveManager.restore());
                        ChangeGameStatus();
                    }
                }
                else if (gameStatus == GameStatus.VICTORY)
                {
                    MessageBox.Show($"遊戲結束!!!\n使用了{_game.Counter}步", "VICTORY");
                    this.previous_button.Enabled = false;
                    this.cross_button.Enabled = false;
                }
            }
        }
        private void Start()
        {
            _gameSaveEntities = new List<GameSaveEntity>();
            _gameSaveManager = new GameSaveManager();
            _game = new CrossRiverGame();

            side1.Enabled = _game.IsSide1;
            side2.Enabled = !_game.IsSide1;
            ChangeData();

            step_title.Text = "第00步";
            this.previous_button.Enabled = true;
            this.cross_button.Enabled = true;
            this.historical_record_panel.Controls.Clear();
        }

        private void cross_button_Click(object sender, EventArgs e)
        {
            ListBox currentListBox = (_game.IsSide1) ? side1 : side2;
            string selectStr = (string)currentListBox.SelectedItem;

            _gameSaveManager.save(_game.save());
            ChangeGameStatus(_game.CrossRiver(selectStr));
        }
        private void previous_button_Click(object sender, EventArgs e)
        {
            var gameSave = _gameSaveManager.restore();
            if (!_game.Previous(gameSave))
            {
                MessageBox.Show("沒有上一步!!!", "失敗!!!");
            }
            else
            {
                ChangeGameStatus();
            }
        }
        private void reStart_button_Click(object sender, EventArgs e)
        {
            Start();
        }
    }
}
