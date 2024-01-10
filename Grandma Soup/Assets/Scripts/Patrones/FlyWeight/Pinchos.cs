using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinchos : MonoBehaviour
{
    public SOPinchos scriptableObjectPinchos;
    private Vector3 position;
    private void Start()
    {
        this.transform.localScale = scriptableObjectPinchos.size;
        position = transform.localPosition;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hago una cantidad de daño de: "+ scriptableObjectPinchos.damage);
        }
    }
}
