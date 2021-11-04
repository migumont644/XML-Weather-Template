using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class SearchScreen : UserControl
    {
        public SearchScreen()
        {
            InitializeComponent();
         
        }
      
        public void SearchDisplayCurrent()
        {
            if (Convert.ToInt32(Form1.days[0].conditionCode) == 800)
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.Sunny3;
                pictureBox2.Image = XMLWeather.Properties.Resources.sunny_icon;
                pictureBox2.Parent = pictureBox1;
            }
            else if (Convert.ToInt32(Form1.days[0].conditionCode) >= 232 && Convert.ToInt32(Form1.days[0].conditionCode) <= 232)
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.thunder;
                pictureBox2.Image = XMLWeather.Properties.Resources.thunder_icon;
                pictureBox2.Parent = pictureBox1;
            }
            else if (Convert.ToInt32(Form1.days[0].conditionCode) >= 600 && Convert.ToInt32(Form1.days[0].conditionCode) <= 622)
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.snow;
                pictureBox2.Image = XMLWeather.Properties.Resources.snow_icon;
                pictureBox2.Parent = pictureBox1;
            }
            else if (Convert.ToInt32(Form1.days[0].conditionCode) >= 500 && Convert.ToInt32(Form1.days[0].conditionCode) <= 531)
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.rain31;
                pictureBox2.Image = XMLWeather.Properties.Resources.rain_icon;
                pictureBox2.Parent = pictureBox1;
            }
            else if (Convert.ToInt32(Form1.days[0].conditionCode) >= 801)
            {
                pictureBox1.Image = XMLWeather.Properties.Resources.cloudy;
                pictureBox2.Image = XMLWeather.Properties.Resources.cloudy_icon;
                pictureBox2.Parent = pictureBox1;
            }

            searchcityOutput.Parent = pictureBox1;
            searchcityOutput.Text = Form1.days[0].location;

            searchtempLabel.Parent = pictureBox1;
            searchtempLabel.Text = Form1.days[0].currentTemp + "°C";

            searchminLabel.Parent = pictureBox1;
            searchminTextLabel.Parent = pictureBox1;
            searchminTextLabel.Text = Form1.days[0].tempLow + "°";

            searchmaxLabel.Parent = pictureBox1;
            searchmaxTextLabel.Parent = pictureBox1;
            searchmaxTextLabel.Text = Form1.days[0].tempHigh + "°";

            searchdateLabel.Parent = pictureBox1;
            searchdateLabel.Text = Form1.days[0].date;

            searchoutdoorCondition.Parent = pictureBox1;
            searchoutdoorCondition.Text = Form1.days[0].condition;


        }
        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);

            cityLabel.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);

            cityLabel.Visible = false;
        }
    }
}
