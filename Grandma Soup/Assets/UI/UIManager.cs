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
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                PausarJuego();
            }
        }

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

    public void UpdateHealth(int health)
    {
        vidas[health].SetActive(false);
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

