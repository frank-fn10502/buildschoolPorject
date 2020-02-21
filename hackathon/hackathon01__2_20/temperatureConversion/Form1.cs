using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperatureConversion
{
    public partial class Form1 :Form
    {
        private double temperature;
        private Random random;
        public Form1()
        {
            InitializeComponent();
            createControlPanel();

            random = new Random();
            t1.Checked = true;
            this.textBox1.ReadOnly = true;
            textBox1.KeyPress += TextBox1_KeyPress;
            changeTemp(32);
        }
        private void CreateButton(string name ,int no)
        {
            Button b = new Button();
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.Location = new System.Drawing.Point(30 * (no % 3) + 3 ,43 * (no / 3) + 3);
            b.Name = $"button_{no}";
            b.Size = new System.Drawing.Size(27 ,33);
            b.Text = name;
            b.UseVisualStyleBackColor = true;
            b.Click += B_Click;

            this.panel1.Controls.Add(b);
        }
        private void B_Click(object sender ,EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "." && this.textBox1.Text.Contains("."))
            {
                MessageBox.Show("我覺得不行!!!");
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text == "0" && b.Text != "." ? "" : this.textBox1.Text;
                this.textBox1.Text += b.Text;
            }


        }

        private void createControlPanel()
        {
            this.panel1.Controls.Clear();
            for (int i = 0 ; i < 12 ; i++)
            {
                string name = i < 11 ? i.ToString() : ".";
                CreateButton(name ,i);
            }
        }
        private void TextBox1_KeyPress(object sender ,KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                changeTemp(int.Parse(this.textBox1.Text));
            }
        }
        private void changeTemp(double number)
        {
            temperature = number;
            this.textBox1.Text = temperature.ToString();
        }


        private void change()
        {
            temperature = double.Parse(this.textBox1.Text);
            if (t1.Checked)
            {
                changeTemp(temperature * 9 / 5 + 32);
            }
            else
            {
                changeTemp((temperature - 32) * 5 / 9);
            }
            changeTemp(Math.Round(temperature ,3));
        }

        private void random_button_Click(object sender ,EventArgs e)
        {
            double number = Math.Round(random.NextDouble() * random.Next(0 ,1000) ,4);
            changeTemp(number);
            this.textBox1.Text = temperature.ToString();
        }

        private void clear_button_Click(object sender ,EventArgs e)
        {
            this.textBox1.Text = "";
            changeTemp(0);
        }

        private void convert_button_Click(object sender ,EventArgs e)
        {
            change();
        }
    }
}
