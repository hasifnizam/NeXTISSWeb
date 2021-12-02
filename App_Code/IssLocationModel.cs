using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IssLocationModel
/// </summary>
public class IssLocationModel
{
    public string latitude { get; set; }
    public string longitude { get; set; }
    public string timezone_id { get; set; }
    public string offset { get; set; }
    public string country_code { get; set; }
    public string map_url { get; set; }

    public IssLocationModel()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}