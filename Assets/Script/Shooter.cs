using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public float shootWait = 0.2f;
    public float shootTimer = 0;
    public GameObject bullet;
    void Update()
    {
        shootTimer -= Time.deltaTime;
        if (Input.GetMouseButton(0))
        {
            if(shootTimer <= 0)
            {
                Instantiate(bullet, transform.position, transform.rotation);
                shootTimer = shootWait;
            }
        }
    }
}
