using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace braised_dishes_winform
{
    public partial class Form1 : Form
    {
        private Street_Vendor _streetVendor;
        public Form1()
        {
            InitializeComponent();
            createStreetVender();
        }

        private void createStreetVender()
        {
            _streetVendor = new Street_Vendor()
            {
                FoodList = new List<Food>()
                {
                    new FoodEntity("高麗菜" ,1 ,30),
                    new FoodEntity("豆乾" ,2 ,15),
                    new FoodEntity("海帶" ,2 ,15),
                    new FoodEntity("肉片" ,1 ,40),
                    new FoodEntity("鳥蛋" ,4 ,13),
                    new FoodEntity("豆皮" ,1 ,17),
                }
            };
            this.menu.Controls.Clear();
            foreach(FoodEntity fe in _streetVendor.FoodList)
            {
                this.menu.Controls.Add(fe.Label);
                this.menu.Controls.Add(fe.NumericUpDown);
                fe.NumericUpDown.ValueChanged += NumericUpDown_ValueChanged;
            }
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.menu_display.Text = _streetVendor.ToString();
            this.check_display.Text = "";
        }

        private void Check_button_Click(object sender, EventArgs e)
        {
            this.check_display.Text = _streetVendor.Check();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            foreach(FoodEntity fe in _streetVendor.FoodList)
            {
                fe.NumericUpDown.Value = 0;
            }
            this.menu_display.Text = "";
            this.check_display.Text = "";
        }
    }
}
