using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gassNumber
{
    public partial class Form1 :Form
    {
        private Game game;
        public Form1()
        {
            InitializeComponent();
            game = new Game();
            answer.KeyUp += Answer_KeyUp;
            answer.KeyPress += Answer_KeyPress;
            panel1.Enabled = false;
            restart_button.Enabled = false;
            check_button.Enabled = false;
        }

        private void Answer_KeyUp(object sender ,KeyEventArgs e)
        {
            checkLegal();
        }
        private void Answer_KeyPress(object sender ,KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {              
                record_display.Text += game.checkAnswer(answer.Text) + "\n";
                answer.Text = "";
                if (game.Victory)
                {
                    record_display.Text += "Victory!!!";
                    MessageBox.Show("You Win!!!");
                    start_button.Enabled = true;
                    answer.Enabled = false;
                }
            }
        }

        private void startGame()
        {
            record_display.Text = "";
            sneak_display.Text = "";

            panel1.Enabled = true;
            start_button.Enabled = false;
            restart_button.Enabled = true;
            check_button.Enabled = true;
            answer.Enabled = true;

            MessageBox.Show("start!!!");
        }
        private void checkLegal()
        {
            if (answer.Text.Length > game.MaxLength) answer.Text = answer.Text.Remove(game.MaxLength);

            for (int i = 0 ; i < answer.Text.Length ; i++)
            {
                if (!char.IsDigit(answer.Text[i]))
                {
                    answer.Text = answer.Text.Remove(i);
                    break;
                }
            }
        }
        private void start_button_Click(object sender ,EventArgs e)
        {

            game.StartGame();
            startGame();
        }

        private void restart_button_Click(object sender ,EventArgs e)
        {
            game.StartGame();

            startGame();
        }

        private void check_button_Click(object sender ,EventArgs e)
        {
            check_button.Enabled = false;
            sneak_display.Text = game.Real;
        }
    }
}
