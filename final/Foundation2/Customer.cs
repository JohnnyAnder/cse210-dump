public class Customer(string shopper, Address address)
{
    private string _shopper = shopper;
    public Address _address = address;
    public bool _InUSA = address._InUSA;


    public void ShippingLabel()
    {
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"To: {_shopper}");
        Console.WriteLine(_address.DisplayAddress());
    }
}