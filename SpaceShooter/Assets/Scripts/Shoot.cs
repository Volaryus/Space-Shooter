using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject[] shootPoint;
    public float shootInterval = 2f;
    public AudioClip shootSound;
    public int howManyShot = 1;
    float timer = 2f;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && shootInterval <= timer)
        {
            ShootBullet();
            timer = 0f;
        }
    }
    void ShootBullet()
    {
        int i = 0;
        if (howManyShot > shootPoint.Length) { howManyShot = shootPoint.Length; }
        if(howManyShot%2==0)
        {
            for (i = howManyShot; i >0; i--)
            {
                Instantiate(bulletPrefab, shootPoint[i].transform.position, Quaternion.identity);
            }
        }
        else
        {
            for (i = 0; i < howManyShot; i++)
            {
                Instantiate(bulletPrefab, shootPoint[i].transform.position, Quaternion.identity);
            }
        }
        
        audioSource.PlayOneShot(shootSound);
    }
}
