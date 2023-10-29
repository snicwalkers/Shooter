using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float fall = 0.1f;
    void Update()
    {
        transform.position += new Vector3(0, -fall * Time.deltaTime, 0);
        if (gameObject.transform.position.y < -11)
        {
            Destroy(gameObject);
        }
    }
    public GameObject effect;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("Bullet"))
        {
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
