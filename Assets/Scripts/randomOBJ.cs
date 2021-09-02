using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomOBJ : MonoBehaviour
{
    public float speed = 7f;
    private Rigidbody2D rb;
    

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        Destroy(this.gameObject, 5f);
    }
}
