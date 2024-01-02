using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Components.Interfaces;
using Observer2;

namespace Components
{
    public class HealthPick : MonoBehaviour
    {
        [SerializeField] private HealthView _healthView;

        private Hero _hero;

        private void Awake()
        {
            _hero = new Hero();
            _hero.Subscribe(_healthView);
            _hero.Notify();
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                _hero.Healing(1);
            }
        }
    }
}
