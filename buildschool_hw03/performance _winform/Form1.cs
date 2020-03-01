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
        private PerformanceScale _performanceScale;
        public Form1()
        {
            InitializeComponent();
            
            _performanceScale = new PerformanceScale();
            DisplaySalesman();
            DisplayMerchandise();
            DisplayOther();
        }

        private void DisplayOther()
        {
            textBox1.Text = _performanceScale.PrintOther();
        }

        private void DisplayMerchandise()
        {
            merchandiseGridView.Columns.Add("name" ,"名稱");
            merchandiseGridView.Columns.Add("price" ,"單價");
            merchandiseGridView.Columns.Add("quantity" ,"總量");
            merchandiseGridView.Columns.Add("total" ,"總額");

            foreach (var item in _performanceScale.MerchandiseTotal())
            {
                merchandiseGridView.Rows.Add(item.ToArray());
            }
        }

        private void DisplaySalesman()
        {
            salesmanGridView.Columns.Add("salesman" ,"銷售員");
            int i = 0;
            foreach (var item in _performanceScale.MerchandiseList)
            {
                int index = salesmanGridView.Columns.Add($"list{i++}" ,item.Name);
                salesmanGridView.Columns[index].Width = 50;
            }
            salesmanGridView.Columns.Add("Total" ,"總額");

            foreach (var item in _performanceScale.SalesmanTotal())
            {
                salesmanGridView.Rows.Add(item.ToArray());
            }
        }
    }
}
