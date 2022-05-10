using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 50;
    public GameObject ball;
    public GameObject playerCamera;
    public float ballDistance = 2f;
    public float ballThrowingForce = 5f;
    private bool holdingBall = true;



    // Start is called before the first frame update
    void Start()
    {
        ball.GetComponent<Rigidbody>().useGravity = false;
    }

    void Update()
    {
        if (holdingBall) {
            ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;
            if(Input.GetMouseButtonDown(0))
            {
                holdingBall = false;
                ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);
            }
        }
    }

    // Update is called once per frame
    /*
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement*speed);
    }
    */
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

}
