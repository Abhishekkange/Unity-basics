using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        //reading values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //moving the object
        transform.position += (Vector3.forward * verticalInput * speed);
        transform.position += (Vector3.right * horizontalInput * speed);










    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }

}

