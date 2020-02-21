using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace constellation
{
    public partial class Form1 :Form
    {
        private LifeSpirits lifeSpirits;
        public Form1()
        {
            InitializeComponent();
            lifeSpirits = new LifeSpirits();
        }

        private void cal_button_Click(object sender ,EventArgs e)
        {
            constellation_display.Text = lifeSpirits.Cal(constellation.Value);
        }
    }
}
