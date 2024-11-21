using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;// the player speed

    private Rigidbody rb;//rigidbody of the player

    private float movementX;//the X and Y axes 
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementvalue)
    {//fuction body
        Vector2 movementvector = movementvalue.Get<Vector2>();

        movementX = movementvector.x;
        movementY = movementvector.y;
    }


    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX,0.0f,movementY);

        rb.AddForce(movement * speed);
    }
}
