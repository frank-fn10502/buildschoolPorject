using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sat_Sun_InOneYear
{
    public partial class Form1 :Form
    {
        private Calendar myCalendar;
        public Form1()
        {
            InitializeComponent();

            yearType_comboBox.Items.Add("民國");
            yearType_comboBox.Items.Add("西元");
            yearType_comboBox.SelectedIndex = 0;
        }

        private void cal_button_Click(object sender ,EventArgs e)
        {
            if (input_numericUpDown.Text != "0")
            {
                string displayStr1 = $"使用迴圈({input_numericUpDown.Text}):\r\n", displayStr2 = $"未使用迴圈({input_numericUpDown.Text}):\r\n";
                int year = int.Parse(input_numericUpDown.Text);

                myCalendar = new Calendar(year ,(YearType)yearType_comboBox.SelectedIndex);
                myCalendar.calWithLoop();
                displayStr1 += myCalendar.ToString();

                myCalendar = new Calendar(year ,(YearType)yearType_comboBox.SelectedIndex);
                myCalendar.calWithOutLoop();
                displayStr2 += myCalendar.ToString();

                display_textBox.Text = $"{displayStr1}{displayStr2}";
            }
            else
            {
                MessageBox.Show("ㄟㄟㄟ!! 不能是零阿");
            }
        }

        private void yearType_comboBox_SelectedIndexChanged(object sender ,EventArgs e)
        {
            if (input_numericUpDown.Text != "0")
            {
                CultureInfo culture_TW = CultureInfo.CreateSpecificCulture("zh-TW");
                culture_TW.DateTimeFormat.Calendar = new TaiwanCalendar();
                int year = int.Parse(input_numericUpDown.Text);
                DateTime dateTime;

                if (yearType_comboBox.SelectedIndex == (int)YearType.ROCYEAR)
                {
                    if (year > 1911)
                    {
                        dateTime = new DateTime(year ,1 ,1);
                        input_numericUpDown.Text = dateTime.ToString("yyy" ,culture_TW);
                    }
                    else
                    {
                        input_numericUpDown.Text = "0";
                    }
                }
                else
                {                 
                    dateTime = DateTime.ParseExact(year.ToString() ,"yyy" ,culture_TW);
                    input_numericUpDown.Text = dateTime.Year.ToString();
                }
            }
        }
    }
}
