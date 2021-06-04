using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletObj;
    public float bulletspeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            BulletMovement(Vector3.forward);
        }
        //float Xaxis = Input.GetAxis("Mouse X");
        //float Yaxis = Input.GetAxis("Mouse Y");
        //transform.Rotate(-Yaxis, Xaxis, 0);


    }

    private void BulletMovement(Vector3 direction)
    {
        GameObject bulletGeneratedRef = Instantiate(bulletObj);
        bulletGeneratedRef.transform.position = transform.position;
        Rigidbody rb = bulletGeneratedRef.GetComponent<Rigidbody>();
        // rb.AddForce(Vector3.forward * bulletspeed);
        Camera camera = GetComponentInChildren<Camera>();
        rb.velocity = camera.transform.rotation * Vector3.forward * bulletspeed;


    }
}