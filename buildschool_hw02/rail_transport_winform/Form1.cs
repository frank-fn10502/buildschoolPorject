using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rail_transport_winform
{
    public partial class Form1 : Form
    {
        private RailTransportEntity _rte;
        public Form1()
        {
            InitializeComponent();
            _rte = new RailTransportEntity(startComboBox, endComboBox);
        }

        private void cal_button_Click(object sender, EventArgs e)
        {
            string startName = (string)startComboBox.SelectedItem;
            string endName = (string)endComboBox.SelectedItem;
            ticket_display.Text =  _rte.Calprice(startName , endName ,returTticket.Checked ,concessionTicket.Checked);
        }

        private void purchase_button_Click(object sender, EventArgs e)
        {
            ticket_display.Text = "";
            startComboBox.SelectedIndex = -1;
            endComboBox.SelectedIndex = -1;
        }
    }
}
