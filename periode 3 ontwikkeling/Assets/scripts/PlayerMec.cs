using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMec : MonoBehaviour
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
    public bool isGrounded;
    public float jumpBoost;

    public float speedBoost;

    public int health;
    public TextMeshProUGUI healthSpace;

    public float deathBarrier;

    public ObjectPickUp boostJump;

    public PickUpRenBoost pickupEnRen;
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

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Space) && isGrounded == true && boostJump == null)
        {
            rb.velocity += Vector3.up * jumpBoost;
            isGrounded = false;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.velocity += Vector3.up * jumpForce;
            isGrounded = false;
        }


        if (transform.position.y < deathBarrier)
        {
            Destroy(gameObject);
        }


        if (Input.GetKey(KeyCode.Tab) && Input.GetKey(KeyCode.W))
        {

        }

    }

    public void DoDamage(int damageToDo)
    {
        health -= damageToDo;
        healthSpace.text = health.ToString();

        if(health <= 0)
        {
            Destroy(gameObject);
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
