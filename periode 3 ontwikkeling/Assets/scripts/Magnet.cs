using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public GameObject ball1;
    public GameObject ball2;

    private float distanceToBall1;
    private float distanceToBall2;

    public float magnetDistance;

    public void Update()
    {
        if(Input.GetKey(KeyCode.C))
        {
            distanceToBall1 = Vector3.Distance(transform.position, ball1.transform.position);
            distanceToBall2 = Vector3.Distance(transform.position, ball2.transform.position);

            if(distanceToBall1 <= magnetDistance)
            {
                ball1.GetComponent<Rigidbody>().MovePosition(transform.position);
            }

            if (distanceToBall2 <= magnetDistance)
            {
                ball2.GetComponent<Rigidbody>().MovePosition(transform.position);
            }
        }
    }
}
