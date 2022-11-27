using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.collider.tag);
        if (collision.collider.tag.Equals("CarTag"))
        {
            Sprite otherSprite = collision.gameObject.GetComponent<SpriteRenderer>().sprite;
            GetComponent<SpriteRenderer>().sprite = otherSprite;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.tag);
    }
}
