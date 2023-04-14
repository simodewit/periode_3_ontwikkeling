using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMec : MonoBehaviour
{
    private Vector3 movement;
    public float moveSpeed;
    public float runSpeed;
    public bool checkIfRunning;

    private Vector3 vec3Rot;
    public float rotSpeed;

    private Vector3 camRot;
    public Camera cam;
    public GameObject face;
    public float camspeed;

    public Rigidbody rb;
    public float jumpForce;

    public float jumpBoost;
    public ObjectPickUp boostJump;

    public float renBoost;
    public PickUpRenBoost pickupRen;
    public bool checkIfBoosting;

    public int health;
    public TextMeshProUGUI healthSpace;

    public float deathBarrier;

    public RaycastHit hit;

    public bool isGrounded;
    
    public GameObject canvas;
    public GameObject deadText;
    public GameObject exit;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");
        transform.Translate(movement * moveSpeed * Time.deltaTime);


        vec3Rot.y = Input.GetAxis("Mouse X");
        transform.Rotate(vec3Rot * rotSpeed);


        camRot.x = -Input.GetAxis("Mouse Y");
        cam.transform.Rotate(camRot * camspeed);


        if (Input.GetKeyDown(KeyCode.LeftControl) && pickupRen == null && checkIfBoosting == false && isGrounded == true)
        {
            moveSpeed += pickupRen.renBoost;
            checkIfBoosting = true;
        }
        else if(Input.GetKeyUp(KeyCode.LeftControl) && pickupRen == null && checkIfBoosting == true)
        {
            moveSpeed -= pickupRen.renBoost;
            checkIfBoosting = false;
        }


        if(Input.GetKeyDown(KeyCode.LeftShift) && checkIfRunning == false)
        {
            moveSpeed += runSpeed;
            checkIfRunning = true;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift) && checkIfRunning == true)
        {
            moveSpeed -= runSpeed;
            checkIfRunning = false;
        }

        if (Physics.Raycast(transform.position, -transform.up, out hit, 1))
        {
            isGrounded = true;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity += Vector3.up * jumpForce;
            }


            if (Input.GetKey(KeyCode.E) && Input.GetKeyDown(KeyCode.Space) && boostJump == null)
            {
                rb.velocity += Vector3.up * boostJump.pickupBoost;
            }
        }
        else
        {
            isGrounded = false;
        }

        if (transform.position.y < deathBarrier)
        {
            Instantiate(face, transform.position, transform.rotation);
            Destroy(gameObject);

            canvas.SetActive(true);
            deadText.SetActive(true);
            exit.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void DoDamage(int damageToDo)
    {
        health -= damageToDo;
        healthSpace.text = health.ToString();

        if(health <= 0)
        {
            canvas.SetActive(true);
            deadText.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;


        }
    }
}
