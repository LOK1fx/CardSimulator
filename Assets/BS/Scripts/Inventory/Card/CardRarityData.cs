using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "new CardRarityData", menuName = "Inventory/CardRarityData")]
public class CardRarityData : ScriptableObject
{
    public List<Rarity> Rarities = new List<Rarity>();
}

[Serializable]
public class Rarity
{
    public string Name;
    public Color Color;
}