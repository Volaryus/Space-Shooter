using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject bulletPrefab;
    public float shootInterval = 0.5f;
    float timer = 2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= shootInterval)
        {
            Shoot();
            timer = 0f;
        }
        timer += Time.deltaTime;
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, shootPoint.position,Quaternion.identity);
    }
}
