using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace performance__winform
{
    class Merchandise
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    class Salesman
    {
        public string Name { get; set; }
    }
    class MS
    {
        public string MerchandiseName { get; set; }
        public string SalesmanName { get; set; }
        public int Quantity { get; set; }

    }
    class PerformanceScale
    {
        public List<Merchandise> MerchandiseList { get; private set; }
        public List<Salesman> SalesmanList { get; private set; }
        public List<MS> MSList { get; private set; }

        public PerformanceScale()
        {
            Init(@"../data/Merchandise.txt" ,@"../data/Salesman.txt");
        }

        private void Init(string Mpath1 ,string Spath2)
        {
            MerchandiseList = new List<Merchandise>();
            if (File.Exists(Mpath1))
            {
                foreach (var lines in File.ReadLines(Mpath1))
                {
                    var item = lines.Split(',');
                    Merchandise merchandise = new Merchandise() { Name = item[0] ,Price = int.Parse(item[1]) };
                    MerchandiseList.Add(merchandise);
                }
            }

            SalesmanList = new List<Salesman>();
            MSList = new List<MS>();
            if (File.Exists(Spath2))
            {
                foreach (var lines in File.ReadLines(Spath2))
                {
                    var item = lines.Split(' ');
                    Salesman salesman = new Salesman() { Name = item[0] };
                    SalesmanList.Add(salesman);

                    for (int i = 1 ; i < item.Length ; i++)
                    {
                        MS ms = new MS()
                        {
                            SalesmanName = salesman.Name ,
                            MerchandiseName = MerchandiseList[i - 1].Name ,
                            Quantity = int.Parse(item[i])
                        };
                        MSList.Add(ms);
                    }
                }
            }
        }

        public List<List<string>> SalesmanTotal()
        {
            var results =
                from s in SalesmanList
                join ms in MSList
                on s.Name equals ms.SalesmanName
                join m in MerchandiseList
                on ms.MerchandiseName equals m.Name
                select new { SalesmanName = s.Name ,MerchandiseName = ms.MerchandiseName ,Quantity = ms.Quantity ,price = m.Price };

            var tempList = results.GroupBy(x => x.SalesmanName).Select(x =>
                           new
                           {
                               SalesmanName = x.Key ,
                               merList = x.Select(y => y.Quantity) ,
                               Total = x.Select(y => y.price * y.Quantity).Sum()
                           });

            List<List<string>> r = new List<List<string>>();
            foreach (var item in tempList)
            {
                List<string> str = new List<string>();
                str.Add(item.SalesmanName);
                foreach (var i in item.merList)
                {
                    str.Add(i.ToString());
                }
                str.Add(item.Total.ToString());

                r.Add(str);
            }
            return r;
        }
        public List<List<string>> MerchandiseTotal()
        {
            var result =
                from ms in MSList
                join m in MerchandiseList
                on ms.MerchandiseName equals m.Name
                select new { mName = m.Name ,Quantity = ms.Quantity ,Price = m.Price };

            var tempList = result.GroupBy(x => x.mName).Select(x =>
                                  new
                                  {
                                      mName = x.Key ,
                                      Total = x.Select(y => y.Price * y.Quantity).Sum() ,
                                      price = x.Select(y => y.Price).Max() ,
                                      quantity = x.Select(y => y.Quantity).Sum() ,
                                  });

            List<List<string>> r = new List<List<string>>();
            foreach (var item in tempList)
            {
                r.Add(new List<string>()
                {
                    item.mName,
                    item.price.ToString(),
                    item.quantity.ToString(),
                    item.Total.ToString()
                });
            }
            return r;
        }

        public string PrintOther()
        {
            var results =
                from s in SalesmanList
                join ms in MSList
                on s.Name equals ms.SalesmanName
                join m in MerchandiseList
                on ms.MerchandiseName equals m.Name
                select new { SalesmanName = s.Name ,MerchandiseName = ms.MerchandiseName ,Quantity = ms.Quantity ,price = m.Price };

            var salesmanName = results.GroupBy(x => x.SalesmanName)
                                      .Select(x => new { name = x.Key ,Total = x.Select(y => y.price * y.Quantity).Sum() })
                                      .OrderByDescending(x => x.Total)
                                      .First(x => true);

            var merchandiseName = results.GroupBy(x => x.MerchandiseName)
                                         .Select(x => new { name = x.Key ,Total = x.Select(y => y.price * y.Quantity).Sum() })
                                         .OrderByDescending(x => x.Total)
                                         .First(x => true);

            return $"最佳銷售員: { salesmanName.name} ,總金額為: { salesmanName.Total} {Environment.NewLine}" +
                   $"銷售總金額為最多的產品: {merchandiseName.name} ,總金額為:{merchandiseName.Total}";
        }
    }
}
