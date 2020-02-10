using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace braised_dishes_winform
{
    class Food
    {
        private string _name;
        private int _leastUnit;
        private int _price;

        public string Name
        {
            get { return _name; }
        }
        public int LeastUnit 
        { 
            get { return _leastUnit; } 
        }
        public int Price 
        { 
            get { return _price; } 
        }

        public int Unit { get; set; }
        public int TotalCost 
        { 
            get { return Unit * Price; } 
        }

        public Food(string name ,int leastUnit ,int price)
        {
            _name = name;
            _leastUnit = leastUnit;
            _price = price;
        }

        public override string ToString()
        {
            return $"{Name,-7}({Unit,-4}份,{Unit * LeastUnit,-4}個)............{TotalCost}";
        }
    }
    class FoodEntity : Food
    {
        private static int _counter = 0;
        private Label _label;
        private NumericUpDown _numericUpDown;

        public Label Label 
        { 
            get { return _label; } 
        }
        public NumericUpDown NumericUpDown
        {
            get { return _numericUpDown; }
        }


        public FoodEntity(string name, int leastUnit, int price) 
        : base(name ,leastUnit ,price)
        {
            createEntity(++_counter);
        }
        private void createEntity(int no)
        {
            Label l = new Label();
            l.Location = new System.Drawing.Point(5, 11 + (no-1) * 40);
            l.Name = $"l_{no}";
            l.Size = new System.Drawing.Size(215, 29);
            l.Text = $"{this.Name}({this.LeastUnit}個/份,{this.Price}元)";
            l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            NumericUpDown nup = new NumericUpDown();
            nup.Location = new System.Drawing.Point(228, 11 + (no - 1) * 40);
            nup.Name = $"nup_{no}";
            nup.Size = new System.Drawing.Size(70, 29);
            nup.Maximum = 1000;
            nup.ValueChanged += Nup_ValueChanged;

            this._label = l;
            this._numericUpDown = nup;
        }

        private void Nup_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nup = (NumericUpDown)sender;
            this.Unit = (int)nup.Value;
        }
    }
}
