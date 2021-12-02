using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IssModel
/// </summary>
public class IssModel
{
    public string name { get; set; }
    public int id { get; set; }
    public string latitude { get; set; }
    public string longitude { get; set; }
    public string altitude { get; set; }
    public float velocity { get; set; }
    public string visibility { get; set; }
    public float footprint { get; set; }
    public string timestamp { get; set; }
    public float daynum { get; set; }
    public float solar_lat { get; set; }
    public float solar_lon { get; set; }
    public string units { get; set; }

    public IssModel()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}