using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private RaycastHit hit;
    public int damage;

    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(transform.position, transform.forward, out hit, 15))
            {
                print("shoot");

                if(hit.transform.tag == "Enemy")
                {
                    print("hit");
                    hit.transform.gameObject.GetComponent<Ai>().DoDamage(damage);
                }
            }
        }
    }
}
