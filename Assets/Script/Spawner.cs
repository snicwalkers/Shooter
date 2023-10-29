using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject target;
    public float spawnWait = 0.2f;
    public float spawnTimer = 0;
    void Update()
    {
        spawnTimer -= Time.deltaTime;
            if (spawnTimer <= 0)
            {
            float randx = Random.Range(-4.5f, 4.8f);
            Vector3 pos = new Vector3(randx, transform.position.y, 0);
            Instantiate(target, pos, transform.rotation);
            spawnTimer = spawnWait;
            }
    }
}
