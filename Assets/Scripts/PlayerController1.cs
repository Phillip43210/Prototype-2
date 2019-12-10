using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float S = 1;
    public float F = 1;
    public float horizontalInput;
    public float speed = 100;
    public float b = 20;
    public GameObject projectilePrefap;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -b)
        {
            transform.position = new Vector3(b, transform.position.y, transform.position.z);
        }
        if (transform.position.x > b)
        {
            transform.position = new Vector3(-b, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.P))
        {
            InvokeRepeating("ShootFood", S, F );
        } else if (Input.GetKeyDown(KeyCode.I ))
        {
            CancelInvoke("ShootFood");
        }

    }
    void ShootFood()
    {  
     Instantiate(projectilePrefap, transform.position, projectilePrefap.transform.rotation);
    }
}
