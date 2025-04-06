class Product
{
    private int _id;
    public string _name;
    public decimal _price;
    public int _quantity;
    public Product(int id, string name, decimal price, int quantity)
    {
        _id = id;
        _name = name;
        _price = price;
        _quantity = quantity;
    }
}