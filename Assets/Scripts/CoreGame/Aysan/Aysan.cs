using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aysan : MonoBehaviour
{
    [SerializeField]
    Vector2 velocity;
    Rigidbody2D rb;
    private void Start()
    {
        rb=this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, 0);
            rb.AddForce(velocity);
        }
    }
}
