using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class MainCharacterMovement : MonoBehaviour
{

    Rigidbody2D rb;
    int vidas = 2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector3(0, 5, 0);
        }
    }
    void FixedUpdate()
    {
        
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector3(+2.5f, this.rb.velocity.y, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector3(-2.5f, this.rb.velocity.y, 0);
        }
    }
}
