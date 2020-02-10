using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rail_transport_winform
{
    delegate int FindPrice(int start ,int end);
    class RailTransport
    {
        private Dictionary<string, int> _stationName;
        private List<List<int>> _priceList;

        public List<string> StationName
        {
            get { return _stationName.Keys.ToList(); }
        }

        public RailTransport()
        {
            _stationName = new Dictionary<string, int>();
            _stationName["台北"] = 0;
            _stationName["新竹"] = 1;
            _stationName["台中"] = 2;
            _stationName["嘉義"] = 3;
            _stationName["台南"] = 4;
            _stationName["高雄"] = 5;


            _priceList = new List<List<int>>()
            {
                new List<int>(){0},
                new List<int>(){177 ,0},
                new List<int>(){375 ,197 ,0},
                new List<int>(){598 ,421 ,224, 0},
                new List<int>(){738 ,560 ,363 ,139, 0},
                new List<int>(){842 ,755 ,469 ,245 ,106, 0},
            };
        }
        private int north(int start ,int end)
        {
            return _priceList[start][end];
        }
        private int sorth(int start ,int end)
        {
            return _priceList[end][start];
        }
        private decimal Discount(decimal price , bool d1 ,bool d2)
        {
            decimal offer = (d1 && d2) ? 9 * 9 : (d1 || d2 ? 90 : 100);
            return Math.Ceiling(price * offer / 100);
        }

        public string Calprice(string startName , string endName ,bool returTticket ,bool concessionTicket)
        {
            string dec = "";
            int start = _stationName[startName];
            int end = _stationName[endName];
            FindPrice findPrice = null;
            if (end - start > 0)//南下
            {
                dec += "南下\n";
                findPrice = this.sorth;
            }
            else if(end - start < 0)//北上
            {
                dec += "北上\n";
                findPrice = this.north;
            }
            else
            {
                dec += "同站\n";
                findPrice = this.north;
            }

            decimal price = findPrice(start, end);
            price = (returTticket) ? price * 2 : price;

            dec +=  $"{(returTticket ? "來回票" : "單程票")}\n" +
                    $"從<{startName}>到<{endName}>\n" + 
                    $"價錢為:{this.Discount(price , returTticket , concessionTicket)}";

            return dec;
        }
    }
    class RailTransportEntity : RailTransport
    {
        public ComboBox StartList { get; set; }
        public ComboBox EndList { get; set; }

        public RailTransportEntity(ComboBox c1 ,ComboBox c2) 
        : base()
        {
            StartList = c1;
            EndList = c2;

            StartList.DataSource = StationName;
            EndList.DataSource = StationName;
        }
    }
}
