public class InventoryAddItemResult
{
    public string Message { get; private set; }
    public int ItemCount { get; private set; }
    public int IndexInInventory { get; private set; }

    public InventoryAddItemResult(string message, int itemCount, int indexInInventory)
    {
        Message = message;
        ItemCount = itemCount;
        IndexInInventory = indexInInventory;
    }
}