using System;
// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
class Address
{

    private string zipCode;
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public string Street { get { return street; } }
    public string City { get { return city; } }
    public string State { get { return state; } }
    public string Country { get { return country; } }

    // public Boolean IsUSA(String Country)
    // {
    //     if (Country == "USA")
    //     {
    //         return false;
    //     }
    //     else
    //     {
    //         return false;
    //     }
    // }

    public bool IsInUSA()
    {
        return country == "USA";
    }

    public void DisplayAdd()
    {
        Console.WriteLine($"{street}, {city}, {state}, {zipCode}");
    }
}