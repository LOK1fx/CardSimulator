using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Case : MonoBehaviour
{
    [SerializeField] private Card _cardPrefab;

    [Space]
    [SerializeField] private int _cardAmount = 20;
    [SerializeField]private Transform _cardsParent;

    private List<Card> _spawnedCards = new List<Card>();
    private CardData[] _allCardsData;

    private void Awake()
    {
        _allCardsData = Resources.LoadAll<CardData>("Cards/");
    }

    private void Update()
    {
        if(_spawnedCards.Count > 0)
        {
            foreach(var card in _spawnedCards)
            {
                card.transform.position += new Vector3(0f, 1f, 0f);
            }
        }
    }

    public void Open()
    {
        for (int i = 0; i < 20; i++)
        {
            var card = Instantiate(_cardPrefab, _cardsParent);

            card.Data = _allCardsData[Random.Range(0, _allCardsData.Length)];

            _spawnedCards.Add(card);
        }
    }
}