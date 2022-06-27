using System.Collections.Generic;

public class PlayerInventory : IInventory
{
    private List<InventoryItem> _items = new List<InventoryItem>();

    public void AddItem(object sender, InventoryItem item, out InventoryAddItemResult result)
    {
        _items.Add(item);

        result = new InventoryAddItemResult(true, "Succes", _items.Count - 1, 1);
    }

    public InventoryItem[] GetAllItems()
    {
        return _items.ToArray();
    }

    public InventoryItem GetItemAtIndex(int index)
    {
        return _items[index];
    }
}