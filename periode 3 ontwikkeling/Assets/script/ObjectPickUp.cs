using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ObjectPickUp : MonoBehaviour
{
    public float pickupBoost;
    public KeyMovementScript movement;
    public float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        pickupBoost = 7;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        movement.jumpForce += pickupBoost;
        Destroy (gameObject);


    }
}
