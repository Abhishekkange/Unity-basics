using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateEnemy : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField,Range(0.01f,1)] float rotateSpeed =1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateContinously();
        
    }
    public void rotateContinously()
    {
        transform.Rotate(0, rotateSpeed, 0);
        //rotates continously on y axis at speed 
    }
}
