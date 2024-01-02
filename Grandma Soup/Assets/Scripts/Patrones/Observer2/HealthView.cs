using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Observer2
{
    public class HealthView : MonoBehaviour, Observer
    {
        [SerializeField] private TextMeshProUGUI _health;
        public GameObject[] vidas;

        public void Updated(Subject subject)
        {
            if (subject is Hero hero)
            {
                _health.SetText(hero.Health.ToString());
                vidas[hero.Health].SetActive(false);

            }
        }
    }
}
