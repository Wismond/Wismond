// Fixed ItemManager class
public class ItemManager<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void RemoveItem(T item)
    {
        items.Remove(item);
    }

    public void PrintItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
