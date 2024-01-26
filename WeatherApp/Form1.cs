using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string APIKey = "77d4737222e7827fecc4f307550c0d9b";

        private void btn_search_Click(object sender, EventArgs e)
        {
            getWeather();
            lab_city.Text=TbCity.Text;
            pictureBox1.Visible=true;
            label2.Visible=true;
            
        }
        private string LimitCharacters(string originalText, int maxLength)
        {
            if (originalText.Length > maxLength)
            {
                return originalText.Substring(0, maxLength);
            }
            else
            {
                return originalText;
            }
        }

        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TbCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                lab_condtion.Text = Info.weather[0].main;
                lbl_temp.Text = LimitCharacters(((Info.main.temp) - 273.15).ToString(),1);
                lab_detail.Text = Info.weather[0].description;
                lab_sunset.Text = convertDateTime(Info.sys.sunset).ToString();
                lab_sunrise.Text = convertDateTime(Info.sys.sunrise).ToString();
                lab_windspeed.Text = Info.wind.speed.ToString();
                lab_pressure.Text = Info.main.pressure.ToString();
                            

            }
            
        }
        DateTime convertDateTime(long millisec)

        {
            DateTime day = new DateTime(1970,1,1,0,0,0, DateTimeKind.Utc);
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lab_condtion_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lab_city_Click(object sender, EventArgs e)
        {

        }

        private void lab_sunset_Click(object sender, EventArgs e)
        {

        }
    }
}
