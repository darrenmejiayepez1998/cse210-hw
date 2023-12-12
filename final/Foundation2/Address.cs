using System;
using System.Collections.Generic;

public class Address
{
    public string Street {get; private set; }
    public string City {get; private set; }
    public string StateProvince {get; private set; }
    public string Country {get; private set; }

    public Address(string street, string city, string stateProvince, string country)
    {
        Street = street;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.ToLower() == "usa";
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {StateProvince}, {Country}";
    }
}