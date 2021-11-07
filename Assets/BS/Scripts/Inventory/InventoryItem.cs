public abstract class InventoryItem
{
    public InventoryItemData Data { get; private set; }

    public InventoryItem(InventoryItemData data)
    {
        Data = data;
    }
}