using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        //create list to hold day objects
      public static  List<Day> days = new List<Day>();


        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            //ExtractSearchCurrent();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //create a day object
                Day newDay= new Day();

                //fill day object with required data
                reader.ReadToFollowing("time");
                newDay.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                newDay.conditionCode = reader.GetAttribute("number");

                reader.ReadToFollowing("temperature");

                newDay.tempLow = Convert.ToDouble(reader.GetAttribute("min")).ToString("0");
                //newDay.tempLow = reader.GetAttribute("min");

                newDay.tempHigh = Convert.ToDouble(reader.GetAttribute("max")).ToString("0");
                //newDay.tempHigh = reader.GetAttribute("max");
         

                //if day object not null add to the days list
                days.Add(newDay);
            }
        }

        public static void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it

            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            reader.ReadToFollowing("weather");
            days[0].conditionCode = reader.GetAttribute("number");
            days[0].condition = reader.GetAttribute("value");

        }

        private void ExtractSearchCurrentLondon()
        {

            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=London,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            reader.ReadToFollowing("weather");
            days[0].conditionCode = reader.GetAttribute("number");
            days[0].condition = reader.GetAttribute("value");
        }

        private void ExtractSearchCurrentKitchener()
        {

            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Kitchener,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            reader.ReadToFollowing("weather");
            days[0].conditionCode = reader.GetAttribute("number");
            days[0].condition = reader.GetAttribute("value");
        }
        

             private void ExtractSearchCurrentOttawa()
        {

            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Ottawa,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            reader.ReadToFollowing("weather");
            days[0].conditionCode = reader.GetAttribute("number");
            days[0].condition = reader.GetAttribute("value");
        }

        private void ExtractSearchCurrentToronto()
        {

            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Toronto,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            reader.ReadToFollowing("weather");
            days[0].conditionCode = reader.GetAttribute("number");
            days[0].condition = reader.GetAttribute("value");
        }
        

             private void ExtractSearchCurrentVancouver()
        {

            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Vancouver,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            reader.ReadToFollowing("weather");
            days[0].conditionCode = reader.GetAttribute("number");
            days[0].condition = reader.GetAttribute("value");
        }
    }
}
//XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=" + urlCity + "&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");