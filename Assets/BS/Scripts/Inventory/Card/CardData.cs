using UnityEngine;

[CreateAssetMenu(fileName = "New CardData", menuName = "Inventory/CardData")]
public class CardData : InventoryItemData
{
    public int RarityIndex;
    public Sprite Sprite;
}