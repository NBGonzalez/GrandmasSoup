using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Me cogiste");
            ControladorVidas.Instance.SumarVidas();
            Destroy(gameObject);
        }
    }
}
