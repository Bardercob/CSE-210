class Order
{
    private List<Product> _productList;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _productList = new List<Product>();
    }

    public int FindTotalCost()
    {
        int totalCost = 0;
        foreach(Product product in _productList)
        {
            totalCost += product.FindTotalCost();
        }
        if (_customer.InUSA())
        {
            totalCost += 5;
            return totalCost;
        }
        else
        {
            totalCost += 35;
            return totalCost;
        }
    }

    public void PackingLabel()
    {
        foreach(Product product in _productList)
        {
            Console.WriteLine($"{product.GetName}: {product.GetID}");
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine($"{_customer.GetName()}\n{_customer.GetAddress()}");
    }
}