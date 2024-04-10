using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public GameObject[] vidas;
    public GameObject menuPausa;
    private bool isPaused = false;

    private void Start()
    {
        if (UIManager.Instance == null)
        {
            UIManager.Instance = this;
            Debug.Log("Singleton UIManager [CREADO]");
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Debug.Log("Singleton UIManager [DESTRUIDO]");
            Destroy(gameObject);
        }
    }

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
    public void RestablecerVidasUI(int health)
    {
        for(int i = 0; i < health; i++)
        {
            vidas[i].SetActive(true);
        }
    }
    public void ActualizarVidasUI(int health)
    {
        if (health <= 3)
        {
            for (int i = health; i < 4; i++)
            {
                vidas[i].SetActive(false);
            }
        }
        else
        {
            for (int i = 0; i < health + 1; i++)
            {
                vidas[i].SetActive(true);
            }
        }
        
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
        ControladorVidas.Instance.RestablecerVidas();
    }

}

