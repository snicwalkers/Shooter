using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    public GameObject effect;
    public UIManager uiManager;
    void Start()
    {
        uiManager = GameObject.Find("GameManager").GetComponent<UIManager>();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("Asteroid"))
        {
            uiManager.Defeat();
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
