using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class enemyShoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public Transform shooterPos;
    public float force;
    [SerializeField, Range(0.01f,1)] float spawnSpeed = 1;
    public float num = 0;
    GameObject temp;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(num % (1 / spawnSpeed));
        if((int)(num%(1/spawnSpeed))==0)
        shootBullet();
        num += 1;
    }

    public void shootBullet()
    {

        temp = Instantiate(bullet);
        temp.transform.position = transform.position;
        temp.GetComponent<Rigidbody>().AddForce(transform.forward * force);


    }
}
