using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Patterns.Observer.Interfaces;
using TMPro;


namespace Patterns.Observer
{
    public class ObserverUIManager : MonoBehaviour, IObserver<int>
    {
        private TextMeshProUGUI _goldText;
        public GameObject[] vidas;
        private void Awake()
        {
            //_goldText = transform.Find("GoldText").GetComponent<TextMeshProUGUI>();

            GameObject player = GameObject.FindWithTag("Player");
            ObserverHealthBag healthBag = player.GetComponent<ObserverHealthBag>();
            healthBag.AddObserver(this);
        }

        public void UpdateObserver(int data)
        {
            //_goldText.text = $"Gold: {data}";
            vidas[data].SetActive(true);
    }
    }
}