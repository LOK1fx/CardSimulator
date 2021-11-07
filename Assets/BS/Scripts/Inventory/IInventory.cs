public interface IInventory
{
    void AddItem(object sender, InventoryItem item, out InventoryAddItemResult result);
    InventoryItem GetItemAtIndex(int index);
    InventoryItem[] GetAllItems();
}