using System;

// Contains the name, product id, price, and quantity of each product.
// The price of this product is computed by multiplying the price and the quantity.
class Product
{
    private string _pname = "";
    private string _pid;
    private double _price;
    private int _quantity;
    // public int _totprice = 0;

    // public void tot()
    // {
    //     _totprice = _price * _totprice;
    // }

    public Product(string name, string id, double price, int quantity)
    {
        this._pname = name;
        this._pid = id;
        this._price = price;
        this._quantity = quantity;
    }

    public string Name { get { return _pname; } }
    public string Id { get { return _pid; } }
    public double Price { get { return _price; } }
    public int Quant { get { return _quantity; } }

    public double TotalPrice()
    {
        return _price * _quantity;
    }

}