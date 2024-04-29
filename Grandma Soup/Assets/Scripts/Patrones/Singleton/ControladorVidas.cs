using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorVidas : MonoBehaviour
{
    // Singleton variables
    public static ControladorVidas Instance;
    public const int MAX_VIDAS = 6;
    [SerializeField] private int vidas = 3;
    [SerializeField] private UIManager uiManager;


    //
    // Singleton
    //
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
            uiManager.RestablecerVidasUI(vidas);
        }
        ActualizarVidas();
    }
    public void SumarVidas(int vida)
    {
        if(vidas <= MAX_VIDAS) { vidas += vida; }
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
    public void ActualizarVidas()
    {
        //uiManager.ActualizarVidasUI(vidas);
    }
}
