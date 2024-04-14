using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<PlayerStateManager>().gettingDamage = true;
            ControladorVidas.Instance.RestarVidas(scriptableObjectPinchos.damage);
        }
    }
}
