using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
            
        if (collision.gameObject.name == "Enemy")
        {
            print("i hit the enemy");
        }
    }

}