public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public bool _InUSA;
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _InUSA = LiveInUSA();
    }
    private bool LiveInUSA()
    {
        if (_country.ToLower() == "united states" || _country.ToLower() == "united states of america" || _country.ToLower() == "usa" || _country.ToLower() == "us")
        {
            return true;
        }
        return false;
    }
    public string DisplayAddress()
    {
        return ($"{_street}, {_city}, {_state}, {_country}");
    }
}