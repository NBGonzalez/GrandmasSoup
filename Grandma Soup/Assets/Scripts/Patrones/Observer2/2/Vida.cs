using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Asegúrate de que el objeto con el que colisiona tenga el tag "vida"

            // Notifica a los observadores que se ha recogido una vida
            EventosJuego.NotificarRecogerVida();

            // También puedes destruir el objeto de vida si lo prefieres
            Destroy(gameObject);
        }
    }
}
