// See https://aka.ms/new-console-template for more information
Console.WriteLine("Fluent Builder Pattern");


var order = OrderBuilder.Empty()
    .WithNumber(10)
    .WithCreatedOn(DateTime.UtcNow)
    .WithShippingAddress(b => b
        .WithCity("Reykjavik")
        .WithStreet("Dúfnahólar 10")
        .WithZip("111")
        .WithCountry("Iceland"))
    .Build();

List<Order[]> orders = Enumerable
    .Range(1, 10)
    .Select(number => 
        OrderBuilder.Empty()
            .WithNumber(number)
            .WithCreatedOn(DateTime.UtcNow)
            .WithShippingAddress(b => b
            .WithCity("Reykjavík")
            .WithZip("111")
            .WithStreet("Dúfnahólar 10")
            .WithCountry("Iceland"))
            .Build())
    .Chunk(2)
    .ToList();

Console.WriteLine(order);
