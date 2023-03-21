using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRenBoost : MonoBehaviour
{
    public float renBoost;
    public PlayerMec movement;

    void Start()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            movement.renBoost = renBoost;
            Destroy(gameObject);
        }
    }
}
