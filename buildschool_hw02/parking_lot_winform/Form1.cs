using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parking_lot_winform
{
    public partial class Form1 : Form
    {
        private PrkingLot _pl;
        public Form1()
        {
            InitializeComponent();
            Init();
            create();
        }
        private void create()
        {
            dtp_end.ValueChanged += Dtp_ValueChanged;
            dtpTime_end.ValueChanged += Dtp_ValueChanged;
            for(int i = 1; i <= 6; i++)
            {
                Button b = (Button)outDisply.Controls.Find($"speedUp{i}" ,true)[0];
                b.Click += speedUp_Click;
            }
            
        }

        private void speedUp_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Text.Contains("分"))
            {
                int n = int.Parse(b.Text.Remove(b.Text.LastIndexOf("分")).Trim());
                this.dtpTime_end.Value = this.dtpTime_end.Value.AddMinutes(n);
            }
            else if(b.Text.Contains("小時"))
            {
                int n = int.Parse(b.Text.Remove(b.Text.LastIndexOf("小時")).Trim());
                this.dtpTime_end.Value = this.dtpTime_end.Value.AddHours(n);
            }
            else if(b.Text.Contains("天"))
            {
                int n = int.Parse(b.Text.Remove(b.Text.LastIndexOf("天")).Trim());
                this.dtpTime_end.Value = this.dtpTime_end.Value.AddDays(n);
            }
            else if (b.Text.Contains("周"))
            {
                int n = int.Parse(b.Text.Remove(b.Text.LastIndexOf("周")).Trim());
                this.dtpTime_end.Value = this.dtpTime_end.Value.AddDays(n * 7);
            }
            cost_display.Text = "";
        }

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            TimeSpan checkAnotherDay = dtp.Value - _pl.EndTime;
            if(checkAnotherDay.TotalDays < 0)
            {
                dtp.Value = dtp.Value.AddDays(1);
            }
            this.dtp_end.Value = dtp.Value;
            this.dtpTime_end.Value = dtp.Value;

            if ((int)CalTimeSpan().TotalSeconds < 0)
            {
                MessageBox.Show($"不能小於起始時間!!!\n{CalTimeSpan()}");
                this.dtp_end.Value = this.dtp_start.Value;
                this.dtpTime_end.Value = this.dtpTime_start.Value;
            }
            else
            {
                _pl.EndTime = dtp.Value;
            }
            cost_display.Text = "";
        }

        private void Init()
        {
            _pl = new PrkingLot();

            this.dtp_start.Value = _pl.StartTime;
            this.dtpTime_start.Value = _pl.StartTime;
            this.dtp_end.Value = _pl.EndTime;
            this.dtpTime_end.Value = _pl.EndTime;

            outDisply.Enabled = false;
            regulation_display.Text = _pl.Cost.ToString();
            cost_display.Text = "";
        }
        private void Clock()
        {
            while(true)
            {
                this.dtp_start.Value = _pl.StartTime;
                this.dtpTime_start.Value = _pl.StartTime;
                this.dtp_end.Value = _pl.EndTime;
                this.dtpTime_end.Value = _pl.EndTime;

                Thread.Sleep(100);
            }
        }
        private TimeSpan CalTimeSpan()
        {
            DateTime ds = this.dtp_start.Value.Date;
            TimeSpan ts1 = this.dtpTime_start.Value - this.dtpTime_start.Value.Date;
            ds += ts1;

            DateTime de = this.dtp_end.Value.Date;
            TimeSpan ts2 = this.dtpTime_end.Value - this.dtpTime_end.Value.Date;
            de += ts2;

            return de - ds;
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            outDisply.Enabled = true;
        }
        private void restart_button_Click(object sender, EventArgs e)
        {
            Init();
        }
        private void pay_button_Click(object sender, EventArgs e)
        {
            cost_display.Text = _pl.Cost.Cal(CalTimeSpan());
        }

    }
}
