using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    public GameObject effect;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("Asteroid"))
        {
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
