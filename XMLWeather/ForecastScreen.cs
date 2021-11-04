using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            if (Convert.ToInt32(Form1.days[0].conditionCode) == 800)
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.sunny_icon;
            }
            else if (Convert.ToInt32(Form1.days[0].conditionCode) >= 232 && Convert.ToInt32(Form1.days[0].conditionCode) <= 232)
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.thunder_icon;
            }
            else if (Convert.ToInt32(Form1.days[0].conditionCode) >= 600 && Convert.ToInt32(Form1.days[0].conditionCode) <= 622)
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.snow_icon;
            }
            else if (Convert.ToInt32(Form1.days[0].conditionCode) >= 500 && Convert.ToInt32(Form1.days[0].conditionCode) <= 531)
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.rain_icon;
            }
            else if (Convert.ToInt32(Form1.days[0].conditionCode) >= 801)
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.cloudy_icon;
            }
            date1.Text = Form1.days[0].date;
            min1.Text = Form1.days[0].tempLow + "°";
            max1.Text = Form1.days[0].tempHigh + "°";
        


            if (Convert.ToInt32(Form1.days[1].conditionCode) == 800)
            {
                pictureBox2.Image = XMLWeather.Properties.Resources.sunny_icon;
            }
            else if (Convert.ToInt32(Form1.days[1].conditionCode) >= 232 && Convert.ToInt32(Form1.days[1].conditionCode) <= 232)
            {
                pictureBox2.Image = XMLWeather.Properties.Resources.thunder_icon;
            }
            else if (Convert.ToInt32(Form1.days[1].conditionCode) >= 600 && Convert.ToInt32(Form1.days[1].conditionCode) <= 622)
            {
                pictureBox2.Image = XMLWeather.Properties.Resources.snow_icon;
            }
            else if (Convert.ToInt32(Form1.days[1].conditionCode) >= 500 && Convert.ToInt32(Form1.days[1].conditionCode) <= 531)
            {
                pictureBox2.Image = XMLWeather.Properties.Resources.rain_icon;
            }
            else if (Convert.ToInt32(Form1.days[1].conditionCode) >= 801)
            {
                pictureBox2.Image = XMLWeather.Properties.Resources.cloudy_icon;
            }
            date2.Text = Form1.days[1].date;
            min2.Text = Form1.days[1].tempLow + "°";
            max2.Text = Form1.days[1].tempHigh + "°";

            if (Convert.ToInt32(Form1.days[2].conditionCode) == 800)
            {
                pictureBox3.Image = XMLWeather.Properties.Resources.sunny_icon;
            }
            else if (Convert.ToInt32(Form1.days[2].conditionCode) >= 232 && Convert.ToInt32(Form1.days[2].conditionCode) <= 232)
            {
                pictureBox3.Image = XMLWeather.Properties.Resources.thunder_icon;
            }
            else if (Convert.ToInt32(Form1.days[2].conditionCode) >= 600 && Convert.ToInt32(Form1.days[2].conditionCode) <= 622)
            {
                pictureBox3.Image = XMLWeather.Properties.Resources.snow_icon;
            }
            else if (Convert.ToInt32(Form1.days[2].conditionCode) >= 500 && Convert.ToInt32(Form1.days[2].conditionCode) <= 531)
            {
                pictureBox3.Image = XMLWeather.Properties.Resources.rain_icon;
            }
            else if (Convert.ToInt32(Form1.days[2].conditionCode) >= 801)
            {
                pictureBox3.Image = XMLWeather.Properties.Resources.cloudy_icon;
            }
            date3.Text = Form1.days[2].date;
            min3.Text = Form1.days[2].tempLow + "°";
            max3.Text = Form1.days[2].tempHigh + "°";

            if (Convert.ToInt32(Form1.days[3].conditionCode) == 800)
            {
                pictureBox4.Image = XMLWeather.Properties.Resources.sunny_icon;
            }
            else if (Convert.ToInt32(Form1.days[3].conditionCode) >= 232 && Convert.ToInt32(Form1.days[0].conditionCode) <= 232)
            {
                pictureBox4.Image = XMLWeather.Properties.Resources.thunder_icon;
            }
            else if (Convert.ToInt32(Form1.days[3].conditionCode) >= 600 && Convert.ToInt32(Form1.days[0].conditionCode) <= 622)
            {
                pictureBox4.Image = XMLWeather.Properties.Resources.snow_icon;
            }
            else if (Convert.ToInt32(Form1.days[3].conditionCode) >= 500 && Convert.ToInt32(Form1.days[0].conditionCode) <= 531)
            {
                pictureBox4.Image = XMLWeather.Properties.Resources.rain_icon;
            }
            else if (Convert.ToInt32(Form1.days[3].conditionCode) >= 801)
            {
                pictureBox4.Image = XMLWeather.Properties.Resources.cloudy_icon;
            }
            date4.Text = Form1.days[3].date;
            min4.Text = Form1.days[3].tempLow + "°";
            max4.Text = Form1.days[3].tempHigh + "°";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen ss = new SearchScreen();
            f.Controls.Add(ss);
        }
    }
}
