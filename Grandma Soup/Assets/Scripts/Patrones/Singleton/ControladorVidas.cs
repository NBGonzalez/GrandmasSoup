using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorVidas : MonoBehaviour
{
    public static ControladorVidas Instance;

    [SerializeField] private int vidas = 3;
    [SerializeField] private UIManager uiManager;

    private void Start()
    {
        if(ControladorVidas.Instance == null)
        {
            ControladorVidas.Instance = this;
            Debug.Log("Singleton Controlador Vidas [CREADO]");
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Debug.Log("Singleton Controlador Vidas [DESTRUIDO]");
            Destroy(gameObject);
        }
        uiManager = FindAnyObjectByType<UIManager>();
    }
    private void Update()
    {
        if(uiManager == null)
        {
            uiManager= FindAnyObjectByType<UIManager>();
        }
    }
    public void SumarVidas(int vida)
    {
        vidas += vida ;
        uiManager.SumarVidasUI(vidas-1);

        Debug.Log("vidas: " + vidas);
    }
    public void RestarVidas(int daño)
    {
        vidas -= daño;
        if (vidas <= 0)
        {
            RestablecerVidas();
            SceneManager.LoadScene("MenuInicial");
        }
        uiManager.RestarVidasUI(vidas);
        Debug.Log("vidas: " + vidas);
    }
    public void RestablecerVidas()
    {
        vidas = 3;
        uiManager.RestablecerVidasUI(vidas);
    }
}
