using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 1;
    void Update()
    {
        transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        if(gameObject.transform.position.y > 9)
        {
            Destroy(gameObject);
        }

    }
}
