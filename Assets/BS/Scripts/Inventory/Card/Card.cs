using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public CardData Data;

    [Space]
    [SerializeField] private Image _highlight;
    [SerializeField] private Image _image;
    [SerializeField] private TextMeshProUGUI _name;

    private void Start()
    {
        if(Data == null) { return; }

        _image.sprite = Data.Sprite;
        _name.text = Data.Name;

        SetRarity(Data.RarityIndex);
    }

    private void SetRarity(int rarityIndex)
    {
        if (CardRarityManager.TryGetRarityByIndex(rarityIndex, out var rarity))
        {
            _highlight.color = rarity.Color;
            _name.color = rarity.Color;
            _name.text = $"{_name.text}\n({rarity.Name})";
        }
    }
}