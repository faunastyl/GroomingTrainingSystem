using System;

public class Location
{
    public string City { get; set; }
    public string Address { get; set; }

    public Location(string city, string address)
    {
        City = city;
        Address = address;
    }

    public override string ToString()
    {
        return $"{City}, {Address}";
    }
}