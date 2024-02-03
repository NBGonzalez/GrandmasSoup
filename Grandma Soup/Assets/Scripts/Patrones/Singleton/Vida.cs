using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public int vida = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Me cogiste");
            ControladorVidas.Instance.SumarVidas(vida);
            Destroy(gameObject);
        }
    }
}
