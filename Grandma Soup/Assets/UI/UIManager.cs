using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class UIManager : MonoBehaviour
{
    public GameObject[] vidas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestarVida(int indice)
    {
        vidas[indice].SetActive(false);
    }
    public void SumarVida(int indice)
    {
        vidas[indice].SetActive(true);
    }
}
*/
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
            //_goldText.text = $"Gold: {gold}";
            vidas[health].SetActive(true);
        }
    }
}
