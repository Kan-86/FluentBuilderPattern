﻿// See https://aka.ms/new-console-template for more information
public class Order
{
    public int Number { get; init; }
    public DateTime CreatedOn { get; init; }
    public Address ShippingAddress { get; init; }
}

public class Address
{
    public string Street { get; init; }
    public string City { get; init; }
    public string State { get; init; }
    public string PostalCode { get; init; }
    public string Country { get; init; }
}
