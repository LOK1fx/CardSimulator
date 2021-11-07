using System;
using UnityEngine;

[CreateAssetMenu(fileName = "New InventoryItemData", menuName = "Inventory/BaseInventoryItemData")]
public class InventoryItemData : ScriptableObject
{
    public string ID { get; private set; }
    public string Name;

#if UNITY_EDITOR

    [ContextMenu("Generate a new ID")]
    private void GenerateID()
    {
        ID = $"Bebra_InventoryItem#{Guid.NewGuid().ToString()}";
    }

    [ContextMenu("Print in console the ID")]
    private void PrintId()
    {
        if(String.IsNullOrEmpty(ID) == false)
        {
            Debug.Log($"{name} ID is: {ID}");
        }
        else
        {
            Debug.Log($"{name} the are no any ID");

            GenerateID();
        }  
    }

#endif
}