using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pinchos : MonoBehaviour
{
    public SOPinchos scriptableObjectPinchos;
    private Vector3 position;
    private void Start()
    {
        this.transform.localScale = scriptableObjectPinchos.size;
        position = transform.localPosition;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<VidasPlayer>().QuitarVidas(scriptableObjectPinchos.damage);
            Debug.Log(collision.GetComponent<VidasPlayer>().vidas);
        }
    }
}
