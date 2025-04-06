class Order
{
    public List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public decimal TotalCost()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product._price * product._quantity;
        }

        if (_customer._InUSA)
        {
            total += total + 5;
        }
        else
        {
            total += total + 35;
        }

        return total;
    }
    public string PackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product._quantity} x {product._name} @ {product._price:C}\n";
        }
        if (_customer._InUSA)
        {
            packingLabel += "Shipping: $5.00 (Domestic)\n";
        }
        else
        {
            packingLabel += "Shipping: $35.00 (International)\n";
        }
        packingLabel += $"Total Cost: {TotalCost():C}";
        return packingLabel;
    }
}