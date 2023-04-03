using System;

// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)

class Customer
{
    private string _cname = "";
    private Address address;

    public Customer(string name, Address address)
    {
        this._cname = name;
        this.address = address;
    }

    public string Name { get { return _cname; } }
    public Address Address { get { return address; } }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }


}