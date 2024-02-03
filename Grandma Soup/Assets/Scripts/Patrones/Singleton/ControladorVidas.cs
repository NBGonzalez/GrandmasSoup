using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorVidas : MonoBehaviour
{
    public static ControladorVidas Instance;

    [SerializeField] private int vidas = 3;
    [SerializeField] private UIManager uiManager;

    private void Awake()
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
    public void SumarVidas()
    {
        vidas++;
        uiManager.SumarVidasUI(vidas-1);
        Debug.Log("vidas: " + vidas);
    }
    public void RestarVidas()
    {
        vidas--;
        if (vidas <= 0)
        {
            SceneManager.LoadScene("MenuInicial");
        }
        uiManager.RestarVidasUI(vidas);
        Debug.Log("vidas: " + vidas);
    }
}
