using System;

class Address
{

    public string State = "";
    public string ZipCode = "";
    public string Street = "";
    public string City = "";
    public string Country = "";

    public string IsUSA(String Country)
    {
        if (Country == 'USA')
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void DisplayAdd()
    {
        Console.WriteLine($"{Street}, {City}, {State}, {ZipCode}");
    }
}