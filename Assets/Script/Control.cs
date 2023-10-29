using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    private void Update()
    {
        Move();
    }
    private void Move()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = realPos;
    }
}
