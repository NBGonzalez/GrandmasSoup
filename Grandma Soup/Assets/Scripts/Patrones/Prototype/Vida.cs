using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour, IPrototype, IVida
{
    public int vida = 1;
    private int i = 0;

    public List<Transform> _respawnsVida = new List<Transform>();
    private void Awake()
    {
        GameObject respawns = GameObject.FindGameObjectWithTag("Respawn");
        foreach(Transform spawn in respawns.transform)
        {
            _respawnsVida.Add(spawn);
            print(_respawnsVida.Count);
        }
    }
    public IVida Clonar()
    {
        print(_respawnsVida.Count);
        GameObject miVida = Instantiate(gameObject, _respawnsVida[i].position, _respawnsVida[i].rotation);
        Vida newVida= miVida.GetComponent<Vida>();
        i++;
        return newVida;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Me cogiste");
            ControladorVidas.Instance.SumarVidas(vida);
            Destroy(gameObject);
        }
    }
}
