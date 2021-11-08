using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public int RarityIndex { get; private set; }

    [SerializeField] private CardData _data;

    [Space]
    [SerializeField] private Image _image;
    [SerializeField] private TextMeshProUGUI _name;

    private void Awake()
    {
        _image.sprite = _data.Sprite;
        _name.text = _data.Name;

        //testing rarity
        var rarityIndex = Random.Range(0, 8);

        if(CardRarityManager.TryGetRarityAtIndex(rarityIndex, out var rarity))
        {
            RarityIndex = rarityIndex;

            _name.color = rarity.Color;
            _name.text = $"{_name.text}({rarity.Name})";
        }
    }

    public CardData GetData()
    {
        return _data;
    }
}