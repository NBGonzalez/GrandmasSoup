using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //librer�a para el manejo de escenas

public class MenuInicial : MonoBehaviour
{

    //Funci�n que pasa a la siguiente escena (para el bot�n jugar)
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }

    //Funci�n que te saca del juego y muestra mensaje 
    public void Salir()
    {
        Debug.Log("Saliendo...");
        Application.Quit();
    }
}
