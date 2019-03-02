using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Coffee
/// </summary>
public class Coffee
{
    public Coffee(int id, string name, string type, double price, string country, string roast, string image,
        string review)
    {
        Id = id;
        Name = name;
        Type = type;
        Price = price;
        Country = country;
        Roast = roast;
        Image = image;
        Review = review;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Price { get; set; }

    public string Country { get; set; }

    public string Roast { get; set; }

    public string Image { get; set; }

    public string Review { get; set; }

}