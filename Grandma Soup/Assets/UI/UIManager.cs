using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
