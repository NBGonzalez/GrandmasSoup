using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour, IPrototype, IVida
{
    public int vida = 1;

    public List<Transform> _respawnsVida = new List<Transform>();
    private void Start()
    {
        GameObject respawns = GameObject.FindGameObjectWithTag("Respawn");
        foreach(Transform spawn in respawns.transform)
        {
            _respawnsVida.Add(spawn);
        }
    }
    public IVida Clonar()
    {
        GameObject miVida = Instantiate(gameObject, _respawnsVida[0].position, _respawnsVida[0].rotation);
        Vida newVida= miVida.GetComponent<Vida>();
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
