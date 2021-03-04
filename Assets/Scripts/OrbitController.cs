using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitController : MonoBehaviour
{
    public Transform planet;
    public float radius;

    private Transform pivot;
    public Joystick joystick;

    float horizontalMove = 0f;
    float verticalMove = 0f;

    void Start()
    {
        pivot = planet.transform;
        transform.parent = pivot;
        transform.position += Vector3.up * radius;
    }

    void Update()
    {

        horizontalMove = joystick.Horizontal;
        verticalMove = joystick.Vertical;
        
        float angle = Mathf.Atan2(verticalMove, horizontalMove) * Mathf.Rad2Deg;

        pivot.position = planet.position;
        pivot.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
    }
}
