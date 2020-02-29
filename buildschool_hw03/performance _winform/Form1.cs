using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace performance__winform
{
    public partial class Form1 :Form
    {
        private List<Salesman> _salesmenList;
        public Form1()
        {
            InitializeComponent();
            Salesman.MerchandiseList = GetMerchandiseList(@"D:\Documents\build_school\project\buildschool_hw03\performance _winform\data\Merchandise.txt");
            InitSalesman(@"D:\Documents\build_school\project\buildschool_hw03\performance _winform\data\Salesman.txt");
            DisplaySalesman();
            DisplayMerchandise();
            DisplayOther();
        }
        private List<Merchandise> GetMerchandiseList(string path)
        {
            List<Merchandise> MerchandiseList = new List<Merchandise>();
            if (File.Exists(path))
            {
                foreach (var lines in File.ReadLines(path))
                {
                    var item = lines.Split(',');
                    Merchandise merchandise = new Merchandise() { Name = item[0] ,Price = int.Parse(item[1]) };
                    MerchandiseList.Add(merchandise);
                }
            }
            return MerchandiseList;
        }
        private void InitSalesman(string path)
        {
            _salesmenList = new List<Salesman>();
            if (File.Exists(path))
            {
                foreach (var lines in File.ReadLines(path))
                {
                    var item = lines.Split(' ');
                    Salesman salesman = new Salesman() { Name = item[0] };

                    for (int i = 1 ; i < item.Length ; i++)
                    {
                        salesman.MerchandiseDict[i - 1] = int.Parse(item[i]);

                    }
                    _salesmenList.Add(salesman);
                }
            }
        }
        private void DisplaySalesman()
        {
            salesmanGridView.ColumnCount = Salesman.MerchandiseList.Count + 1;
            salesmanGridView.Columns[0].Name = "銷售員";
            for (int i = 0 ; i < Salesman.MerchandiseList.Count ; i++)
            {
                salesmanGridView.Columns[i + 1].Name = Salesman.MerchandiseList[i].Name;
                salesmanGridView.Columns[i + 1].Width = 50;
            }
            salesmanGridView.Columns.Add("Total" ,"總額");

            salesmanGridView.RowCount = _salesmenList.Count;
            for (int i = 0 ; i < _salesmenList.Count ; i++)
            {
                salesmanGridView.Rows[i].Cells[0].Value = _salesmenList[i].Name;
                int c = 0;
                foreach(var item in _salesmenList[i].MerchandiseDict.Values)
                {
                    salesmanGridView.Rows[i].Cells[1 + c++].Value = item;
                }
                salesmanGridView.Rows[i].Cells["Total"].Value = _salesmenList[i].Total;
            }
        }

        private void DisplayMerchandise()
        {
            merchandiseGridView.Columns.Add("name" ,"名稱");
            merchandiseGridView.Columns.Add("price" ,"單價");
            merchandiseGridView.Columns.Add("quantity" ,"總量");
            merchandiseGridView.Columns.Add("total" ,"總額");

            merchandiseGridView.RowCount = Salesman.MerchandiseList.Count;
            for (int i = 0 ; i < Salesman.MerchandiseList.Count ; i++)
            {
                merchandiseGridView.Rows[i].Cells["name"].Value = Salesman.MerchandiseList[i].Name;
                merchandiseGridView.Rows[i].Cells["price"].Value = Salesman.MerchandiseList[i].Price;
                merchandiseGridView.Rows[i].Cells["quantity"].Value = _salesmenList.Select(x => x.MerchandiseDict[i]).Sum();
                merchandiseGridView.Rows[i].Cells["total"].Value = _salesmenList.Select(x => x.MerchandiseDict[i] * Salesman.MerchandiseList[i].Price).Sum();
            }
        }
        private void DisplayOther()
        {
            Salesman bestSlesman = _salesmenList.OrderByDescending(x => x.Total).First(x => true);

            List<int> totalList = new List<int>();
            for (int i = 0 ; i < Salesman.MerchandiseList.Count ; i++)
            {
                totalList.Add(_salesmenList.Select(x => x.MerchandiseDict[i] * Salesman.MerchandiseList[i].Price).Sum());
            }
            int index = totalList.FindIndex(x => x == totalList.OrderByDescending(y => y).First(y => true));
            Merchandise bestMerchandise = Salesman.MerchandiseList[index];

            textBox1.Text = $"最佳銷售員: {bestSlesman.Name} ,總金額為:{bestSlesman.Total}\r\n" + 
                            $"銷售總金額為最多的產品: {bestMerchandise.Name} ,總金額為:{totalList.OrderByDescending(y => y).First(y => true)}";
        }
    }
}
