public class InventoryAddItemResult
{
    public bool ItemAdded { get; private set; }
    public string Message { get; private set; }
    public int ItemCount { get; private set; }
    public int IndexInInventory { get; private set; }

    public InventoryAddItemResult(bool isAdded, string message, int indexInInventory, int itemCount = 1)
    {
        ItemAdded = isAdded;
        Message = message;
        ItemCount = itemCount;
        IndexInInventory = indexInInventory;
    }

    public InventoryAddItemResult(bool isAdded, int indexInInventory, int itemCount = 1)
    {
        ItemAdded = isAdded;
        ItemCount = itemCount;
        IndexInInventory = indexInInventory;

        if(ItemAdded)
        {
            Message = "Succes";
        }
        else
        {
            Message = "Unknow error";
        }
    }
}