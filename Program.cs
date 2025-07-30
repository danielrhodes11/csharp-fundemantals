// See https://aka.ms/new-console-template for more information


using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Welcome to Thrown for a Loop!");

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Football",
        Price = 15,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 12,
        Sold = false,
        StockDate = new DateTime(2025, 12, 05),
        ManufactureYear = 1996
    },
    new Product()
    {
        Name = "Bike",
        Price = 100,
        Sold = false,
        StockDate = new DateTime(2025, 06, 14),
        ManufactureYear = 2025
    },
    new Product()
    {
        Name = "Frisbee",
        Price = 20,
        Sold = true,
        StockDate = new DateTime(2024, 10, 31),
        ManufactureYear = 2019
    },
    new Product()
    {
        Name = "Tennis Ball",
        Price = 6,
        Sold = false,
        StockDate = new DateTime(2023, 01, 13),
        ManufactureYear = 1957
    },
    new Product()
    {
        Name = "Baseball",
        Price = 5,
        Sold = true,
        StockDate = new DateTime(2025, 11, 28),
        ManufactureYear = 1997
    }
};

Console.WriteLine("Products:");

for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i].Name}");
}

Console.WriteLine("Please enter a product number: ");

int response = int.Parse(Console.ReadLine().Trim());

while (response < 1 || response > products.Count)
{
    Console.WriteLine($"Choose a number between 1 and {products.Count}!");
    response = int.Parse(Console.ReadLine().Trim());
}

Product chosenProduct = products[response - 1];

DateTime now = DateTime.Now;

TimeSpan timeInStock = now - chosenProduct.StockDate;
Console.WriteLine(@$"You chose:
{chosenProduct.Name}, which costs {chosenProduct.Price} dollars. It is {now.Year - chosenProduct.ManufactureYear} years old. It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}");

