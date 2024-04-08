using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acid : MonoBehaviour
{
    Rigidbody2D rb;
    private float downSpeed;
    private float lateralSpeed;

    private int pointOfReset;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        downSpeed = Random.Range(2, 5);
        lateralSpeed= Random.Range(1, 2);

        pointOfReset = -10;
    }

    // Update is called once per frame
    
    void Update()
    {
        if(this.transform.position.y <= pointOfReset)
        {
            gameObject.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.down * downSpeed + Vector2.left * lateralSpeed;
    }
}
