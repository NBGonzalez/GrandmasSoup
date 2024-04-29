using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawneadorDeVidas : MonoBehaviour
{
    //public List<Transform> _respawnsVida = new List<Transform>();
    // Start is called before the first frame update
    public Vida vida;
    void Start()
    {
        GameObject respawns = GameObject.FindGameObjectWithTag("Respawn");
        for (int i = 0; i < 3; i++)
        {
            vida.Clonar();
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
