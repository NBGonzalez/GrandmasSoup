using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidercaida : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<VidasPlayer>().QuitarVidas(3);
            Debug.Log(collision.GetComponent<VidasPlayer>().vidas);
        }
    }
}
