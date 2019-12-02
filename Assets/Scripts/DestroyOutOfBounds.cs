using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 34)
        {
            Destroy(gameObject);
        } else if (transform.position.z < -15)
        {

            Destroy(gameObject);
        } 
        
    }
}
