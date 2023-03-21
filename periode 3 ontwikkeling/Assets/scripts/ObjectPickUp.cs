using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ObjectPickUp : MonoBehaviour
{
    public float pickupBoost;
    public PlayerMec movement;

    void Start()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            movement.jumpBoost = pickupBoost;
            Destroy(gameObject);
        }
    }
}
