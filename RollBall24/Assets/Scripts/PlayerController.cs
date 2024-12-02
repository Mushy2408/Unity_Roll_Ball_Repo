using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class PlayerController : MonoBehaviour
{
    public float speed = 0;// the player speed

    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    private Rigidbody rb;//rigidbody of the player

    private int count;

    private float movementX;//the X and Y axes 
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;


        SetCountText();
        winTextObject.SetActive(false);
    }

    void OnMove(InputValue movementvalue)
    {//fuction body
        Vector2 movementvector = movementvalue.Get<Vector2>();

        movementX = movementvector.x;
        movementY = movementvector.y;
    }
    void SetCountText()
    {
        countText.text = "count:" + count.ToString();
        if (count > 11)
        {
            winTextObject.SetActive (true);
        }
    }


    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX,0.0f,movementY);

        rb.AddForce(movement * speed);
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
           other.gameObject.SetActive(false);
            count= count + 1;

            SetCountText();
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if
    }
}
