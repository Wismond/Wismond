public class Program
{
    private static readonly IItemManager<string> itemManager = new ItemManager<string>();
    private static readonly IItemManager<Fruit> fruitManager = new ItemManager<Fruit>();

    public static void Main(string[] args)
    {
        DemonstrateStringItems();
        DemonstrateFruitItems();
    }

    private static void DemonstrateStringItems()
    {
        itemManager.AddItem("Book");
        itemManager.AddItem("Pen");
        itemManager.AddItem("Notebook");
        
        Console.WriteLine("All string items:");
        itemManager.PrintItems();
        
        itemManager.RemoveItem("Pen");
        Console.WriteLine("\nAfter removing 'Pen':");
        itemManager.PrintItems();
    }

    private static void DemonstrateFruitItems()
    {
        fruitManager.AddItem(new Fruit { Name = "Apple", Color = "Red" });
        fruitManager.AddItem(new Fruit { Name = "Banana", Color = "Yellow" });
        
        Console.WriteLine("\nAll fruit items:");
        fruitManager.PrintItems();
    }
}
