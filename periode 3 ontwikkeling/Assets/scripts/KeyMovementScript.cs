using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KeyMovementScript : MonoBehaviour
{
    public float hor;
    public float vert;
    public float moveSpeed;
    public Vector3 movement;

    public float rotSpeed;
    public float rot;
    public Vector3 vec3Rot;

    public Camera cam;
    public Vector3 camRot;
    public float came;
    public float camspeed;

    public Rigidbody rb;
    public float jumpForce;
    public bool canJump;
    public bool isGrounded;

    public ObjectPickUp deBoost;


    void Start()
    {
        moveSpeed = 4;
        jumpForce = 3;
        rotSpeed = 4;
        camspeed = 4;
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");


        transform.Translate(movement * moveSpeed * Time.deltaTime);

        rot = Input.GetAxis("Mouse X");
        vec3Rot.y = rot;
        transform.Rotate(vec3Rot * rotSpeed);


        came = -Input.GetAxis("Mouse Y");
        camRot.x = came;
        cam.transform.Rotate(camRot * camspeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isGrounded = false;
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                rb.velocity += Vector3.up * jumpForce * 7;
            }
            else
            {
                {
                    rb.velocity += Vector3.up * jumpForce;
                }

            }
        }




    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Floor")
        {
            isGrounded = true;
        }
    }
}
