public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // TODO: Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId= itemId;
        Price = price;
        QuantityInStock = quantityInStock;

    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // TODO: Update the item's price with the new price.
        Price= newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        QuantityInStock -= quantitySold;
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        if (QuantityInStock > 0)
        {
            return true;
        }
        else
            return false;
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine("Item Name:" + ItemName);
        Console.WriteLine( "Item ID:" + ItemId);
        Console.WriteLine("Price:" + Price);
        Console.WriteLine( "Quantity In Stock:" + QuantityInStock);
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        Console.WriteLine("First Items Details>>>");
        item1.PrintDetails();
        Console.WriteLine("");
        Console.WriteLine("Second Items Details>>>");
        item2.PrintDetails();
        // 2. Sell some items and then print the updated details.
        Console.WriteLine("");
        Console.WriteLine("Sell 5 Laptops>>>");
        item1.SellItem(5);
        item1.PrintDetails();

        Console.WriteLine("");
        Console.WriteLine("Sell 5 Smartphones>>>");
        item2.SellItem(5);
        item2.PrintDetails();


        // 3. Restock an item and print the updated details.
        Console.WriteLine("");
        Console.WriteLine("Restock Laptop with 2 Laptops>>>");
        item1.RestockItem(2);
        item1.PrintDetails();

        Console.WriteLine("");
        Console.WriteLine("Restock Smartphone with 2 Smartphones>>>");
        item2.RestockItem(2);
        item2.PrintDetails();

        // 4. Check if an item is in stock and print a message accordingly.
        //Check the first item (laptop)
        if (item1.IsInStock())
        {
            Console.WriteLine("");
            Console.WriteLine("Laptop is in stock, details as follows>>>");
            item1.PrintDetails();
        }
        else { Console.WriteLine("Laptop is not in stock"); }

        //Check the second item (Smartphone)
        if (item2.IsInStock())
        {
            Console.WriteLine("");
            Console.WriteLine("Smartphone is in stock, details as follows>>>");
            item2.PrintDetails();
        }
        else { Console.WriteLine("Smartphone is not in stock"); }

    }
}
