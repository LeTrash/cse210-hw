using System;
using System.Linq;
// Contains a list of products and a customer. Can calculate the total cost of the order, and can return a string for the packing label, and can return a string for the shipping label.
// The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer

class Order
{
    public Customer customer;
    private List<Product> products;

    public Order()
    {
        products = new List<Product>();
    }
    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }


    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.Price;
        }
        if (customer.Address.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += product.Name + "(ID: " + product.Id + ")" + " \n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = customer.Name + "\n" + customer.Address.GetAddressString();
        return shippingLabel;
    }



}