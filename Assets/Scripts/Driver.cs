using System.Collections;      
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update

    float steerSpped = 100f;
    float speed = 10f;

    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {

        float vertical = (float)Input.GetAxis("Vertical");

        transform.Translate(0, vertical * speed * Time.deltaTime, 0 );

        float horizontal = (float) Input.GetAxis("Horizontal");

        //because we cant turn car without moving forward or backward
        if (vertical != 0)
        {
            transform.Rotate(0, 0, - horizontal * steerSpped * Time.deltaTime);
        }

    }
}
