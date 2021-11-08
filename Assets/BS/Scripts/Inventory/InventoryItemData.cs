using System;
using UnityEngine;

[CreateAssetMenu(fileName = "New InventoryItemData", menuName = "Inventory/BaseInventoryItemData")]
public class InventoryItemData : ScriptableObject
{
    [SerializeField] private string _id;

    [Space]
    public string Name;

    //Because for some reason unity doesn't save
    //the id if it { get; private set; }
    public string GetId()
    {
        return _id;
    }

#if UNITY_EDITOR

    private void OnValidate()
    {
        if(!string.IsNullOrEmpty(_id)) { return; }

        GenerateID();
        PrintId();
    }

    [ContextMenu("Generate a new ID")]
    private void GenerateID()
    {
        _id = $"Bebra_InventoryItem#{Guid.NewGuid().ToString()}";
    }

    [ContextMenu("Print in console the ID")]
    private void PrintId()
    {
        if(string.IsNullOrEmpty(_id) == false)
        {
            Debug.Log($"{name} ID is: {_id}");
        }
        else
        {
            Debug.Log($"{name} the are no any ID");

            GenerateID();
        }  
    }

#endif
}