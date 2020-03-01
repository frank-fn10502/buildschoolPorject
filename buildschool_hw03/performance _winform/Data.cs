using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace performance__winform
{
    interface IParsable
    {
        List<string> Parse(string path);
    }
    class Merchandise
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    class Salesman
    {
        private int? _total;

        public string Name { get; set; }
        public int? Total
        {
            get
            {
                if (_total == null)
                    _total = MerchandiseQuantityList.Select(x => x.Key.Price * x.Value).Sum();

                return _total;
            }
        }
        public Dictionary<Merchandise ,int> MerchandiseQuantityList { get; private set; }

        public Salesman()
        {
            MerchandiseQuantityList = new Dictionary<Merchandise ,int>();
            _total = null;
        }
    }

    class PerformanceScale
    {
        private List<Merchandise> _merchandiseList;
        private List<Salesman> _salesmenList;

        private List<int> _merchandiseTotalSalesList;

        private List<List<string>> _salesmenDisplayList;
        private List<List<string>> _merchandiseDisplayList;

        public List<Merchandise> MerchandiseList { get { return _merchandiseList; } }
        public List<List<string>> SalesmenDisplayList
        {  
            get 
            {
                if(_salesmenDisplayList == null)
                {
                    _salesmenDisplayList = new List<List<string>>();
                    foreach(var item in _salesmenList)
                    {
                        List<string> row = new List<string>();
                        row.Add(item.Name);
                        foreach(var i in item.MerchandiseQuantityList.Values)
                        {
                            row.Add(i.ToString());
                        }
                        row.Add(item.Total.ToString());

                        _salesmenDisplayList.Add(row);
                    }
                }
                    
                return _salesmenDisplayList;
            } 
        }
        public List<List<string>> MerchandiseDisplayList
        {
            get
            {
                if (_merchandiseTotalSalesList == null)
                    _merchandiseTotalSalesList = _merchandiseList.Select(x => 
                       _salesmenList.Select(y => y.MerchandiseQuantityList[x]).Sum() * x.Price
                    ).ToList();

                if(_merchandiseDisplayList == null)
                {
                    _merchandiseDisplayList = new List<List<string>>();
                    for (int i = 0 ; i < _merchandiseList.Count ; i++)
                    {
                        List<string> row = new List<string>();
                        row.Add(_merchandiseList[i].Name);
                        row.Add(_merchandiseList[i].Price.ToString());
                        row.Add((_merchandiseTotalSalesList[i] / _merchandiseList[i].Price).ToString());
                        row.Add(_merchandiseTotalSalesList[i].ToString());

                        _merchandiseDisplayList.Add(row);
                    }
                }
                return _merchandiseDisplayList;
            }
        }
        public string bestSalesman 
        { 
            get
            {
                Salesman salesman = _salesmenList.OrderByDescending(x => x.Total).First(x => true);
                return $"最佳銷售員: { salesman.Name} ,總金額為: { salesman.Total}";
            }
        }        
        public string bestMerchandise
        {
            get
            {
                int max = _merchandiseTotalSalesList.Max();
                int index = _merchandiseTotalSalesList.IndexOf(max);

                return $"銷售總金額為最多的產品: {_merchandiseList[index].Name} ,總金額為:{max}";
            }
        }

        public PerformanceScale()
        {
            InitMerchandiseList(@"../data/Merchandise.txt");
            InitSalesmeList(@"../data/Salesman.txt");
        }

        public void InitMerchandiseList(string path)
        {
            _merchandiseList = new List<Merchandise>();
            if (File.Exists(path))
            {
                foreach (var lines in File.ReadLines(path))
                {
                    var item = lines.Split(',');
                    Merchandise merchandise = new Merchandise() { Name = item[0] ,Price = int.Parse(item[1]) };
                    _merchandiseList.Add(merchandise);
                }
            }
        }        
        public void InitSalesmeList(string path)
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
                        var key = _merchandiseList[i - 1];
                        salesman.MerchandiseQuantityList[key] = int.Parse(item[i]);
                    }
                    _salesmenList.Add(salesman);
                }
            }
        }
    }
}
