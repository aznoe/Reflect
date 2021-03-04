using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Joystick joystick;
    public float runSpeed = 2f;

    private float horizontalMove = 0f;
    private float verticalMove = 0f;


    void Update()
    {
        horizontalMove = joystick.Horizontal* runSpeed;
        verticalMove = joystick.Vertical*runSpeed;



        gameObject.transform.position = new Vector2(transform.position.x + horizontalMove,
           transform.position.y + verticalMove);

    }

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<GameManager>().EndGame();
    }

}
