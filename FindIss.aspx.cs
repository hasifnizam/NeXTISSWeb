using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FindIss : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    //protected void getWeatherInfo()
    //{
    //    string weatherAPIKey = "966ce9cc383692efc70ddfcac952c73c";
    //    string issWeatherLocation = "Kuala Lumpur";
    //    string strWeatherIssUrl = String.Format("https://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units=metric&cnt=1&APPID={1}", issWeatherLocation, weatherAPIKey);
    //    using (WebClient client = new WebClient())
    //    {
    //        string json = client.DownloadString(strWeatherIssUrl);
    //        WeatherInfo weatherinfo = (new JavaScriptSerializer()).Deserialize<WeatherInfo>(json);
    //        lblCity_Country.Text = weatherinfo.city.name + "," + weatherinfo.city.country;
    //        lblDescription.Text = weatherinfo.list[0].weather[0].description;
    //        imgCountryFlag.ImageUrl = string.Format("http://openweathermap.org/images/flags/{0}.png", weatherinfo.city.country.ToLower());
    //        lblTempMin.Text = string.Format("{0}.c", Math.Round(weatherinfo.list[0].temp.min, 1));
    //        lblTempMax.Text = string.Format("{0}.c", Math.Round(weatherinfo.list[0].temp.max, 1));
    //        lblTempDay.Text = string.Format("{0}.c", Math.Round(weatherinfo.list[0].temp.day, 1));
    //        lblTempNight.Text = string.Format("{0}.c", Math.Round(weatherinfo.list[0].temp.night, 1));
    //        lblHumidity.Text = weatherinfo.list[0].humidity.ToString();

    //    }
    //}

    protected void BtnSearchISS(object sender, EventArgs e)
    {
        System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("ms-MY");
        DateTime issDate = DateTime.Parse(dateChoosen.Text, cultureInfo);
        Session["IssDate"] = issDate;

        Response.Redirect("IssViewData.aspx");
    }

    //public class WeatherInfo
    //{
    //    public City city { get; set; }
    //    public List<List> list { get; set; }
    //}

    //public class City
    //{
    //    public string name { get; set; }
    //    public string country { get; set; }
    //}

    //public class Temp
    //{
    //    public double day { get; set; }
    //    public double min { get; set; }
    //    public double max { get; set; }
    //    public double night { get; set; }
    //}

    //public class Weather
    //{
    //    public string description { get; set; }
    //    public string icon { get; set; }
    //}

    //public class List
    //{
    //    public Temp temp { get; set; }
    //    public int humidity { get; set; }
    //    public List<Weather> weather { get; set; }
    //}
}