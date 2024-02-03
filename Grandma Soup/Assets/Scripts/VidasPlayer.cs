
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidasPlayer : MonoBehaviour
{

    public int vidas = 3;
    public bool inmortal = false;
    public UIManager uiManager;
    private void Awake()
    {
        vidas = 3;
    }
    public void QuitarVidas(int damage)
    {
        if (inmortal == false)
        {
            vidas -= damage;
            if (vidas <= 0)
            {
                SceneManager.LoadScene("MenuInicial");
            }
            uiManager.RestarVidasUI(vidas);
            inmortal = true;
        }
        
        StartCoroutine(Invulnerable());
    }
    IEnumerator Invulnerable()
    {
        yield return new WaitForSeconds(1);
        inmortal= false;

    }

}
