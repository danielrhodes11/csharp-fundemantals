// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to Thrown for a Loop!");

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Football",
        Price = 15.00M,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010,
        Condition = 4.2
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 12,
        Sold = false,
        StockDate = new DateTime(2025, 12, 05),
        ManufactureYear = 1996,
        Condition = 8.9
    },
    new Product()
    {
        Name = "Bike",
        Price = 100,
        Sold = false,
        StockDate = new DateTime(2025, 06, 14),
        ManufactureYear = 2025,
        Condition = 6.7
    },
    new Product()
    {
        Name = "Frisbee",
        Price = 20,
        Sold = true,
        StockDate = new DateTime(2024, 10, 31),
        ManufactureYear = 2019,
        Condition = 3.3
    },
    new Product()
    {
        Name = "Tennis Ball",
        Price = 6,
        Sold = false,
        StockDate = new DateTime(2023, 01, 13),
        ManufactureYear = 1957,
        Condition = 2.5
    },
    new Product()
    {
        Name = "Baseball",
        Price = 5,
        Sold = true,
        StockDate = new DateTime(2025, 11, 28),
        ManufactureYear = 1997,
        Condition = 7.1
    }
};

decimal totalValue = 0.0M;
foreach (Product product in products)
{
    if (!product.Sold)
    {
        totalValue += product.Price;
    }
}
Console.WriteLine($"Total inventory value: ${totalValue}");


Console.WriteLine("Products:");

for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i].Name}");
}

Product chosenProduct = null;

while (chosenProduct == null)
{
    Console.WriteLine("Please enter a product number: ");
    try
    {
        int response = int.Parse(Console.ReadLine().Trim());
        chosenProduct = products[response - 1];
    }
    catch (FormatException)
    {
        Console.WriteLine("Please type only integers!");
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine("Please choose an existing item only!");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
        Console.WriteLine("Do better!");
    }
}

DateTime now = DateTime.Now;

TimeSpan timeInStock = now - chosenProduct.StockDate;
Console.WriteLine(@$"You chose:
{chosenProduct.Name}, which costs {chosenProduct.Price} dollars. It is {now.Year - chosenProduct.ManufactureYear} years old. It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")} Has a condition of {chosenProduct.Condition} out of 10");

