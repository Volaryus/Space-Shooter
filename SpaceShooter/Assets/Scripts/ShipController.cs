using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float speed;
    public float xLimit = 3f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        //Debug.Log(moveX);
        rb.velocity = new Vector2(moveX * speed , 0);
        if(transform.position.x>xLimit+0.02f)
        {
            transform.position = new Vector2(xLimit, transform.position.y);
        }
        if(transform.position.x<-xLimit-0.02f)
        {
            transform.position = new Vector2(-xLimit, transform.position.y);
        }
    }

}
