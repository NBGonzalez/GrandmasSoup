using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidercaida : MonoBehaviour
{
    public int da�o = 99;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ControladorVidas.Instance.RestarVidas(da�o);
        }
    }
}
