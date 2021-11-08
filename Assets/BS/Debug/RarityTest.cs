using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tests
{
    public class RarityTest : MonoBehaviour
    {
        [SerializeField] private Card _cardPrefab;

        private const int SAVED_STEPS_COUNT = 1024;

        private int[] _rarityAtSteps = new int[SAVED_STEPS_COUNT];
        private int _step = 0;
        private Card _card;

        private bool _isRunning;

        private void FixedUpdate()
        {
            if (!_isRunning) { return; }

            if(_step >= SAVED_STEPS_COUNT)
            {
                StopLoop();

                return;
            }

            _card = Instantiate(_cardPrefab, transform);

            _rarityAtSteps[_step % SAVED_STEPS_COUNT] = _card.RarityIndex;

            _step++;

            Destroy(_card.gameObject, 0.05f);
        }

        public void StartLoop()
        {
            _step = 0;
            _isRunning = true;
        }

        public void StopLoop()
        {
            Debug.Log($"Avarge rarity index is {GetAvargeIndex(_rarityAtSteps)}");

            _isRunning = false;
        }

        private int GetAvargeIndex(int[] numbers)
        {
            var number = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                number += numbers[i];
            }

            return Mathf.RoundToInt(number / numbers.Length);
        }
    }
}