using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float shootForce;
    public float damage = 5f;
    public AudioSource playerSource;
    public AudioClip hitSound;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject,3f);
        playerSource = GameObject.FindWithTag("Player").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.up * shootForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Health>()!=null)
        {
            collision.gameObject.GetComponent<Health>().GetDamage(damage);
        }
        playerSource.PlayOneShot(hitSound);
        Destroy(gameObject);
    }
}
