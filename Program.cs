// See https://aka.ms/new-console-template for more information


Console.WriteLine("Welcome to Thrown for a Loop!");

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Football",
        Price = 15,
        Sold = false
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 12,
        Sold = false
    },
    new Product()
    {
        Name = "Bike",
        Price = 100,
        Sold = false
    },
    new Product()
    {
        Name = "Frisbee",
        Price = 20,
        Sold = true
    },
    new Product()
    {
        Name = "Tennis Ball",
        Price = 6,
        Sold = false
    },
    new Product()
    {
        Name = "Baseball",
        Price = 5,
        Sold = true
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

Console.WriteLine($"You chose: {chosenProduct.Name}, which costs {chosenProduct.Price} dollars and is {(chosenProduct.Sold ? "" : "not ")}sold.");
