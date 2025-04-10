using System.Security.Cryptography;

class Product
{
    private string _productName;
    private int _productID;
    private int _pricePerUnit;
    private int _quantity;

    public Product(string productName, int productID, int pricePerUnit, int quantity)
    {
        _productName = productName;
        _pricePerUnit = pricePerUnit;
        _productID = productID;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _productName;
    }

    public int GetID()
    {
        return _productID;
    }

    public int FindTotalCost()
    {
        return _pricePerUnit * _quantity;
    }
}