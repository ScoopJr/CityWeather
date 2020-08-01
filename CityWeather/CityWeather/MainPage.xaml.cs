using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Xml.Linq;
using System.Net;

namespace CityWeather
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        bool isBigFont = false;
        bool isTheme = false;

        public MainPage()
        {
            InitializeComponent();
        }


        private void mnuChangeFont_clicked(object sender, EventArgs e)
        {
            if (isBigFont)
            {
                lblCityWeather.FontSize = 16;
                lblSelectCity.FontSize = 16;
                pckCity.FontSize = 16;
                lblCurrentWeather.FontSize = 16;
                lblCurrentTemperature.FontSize = 16;
                entCurrentTemperature.FontSize = 16;
                lblSunriseTime.FontSize = 16;
                entSunriseTime.FontSize = 16;
                lblSunsetTime.FontSize = 16;
                entSunsetTime.FontSize = 16;
                lblWindSpeed.FontSize = 16;
                entWindSpeed.FontSize = 16;
                lblHumidity.FontSize = 16;
                entHumidity.FontSize = 16;
                isBigFont = false;
            }
            else
            {
                lblCityWeather.FontSize = 24;
                lblSelectCity.FontSize = 24;
                pckCity.FontSize = 24;
                lblCurrentWeather.FontSize = 24;
                lblCurrentTemperature.FontSize = 24;
                entCurrentTemperature.FontSize = 24;
                lblSunriseTime.FontSize = 24;
                entSunriseTime.FontSize = 24;
                lblSunsetTime.FontSize = 24;
                entSunsetTime.FontSize = 24;
                lblWindSpeed.FontSize = 24;
                entWindSpeed.FontSize = 24;
                lblHumidity.FontSize = 24;
                entHumidity.FontSize = 24;
                isBigFont = true;
            }
        }


        private void mnuChangeTheme_clicked(object sender, EventArgs e)
        {
            if (isTheme)
            {
                lblCityWeather.BackgroundColor = Color.White;
                lblSelectCity.BackgroundColor = Color.White;
                pckCity.BackgroundColor = Color.White;
                lblCurrentWeather.BackgroundColor = Color.White;
                lblCurrentTemperature.BackgroundColor = Color.White;
                entCurrentTemperature.BackgroundColor = Color.White;
                lblSunriseTime.BackgroundColor = Color.White;
                entSunriseTime.BackgroundColor = Color.White;
                lblSunsetTime.BackgroundColor = Color.White;
                entSunsetTime.BackgroundColor = Color.White;
                lblWindSpeed.BackgroundColor = Color.White;
                entWindSpeed.BackgroundColor = Color.White;
                lblHumidity.BackgroundColor = Color.White;
                entHumidity.BackgroundColor = Color.White;

                isTheme = false;
            }
            else
            {
                lblCityWeather.BackgroundColor = Color.Salmon;
                lblSelectCity.BackgroundColor = Color.DarkGray;
                pckCity.BackgroundColor = Color.DarkGray;
                lblCurrentWeather.BackgroundColor = Color.DarkGray;
                lblCurrentTemperature.BackgroundColor = Color.DarkGray;
                entCurrentTemperature.BackgroundColor = Color.DarkGray;
                lblSunriseTime.BackgroundColor = Color.DarkGray;
                entSunriseTime.BackgroundColor = Color.DarkGray;
                lblSunsetTime.BackgroundColor = Color.DarkGray;
                entSunsetTime.BackgroundColor = Color.DarkGray;
                lblWindSpeed.BackgroundColor = Color.DarkGray;
                entWindSpeed.BackgroundColor = Color.DarkGray;
                lblHumidity.BackgroundColor = Color.DarkGray;
                entHumidity.BackgroundColor = Color.DarkGray;

                lblCityWeather.TextColor = Color.White;
                lblSelectCity.TextColor = Color.White;
                pckCity.TextColor = Color.White;
                lblCurrentWeather.TextColor = Color.White;
                lblCurrentTemperature.TextColor = Color.White;
                entCurrentTemperature.TextColor = Color.White;
                lblSunriseTime.TextColor = Color.White;
                entSunriseTime.TextColor = Color.White;
                lblSunsetTime.TextColor = Color.White;
                entSunsetTime.TextColor = Color.White;
                lblWindSpeed.TextColor = Color.White;
                entWindSpeed.TextColor = Color.White;
                lblHumidity.TextColor = Color.White;
                entHumidity.TextColor = Color.White;
                
                isTheme = true;
            }
        }


        private void PickerItem_selected(object sender, EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("buttonClick.wav");
            player.Play();

            getWeatherInfo();
        }


        private async void getWeatherInfo()
        {

            //https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/picker/populating-itemssource

            if (pckCity.SelectedIndex == 0)
            {
                string query =
                @"http://api.openweathermap.org/data/2.5/weather?q=Adelaide,AU&APPID=98e9ee932a07bd57b69bb8c9ba72819e&units=metric&mode=xml";
                WebRequest req = WebRequest.Create(query);
                WebResponse res = await req.GetResponseAsync();
                XDocument xdoc = XDocument.Load(res.GetResponseStream());

                PopulateValues(xdoc);
            }

            if (pckCity.SelectedIndex == 1)
            {
                string query =
                @"http://api.openweathermap.org/data/2.5/weather?q=Brisbane,AU&APPID=98e9ee932a07bd57b69bb8c9ba72819e&units=metric&mode=xml";
                WebRequest req = WebRequest.Create(query);
                WebResponse res = await req.GetResponseAsync();
                XDocument xdoc = XDocument.Load(res.GetResponseStream());
                PopulateValues(xdoc);
            }

            if (pckCity.SelectedIndex == 2)
            {
                string query =
                @"http://api.openweathermap.org/data/2.5/weather?q=Canberra,AU&APPID=98e9ee932a07bd57b69bb8c9ba72819e&units=metric&mode=xml";
                WebRequest req = WebRequest.Create(query);
                WebResponse res = await req.GetResponseAsync();
                XDocument xdoc = XDocument.Load(res.GetResponseStream());

                PopulateValues(xdoc);
            }

            if (pckCity.SelectedIndex == 3)
            {
                string query =
                @"http://api.openweathermap.org/data/2.5/weather?q=Darwin,AU&APPID=98e9ee932a07bd57b69bb8c9ba72819e&units=metric&mode=xml";
                WebRequest req = WebRequest.Create(query);
                WebResponse res = await req.GetResponseAsync();
                XDocument xdoc = XDocument.Load(res.GetResponseStream());

                PopulateValues(xdoc);
            }

            if (pckCity.SelectedIndex == 4)
            {
                string query =
                @"http://api.openweathermap.org/data/2.5/weather?q=Hobart,AU&APPID=98e9ee932a07bd57b69bb8c9ba72819e&units=metric&mode=xml";
                WebRequest req = WebRequest.Create(query);
                WebResponse res = await req.GetResponseAsync();
                XDocument xdoc = XDocument.Load(res.GetResponseStream());

                PopulateValues(xdoc);
            }

            if (pckCity.SelectedIndex == 5)
            {
                string query =
                @"http://api.openweathermap.org/data/2.5/weather?q=Melbourne,AU&APPID=98e9ee932a07bd57b69bb8c9ba72819e&units=metric&mode=xml";
                WebRequest req = WebRequest.Create(query);
                WebResponse res = await req.GetResponseAsync();
                XDocument xdoc = XDocument.Load(res.GetResponseStream());

                PopulateValues(xdoc);
            }

            if (pckCity.SelectedIndex == 6)
            {
                string query =
                @"http://api.openweathermap.org/data/2.5/weather?q=Perth,AU&APPID=98e9ee932a07bd57b69bb8c9ba72819e&units=metric&mode=xml";
                WebRequest req = WebRequest.Create(query);
                WebResponse res = await req.GetResponseAsync();
                XDocument xdoc = XDocument.Load(res.GetResponseStream());

                PopulateValues(xdoc);
            }

            if (pckCity.SelectedIndex == 7)
            {
                string query =
                @"http://api.openweathermap.org/data/2.5/weather?q=Sydney,AU&APPID=98e9ee932a07bd57b69bb8c9ba72819e&units=metric&mode=xml";
                WebRequest req = WebRequest.Create(query);
                WebResponse res = await req.GetResponseAsync();
                XDocument xdoc = XDocument.Load(res.GetResponseStream());

                PopulateValues(xdoc);
            }

        }


        private void PopulateValues(XDocument xdoc)
        {
            entCurrentTemperature.Text = xdoc.Root.Element("temperature").Attribute("value").Value;
            entSunriseTime.Text = xdoc.Root.Element("city").Element("sun").Attribute("rise").Value; 
            entSunsetTime.Text = xdoc.Root.Element("city").Element("sun").Attribute("set").Value; 
            entWindSpeed.Text = xdoc.Root.Element("wind").Element("speed").Attribute("value").Value;
            entHumidity.Text = xdoc.Root.Element("humidity").Attribute("value").Value;
        }
    }
}

