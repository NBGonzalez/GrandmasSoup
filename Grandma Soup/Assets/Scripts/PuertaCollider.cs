using System.Collections;
using System.Collections.Generic;
using TMPro;
//using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PuertaCollider : MonoBehaviour
{
    public GameObject texto;
    public int indice;
    private void Start()
    {
        texto = GameObject.FindGameObjectWithTag("UI").transform.GetChild(6).gameObject;
        texto.SetActive(false);
        Debug.Log(texto.name);
    }
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
            indice = SceneManager.GetActiveScene().buildIndex;
            indice++;
            SceneManager.LoadScene(indice);
        }
    }
}
