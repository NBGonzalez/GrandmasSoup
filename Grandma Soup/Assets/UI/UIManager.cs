using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public GameObject[] vidas;
    public GameObject menuPausa;
    private bool isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausarJuego();
        }
    }
    // Lógica de vidas en la UI
    public void SumarVidasUI(int health)
    {
        vidas[health].SetActive(true);
    }
    public void RestarVidasUI(int health)
    {
        vidas[health].SetActive(false);
    }
    // Lógica de Menús
    public void PausarJuego()
    {
        if (isPaused == false)
        {
            isPaused = true;
            menuPausa.SetActive(true);
        }
        else
        {
            menuPausa.SetActive(false);
            isPaused = false;
        }
    }
    public void Reanudar()
    {
        PausarJuego();
    }
    public void Salir()
    {
        SceneManager.LoadScene("MenuInicial");
    }

}

