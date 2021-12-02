using System;
using System.Data;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Runtime.Serialization.Json;

public partial class IssViewData : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["IssDate"] == null)
        {
            Response.Redirect("FindIss.aspx");
        }
        else
        {
            getIssDatePicker();
        }
    }

    protected void getIssDatePicker()
    {
        int countPositive = 0;
        int countNegative = 5;
        int countForLoopNegative = 5;
        int countForLoopPositive = 0;
        int valueMinusOn = 0;
        int valueAddOn = 0;
        int b = 0;
        int j = 0;

        System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("ms-MY");
        string dateChoosen = Session["IssDate"].ToString();

        DateTime issDate = DateTime.Parse(dateChoosen, cultureInfo);
        DateTime uniDate = issDate.ToUniversalTime();   //UTC Time
        string dateDisplay = issDate.ToString("dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);

        string[] oneHourBefore = new string[6];
        string[] oneHourAfter = new string[6];
        string[] timeStampBefore = new string[6];
        string[] timeStampAfter = new string[6];

        for (int a = 0; a > -6; a--)
        {
            valueMinusOn += b - 10;
            countNegative = countForLoopNegative;
            DateTime oneHour = uniDate.AddMinutes(valueMinusOn);
            DateTime oneHourGMT = issDate.AddMinutes(valueMinusOn);
            oneHourBefore[countNegative] = oneHourGMT.ToString("dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            countForLoopNegative--;

            long timestamp = ConvertToTimestamp(oneHour);
            timeStampBefore[countNegative] = timestamp.ToString();
        }

        for (int i = 0; i < 6; i++)
        {
            valueAddOn += j + 10;
            countPositive = countForLoopPositive;
            DateTime oneHour = uniDate.AddMinutes(valueAddOn);
            DateTime oneHourGMT = issDate.AddMinutes(valueAddOn);
            oneHourAfter[countPositive] = oneHourGMT.ToString("dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            countForLoopPositive++;

            long timestamp = ConvertToTimestamp(oneHour);
            timeStampAfter[countPositive] = timestamp.ToString();
        }

        firstDateData.Text = oneHourBefore[0];
        secondDateData.Text = oneHourBefore[1];
        thirdDateData.Text = oneHourBefore[2];
        forthDateData.Text = oneHourBefore[3];
        fifthDateData.Text = oneHourBefore[4];
        sixDateData.Text = oneHourBefore[5];
        sevenDateData.Text = dateDisplay;
        eightDateData.Text = oneHourAfter[0];
        nineDateData.Text = oneHourAfter[1];
        tenDateData.Text = oneHourAfter[2];
        elevenDateData.Text = oneHourAfter[3];
        twelveDateData.Text = oneHourAfter[4];
        thirteenDateData.Text = oneHourAfter[5];

        getIssData(timeStampBefore, timeStampAfter);
    }

    protected void getIssData(string[] timeStampBefore, string[] timeStampAfter)
    {
        System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-GB");
        string dateChoosen = Session["IssDate"].ToString();

        DateTime issDate = DateTime.Parse(dateChoosen, cultureInfo);
        DateTime uniDate = issDate.ToUniversalTime();   //UTC Time
        long timestampnow = ConvertToTimestamp(uniDate);

        string strIssUrl = String.Format("https://api.wheretheiss.at/v1/satellites/25544/positions?timestamps=" + timeStampBefore[0] + "," + timeStampBefore[1] + "," + timeStampBefore[2] 
            + "," + timeStampBefore[3] + "," + timeStampBefore[4] + "," + timeStampBefore[5] + "," + timestampnow + "," + timeStampAfter[0] + "," + timeStampAfter[1]
            + "," + timeStampAfter[2] + "," + timeStampAfter[3] + "," + timeStampAfter[4] + "," + timeStampAfter[5]);

        WebRequest requestObjGet = WebRequest.Create(strIssUrl);
        requestObjGet.Method = "GET";

        HttpWebResponse responeObjGet = null;
        responeObjGet = (HttpWebResponse)requestObjGet.GetResponse();

        string strResult = null;
        using (Stream stream = responeObjGet.GetResponseStream())
        {
            StreamReader sr = new StreamReader(stream);
            strResult = sr.ReadToEnd();
            sr.Close();
        }

        var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

        List<IssModel> objList = (List<IssModel>)serializer.Deserialize(strResult, typeof(List<IssModel>));


        foreach(IssModel obj in objList)
        {
            if(obj.timestamp == timeStampBefore[0])
            {
                string cityName = getLocationData(obj.latitude.ToString(), obj.longitude.ToString());
                string mapPreview = getLocationMap(obj.latitude.ToString(), obj.longitude.ToString());

                firstCityName.Text = cityName;
                firstLatitude.Text = obj.latitude.ToString();
                firstLongitude.Text = obj.longitude.ToString();
                firstAltitude.Text = obj.altitude.ToString();
                firstLocationMaps.Text = "<a href='" + mapPreview + "' class='btn btn-primary' target='_blank'>View on Maps</a>";
            }
            else if(obj.timestamp == timeStampBefore[1])
            {
                string cityName = getLocationData(obj.latitude.ToString(), obj.longitude.ToString());
                string mapPreview = getLocationMap(obj.latitude.ToString(), obj.longitude.ToString());

                secondCityName.Text = cityName;
                secondLatitude.Text = obj.latitude.ToString();
                secondLongitude.Text = obj.longitude.ToString();
                secondAltitude.Text = obj.altitude.ToString();
                secondLocationMaps.Text = "<a href='" + mapPreview + "' class='btn btn-primary' target='_blank'>View on Maps</a>";
            }
            else if(obj.timestamp == timeStampBefore[2])
            {
                string cityName = getLocationData(obj.latitude.ToString(), obj.longitude.ToString());
                string mapPreview = getLocationMap(obj.latitude.ToString(), obj.longitude.ToString());

                thirdCityName.Text = cityName;
                thirdLatitude.Text = obj.latitude.ToString();
                thirdLongitude.Text = obj.longitude.ToString();
                thirdAltitude.Text = obj.altitude.ToString();
                thirdLocationMaps.Text = "<a href='" + mapPreview + "' class='btn btn-primary' target='_blank'>View on Maps</a>";
            }
            else if(obj.timestamp == timeStampBefore[3])
            {
                string cityName = getLocationData(obj.latitude.ToString(), obj.longitude.ToString());
                string mapPreview = getLocationMap(obj.latitude.ToString(), obj.longitude.ToString());

                forthCityName.Text = cityName;
                forthLatitude.Text = obj.latitude.ToString();
                forthLongitude.Text = obj.longitude.ToString();
                forthAltitude.Text = obj.altitude.ToString();
                forthLocationMaps.Text = "<a href='" + mapPreview + "' class='btn btn-primary' target='_blank'>View on Maps</a>";
            }
            else if(obj.timestamp == timeStampBefore[4])
            {
                string cityName = getLocationData(obj.latitude.ToString(), obj.longitude.ToString());
                string mapPreview = getLocationMap(obj.latitude.ToString(), obj.longitude.ToString());

                fifthCityName.Text = cityName;
                fifthLatitude.Text = obj.latitude.ToString();
                fifthLongitude.Text = obj.longitude.ToString();
                fifthAltitude.Text = obj.altitude.ToString();
                fifthLocationMaps.Text = "<a href='" + mapPreview + "' class='btn btn-primary' target='_blank'>View on Maps</a>";
            }
            else if(obj.timestamp == timeStampBefore[5])
            {
                string cityName = getLocationData(obj.latitude.ToString(), obj.longitude.ToString());
                string mapPreview = getLocationMap(obj.latitude.ToString(), obj.longitude.ToString());

                sixCityName.Text = cityName;
                sixLatitude.Text = obj.latitude.ToString();
                sixLongitude.Text = obj.longitude.ToString();
                sixAltitude.Text = obj.altitude.ToString();
                sixLocationMaps.Text = "<a href='" + mapPreview + "' class='btn btn-primary' target='_blank'>View on Maps</a>";
            }
            else if(obj.timestamp == timestampnow.ToString())
            {
                string cityName = getLocationData(obj.latitude.ToString(), obj.longitude.ToString());
                string mapPreview = getLocationMap(obj.latitude.ToString(), obj.longitude.ToString());

                sevenCityName.Text = cityName;
                sevenLatitude.Text = obj.latitude.ToString();
                sevenLongitude.Text = obj.longitude.ToString();
                sevenAltitude.Text = obj.altitude.ToString();
                sevenLocationMaps.Text = "<a href='" + mapPreview + "' class='btn btn-primary' target='_blank'>View on Maps</a>";
            }
            else if(obj.timestamp == timeStampAfter[0])
            {
                string cityName = getLocationData(obj.latitude.ToString(), obj.longitude.ToString());
                string mapPreview = getLocationMap(obj.latitude.ToString(), obj.longitude.ToString());

                eightCityName.Text = cityName;
                eightLatitude.Text = obj.latitude.ToString();
                eightLongitude.Text = obj.longitude.ToString();
                eightAltitude.Text = obj.altitude.ToString();
                eightLocationMaps.Text = "<a href='" + mapPreview + "' class='btn btn-primary' target='_blank'>View on Maps</a>";
            }
            else if(obj.timestamp == timeStampAfter[1])
            {
                string cityName = getLocationData(obj.latitude.ToString(), obj.longitude.ToString());
                string mapPreview = getLocationMap(obj.latitude.ToString(), obj.longitude.ToString());

                nineCityName.Text = cityName;
                nineLatitude.Text = obj.latitude.ToString();
                nineLongitude.Text = obj.longitude.ToString();
                nineAltitude.Text = obj.altitude.ToString();
                nineLocationMaps.Text = "<a href='" + mapPreview + "' class='btn btn-primary' target='_blank'>View on Maps</a>";
            }
            else if(obj.timestamp == timeStampAfter[2])
            {
                string cityName = getLocationData(obj.latitude.ToString(), obj.longitude.ToString());
                string mapPreview = getLocationMap(obj.latitude.ToString(), obj.longitude.ToString());

                tenCityName.Text = cityName;
                tenLatitude.Text = obj.latitude.ToString();
                tenLongitude.Text = obj.longitude.ToString();
                tenAltitude.Text = obj.altitude.ToString();
                tenLocationMaps.Text = "<a href='" + mapPreview + "' class='btn btn-primary' target='_blank'>View on Maps</a>";
            }
            else if(obj.timestamp == timeStampAfter[3])
            {
                string cityName = getLocationData(obj.latitude.ToString(), obj.longitude.ToString());
                string mapPreview = getLocationMap(obj.latitude.ToString(), obj.longitude.ToString());

                elevenCityName.Text = cityName;
                elevenLatitude.Text = obj.latitude.ToString();
                elevenLongitude.Text = obj.longitude.ToString();
                elevenAltitude.Text = obj.altitude.ToString();
                elevenLocationMaps.Text = "<a href='" + mapPreview + "' class='btn btn-primary' target='_blank'>View on Maps</a>";
            }
            else if(obj.timestamp == timeStampAfter[4])
            {
                string cityName = getLocationData(obj.latitude.ToString(), obj.longitude.ToString());
                string mapPreview = getLocationMap(obj.latitude.ToString(), obj.longitude.ToString());

                twelveCityName.Text = cityName;
                twelveLatitude.Text = obj.latitude.ToString();
                twelveLongitude.Text = obj.longitude.ToString();
                twelveAltitude.Text = obj.altitude.ToString();
                twelveLocationMaps.Text = "<a href='" + mapPreview + "' class='btn btn-primary' target='_blank'>View on Maps</a>";
            }
            else if(obj.timestamp == timeStampAfter[5])
            {
                string cityName = getLocationData(obj.latitude.ToString(), obj.longitude.ToString());
                string mapPreview = getLocationMap(obj.latitude.ToString(), obj.longitude.ToString());

                thirteenCityName.Text = cityName;
                thirteenLatitude.Text = obj.latitude.ToString();
                thirteenLongitude.Text = obj.longitude.ToString();
                thirteenAltitude.Text = obj.altitude.ToString();
                thirteenLocationMaps.Text = "<a href='" + mapPreview + "' class='btn btn-primary' target='_blank'>View on Maps</a>";
            }
        }
    }

    public string getLocationData(string latitude, string longitude)
    {
        string cityName = "";
        string strLocationIssUrl = String.Format("https://api.wheretheiss.at/v1/coordinates/" + latitude + "," + longitude);

        WebRequest requestObjGet = WebRequest.Create(strLocationIssUrl);
        requestObjGet.Method = "GET";

        HttpWebResponse responeObjGet = null;
        responeObjGet = (HttpWebResponse)requestObjGet.GetResponse();

        string strLocationResult = null;
        using (Stream stream = responeObjGet.GetResponseStream())
        {
            StreamReader sr = new StreamReader(stream);
            strLocationResult = sr.ReadToEnd();
            sr.Close();
        }

        using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(strLocationResult)))
        {
            // Deserialization from JSON
            DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(IssLocationModel));
            IssLocationModel issLocationObj = (IssLocationModel)deserializer.ReadObject(ms);
            if(issLocationObj.country_code != "??")
            {
                cityName = issLocationObj.timezone_id;
            }
            else
            {
                cityName = "??";
            }
             
        }

        return cityName;
    }

    public string getLocationMap(string latitude, string longitude)
    {
        string issLocationMap = "";
        string strLocationIssUrl = String.Format("https://api.wheretheiss.at/v1/coordinates/" + latitude + "," + longitude);

        WebRequest requestObjGet = WebRequest.Create(strLocationIssUrl);
        requestObjGet.Method = "GET";

        HttpWebResponse responeObjGet = null;
        responeObjGet = (HttpWebResponse)requestObjGet.GetResponse();

        string strLocationResult = null;
        using (Stream stream = responeObjGet.GetResponseStream())
        {
            StreamReader sr = new StreamReader(stream);
            strLocationResult = sr.ReadToEnd();
            sr.Close();
        }

        using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(strLocationResult)))
        {
            // Deserialization from JSON
            DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(IssLocationModel));
            IssLocationModel issLocationObj = (IssLocationModel)deserializer.ReadObject(ms);
            issLocationMap = issLocationObj.map_url;
        }

        return issLocationMap;
    }

    //public string getWeatherLocation(string latitude, string longitude, string timestamp)
    //{
    //    string weatherAPIKey = "966ce9cc383692efc70ddfcac952c73c";
    //    string issWeatherLocation = "";
    //    string strWeatherIssUrl = String.Format("https://api.openweathermap.org/data/2.5/weather?lat" + latitude + "&lon=" + longitude + "&appid=" + weatherAPIKey);

    //    WebRequest requestObjGet = WebRequest.Create(strWeatherIssUrl);
    //    requestObjGet.Method = "GET";

    //    HttpWebResponse responeObjGet = null;
    //    responeObjGet = (HttpWebResponse)requestObjGet.GetResponse();

    //    string strWeatherResult = null;
    //    using (Stream stream = responeObjGet.GetResponseStream())
    //    {
    //        StreamReader sr = new StreamReader(stream);
    //        strWeatherResult = sr.ReadToEnd();
    //        sr.Close();
    //    }

    //    using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(strWeatherResult)))
    //    {
    //        // Deserialization from JSON
    //        DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(IssLocationModel));
    //        IssLocationModel issLocationObj = (IssLocationModel)deserializer.ReadObject(ms);
    //        issWeatherLocation = issLocationObj.map_url;
    //        Response.Write(issWeatherLocation);
    //        Response.End();
    //    }

    //    //return issWeatherLocation;
    //    return null;
    //}


    private long ConvertToTimestamp(DateTime value)
    {
        long epoch = (value.Ticks - 621355968000000000) / 10000000;
        return epoch;
    }
}