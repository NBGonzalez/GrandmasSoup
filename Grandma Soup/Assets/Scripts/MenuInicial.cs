using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //librería para el manejo de escenas

public class MenuInicial : MonoBehaviour
{

    //Función que pasa a la siguiente escena (para el botón jugar)
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }

    //Función que te saca del juego y muestra mensaje 
    public void Salir()
    {
        Debug.Log("Saliendo...");
        Application.Quit();
    }
}
