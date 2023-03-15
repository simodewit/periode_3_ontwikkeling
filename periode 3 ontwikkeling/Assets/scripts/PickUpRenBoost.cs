using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRenBoost : MonoBehaviour
{
    public float renBoost;
    public PlayerMec renScript;


    // Start is called before the first frame update
    void Start()
    {
        renBoost = 9;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            renScript.moveSpeed = renBoost;
            Destroy(gameObject);
        }
    }
}
