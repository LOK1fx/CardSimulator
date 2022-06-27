using UnityEngine;

public class CardRarityManager
{
    private static readonly string _pathToRaritiesData = "CardRarityData";

    private static bool _rarityListIsLoaded = false;
    private static CardRarityData _rarityData;

    public static bool TryGetRarityByIndex(int index, out Rarity rarity)
    {
        if(_rarityListIsLoaded == false)
        {
            _rarityData = Resources.Load<CardRarityData>(_pathToRaritiesData);
        }

        var rarityAtIndex = _rarityData.Rarities[index];

        if(rarityAtIndex != null)
        {
            rarity = rarityAtIndex;

            return true;
        }
        else
        {
            rarity = null;

            return false;
        }
    }
}