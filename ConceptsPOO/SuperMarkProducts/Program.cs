using SuperMarkProducts;
Console.WriteLine("Products");
Console.WriteLine("-----------------------------------------------------------");

Product product1 = new FixedPriceProduct()
{
    Id = 1,
    Description = "Leche colanta",
    Price = 2500M,
    Tax = 0.05F
};

Console.WriteLine(product1);

Product product2 = new VariablePriceProduct()
{
    Id = 2,
    Description = "Carne de res",
    Price = 5000M,
    Measurement = "Kilo",
    Quantity = 0.50F,
    Tax = 0.10F,

};

Console.WriteLine(product2);

Product product3 = new ComposedProduct()
{
    Id = 3,
    Description = "Ancheta #1",
    Discount = 0.12F,
    Products = new List<Product>() { product1, product2 }
};

Console.WriteLine(product3);


Invoice invoice1 = new Invoice();
invoice1.Addproduct(product1);
invoice1.Addproduct(product2);
invoice1.Addproduct(product3);
