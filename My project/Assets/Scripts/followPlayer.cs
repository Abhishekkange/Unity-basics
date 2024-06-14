using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour

{
    // Start is called before the first frame update
    public float turn;
    public float up;
    public float horizontalInput;
    public float verticalInput;
    public float speed;
    public float moveSpeed =0.5f;
    public float num = 0;
    [SerializeField,Range(0.1f,10)] float mouseSensitivity = 1f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        moveCamera();
        
       
        
        
    }

    void rotateCamera()
    {

        turn += Input.GetAxis("Mouse X") * mouseSensitivity;
        up += Input.GetAxis("Mouse Y") * mouseSensitivity;


        transform.localRotation = Quaternion.Euler(-up, turn, 0f);


       





    }
    void moveCamera()
    {

        //reading values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //moving the object

       
        transform.position += (Vector3.forward * verticalInput * speed);
        transform.position += (Vector3.right * horizontalInput * speed);


    }
}
