using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    private float speed = 15;

    GameObject bullet;
    public Transform shotspawn;
    // Start is called before the first frame update
    void Start()
    {
        speed = 20;
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemies")
        {
        
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            shoot();
        }
    }
    
    public void shoot()
    {
        Instantiate(bullet, shotspawn.position, shotspawn.rotation);
    }
}
