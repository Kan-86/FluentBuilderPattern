// See https://aka.ms/new-console-template for more information



public class AddressBuilder
{
    private string _street;
    private string _city;
    private string _zip;
    private string? _state;
    private string _country;

    private AddressBuilder()
    {

    }

    public static AddressBuilder Empty() => new();

    public AddressBuilder WithStreet(string street)
    {
        _street = street;
        return this;
    }

    public AddressBuilder WithCity(string city)
    {
        _city = city;
        return this;
    }

    public AddressBuilder WithZip(string zip)
    {
        _zip = zip;
        return this;
    }

    public AddressBuilder WithState(string state)
    {
        _state = state;
        return this;
    }

    public AddressBuilder WithCountry(string country)
    {
        _country = country;
        return this;
    }

    public Address Build()
    {
        return new Address
        {
            City = _city,
            Country = _country,
            PostalCode = _zip,
            Street = _street,
            State = _state ?? "N/A",
        };
    }
}