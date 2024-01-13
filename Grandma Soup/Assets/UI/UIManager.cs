using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine;

namespace Patterns.Observer.BadImplementation
{
    public class UIManager : MonoBehaviour
    {
        public GameObject[] vidas;

        private void Awake()
        {

        }

        public void UpdateHealth(int health)
        {
            vidas[health].SetActive(false);
        }
    }
}
