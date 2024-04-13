using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pinchos : MonoBehaviour
{
    public SOPinchos scriptableObjectPinchos;
    private Vector3 position;
    int fuerza;
    private void Start()
    {
        this.transform.localScale = scriptableObjectPinchos.size;
        position = transform.localPosition;
        fuerza = -7;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Vector2 direccionRebote = (transform.position - collision.transform.position).normalized;
            //collision.GetComponent<Rigidbody2D>().AddForce(-fuerza*direccionRebote, ForceMode2D.Impulse);
            //collision.GetComponent<Rigidbody2D>().AddForce(-fuerza * direccionRebote, ForceMode2D.Impulse);
            collision.GetComponent<PlayerStateManager>().gettingDamage = true;
            //collision.gameObject.GetComponent<PlayerStateManager>().BumpDamageForce(direccionRebote * fuerza);
            ControladorVidas.Instance.RestarVidas(scriptableObjectPinchos.damage);
        }
    }
}
