using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acidRain : MonoBehaviour
{
    float randomNumber;
    Vector3 vec;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject acido = ObjectPool.instance.GetPooledObject();
        if (acido != null)
        {
            randomNumber = Random.Range(-20, 150);
            vec = new Vector3(randomNumber, 30, 0);
            acido.transform.position = vec;
            acido.SetActive(true);
        }
    }
}
