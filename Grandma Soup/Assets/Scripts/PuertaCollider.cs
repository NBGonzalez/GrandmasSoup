using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PuertaCollider : MonoBehaviour
{
    public GameObject texto;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Estas en la puerta");
            texto.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Estas en la puerta");
            texto.SetActive(false);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene("MenuInicial");
        }
    }
}
