using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cam;

    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        cam.transform.position = new Vector3(transform.position.x, transform.position.y, -20);
    }
}
