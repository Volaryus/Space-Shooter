using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    float health = 100f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GetDamage(float amount)
    {
        health -= amount;
        Color firstColor = gameObject.GetComponent<SpriteRenderer>().color;
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        StartCoroutine(TurnColor(firstColor));

        if (health <= 0)
        {
            if (gameObject.CompareTag("Player"))
            {
                //kill the character
                return;
            }
            Destroy(gameObject);
        }
    }

    IEnumerator TurnColor(Color color)
    {
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<SpriteRenderer>().color = color;
    }
}
