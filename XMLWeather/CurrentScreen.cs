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
    public partial class CurrentScreen : UserControl
    {     
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
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

            cityOutput.Parent = pictureBox1;
            cityOutput.Text = Form1.days[0].location;

            tempLabel.Parent = pictureBox1;
            tempLabel.Text = Form1.days[0].currentTemp + "°C"; 

            minLabel.Parent = pictureBox1;
            minTextLabel.Parent = pictureBox1;
            minTextLabel.Text = Form1.days[0].tempLow + "°";

            maxLabel.Parent = pictureBox1;
            maxTextLabel.Parent = pictureBox1;
            maxTextLabel.Text = Form1.days[0].tempHigh + "°";

            dateLabel.Parent = pictureBox1;
            dateLabel.Text = Form1.days[0].date;

            outdoorCondition.Parent = pictureBox1;
            outdoorCondition.Text = Form1.days[0].condition;

           
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
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
